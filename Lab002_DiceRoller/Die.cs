﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002_DiceRoller
{
    public class Die
    {
        private Random random;

        public Die (int seednumber)
        {
            this.random = new Random(seednumber + DateTime.Now.Millisecond);
        }
       

  
    public int Roll()
        {
           
            int randomDie = random.Next(1, 7);
       

            return randomDie;

           
        }


    }
}
