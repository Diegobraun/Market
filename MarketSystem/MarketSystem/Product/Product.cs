﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.Product
{
    class Product
    {
        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }

        public Product (string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }


        public void SetProductId (int productId)
        {
            ProductId = productId;
        }

        public void SetName (string name)
        {
            Name = name;
        }

        public void SetDescription (string description)
        {
            Description = description;
        }

        public void SetPrice (double price)
        {
            Price = price;
        }
    }
}
