using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // what is the difference between cast int(VARIABLE) and int.Parse(VARIABLE)

            // P 135
            int wholeNumber = 3;
            double realNumber = 3.0;
            decimal decimalNumber = 3.1m;

            // cast the double to an int
            Console.WriteLine((int)realNumber);         // 3
            Console.WriteLine((int)decimalNumber);      // 3
            Console.WriteLine((double)wholeNumber);     // 3
            Console.WriteLine((double)decimalNumber);   // 3.1
            Console.WriteLine((decimal)realNumber);     // 3
            Console.WriteLine((decimal)wholeNumber);    // 3

 

            Console.ReadLine();









        }
    }
}
