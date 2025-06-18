using System;

namespace reseau_de_bus.Backend.Etats
{
    public class EtatArrete : EtatAlerte
    {
        public override void Deplacer()
        {
            Console.WriteLine("Impossible de se déplacer - Bus arrêté");
        }

        public override void ArriverArret()
        {
            Console.WriteLine("Bus déjà à l'arrêt");
        }

        public override void RepartirArret()
        {
            Console.WriteLine("Redémarrage du bus");
        }

        public override void GetNomEtat()
        {
            Console.WriteLine("État: Arrêté");
        }
    }
}