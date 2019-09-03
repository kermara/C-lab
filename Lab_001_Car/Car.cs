using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_001_Car
{
    public class Car
    {
        private double speed;
        private double gasLevel;

        public Car()
        {
            this.speed = 0.0;
            this.gasLevel = 1.0;
        }

        public double getSpeed()
        {
            return this.speed;
        }

        public double getGasLevel()
        {
            return this.gasLevel;
        }

        public void accelerate()
        {
            Console.WriteLine("Begin Accelerate(): " + this.speed + ", " + this.gasLevel);
            if (this.gasLevel >= 0.1)
            {
                this.speed = this.speed + 1.0;
                this.gasLevel = this.gasLevel - 0.1;
            }

            Console.WriteLine("End Accelerate(): " + this.speed + this.gasLevel);
        }

        public void Decelarate()
        {
            Console.WriteLine(".");
            if (this.speed - 1.0 < 0)
            {
                this.speed = 0.0;
            }
            else
            {
                this.speed = this.speed - 1.0;

            }

            Console.WriteLine("End Decelerate(): " + this.speed + ", " + this.gasLevel);
        }

            public void fillTank()
            {

            
            this.gasLevel = 20.0;
            Console.WriteLine("Tank is filled");
            }
        }
    }

    
