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
            double rest = 0;
            double parcelValue = Parcel.Purchase.FinalValue / Parcel.ParcelAmount;
            
            if (Parcel.Purchase.FinalValue > parcelValue * Parcel.ParcelAmount)
                rest = Parcel.Purchase.FinalValue - (parcelValue * Parcel.ParcelAmount);

            for (int i = 0; i < Parcel.ParcelAmount;i++){
                if ((i == Parcel.ParcelAmount) && (rest != 0))
                    Parcel.ParcelList.Add((Parcel.Purchase.FinalValue / Parcel.ParcelAmount)
                     + rest);
                else
                    Parcel.ParcelList.Add(Parcel.Purchase.FinalValue / Parcel.ParcelAmount);
            }
        }

        public string GenerateTextListParcels (){
            string parcelsText = "\nParcelamento: \n\n";

            for (int i = 0; i < Parcel.ParcelAmount;i++){
                parcelsText += $"Parcela {i+1} de {Parcel.ParcelAmount}";
                parcelsText += $"\nValor de {Parcel.Purchase.FinalValue/Parcel.ParcelAmount}\n";
            }
            return parcelsText;
        }
    }
}