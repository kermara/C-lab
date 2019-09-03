using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_001_Car
{
    public class Driver
    {
        private Car myCar;

        public Driver (Car myCar)
        {
            this.myCar = myCar;
        }

        public void Drive ()
        {
            myCar.fillTank();

            Console.WriteLine("Car is ready");

            while ((myCar.getSpeed() < 50.0) && (myCar.getGasLevel() >= 0.1)){
                myCar.accelerate();

                
            }

            while (myCar.getSpeed() > 0.0)
            {
                myCar.Decelarate();
            }
            {
                

            }
        }
    }
}
