using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.6 Formatting Numbers with the ToString() Method, p. 149

            // Pass a formatting string as an argument when calling the .ToString() method
            // Rounding happens as expected

            decimal amount = 123456789.45678m;
            int amountInt = 25;

            Console.WriteLine("amount " + amount.ToString());
            Console.WriteLine("amount 'c' " + amount.ToString("c"));    // formats as American currency
            Console.WriteLine("amount 'n' " + amount.ToString("n"));    // Number format, with decimals separators
            Console.WriteLine("amount 'n3' " + amount.ToString("n3"));   // Number format while specifying number of digits after decimal
            Console.WriteLine("amount 'f' " + amount.ToString("f"));    // Fixed-point scientific notation
            Console.WriteLine("amount 'f3' " + amount.ToString("f3"));   // Fixed-point scientific notation while specifiying number of digits after the decimal
            Console.WriteLine("amount 'e' " + amount.ToString("e"));    // Exponential scientfic notation
            Console.WriteLine("amount 'p' " + amount.ToString("p"));    // Percent format
            Console.WriteLine("amountInt 'd' " + amountInt.ToString("d"));    // Leading zeros for integers
            Console.WriteLine("amountInt 'd4' " + amountInt.ToString("d4"));    // Leading zeros for integers






            Console.ReadLine();

        }
    }
}
