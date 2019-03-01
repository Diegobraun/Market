using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem_Client_Client;

namespace MarketSystem.ClientFeatures.Validation
{
    public class ValidationClient
    {
        public bool CheckIfIsNotEmpty (string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return false;
            else
                return true;
        }
        
        public bool CheckIfIsValidClientLengthState (Client client)
        {            
            if (client.FirstName.Length > 15)
                return false;
            else if (client.LastName.Length > 15)
                return false;
            else if (client.Email.Length > 50)
                return false;
            else if (client.Gender.ToString().Length > 1)
                return false;
            else if (client.DateOfBirth.ToString().Length > 8)
                return false;
            else if (client.Cpf.Length > 11)
                return false;
            else if (client.Password.Length > 15)
                return false;
            else 
                return true;
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

            foreach(object value in values)
            {
                if (CheckIfIsNotEmpty(value.ToString()))
                    check = false;
            }

            return check;
        }
    }
}
