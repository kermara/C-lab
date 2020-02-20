using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab005_Foodmarket
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
