using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    internal class Class4
    {
        static void Main()
        {

            //uuper  case and lower case
            char ch;
            char chh;
            do
            {
                Console.WriteLine("Enter the aphabet");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch >= 65 && ch <= 97)
                {
                    Console.WriteLine("upper case");
                }
                else
                {
                    Console.WriteLine("lower case");
                }
                Console.WriteLine("Do you want to continue(y/n)");
                chh= Convert.ToChar(Console.ReadLine());
                
            } while (chh=='Y' || chh=='y');
            Console.ReadKey();
        }
    }
}
