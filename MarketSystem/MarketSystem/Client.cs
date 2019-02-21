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
        public string Email { get; private set; }
        public char Gender { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Cpf { get; private set; }
        public string Password { get; private set; }
        public Contact Contact { get; private set; }
        public Address Address { get; private set; }

        
        public void SetId (int id)
        {
            ClientId = id;
        }

        public void SetFirstName (string firstName)
        {
            FirstName = firstName;
        }

        public void SetLastName (string lastName)
        {
            LastName = lastName;
        }

        public void SetEmail (string email)
        {
            Email = email;
        }

        public void SetGender (char gender)
        {
            Gender = gender;
        }

        public void SetDateOfBirth (DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public void SetCpf (string cpf)
        {
            Cpf = cpf;
        }

        public void SetPassword (string password)
        {
            Password = password;
        }

        public void SetContact (Contact contact)
        {
            Contact = contact;
        }

        public void SetAddress (Address address)
        {
            Address = address;
        }
    }
}
