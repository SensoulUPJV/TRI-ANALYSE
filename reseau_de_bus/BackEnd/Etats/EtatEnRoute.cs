using reseau_de_bus.Backend.Etats;
using System;

namespace reseau_de_bus.BackEnd.Etats
{
    public class EtatEnRoute : EtatAlerte
    {
        public override void Deplacer()
        {
            Console.WriteLine("Bus en d�placement");
        }

        public override void ArriverArret()
        {
            Console.WriteLine("Arriv�e � l'arr�t");
        }

        public override void RepartirArret()
        {
            Console.WriteLine("Red�marrage depuis l'arr�t");
        }

        public override void GetNomEtat()
        {
            Console.WriteLine("�tat: En route");
        }
    }
}