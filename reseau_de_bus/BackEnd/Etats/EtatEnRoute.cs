using reseau_de_bus.Backend.Etats;
using System;

namespace reseau_de_bus.BackEnd.Etats
{
    public class EtatEnRoute : EtatAlerte
    {
        public override void Deplacer()
        {
            Console.WriteLine("Bus en déplacement");
        }

        public override void ArriverArret()
        {
            Console.WriteLine("Arrivée à l'arrêt");
        }

        public override void RepartirArret()
        {
            Console.WriteLine("Redémarrage depuis l'arrêt");
        }

        public override void GetNomEtat()
        {
            Console.WriteLine("État: En route");
        }
    }
}