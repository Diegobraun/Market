using Market.PurchaseFeatures;
using System.Linq;

namespace Market.PurchaseFeatures
{
    public class GenerateParcel
    {
        public Parcel Parcel { get; private set; }

        public GenerateParcel(Parcel parcel){
            Parcel = parcel;
        }
        public void GenerateParcels()
        {
            double rest = 0;
            double parcelValue = double.Parse(string.Format("{0:0.00}",
            (Parcel.Purchase.FinalValue / Parcel.ParcelAmount)));
            
            if (Parcel.Purchase.FinalValue > parcelValue * Parcel.ParcelAmount)
                rest = double.Parse(string.Format("{0:0.00}",Parcel.Purchase.FinalValue 
                - parcelValue * Parcel.ParcelAmount));


            for (int i = 0; i < Parcel.ParcelAmount;i++){
                if ((i == Parcel.ParcelAmount -1) && (rest != 0))
                    Parcel.ParcelList.Add((parcelValue)
                     + rest);
                else
                    Parcel.ParcelList.Add(parcelValue);
            }
        }

        public string GenerateTextListParcels (){
            string parcelsText = "\nParcelamento: \n\n";

            for (int i = 0; i < Parcel.ParcelAmount;i++){
                parcelsText += $"Parcela {i+1} de {Parcel.ParcelAmount}";
                parcelsText += $"{$"\nValor de {Parcel.ParcelList[i]}\n":0.00}";
            }
            return parcelsText;
        }
    }
}