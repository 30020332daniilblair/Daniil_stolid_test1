using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Name is Dan and Im the Man behind this program. This program will ask the user for two numbers then will give them to the power of.
            Console.WriteLine("Please enter a Base number");                 //asking for a base number
            Console.ReadLine();
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an Exponent number");            //asking the user to input an Exponent number 
            int Exponent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Base ^ Exponent}");                        // Base to the poweet of Exponent
            Console.ReadLine();

            Console.WriteLine("thank you for for participating in this program"); 
            Console.ReadLine();
        }
    }
}
