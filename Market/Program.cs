using System;
using MarketSystem_Client_Client;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client client = new Client();
            client.SetEmail("Diegobraun2000@gmail.com");
            Console.WriteLine(client.Email);
        }
    }
}
