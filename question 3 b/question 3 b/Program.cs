using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Dan and im the maker behind this program");             // Telling the user the maker of program
            Console.WriteLine("This program will ask you to solve an algebraic expression");      // Telling the user what the program is for 
            Console.ReadLine();
            Console.WriteLine(" 2(x - 3) + x = 12 please find the value of x"); 
            Console.ReadLine();
            int x = int.Parse(Console.ReadLine());                                                // declearing variables 
            int guess = int.Parse(Console.ReadLine());
            Console.WriteLine("thank you for using the program");
            Console.ReadLine();
        }
    }
}
