using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;

namespace Regex_s
{
    internal class Program
    {
        // Creating the expression 
        static string expression = "[A-Za-z][A-Za-z][0-9][0-9][A-Za-z][A-Za-z]";

        static void checker()
        {
            Console.WriteLine("Enter the number plate");
            string n_p = Console.ReadLine();

            // Creating an instance 
            Regex rg = new Regex(expression);
            if (n_p == "")
            {
                Console.WriteLine("Invalid number plate");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(500);
                Console.WriteLine("Loading.");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(1500);
                Console.Clear();
            }
            else
            {
                if (rg.IsMatch(n_p))
                {
                    Console.WriteLine(" - The number plate '{0}' is VALID!", n_p);
                    Console.WriteLine(" Please press enter to go back to the Main Menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" - The entered number plate '{0}' is not accepted", n_p);
                    Console.WriteLine(" Please press enter to go back to the Main Menu");
                    Console.ReadKey();
                    Console.Clear();
                }
            }



        } 


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Plate Checker");

            while (true)
            {
                checker();
            }

        }
    }
}
