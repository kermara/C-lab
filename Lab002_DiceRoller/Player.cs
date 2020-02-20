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
        private Die yourDie;
    
        
        public Player ( Die myDie, Die yourDie)
        {
            this.myDie = myDie;
            this.yourDie = yourDie;
            
             
        }



        public void Play()
        {

            int result = myDie.Roll();
            int result2 = yourDie.Roll();
            int count = 1; 

            while (result != result2)
            {
                result = myDie.Roll();
                result2 = yourDie.Roll();
                count = count + 1;
            }
            
            Console.WriteLine("Result "  + result + " Result2 " + result2 + " Laskuri " + count);
        }

        }
    }
