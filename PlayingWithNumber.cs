using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithNumbers
{
    class PlayingWithNumber
    {
        static void Main(string[] args)
        {
            int firstN = 213;
            float secondN = 12.34531f;
            float thirdN = -24.5156f;
            Console.WriteLine("{0,-10:X} {1,-10:f2} {2,-10:f2}" ,firstN , secondN,thirdN);
            Console.ReadLine();
        }

    }
}
