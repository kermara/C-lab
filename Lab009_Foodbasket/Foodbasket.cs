using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab009_Foodbasket
{
    class Foodbasket
    {
        private double price;
        private List<String> months = new List<string>();

        public Foodbasket()
        {
            this.price = 100.0;
        }



        public void IncreasePrice()
        {
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("Abril");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");

            bool warning = false;

            //for (int i = 0; i <= 12; i++)
            foreach (string monthName in months)
            {
                 Console.WriteLine("Monthly price in " + monthName + " " + Math.Round(price, 2));
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
