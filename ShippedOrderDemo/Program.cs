using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippedOrderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippedOrder[] shippedOrders = new ShippedOrder[5];
            Random ranNumGen = new Random();
            string custName;


            for (int i = 0; i < shippedOrders.Length; i++)
            {

                Console.Write("Please enter the customer's name: ");
                custName = Console.ReadLine();


                shippedOrders[i] = new ShippedOrder(custName, ranNumGen.Next(51));

            }


            Array.Sort(shippedOrders);


            foreach (ShippedOrder shippedOrder in shippedOrders)
            {
                Console.WriteLine(shippedOrder);
            }


            DisplayTotalOfAllShippedOrders(shippedOrders);
        }

        private static void DisplayTotalOfAllShippedOrders(ShippedOrder[] shippedOrders)
        {
            double total = 0;
            foreach (ShippedOrder shippedOrder in shippedOrders)
            {
                total += shippedOrder.TotalPrice;
            }
            Console.WriteLine("The total price of all the shipped orders is {0:C}", total);
        }
    }
}
