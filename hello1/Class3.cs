using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    internal class Class3
    {
        static void Main()
        {

            float p;
           Char ch;
            do
            {


                Console.WriteLine("Enter the percentage");
                p = Convert.ToSingle(Console.ReadLine());
                if (p > 60)
                {
                    Console.WriteLine(" First division");

                }
                if (p < 60 && p > 45)
                {
                    Console.WriteLine("Second Division");
                }
                if (p < 45 && p > 33)
                {
                    Console.WriteLine("Third Division");

                }
                if (p <= 33)
                {
                    Console.WriteLine("fail");
                }
                Console.WriteLine("Do u want conntinue");
                ch= char.Parse(Console.ReadLine());
                

            } while (ch == 'Y' || ch == 'y');
        }
    }
}
