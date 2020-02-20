using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003_Roulette
{
    class Roulette
    {
        private Random random = new Random();

        //Roulette have a spin method that returns a random int between 0-36

        public int Spin()
        {
            int randomSpin = random.Next(0, 38);

            if (randomSpin == 37)
            {
                return 0;
            }
            
             return randomSpin;
            
        }
    }
}
//How to change the code so that the likelihood of getting 0 is double compared to other numbers?
//Any number 0-36: probability 1/37
// Add another zero slot: 2/38

