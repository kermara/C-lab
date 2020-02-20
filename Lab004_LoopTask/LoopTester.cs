using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab004_LoopTask
{
    public class LoopTester
    {
        public void DoTheLoops()
        {
            Console.WriteLine("Looping: ");
            TestWhileLoop();
            TestWhileLoop2();
            TestForLoop();
            TestForLoopAndWhile();
            TestDoAndWhile();
        } 

        private void TestWhileLoop()
        {
            int iterator = 1;
            while (iterator <= 5)
            {
                Console.WriteLine(" iterarator " + iterator);
                iterator = iterator + 2;

            }
        }

        private void TestWhileLoop2()
        {
            int pc = 0, passangerLimit = 4;
            Console.WriteLine("While loop: ");

            while (pc<=passangerLimit)
            
            {
                Console.WriteLine("Now I have " + pc + " passengers");
                pc++;

            }
        }

        private void TestForLoop()
        {
            int passangerLimit = 4;

            Console.WriteLine("for loop: ");

            for(int pc = 0; pc <= passangerLimit; pc++)
            {
                Console.WriteLine("This time I have " + pc + " passengers");

            }
        }

        private void TestForLoopAndWhile()
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("i = " + i);
            }

            for(int i= 0; i<8; i++)
            {
                if (i != 4)
                {
                    Console.WriteLine("i= " + i);
                }
            }

            bool stop = false;
            int count = 0;
            while (!stop)
            {
                if (count == 2)
                {
                    stop = true;
                }
                Console.WriteLine("count= " + count);
                count++;
            }
            
        }

        private void TestDoAndWhile()
        {
            int count = 0;
            do
            {
                Console.WriteLine("count= " + count);
                count++;
            } while (count <= 7);
        }
    }
}
