using System;

namespace reseau_de_bus.Backend.Etats
{
    public class EtatArrete : EtatAlerte
    {
        public override void Deplacer()
        {
            Console.WriteLine("Impossible de se d�placer - Bus arr�t�");
        }

        public override void ArriverArret()
        {
            Console.WriteLine("Bus d�j� � l'arr�t");
        }

        public override void RepartirArret()
        {
            Console.WriteLine("Red�marrage du bus");
        }

        public override void GetNomEtat()
        {
            Console.WriteLine("�tat: Arr�t�");
        }
    }
}