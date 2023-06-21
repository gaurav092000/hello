using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class7
    {
        static void Main()
        {
            //area of rectangle
            int l, b;
            double area;
            Console.WriteLine("Enter the lengh");
            l=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breath");
            b=int.Parse(Console.ReadLine());
            area = l * b;
            Console.WriteLine(" Area of Rectangle : " +area);
            Console.ReadKey();

        }

    }
}
