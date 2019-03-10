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