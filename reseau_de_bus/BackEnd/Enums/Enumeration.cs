namespace reseau_de_bus.BackEnd.Enums
{
    public abstract class Enumeration
    {
        public string Value { get; }

        protected Enumeration(string value)
        {
            Value = value;
        }

        public override string ToString() => Value;
    }
}