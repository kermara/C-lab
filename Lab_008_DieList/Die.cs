using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab008_DieList
{
    class Die
    {
        private Random random;
        

        public Die()
        {
            this.random = new Random();
            
        }

        public int Roll()
        {
            int randomDie = random.Next(1, 7);


           
           return randomDie;
        }


    }
}

