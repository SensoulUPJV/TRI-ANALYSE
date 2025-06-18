using System;

namespace reseau_de_bus.Simulation
{
    /// <summary>
    /// Arguments d'événement pour les mises à jour de simulation
    /// </summary>
    public class SimulationEventArgs : EventArgs
    {
        /// <summary>
        /// Heure actuelle dans la simulation
        /// </summary>
        public DateTime HeureActuelle { get; set; }

        /// <summary>
        /// Nombre de bus actuellement en route
        /// </summary>
        public int NombreBusActifs { get; set; }

        /// <summary>
        /// Nombre total de bus dans la simulation
        /// </summary>
        public int NombreBusTotal { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public SimulationEventArgs()
        {
        }

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="heureActuelle">Heure actuelle de la simulation</param>
        /// <param name="nombreBusActifs">Nombre de bus actifs</param>
        /// <param name="nombreBusTotal">Nombre total de bus</param>
        public SimulationEventArgs(DateTime heureActuelle, int nombreBusActifs, int nombreBusTotal)
        {
            HeureActuelle = heureActuelle;
            NombreBusActifs = nombreBusActifs;
            NombreBusTotal = nombreBusTotal;
        }
    }
}