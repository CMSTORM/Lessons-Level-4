using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersDevidedBy5
{
    class Divide
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            for (int i = number1; i <= number2; i++)
            {
                if (i % 5 == 0) Console.WriteLine(i); 

            }
            Console.ReadLine();

        }
    }
}
