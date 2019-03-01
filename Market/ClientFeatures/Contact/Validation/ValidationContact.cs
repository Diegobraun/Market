using MarketSystem_Client_Contact;
using System.Collections.Generic;

namespace Mercado.ClientFeatures.ContactValidation
{
    public class ValidationContact
    {
        public bool CheckIfIsNotEmpty (string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return false;
            else
                return true;
        }
        
        public bool CheckIfIsValidAddressLengthState (Contact contact)
        {            
            if (contact.Type.ToString().Length > 1)
                return false;
            else if (contact.Description.Length > 35)
                return false;
            else 
                return true;
        }

        public bool CheckIfIsValidAddress (Contact contact)
        {
            bool check = true;

            List<object> values = new List<object>();

            values.Add(contact.Type);
            values.Add(contact.Description);

            foreach(object value in values)
            {
                if (CheckIfIsNotEmpty(value.ToString()))
                    check = false;
            }

            return check;
        }
    }
}