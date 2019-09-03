using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002_DiceRoller
{
    public class Player
    {
        private Die myDie;

        public Player ( Die myDie)
        {
            this.myDie = myDie;
        }

    public void Play()
        {

            int result = myDie.Roll();
            Console.WriteLine(result);
           


        }
    }
}
