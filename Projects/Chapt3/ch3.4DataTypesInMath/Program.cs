using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3._4DataTypesInMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursWorked = 40;
            double bonusHours = 3.8;
            decimal payRate = 21.45m;
            decimal grossPay;

            // Compiler will implicitly convert hoursWorked into a decimal
            // and then do the math
            grossPay = hoursWorked * payRate;
            Console.WriteLine(grossPay.ToString("c"));

            // But we cannot multiple a double by a decimal
            //decimal  bonusRate = bonusHours * payRate;
            
            // We must first cast one or the other
            decimal bonusRate2 = (decimal)bonusHours * payRate;

            // INTEGER DIVISION 
            int five = 5;
            int one = 1;
            int balance = one / five;
            Console.WriteLine(balance); // 0, because the remainder is truncated


            //  CHECKPOINT P 141
            // 3.20
            decimal pricePerFoot = 2.99m;
            double boardLength = 10.5;
            decimal totalCost = (decimal)boardLength * pricePerFoot;

            // 3.21
            int result = 4 + 10 / 2;
            Console.WriteLine(result);

            // 3.22
            int result2 = (2 + 5) * 10;
            Console.WriteLine(result2);

            // 3.23
            double result3 = 5 / 2;
            Console.WriteLine(result3);




            Console.ReadLine();

        }
    }
}
