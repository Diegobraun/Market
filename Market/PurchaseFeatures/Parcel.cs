using MarketSystem_Purchase_Purchase;
using System.Collections.Generic;

namespace Market.PurchaseFeatures
{
    public class Parcel
    {
        public List<double> ParcelList = new List<double>();
        public Purchase Purchase { get; private set; }
        public int ParcelAmount { get; private set; }

        public Parcel (Purchase purchase, int parcelAmount){
            Purchase = purchase;
            ParcelAmount = parcelAmount;
        }
        
        public void SetPurchase (Purchase purchase){
            Purchase = purchase;
        }

        public void SetParcelAmount (int parcelAmount){
            ParcelAmount = parcelAmount;
        }

    }
}