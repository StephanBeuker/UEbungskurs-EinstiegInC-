using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenTypFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.141F;
            Console.WriteLine(pi);

            float pi2 = 0.0314e2F;      //0,0314 * 10 hoch 2: Kurzschreibtweise
            Console.WriteLine(pi2);

            float floatmax = float.MaxValue;
            Console.WriteLine(floatmax);

            float floatmax2 = 3.402823e38F;
            Console.WriteLine(floatmax2);
            Console.WriteLine("Ein float hat auf diesem REchner  den maximal Wert: {0:F}", floatmax);

            float a = 123456789.01F;     //gerundet, Geuigkeit nur 10 Stellen 
            float b = 123456789.02F;     //gerundet, Geuigkeit nur 10 Stellen 
            Console.WriteLine($"{ a},{ b}");

            //Double kann 16 Stellen darstellen.

            Console.Read();
        }
    }
}
