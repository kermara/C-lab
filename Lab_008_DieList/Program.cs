using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab008_DieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Die theDie = new Die();

            Player thePlayer = new Player(theDie);

            thePlayer.Play();
        }
    }
}
