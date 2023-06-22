using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    internal class Class5
    {
        static void Main()
        {

            //vovel or consonent
            char ch;
            Console.WriteLine("Enter the aplapha bet");
            ch=char.Parse(Console.ReadLine());
            if (ch =='a'||ch=='e'|| ch == 'i' || ch == 'o' || ch == 'o'|| ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("alphabet vovel:"+ch);

            }
            else
            {
                Console.WriteLine("Constant");
            }
            Console.ReadKey();
        }
    }
}
