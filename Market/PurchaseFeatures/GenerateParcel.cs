using Market.PurchaseFeatures;

namespace Market.PurchaseFeatures
{
    public class GenerateParcel
    {
        public Parcel Parcel { get; private set; }

        public GenerateParcel (Parcel parcel){
            Parcel = parcel;
        }
        public void GenerateParcels ()
        {
            for (int i = 0; i < Parcel.ParcelAmount;i++){
                Parcel.ParcelList.Add((Parcel.Purchase.FinalValue) / Parcel.ParcelAmount);
            }
        }
    }
}