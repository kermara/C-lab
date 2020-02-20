using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab009_Foodbasket
{
    class Program
    {
        static void Main(string[] args)
        {
            Foodbasket basket = new Foodbasket();

            basket.IncreasePrice();
            basket.GetPrice();
        }
    }
}
