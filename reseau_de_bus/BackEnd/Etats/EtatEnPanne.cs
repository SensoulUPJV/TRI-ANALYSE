using System;

namespace reseau_de_bus.Backend.Etats
{
    public class EtatEnPanne : EtatAlerte
    {
        public override void Deplacer()
        {
            Console.WriteLine("Impossible de se d�placer - Bus en panne");
        }

        public override void ArriverArret()
        {
            Console.WriteLine("Bus en panne ne peut pas circuler");
        }

        public override void RepartirArret()
        {
            Console.WriteLine("R�paration n�cessaire");
        }

        public override void GetNomEtat()
        {
            Console.WriteLine("�tat: En panne");
        }
    }
}