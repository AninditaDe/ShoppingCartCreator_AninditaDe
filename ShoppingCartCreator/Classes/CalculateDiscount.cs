using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public abstract class CalculateDiscount
    {
        public abstract double calculateDiscountAmountBread();
        public abstract double calculateDiscountAmountMilk();
    }
}
