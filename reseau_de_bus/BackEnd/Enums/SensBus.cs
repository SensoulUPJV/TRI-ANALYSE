using reseau_de_bus.BackEnd.Enums;

namespace reseau_de_bus.BackEnd.Enums
{
	public class SensBus : Enumeration
	{
		public static readonly SensBus ALLER = new SensBus("ALLER");
		public static readonly SensBus RETOUR = new SensBus("RETOUR");

		private SensBus(string value) : base(value) { }
	}
}