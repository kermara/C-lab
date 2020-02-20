using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab008_DieList
{
    class Player
    {
        private Die myDie;
        private List<int> UniqueResult = new List<int>();

        public Player(Die Die)
        {
            this.myDie = Die;
           
        }

        public void Play()
        {

            int result;
            int RollCount = 0; 
            
            while (UniqueResult.Count < 6)

            {
                RollCount++;
                result = myDie.Roll();

                if (!UniqueResult.Contains(result))
                {
                    UniqueResult.Add(result);
                }
              
                Console.WriteLine("Roll result " + result);
            }

            Console.WriteLine("Roll count: " + RollCount);
            Console.WriteLine("Results from the List ");


            foreach (int rollResult in UniqueResult)

            {
                Console.Write(rollResult + "  ");
            }

            
            
        }
            
           
    }
}
