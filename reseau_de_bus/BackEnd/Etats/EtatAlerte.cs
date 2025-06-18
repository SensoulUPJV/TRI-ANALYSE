namespace reseau_de_bus.Backend.Etats
{
	public abstract class EtatAlerte
	{
		public virtual void Deplacer() { }
		public virtual void ArriverArret() { }
		public virtual void RepartirArret() { }
		public virtual void GetNomEtat() { }
	}
}