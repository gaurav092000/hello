using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class4
    {
        static void Main()
        {
            int a,b,c;
            
            Console.WriteLine("Enter the number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number");
            b=int.Parse(Console.ReadLine());
            c = a + b;
            Console.Write("sum to two number :"+c);
            Console.ReadKey();
        }
       
    }
}
