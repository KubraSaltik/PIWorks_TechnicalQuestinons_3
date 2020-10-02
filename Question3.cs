using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIWorks_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("first state \n" +"a = " + a+ "\n" + "b = "+ b);
            a = a + b;
            b = a - b; //(b=(a+b)-b = a)
            a = a - b; //(a=(a+b)-a = b)
            Console.WriteLine("last state \n" + "a = " + a + "\n" + "b = " + b);
            Console.ReadLine();
        }
    }
}
