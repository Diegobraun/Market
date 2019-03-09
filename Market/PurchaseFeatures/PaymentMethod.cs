namespace MarketSystem_Purchase_PaymentMethod
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; private set; }
        public int Type { get; private set; }

        public PaymentMethod (int paymentMethodId, int type){
            PaymentMethodId = paymentMethodId;
            Type = type;
        }

        public void SetPaymentMethodId (int paymentMethodId){
            PaymentMethodId = paymentMethodId;
        }

        public void SetType (int type){
            Type = type;
        }
    }
}