using reseau_de_bus.BackEnd.Enums;

namespace reseau_de_bus.BackEnd.Vehicules
{
    public abstract class Bus
    {
        public string NBus { get; set; }
        public EtatBus Etat { get; set; }
        public SensBus SensBus { get; set; }

        protected Bus(string nBus)
        {
            NBus = nBus;
            Etat = EtatBus.Arrete;
        }

        public abstract void Deplacer();
        public abstract void ArriverArret();
        public abstract void RepartirArret();
    }
}