using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint3
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal deposit = 976.5m;
            int dollars = (int)deposit;
            Console.WriteLine(dollars.ToString("C"));


            double totalPieces = 6.5;
            int wholePieces = (int)totalPieces;
            Console.WriteLine(wholePieces);



            // Checkpoint 3.6  - p.149
            // What method converts the string literal "40" to a value of the int data type

            string myStrLiteral = "40";

            // int myCast = (int)myStrLiteral;
                // NO, because you cannot cast a string to a numeral; you must parse it
            
            int myParse = int.Parse(myStrLiteral);
            Console.WriteLine(myParse);

            // 3.26  - Write a statement that converts each of the following string values to the 
            // decimal data type using the decimal.Parse method
            
            // a. "9.05" 
            decimal decNineOhFive = decimal.Parse("9.05");
            // b. grandTotal
            decimal grandttl = decimal.Parse(grandTotal);
            // c. "50"
            decimal fifty = decimal.Parse("50");
            // d. string priceTextBox.Text
            decimal price = decimal.Parse(priceTextBox.Text);

            // 3.28 Display each in a message box
            // grandTotal, highScore, sum, width
            





            Console.ReadLine();
        }
    }
}
