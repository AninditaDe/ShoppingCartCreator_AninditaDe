using ShoppingCartCreator.Interfaces;
using ShoppingCartCreator.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public class Resolver
    {
        public double displayResult(List<Tuple<string, int>> lstSelectedItems)
        {
            double result = 0;
            try
            {
                IUserCartInfo userCart = new UserCartInfo(new AvailableProducts());
                ICalculateCost calculateCost = new CalculateCost(userCart);
                IDiscount discount = new DiscountRules(userCart);
                IUtilities utilities = new Utilities();
                TotalCost tc = new TotalCost(calculateCost, discount, utilities);
                userCart.getUserPurchasedData(lstSelectedItems);
                result = tc.totalCost();
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
