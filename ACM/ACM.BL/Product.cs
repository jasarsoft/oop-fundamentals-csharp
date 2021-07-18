﻿using System;

namespace ACM.BL
{
    public class Product
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

        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}