using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem_Client_Address;
using System.Reflection;

namespace Mercado.ClientFeatures.AddressValidation
{
    public class ValidationAddress
    {   
        public bool CheckIfIsNotEmpty (string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return false;
            else
                return true;
        }
        
        public bool CheckIfIsValidAddressLengthState (Address address)
        {            
            if (address.Type.ToString().Length > 1)
                return false;
            else if (address.City.Length > 15)
                return false;
            else if (address.Street.Length > 25)
                return false;
            else if (address.Number.ToString().Length > 10)
                return false;
            else if (address.Complement.ToString().Length > 50)
                return false;
            else if (address.District.Length > 20)
                return false;
            else 
                return true;
        }

        public bool CheckIfIsValidAddress (Address address)
        {
            bool check = true;

            List<object> values = new List<object>();
        
        
            values.Add(address.Type);
            values.Add(address.City);
            values.Add(address.Street);
            values.Add(address.Number);
            values.Add(address.District);

            foreach(object value in values)
            {
                if (CheckIfIsNotEmpty(value.ToString()))
                    check = false;
            }

            return check;
        }
    }
}