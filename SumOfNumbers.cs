using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double number3;
            double number4;
            double number5;
            start:
                bool n1 = double.TryParse(Console.ReadLine(), out number1);
                bool n2 = double.TryParse(Console.ReadLine(), out number2);
                bool n3 = double.TryParse(Console.ReadLine(), out number3);
                bool n4 = double.TryParse(Console.ReadLine(), out number4);
                bool n5 = double.TryParse(Console.ReadLine(), out number5);
            if (n1 && n2 && n3 && n4 && n5 == false)
            {
                Console.WriteLine("Invalid Number!Try Again:");
                goto start;
            }
            else
            {

                Console.WriteLine(number1 + number2 + number3 + number4 + number5);
                
            }
                Console.ReadLine();


        }
    }
}
