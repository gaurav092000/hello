using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class8
    {
        static void Main()
        {
            //even and odd number

            int a;
            char ag;
            do
            {
                Console.WriteLine("Enter the number");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("even number");
                }
                else
                {
                    Console.WriteLine("odd number");
                }
                
                Console.WriteLine("do you want continue");
                ag=char.Parse(Console.ReadLine());

            } while (ag == 'Y' || ag == 'y');
            Console.ReadKey();

        }
    }
}
