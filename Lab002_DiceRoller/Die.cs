using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002_DiceRoller
{
    public class Die
    {
        private Random random = new Random();
       

  
    public int Roll()
        {
           
            int randomdie = random.Next(1, 7);
       

            return randomdie;

           
        }       



    }
}
