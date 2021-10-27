using System;
using Acme.Common;

namespace ACM.BL
{
    public class Product: EntityBase
    {
        public Product()
        {
            
        }

        public Product(int productId)
        {
            
        }

        public decimal? CurrentPrice { get; set; }

        public string ProductDescription { get; set; }

        public int ProductId { get; set; }

        private string _productName;

        public string ProductName
        {
            get
            {
                return StringHandler.InsertSpaces(_productName);
            }
            set { _productName = value; }
        }

        public override string ToString() => ProductName;
  

        public override bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
