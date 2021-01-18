using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Utility
{
    public class Utilities : IUtilities
    {
        public double roundUp(double value)
        {
            return Math.Round(value, 2);
        }
    }
}
