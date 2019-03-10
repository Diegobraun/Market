using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MarketSystem_Purchase_Purchase;
using MarketSystem_Product;

namespace Market_GerarCount
{
    public class GenerateAccount
    {
        public Purchase Purchase { get; private set; }

        public GenerateAccount (Purchase purchase){
            Purchase = purchase;
        }
        
        public void SetPurchase (Purchase purchase){
            Purchase = purchase;
        }

        public string GenerateTextListProduct (){
            string ListProductText = "";

            foreach (Product product in Purchase.ProductList){
                ListProductText += $"\nId : {product.ProductId}";
                ListProductText += $"\nNome produto : {product.Name}";
                ListProductText += $"\nPreço produto : {product.Price}\n";
            }
            return ListProductText;
        }

        public void GenerateReceipt (){
            string receiptText;
            receiptText = $"Identificador da Nota : {Purchase.PurchaseId}";
            receiptText += $"\nIdentificador do cliente : {Purchase.Client.ClientId}";
            receiptText += $"\nNome do cliente : {Purchase.Client.FirstName} {Purchase.Client.LastName}";
            receiptText += $"\nTelefone do cliente : {Purchase.Client.Contact.Description}";
            receiptText += $"\nCidade de entrega : {Purchase.Client.Address.City}";
            receiptText += $"\n\nProdutos : {GenerateTextListProduct()}";
            receiptText += $"{Purchase.Parcel.GenerateTextListParcels()}";

            Console.WriteLine(receiptText);
        }

    }
}