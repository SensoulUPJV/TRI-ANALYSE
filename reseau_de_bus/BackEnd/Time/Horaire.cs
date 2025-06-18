using reseau_de_bus.BackEnd.Enums;

namespace reseau_de_bus.BackEnd.Time
{
	public class Horaire
	{
		public int HeureDebut { get; set; }
		public int HeureFin { get; set; }
		public EcartType EcartType { get; set; }

		public Horaire(int heureDebut, int heureFin, EcartType ecartType)
		{
			HeureDebut = heureDebut;
			HeureFin = heureFin;
			EcartType = ecartType;
		}

		public bool EstActif(int heureActuelle)
		{
			return heureActuelle >= HeureDebut && heureActuelle <= HeureFin;
		}
	}
}