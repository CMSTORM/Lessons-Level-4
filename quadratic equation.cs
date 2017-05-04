using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            double result1 = (-b + Math.Sqrt(discriminant)) / 2;
            double result2 = (-b - Math.Sqrt(discriminant)) / 2;
            Console.WriteLine("a={0} b={1} c{2}",a,b,c);
            Console.WriteLine("D= b*b - 4*a*c = {0} - {1} = {2}",b*b ,4*a*c,discriminant);
            Console.Write("X1 = (-b + square-root(D))/2 = ({0} + {1})/2 = ", -b, Math.Sqrt(discriminant));
            Console.WriteLine(result1);
            Console.Write("X2 = (-b - square-root(D))/2 = ({0} + {1})/2 =", -b, Math.Sqrt(discriminant));
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
