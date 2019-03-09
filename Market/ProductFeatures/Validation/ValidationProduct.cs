using MarketSystem_Product;
using System.Collections.Generic;

namespace Market.ProductFeatures.Validation
{
    public class ValidationProduct
    {
        public bool CheckIfIsNotEmpty (string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return false;
            else
                return true;
        }
        
        public bool CheckIfIsValidProductLengthState (Product product)
        {            
            if (product.Name.ToString().Length > 20)
                return false;
            else if (product.Description.Length > 25)
                return false;
            else if (product.Price.ToString().Length > 10)
                return false;
            else 
                return true;
        }

        public bool CheckIfIsValidProduct (Product product)
        {
            bool check = true;

            List<object> values = new List<object>();

            values.Add(product.Name);
            values.Add(product.Description);
            values.Add(product.Price);

            foreach(object value in values)
            {
                if (CheckIfIsNotEmpty(value.ToString()))
                    check = false;
            }

            return check;
        }
    }
}