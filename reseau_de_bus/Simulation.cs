using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using reseau_de_bus.BackEnd.Enums;
using reseau_de_bus.BackEnd.Models;
using reseau_de_bus.BackEnd.Services;
using reseau_de_bus.BackEnd.Vehicules;
using reseau_de_bus.BackEnd.Time;

namespace reseau_de_bus.Simulation
{
    public abstract class Simulation
    {
        public DateTime Debut { get; set; }
        public DateTime Fin { get; set; }
        public string NumSimulation { get; set; }

        protected Simulation(string numSimulation)
        {
            NumSimulation = numSimulation;
            Debut = DateTime.Now;
        }

        public abstract void Demarrer();
        public abstract void Arreter();
        public abstract void Pause();
    }

    public class SimulationReseau : Simulation
    {
        private Reseau _reseau;
        private List<Bus> _bus;
        private Timer _timer;
        private NetworkService _networkService;
        private CalculationService _calculationService;
        private bool _enCours;

        public event EventHandler<SimulationEventArgs> SimulationUpdated;

        public SimulationReseau(string numSimulation) : base(numSimulation)
        {
            _reseau = new Reseau();
            _bus = new List<Bus>();
            _timer = new Timer();
            _networkService = new NetworkService();
            _calculationService = new CalculationService();
            _enCours = false;

            InitialiserDonnees();
        }

        private void InitialiserDonnees()
        {
            _networkService.InitialiserArrets(_reseau);
            _networkService.InitialiserLignes(_reseau);
        }

        public override void Demarrer()
        {
            Console.WriteLine($"Démarrage de la simulation {NumSimulation}");

            // Afficher le nombre de bus avant de démarrer
            Console.WriteLine($"Nombre de bus dans la simulation: {_bus.Count}");

            _timer.Start();
            _enCours = true;

            Task.Run(() => BoucleSimulation());
        }

        public override void Arreter()
        {
            _enCours = false;
            _timer.Stop();
            Fin = DateTime.Now;
            Console.WriteLine("Simulation arrêtée");
        }

        public override void Pause()
        {
            _enCours = false;
            Console.WriteLine("Simulation en pause");
        }

        private async Task BoucleSimulation()
        {
            while (_enCours)
            {
                // Mise à jour des positions des bus
                foreach (var bus in _bus)
                {
                    if (bus.Etat == EtatBus.EnRoute)
                    {
                        bus.Deplacer();
                    }
                }

                // Gestion des horaires et fréquences
                GererHoraires();

                // Mise à jour du timer
                _timer.IncrementTime(1);

                // Notification des événements
                OnSimulationUpdated();

                // Affichage des résultats
                AfficherEtatSimulation();

                // Attendre avant la prochaine itération
                await Task.Delay(1000); // Augmenté à 1 seconde pour mieux voir
            }
        }

        private void GererHoraires()
        {
            var heureActuelle = _timer.GetHeureActuelle().Hour;

            foreach (var ligne in _reseau.Lignes)
            {
                // Logique pour gérer les horaires de chaque ligne
                // À implémenter selon les besoins spécifiques
            }
        }

        private void AfficherEtatSimulation()
        {
            Console.WriteLine($"=== État Simulation à {_timer.GetHeureActuelle()} ===");
            Console.WriteLine($"Nombre de bus total: {_bus.Count}");
            Console.WriteLine($"Nombre de bus actifs (En Route): {_bus.Count(b => b.Etat == EtatBus.EnRoute)}");
            Console.WriteLine($"Nombre de bus arrêtés: {_bus.Count(b => b.Etat == EtatBus.Arrete)}");
            Console.WriteLine($"Nombre de lignes: {_reseau.Lignes.Count}");
            Console.WriteLine($"Nombre d'arrêts: {_reseau.Arrets.Count}");

            // Afficher les détails de chaque bus
            foreach (var bus in _bus)
            {
                Console.WriteLine($"  - Bus {bus.NBus}: État = {bus.Etat}");
            }

            Console.WriteLine("==========================================");
        }

        private void OnSimulationUpdated()
        {
            SimulationUpdated?.Invoke(this, new SimulationEventArgs
            {
                HeureActuelle = _timer.GetHeureActuelle(),
                NombreBusActifs = _bus.Count(b => b.Etat == EtatBus.EnRoute),
                NombreBusTotal = _bus.Count
            });
        }

        public void AjouterBus(Bus bus)
        {
            _bus.Add(bus);
            Console.WriteLine($"Bus {bus.NBus} ajouté à la simulation. Total: {_bus.Count} bus");
        }

        public Reseau GetReseau()
        {
            return _reseau;
        }

        public List<Bus> GetBus()
        {
            return _bus;
        }
    }
}