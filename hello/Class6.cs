using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class6
    {
        static void Main()
        {
            //area of circle
            int radius;
            double area;
            Console.WriteLine("ENter the radius");
            radius = int.Parse(Console.ReadLine());
            area = 3.142*radius*radius;
            Console.WriteLine("Area of circle :" + area);
            Console.ReadKey();


        }
    }
}
