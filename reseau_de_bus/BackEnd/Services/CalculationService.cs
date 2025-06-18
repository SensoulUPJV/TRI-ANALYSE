using System;
using System.Collections.Generic;
using System.Linq;
using reseau_de_bus.BackEnd.Models;

namespace reseau_de_bus.BackEnd.Services
{
	public class CalculationService
	{
		public double CalculerDistanceEntreArrets(Arret arret1, Arret arret2)
		{
			return arret1.Coordonnees.CalculerDistance(arret2.Coordonnees);
		}

		public int CalculerTempsTrajet(double distance, int vitesseMoyenne = 30)
		{
			// Temps en minutes = (distance en km / vitesse en km/h) * 60
			return (int)Math.Ceiling((distance / vitesseMoyenne) * 60);
		}

		public int AppliquerVariabilite(int tempsBase, int ecartType)
		{
			Random rand = new Random();
			double facteur = rand.NextDouble() * 2 - 1; // Entre -1 et 1
			return Math.Max(1, tempsBase + (int)(facteur * ecartType));
		}
	}
}