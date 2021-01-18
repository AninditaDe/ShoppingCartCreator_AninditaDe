using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public class AvailableProducts: IAvailableProducts
    {
        public List<Product> getAvailableProducts()
        {
            var availableProducts = new List<Product>() { 
            new Product { Name = "Butter", Price = 0.80 },
            new Product {  Name= "Milk", Price= 1.15 },
            new Product {  Name= "Bread", Price= 1.00 }};
            return availableProducts;
        }
    }
}
