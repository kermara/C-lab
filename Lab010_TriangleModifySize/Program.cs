using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab010_TriangleModifySize
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();


            //Console.WriteLine("Triangle of size 3 created ");
            Console.WriteLine("Give size of the triangle: ");
            triangle.DrawTriangle();
        }
    }
}
