using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class5
    {
        static void Main()
        {
            //area of square
            float area, side;
            Console.WriteLine("enter the side");
            side= float.Parse(Console.ReadLine());
            area = side * side;
            Console.WriteLine("area of square : " + area);
            Console.ReadKey();
        }

    }
}
