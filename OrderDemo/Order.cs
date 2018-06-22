using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace OrderDemo
{
    public class Order
    {
        private int quantity;
        protected double totalPrice;

        private const double UNIT_PRICE = 19.95;

        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }

        public virtual int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                quantity = value;
                totalPrice = Quantity * UNIT_PRICE;
            }
        }
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public Order(int number, string custName, int qnty)
        {
            OrderNumber = number;
            CustomerName = custName;
            Quantity = qnty;
        }

        public override bool Equals(object obj)
        {
            Order otherOrder = (Order)obj;

            if (OrderNumber == otherOrder.OrderNumber)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.OrderNumber;
        }

        public override string ToString()
        {
            return string.Format("Order Number: {0}\nCustomer Name: {1}\nQuantity: {2}\nTotal Price: {3:C}\n", this.OrderNumber, this.CustomerName, this.Quantity, this.TotalPrice);
        }

    }
}
