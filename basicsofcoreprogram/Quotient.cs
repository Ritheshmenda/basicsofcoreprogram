using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Quotient
    {
        public void Quot()
        {
			int x, y, quotient, reminder;
			Console.WriteLine("Enter bigger number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter smaller number:");
			y = Convert.ToInt32(Console.ReadLine());

			quotient = x / y;
			reminder = x % y;

			Console.WriteLine("Quotient is:" + quotient);
			Console.WriteLine("Remainder is:" + reminder);
		}
    }
}
