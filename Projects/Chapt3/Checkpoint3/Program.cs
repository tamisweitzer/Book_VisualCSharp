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



            Console.ReadLine();
        }
    }
}
