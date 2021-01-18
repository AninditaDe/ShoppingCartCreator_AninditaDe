using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartCreator.Classes
{
    public class DiscountRules: CalculateDiscount, IDiscount
    {
        public int QtyButter{ get; set;}
        public int QtyBread { get; set; }
        public int QtyMilk { get; set; }
        public double PriceOfBread { get; set; }
        public double PriceOfMilk { get; set; }

        public double DiscountAmount { get; set; }


        private IUserCartInfo _userCartInfo;

        public DiscountRules(IUserCartInfo userCartInfo)
        {
            this._userCartInfo = userCartInfo;
        }

        public double discountCalculator()
        {
            var listOfSelectedProduct = _userCartInfo.selectedItem;
            foreach (var product in listOfSelectedProduct)
            {
                if (product.Name == "Milk")
                {
                    QtyMilk = product.Qty;
                    PriceOfMilk = product.Price;
                }
                if (product.Name == "Butter")
                {
                    QtyButter = product.Qty;
                }
                if (product.Name == "Bread")
                {
                    QtyBread = product.Qty;
                    PriceOfBread = product.Price;
                }
            }
            if (QtyBread == 0 && QtyMilk == 0 && QtyButter== 0)
            {
                return 0;
            }
            DiscountAmount = calculateDiscountAmountBread() + calculateDiscountAmountMilk();
            return DiscountAmount;
        }
        public override double calculateDiscountAmountBread()
        {
            return (min(QtyButter, QtyBread) * (PriceOfBread / 2));
        }

        private int min(int qtyOfButter, int qtyOfBread)
        {
            if ((qtyOfButter / 2) < qtyOfBread)
                return qtyOfButter / 2;
            else
                return qtyOfBread;
        }
        public override double calculateDiscountAmountMilk()
        {
            return QtyMilk > 3 ? (QtyMilk / 4 * PriceOfMilk) : 0;
        }
    }
}
