using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_001_Car
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("The program has started");
            Car theCar = new Car();
            Driver theDriver = new Driver(theCar);

            theDriver.Play();
        }
    }
}
