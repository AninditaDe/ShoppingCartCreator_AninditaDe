using ShoppingCartCreator.Classes;
using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartCreator
{
    public class UserCartInfo : IUserCartInfo
    {
        private IAvailableProducts _availableProducts;
        private List<Product> _selectedItem;
        public UserCartInfo(IAvailableProducts availableProducts)
        {
            this._availableProducts = availableProducts;
        }
        public List<Product> selectedItem
        {
            set
            {
                this._selectedItem = value;
            }
            get
            {
                if(_selectedItem == null)
                {
                    throw new Exception("Products is not initialized");
                }
                else
                {
                    return _selectedItem;
                }
            }
        }
        public List<Product> getUserPurchasedData(List<Tuple<string, int>> lstSelectedItems)
        {
            try
            {
                var availableProductList = _availableProducts.getAvailableProducts();

                _selectedItem = (from product in availableProductList
                                 join newproduct in lstSelectedItems on product.Name equals newproduct.Item1
                                 where product.Name == newproduct.Item1
                                 select new Product { Name = product.Name, Price = product.Price, Qty = newproduct.Item2 }).ToList();

            }
            catch (Exception ex)
            {

            }
            if (_selectedItem == null) throw new Exception();
            return _selectedItem;
        }
    }
}
