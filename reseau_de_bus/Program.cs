using System;
using reseau_de_bus.BackEnd.Vehicules;
using reseau_de_bus.Simulation;

namespace reseau_de_bus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Simulation de Réseau de Bus ===");

            // Création de la simulation
            var simulation = new SimulationReseau("SIM_001");

            // Vérification et ajout des bus
            var reseau = simulation.GetReseau();

            Console.WriteLine($"Nombre de lignes disponibles: {reseau.Lignes.Count}");

            if (reseau.Lignes.Count > 0)
            {
                Console.WriteLine("Ajout des bus...");

                var bus1 = new BusStandard("BUS_001", reseau.Lignes[0]);
                simulation.AjouterBus(bus1);

                if (reseau.Lignes.Count > 1)
                {
                    var bus2 = new BusStandard("BUS_002", reseau.Lignes[1]);
                    simulation.AjouterBus(bus2);
                }

                // Ajouter un troisième bus sur la première ligne
                var bus3 = new BusStandard("BUS_003", reseau.Lignes[0]);
                simulation.AjouterBus(bus3);

                Console.WriteLine($"Nombre total de bus ajoutés: {simulation.GetBus().Count}");
            }
            else
            {
                Console.WriteLine("Aucune ligne disponible dans le réseau !");
            }

            // Démarrage de la simulation
            simulation.Demarrer();

            Console.WriteLine("Appuyez sur une touche pour arrêter la simulation...");
            Console.ReadKey();

            // Arrêt de la simulation
            simulation.Arreter();
        }
    }
}