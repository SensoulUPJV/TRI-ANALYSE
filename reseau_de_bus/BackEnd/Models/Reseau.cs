using System;
using System.Collections.Generic;

namespace reseau_de_bus.BackEnd.Models
{
    public class Reseau
    {
        public List<Ligne> Lignes { get; set; }
        public List<Arret> Arrets { get; set; }

        public Reseau()
        {
            Lignes = new List<Ligne>();
            Arrets = new List<Arret>();
        }

    }
}