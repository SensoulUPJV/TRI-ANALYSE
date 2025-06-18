namespace reseau_de_bus.BackEnd.Models
{
	public class Arret
	{
		public string IdArret { get; set; }
		public string NomArret { get; set; }
		public Coordonnees Coordonnees { get; set; }

		public Arret(string idArret, string nomArret, Coordonnees coordonnees)
		{
			IdArret = idArret;
			NomArret = nomArret;
			Coordonnees = coordonnees;
		}

		public override string ToString()
		{
			return $"{IdArret} - {NomArret}";
		}
	}
}