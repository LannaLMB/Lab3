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
            int square;
            int cube;
            string Continue;


            //Continue Loop
            while (true)
            {


                // Welcome Message
                Console.WriteLine("******  Learn Your Squares and Cubes!!!  ******");
                Console.WriteLine();


                // Input
                Console.WriteLine("Please Enter an Integer: ");
                Console.WriteLine();
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid Entry!  Please Enter an Integer: ");
                    Console.WriteLine();
                }


                // Process
                Console.WriteLine();
                Console.WriteLine("\t\t Number \t Squared \t Cubed");
                Console.WriteLine("\t\t ========== \t ========== \t ==========");


                //Initialize i
                int i;

                for (i = 1; i <= input; i++)
                {
                    //Math
                    square = i * i;
                    cube = (i * i * i);
                    Console.WriteLine("\t\t\t" + i + "\t\t" + square + "\t\t"+cube);
                }
                Console.WriteLine();


                //Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Continue?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }
    }
}
