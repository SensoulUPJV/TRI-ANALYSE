namespace reseau_de_bus.BackEnd.Time
{
    public class TempsTrajet
    {
        public int CreneauJournee { get; set; }
        public int TempsMoyen { get; set; }
        public int EcartType { get; set; }

        public TempsTrajet(int creneauJournee, int tempsMoyen, int ecartType)
        {
            CreneauJournee = creneauJournee;
            TempsMoyen = tempsMoyen;
            EcartType = ecartType;
        }
    }
}