using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Class3
    {
        static void Main()
        {
            //input and output

            string name;
            int age;
            double salary;
            Console.WriteLine("Enter the name");
            name= Console.ReadLine();
            Console.WriteLine("Enter the age");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            salary=double.Parse(Console.ReadLine());

            Console.WriteLine("name :   {0} ",name);
            Console.WriteLine("age :    {0} ", age);
            Console.WriteLine("salary : {0} ", salary);
            Console.ReadKey();




        }
    }
}
