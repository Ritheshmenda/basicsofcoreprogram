using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Cointoss
    {
        public void Flipcoin()
        {
            int count = 0;
            double headcount = 0;
            double tailcount = 0;
            Console.WriteLine("enter number of flips you want");
            double numofflips = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            while (count < numofflips)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("its tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("its head");
                    headcount++;
                }
                count++;               
            }
            Console.WriteLine("number of head count =" + headcount);
            Console.WriteLine("number of tail count =" + tailcount);
            Console.WriteLine("head percentage is" + (headcount / numofflips) * 100);
            Console.WriteLine("tail percentage is" + (tailcount / numofflips) * 100);

        }

    }
}
