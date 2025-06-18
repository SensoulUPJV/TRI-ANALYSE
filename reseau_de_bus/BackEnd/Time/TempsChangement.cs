using reseau_de_bus.BackEnd.Models;
using System;
using System.Collections.Generic;

namespace reseau_de_bus.BackEnd.Time
{
    public class TempsChangement
    {
        public int CreneauJournee { get; set; }
        public int TempsMoyen { get; set; }
        public int EcartType { get; set; }

        public TempsChangement(int creneauJournee, int tempsMoyen, int ecartType)
        {
            CreneauJournee = creneauJournee;
            TempsMoyen = tempsMoyen;
            EcartType = ecartType;
        }

        public int CalculerTempsArret()
        {
            Random rand = new Random();
            double facteur = rand.NextDouble() * 2 - 1;
            return Math.Max(1, TempsMoyen + (int)(facteur * EcartType));
        }

        public int GetArretSuivant(List<Arret> arrets, int arretActuel)
        {
            return arretActuel + 1;
        }
    }
}