using System;

namespace reseau_de_bus.BackEnd.Time
{
    public class Timer
    {
        private DateTime _heureActuelle;
        private bool _enMarche;

        public Timer()
        {
            _heureActuelle = DateTime.Now;
            _enMarche = false;
        }

        public void Start()
        {
            _enMarche = true;
            Console.WriteLine($"Timer démarré à {_heureActuelle}");
        }

        public void Stop()
        {
            _enMarche = false;
            Console.WriteLine("Timer arrêté");
        }

        public DateTime GetHeureActuelle()
        {
            return _heureActuelle;
        }

        public void IncrementTime(int minutes)
        {
            if (_enMarche)
            {
                _heureActuelle = _heureActuelle.AddMinutes(minutes);
            }
        }
    }
}