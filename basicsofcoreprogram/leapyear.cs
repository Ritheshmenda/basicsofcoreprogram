using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Leapyear
    {
        public void Leapyears()
        {
            Console.WriteLine("Enter your year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("its a leap year");
            else
                Console.WriteLine("its not a leap year");



        }
    }
}
