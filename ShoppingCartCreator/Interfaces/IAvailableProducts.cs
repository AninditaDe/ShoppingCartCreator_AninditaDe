using ShoppingCartCreator.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Interfaces
{
    public interface IAvailableProducts
    {
        List<Product> getAvailableProducts();
    }
}
