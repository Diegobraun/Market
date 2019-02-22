using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem_Client_Client;

namespace MarketSystem.ClientFeatures.Validation
{
    class ValidationClient
    {
        public bool CheckIfIsNotEmpty (string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return true;
            else
                return false;
        }
        
        public bool CheckIfIsValidClient (Client client)
        {
            bool check = true;

            List<object> values = new List<object>();

            values.Add(client.FirstName);
            values.Add(client.LastName);
            values.Add(client.Email);
            values.Add(client.Gender);
            values.Add(client.DateOfBirth);
            values.Add(client.Cpf);
            values.Add(client.Password);
            values.Add(client.Contact.Type);
            values.Add(client.Contact.Description);
            values.Add(client.Address.Type);
            values.Add(client.Address.Street);
            values.Add(client.Address.Number);
            values.Add(client.Address.District);
            values.Add(client.Address.City);

            foreach(object value in values)
            {
                if (CheckIfIsNotEmpty(value.ToString()))
                    check = false;
            }

            return check;
        }
    }
}
