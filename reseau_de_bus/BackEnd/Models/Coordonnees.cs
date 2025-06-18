using System;

namespace reseau_de_bus.BackEnd.Models
{
	public class Coordonnees
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Coordonnees(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double CalculerDistance(Coordonnees autres)
		{
			return Math.Sqrt(Math.Pow(X - autres.X, 2) + Math.Pow(Y - autres.Y, 2));
		}
	}
}