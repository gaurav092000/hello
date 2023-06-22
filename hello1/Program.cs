using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instant variable
            Program program = new Program();
            program.add();
            program.sub();
            Console.ReadKey();
        }
        int a, b = 10, c = 20;
        public void add()
        {
            a = b + c;
            Console.WriteLine("add: "+a);
        }
        public void sub()
        {
            a=c-b;
            Console.WriteLine("sub :" +a);
        }

    }
}
