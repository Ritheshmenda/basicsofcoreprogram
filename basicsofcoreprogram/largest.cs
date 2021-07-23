using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Largest
    {
        public void Largestnum()
        {
            int NumberA, NumberB, NumberC;
            Console.Write("Enter the value of A:");
            NumberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B:");
            NumberB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of C:");
            NumberC = Convert.ToInt32(Console.ReadLine());
            if (NumberA > NumberB && NumberA > NumberC)
                Console.WriteLine("A is largest number");
            else if (NumberB > NumberA && NumberB > NumberC)
                Console.WriteLine("B is largest");
            else if (NumberC > NumberA && NumberC > NumberB)
                Console.WriteLine("C is Largest NUMBER");
            else
                Console.WriteLine("all the three or two numbers are equals");
        }
    }
}
