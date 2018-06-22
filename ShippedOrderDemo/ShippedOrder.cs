using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDemo;

namespace ShippedOrderDemo
{
    class ShippedOrder : Order, IComparable
    {
        public static int ORDER_NUMBER = 1;
        private const double SHIPPING_FEE = 4.00;

        public ShippedOrder(string custName, int qnty) : base(ORDER_NUMBER++, custName, qnty)
        {
        }

        public override int Quantity
        {
            get
            {
                return base.Quantity;
            }

            set
            {
                base.Quantity = value;
                this.totalPrice += SHIPPING_FEE;
            }
        }


        public int CompareTo(object obj)
        {
            ShippedOrder other = (ShippedOrder)obj;

            if (this.OrderNumber > other.OrderNumber)
                return 1;
            else if (this.OrderNumber == other.OrderNumber)
                return 0;
            else
                return -1;
        }
    }
}
