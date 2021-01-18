using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartCreator.Interfaces
{
    public interface IResult
    {
        double TotalCost { get; set; }
        double CostWithOutDiscount { get; set; }
        double DiscountAmount { get; set; }
    }
}
