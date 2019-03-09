using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MarketSystem_Purchase_Purchase;

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

        public void GenerateReceipt (){
            //
        }

    }
}