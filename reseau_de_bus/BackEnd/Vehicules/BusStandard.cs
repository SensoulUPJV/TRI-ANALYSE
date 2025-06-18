using reseau_de_bus.BackEnd.Enums;
using reseau_de_bus.BackEnd.Models;
using System;
using reseau_de_bus.BackEnd.Etats;

namespace reseau_de_bus.BackEnd.Vehicules
{
    public class BusStandard : Bus
    {
        private Ligne _ligne;
        private int _arretActuel;
        private bool _sensAller;

        public BusStandard(string nBus, Ligne ligne) : base(nBus)
        {
            _ligne = ligne;
            _arretActuel = 0;
            _sensAller = true;
            // Mettre le bus en route dès sa création
            Etat = EtatBus.EnRoute;
        }

        public override void Deplacer()
        {
            Console.WriteLine($"Bus {NBus} se déplace sur la ligne {_ligne.NomLigne}");

            if (_sensAller)
            {
                _arretActuel++;
                if (_arretActuel >= _ligne.Arrets.Count - 1)
                {
                    _sensAller = false;
                }
            }
            else
            {
                _arretActuel--;
                if (_arretActuel <= 0)
                {
                    _sensAller = true;
                }
            }
        }

        public override void ArriverArret()
        {
            // Correction : utiliser _ au lieu de *
            var arret = _ligne.Arrets[_arretActuel];
            Console.WriteLine($"Bus {NBus} arrive à l'arrêt {arret.NomArret}");
            Etat = EtatBus.Arrete;

        }

        public override void RepartirArret()
        {
            Console.WriteLine($"Bus {NBus} repart de l'arrêt");
            Etat = EtatBus.EnRoute;
        }

        public Ligne GetLigne()
        {
            return _ligne;
        }

        public int GetArretActuel()
        {
            return _arretActuel;
        }

        public bool GetSensAller()
        {
            return _sensAller;
        }
    }
}