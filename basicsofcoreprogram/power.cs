using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Power
    {
        public void Powerof2()
        {
            Console.WriteLine("Enter the maximum");
            double maxpower = Convert.ToInt32(Console.ReadLine());
            double power;
            for (int i = 1; i <= maxpower; i++)
            {
                power = Math.Pow(2, i);
                Console.WriteLine("power of 2^" + i + "  is: " + power);
            }


        }
    }
}
