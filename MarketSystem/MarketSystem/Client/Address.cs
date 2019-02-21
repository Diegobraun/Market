namespace MarketSystem.Client
{
    public class Address
    {
        public char Type { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }

        public Address (char type, string city, string street, string number, string district)
        {
            Type = type;
            City = city;
            Street = street;
            Number = number;
            District = district;
        }

        public Address(char type, string city, string street, string number, string complement, string district)
        {
            Type = type;
            City = city;
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
        }

        public void SetType (char type)
        {
            Type = type;
        }

        public void SetCity (string city)
        {
            City = city;
        }

        public void SetStreet (string street)
        {
            Street = street;
        }

        public void SetNumber (string number)
        {
            Number = number;
        }

        public void SetComplement (string complement)
        {
            Complement = complement;
        }

        public void SetDistrict (string district)
        {
            District = district;
        }
    }
}