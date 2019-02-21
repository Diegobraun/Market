namespace MarketSystem
{
    public class Contact
    {
        public char Type { get; private set; }
        public string Description { get; private set; }

        public void SetType (char type)
        {
            Type = type;
        }

        public void SetDescription (string description)
        {
            Description = description;
        }
    }
}