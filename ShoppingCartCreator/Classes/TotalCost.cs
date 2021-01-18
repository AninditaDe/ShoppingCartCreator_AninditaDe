using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public class TotalCost
    {
        private ICalculateCost _calculateCost;
        private IDiscount _discount;
        private IUtilities _utilities;
        public TotalCost(ICalculateCost calculateCost, IDiscount discount, IUtilities utilities)
        {
            this._calculateCost = calculateCost;
            this._discount = discount;
            this._utilities = utilities;
        }

        public double GrandTotal { get; set; }
        public double CostWithOutDiscount { get; set; }
        public double DiscountAmount { get; set; }

        public double CalculateCostWithoutDiscount(int quantity, double price)
        {
            return quantity * price;
        }

        public double totalCost()
        {
            CostWithOutDiscount = _calculateCost.CalculateCostWithoutDiscount();
            DiscountAmount = _discount.discountCalculator();
            GrandTotal = _utilities.roundUp(CostWithOutDiscount - DiscountAmount);
            return GrandTotal;
        }

    }
}
