using ShoppingCartCreator.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Interfaces
{
    public interface IUserCartInfo
    {
        List<Product> getUserPurchasedData(List<Tuple<string, int>> lstSelectedItems);
        List<Product> selectedItem { get; set; }
        
    }
}
