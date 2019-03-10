using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem_Product;
using MarketSystem_Client_Client;
using MarketSystem_Purchase_PaymentMethod;
using Market.PurchaseFeatures;

namespace MarketSystem_Purchase_Purchase
{
    public class Purchase
    {
        public int PurchaseId { get; private set; }
        public List<Product> ProductList = new List<Product>();
        public Client Client { get; private set; }
        public double FinalValue { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public Parcel Parcel { get; private set; }
        public Purchase (int purchaseId, Client client, PaymentMethod paymentMethod){
            PurchaseId = purchaseId;
            Client = client;
            PaymentMethod = paymentMethod;
        }

        public void SetPurchaseId (int id){
            PurchaseId = id;
        }
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

        public void SetParcel (Parcel parcel){
            Parcel = parcel;
        }

        public double CalculateFinalValue (){
            double value = 0;
            
            foreach (Product product in ProductList){
                value += product.Price;
            }

            return value;
        }
    }
}
