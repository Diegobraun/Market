using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem_Product;
using MarketSystem_Client_Client;
using MarketSystem_Purchase_PaymentMethod;

namespace MarketSystem_Purchase_Purchase
{
    class Purchase
    {
        List<Product> ProductList = new List<Product>();
        public Client Client { get; private set; }
        public double FinalValue { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public void SetClient (Client client)
        {
            Client = client;
        }

        public void SetFinalValue (double finalValue)
        {
            FinalValue = finalValue;
        }

        public void SetPaymentMethod (PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

    }
}
