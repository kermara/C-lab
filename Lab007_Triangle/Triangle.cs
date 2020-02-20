using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab007_Triangle
{
    class Triangle
    {
        /*
        private int size;

        public Triangle(int size)
        {
            this.size = size;
        }
        */

        private void DrawStar(int count)

        {
            for (int i = 1; i <= count; i++)

                Console.Write("*");


        }

        public void DrawTriangle()


        {
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {

                DrawStar(i);
                Console.WriteLine();
            }
        }
    }
}
