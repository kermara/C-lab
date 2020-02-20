using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003_Roulette
{
    class Player
    {
        private Roulette myRoulette;

        public Player ( Roulette myRoulette)
        {
            this.myRoulette = myRoulette;
        }

        //Player spins the Roulette and prints out the result

        public void Play()
        {
            int result = myRoulette.Spin();

            Console.WriteLine(result);
        }
    }
}
