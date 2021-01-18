using ShoppingCartCreator.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Interfaces
{
    public interface IDiscount
    {
        double DiscountAmount { get; set; }
        double discountCalculator();
    }
}
