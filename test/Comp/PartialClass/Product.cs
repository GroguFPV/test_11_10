using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace test.Comp
{
    public partial class Product
    {
        public string DiscountStr
        {
            get
            {
                if (Discount == 0)
                {
                    return "";
                }
                else
                {
                    return $"-{Discount * 100}%";
                }
            }
        }
        public decimal CostDiscount
        {
            get
            {
                if (Discount == 0)
                {
                    return Cost;
                }
                else
                {
                    return Cost - (Cost * (decimal)Discount);
                }
            }
        }
        public string costTimeStr
        {
            get
            {
                if (Discount == 0)
                {
                    return Cost.ToString("N0");
                }
                else
                {
                    return $"{CostDiscount:0}₽ ";
                }
            }
        }


        public Visibility GetVisibility
        {
            get
            {
                if (Discount == 0)
                {
                    return Visibility.Collapsed;
                }

                else
                {
                    return Visibility.Visible;
                }
            }
        }
    }
}
