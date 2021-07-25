using System;

namespace basic
{
    class Program
    {
        public void Operations()
        {
            Console.Write("Enter valid operations among these: ");
            Console.Write(" 1.power  ");
            Console.Write("2.harmonic  ");
            Console.Write("3.leapyear  ");
            Console.Write("4.factors  ");
            Console.Write("5.cointoss  ");
            Console.Write("6.quotient  ");
            Console.Write("7.swap  ");
            Console.Write("8.oddeven  ");
            Console.Write("9.vowels  ");
            Console.Write("10.largest  ");
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
                case "factors":
                    Factors fac = new Factors();
                    fac.Factor();
                    break;
                default:
                    Console.WriteLine("Not a operation");
                    break;
            }
            Console.WriteLine("for further operation press  y , and to terminate the operation press   n  ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y' || ch == 'n')
                Operations();
            else
                Console.WriteLine("terminate operation");


        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Operations();
        }
    }
}
