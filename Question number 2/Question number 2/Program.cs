using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Helo my Name is Dan and im the creator behind this program
            Console.WriteLine("This program will obtain 5 different prices from the user and add them together");      // explaining to the user what the program is about 
            Console.ReadLine();         
            Console.WriteLine("please enter the price of first item");                                                 // asking the user for the 1st item price
            double first = double.Parse(Console.ReadLine());                                                           // assigning the 1st item price to a variable in this case a double
            Console.WriteLine("please enter the price of the second item");                                            // asking the user for the second item price
            double second = double.Parse(Console.ReadLine());                                                         //assigning the second item price to a variable in this case also a double 
            Console.WriteLine("please enter the price of the third item");                                            // asking the user for third item price
            double third = double.Parse(Console.ReadLine());                                                          // assigning the third item price to a variable in this case also a double 
            Console.WriteLine("please enter the price of the forth item");                                            // asking the user for the forth item price 
            double forth = double.Parse(Console.ReadLine());                                                          // assigning the forth item to a variable in this case a double
            Console.WriteLine("Please enter the price of the fifth number");                                          // asking the user for the fifth and final item price
            double fifth = double.Parse(Console.ReadLine());                                                          // assigning the fith item price to a variable, once again a double 

            Console.WriteLine($"the total of the items together is $ {first + second + third + forth + fifth}");      // entering the code that will add the prices together 
            Console.ReadLine();
            Console.WriteLine("I hope you enjoyed using the program");                                                
            Console.ReadLine();

        }
    }
}
