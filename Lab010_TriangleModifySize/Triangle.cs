using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab010_TriangleModifySize
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
            //int size = Convert.ToInt32(Console.ReadLine());

            string input = Console.ReadLine();
            int size;
            Int32.TryParse(input, out size);
        
            for (int i = 1; i<=size; i++)
            {
                
                DrawStar(i);
                Console.WriteLine();
            }
        }
    }
}
