using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab005_Foodmarket
{
    class Foodbasket
    {
        private double price;

        public Foodbasket()
        {
            this.price = 100.0;
        }

        public void IncreasePrice()
        {
            bool warning = false;


            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine("Monthly price: " + Math.Round(price, 2));

                if (price > 105.0 && !warning)
                {

                    Console.WriteLine("WARNING, the price goes over 105");
                    warning = true;
                }

                price = price * 1.015;


            }
        }

        public double GetPrice()
        {
            return price;

        }
    }
}
