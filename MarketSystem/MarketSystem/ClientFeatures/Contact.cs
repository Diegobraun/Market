namespace MarketSystem_Client_Contact
{
    public class Contact
    {
        public char Type { get; private set; }
        public string Description { get; private set; }

        public Contact (char type, string description)
        {
            Type = type;
            Description = description;
        }

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