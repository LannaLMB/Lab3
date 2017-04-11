using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int input;


            // Input
            Console.WriteLine("Please Enter an Integer: ");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid Entry!  Please Enter an Integer: ");
            }
        }
    }
}
