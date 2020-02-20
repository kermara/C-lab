using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002_DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die theDie = new Die(1);
            Die thisDie = new Die(2);
            
            Player thePlayer = new Player(theDie, thisDie);
            

            thePlayer.Play();
            thePlayer.Play();
            thePlayer.Play();



        }
    }
}
