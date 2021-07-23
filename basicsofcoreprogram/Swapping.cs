using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Swaping
    {
        public void Swap()
        {
            int Number1, Number2;
            Console.WriteLine("Please enter the 1st number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the 2nd number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Number1 = Number1 + Number2;      
            Number2 = Number1 - Number2;       
            Number1 = Number1 - Number2;  
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("1st Number: " + Number1);
            Console.WriteLine("2nd Number: " + Number2);
        }
    }
}
