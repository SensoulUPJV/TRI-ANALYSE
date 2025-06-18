using reseau_de_bus.BackEnd.Enums;
using reseau_de_bus.BackEnd.Time;
using System;
using System.Collections.Generic;

namespace reseau_de_bus.BackEnd.Models
{
    public class Ligne
    {
        public string NomLigne { get; set; }
        public List<Arret> Arrets { get; set; }
        public Horaire HeureDebut { get; set; }
        public Horaire HeureFin { get; set; }
        public EcartType EcartType { get; set; }

        public Ligne(string nomLigne)
        {
            NomLigne = nomLigne;
            Arrets = new List<Arret>();
        }

        public void AjouterArret(Arret arret)
        {
            Arrets.Add(arret);
        }

    }
}