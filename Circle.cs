using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the radius: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is: {0:F2} " , Math.PI*r*r);
        }
    }
}
