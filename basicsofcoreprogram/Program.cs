using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation;
            Console.WriteLine("Enter an operation");
            operation = Convert.ToString(Console.ReadLine());
            switch(operation)
            {
                case "power":
                    Power pow = new Power();
                    pow.Powerof2();
                    break;
                case "leapyear":
                    Leapyear leap = new Leapyear();
                    leap.Leapyears();
                        break;
                case "harmonic":
                    Harmonic Harm = new Harmonic();
                    Harm.Harmonics();
                    break;
                case "cointoss":
                    Cointoss cn = new Cointoss();
                    cn.Flipcoin();
                    break;
                case "quotient":
                    Quotient rem = new Quotient();
                    rem.Quot();
                    break;
                case "swap":
                    Swaping sw = new Swaping();
                    sw.Swap();
                    break;
                case "oddeven":
                    Oddeven qe = new Oddeven();
                    qe.Oddoreven();
                    break;
                case "vowels":
                    Vowels cons = new Vowels();
                    cons.Vowelcons();
                    break;
                case "largest":
                    Largest lar = new Largest();
                    lar.Largestnum();
                    break;
                default:
                    Console.WriteLine("Not a operation");
                    break;
            }
        }
    }
}
