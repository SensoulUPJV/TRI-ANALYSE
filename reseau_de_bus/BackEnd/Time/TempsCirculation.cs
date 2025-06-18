using System;

namespace reseau_de_bus.BackEnd.Time
{
	public class TempsCirculation
	{
		public int CreneauJournee { get; set; }
		public int TempsMoyen { get; set; }
		public int EcartType { get; set; }

		public TempsCirculation(int creneauJournee, int tempsMoyen, int ecartType)
		{
			CreneauJournee = creneauJournee;
			TempsMoyen = tempsMoyen;
			EcartType = ecartType;
		}

		public int GetTempsAleatoire()
		{
			Random rand = new Random();
			double facteur = rand.NextDouble() * 2 - 1;
			return Math.Max(1, TempsMoyen + (int)(facteur * EcartType));
		}

		public int AjusterSelonHeure(int heureActuelle)
		{
			float multiplicateur = 1.0f;

			if (heureActuelle >= 8 && heureActuelle <= 9) multiplicateur = 1.5f;
			else if (heureActuelle >= 17 && heureActuelle <= 19) multiplicateur = 1.3f;
			else if (heureActuelle >= 22 || heureActuelle <= 6) multiplicateur = 0.8f;

			return (int)(GetTempsAleatoire() * multiplicateur);
		}
	}
}