using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab003_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player and Roulette

            Roulette theRoulette = new Roulette();
            Player thePlayer = new Player(theRoulette);

            //call player's method to start playing

            thePlayer.Play();
        }
    }
}
