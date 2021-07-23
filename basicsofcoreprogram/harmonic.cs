using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Harmonic
    {
        public void Harmonics()
        {
            int i, number;
            double s = 0;
            Console.Write("Input the number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("------");
            Console.WriteLine("Sum of Series" + s);
        }
    }
}
