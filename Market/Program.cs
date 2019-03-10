using System;
using MarketSystem_Client_Client;
using Market_GerarCount;
using MarketSystem_Purchase_Purchase;
using MarketSystem_Purchase_PaymentMethod;
using MarketSystem_Product;
using MarketSystem_Client_Contact;
using MarketSystem_Client_Address;
using Market.PurchaseFeatures;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1,"pizza","pizza boa",123);
            Product product2 = new Product(2,"hamburguer","hamburguer bom",254);
            Contact contact = new Contact('C',"997432522");
            Address address = new Address('C',"Dois irmãos","29 de setembro","269","RS");
            DateTime dateTime = new DateTime(2000,5,17);

            Client client = new Client(1,"Diego","Braun","diegobraun2000@gmail.com",'M',dateTime,
            "03040959077","senhateste",contact,address,1);

            PaymentMethod paymentMethod = new PaymentMethod(1,2);

            Purchase purchase = new Purchase(client,paymentMethod);

            purchase.ProductList.Add(product);
            purchase.ProductList.Add(product2);
            purchase.SetFinalValue(purchase.CalculateFinalValue());
            
            Parcel parcel = new Parcel(purchase,5);
            GenerateParcel generateParcel = new GenerateParcel(parcel);

            generateParcel.GenerateParcels();

            Console.WriteLine(purchase.FinalValue);

            foreach (double value in parcel.ParcelList){
                Console.WriteLine("Parcela de : "+value);
            }
            Console.ReadLine();
        }
    }
}
