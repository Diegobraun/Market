using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MarketSystem
{
    class Client
    {
        public int ClientId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public char Gender { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Cpf { get; private set; }
        public string Password { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }

    }
}
