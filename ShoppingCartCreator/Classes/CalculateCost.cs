using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public class CalculateCost : ICalculateCost
    {
        private IUserCartInfo _userCartInfo;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }

        public CalculateCost(IUserCartInfo userCartInfo)
        {
            this._userCartInfo = userCartInfo;
        }
        public double CalculateCostWithoutDiscount()
        {
            var listOfSelectedProduct = _userCartInfo.selectedItem;
            foreach (var product in listOfSelectedProduct) {
                Quantity = product.Qty;
                Price = product.Price;
                Cost += Quantity * Price;
            }
            return Cost;
        }
    }
}
