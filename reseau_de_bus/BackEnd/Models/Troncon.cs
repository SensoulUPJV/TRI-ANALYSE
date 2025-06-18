namespace reseau_de_bus.BackEnd.Models
{
    public class Troncon
    {
        public Arret Depart { get; set; }
        public Arret Arrivee { get; set; }
        public int Duree { get; set; }

        public Troncon(Arret depart, Arret arrivee, int duree)
        {
            Depart = depart;
            Arrivee = arrivee;
            Duree = duree;
        }

        public int CalculerTemps()
        {
            return Duree;
        }

        public int GetTempsCirculation()
        {
            return Duree;
        }
    }
}