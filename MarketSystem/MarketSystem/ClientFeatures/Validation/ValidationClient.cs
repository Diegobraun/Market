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
            return true;
        }
    }
}
