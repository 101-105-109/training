using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLEASE_THE_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int chislo;
            int cisloLower;
            int cisloUpper;
            int cislo;
            int cisloPopitok = 8;

            cislo = random.Next(0, 101);
            cisloLower = random.Next(cislo - 10, cislo);
            cisloUpper = random.Next(cislo + 1, cislo + 10);

            Console.WriteLine($"число больше {cisloLower} и меньше {cisloUpper}");

            while(cisloPopitok-- > 0)
            {
                Console.WriteLine($"{cisloPopitok} осталось попыток");
                Console.WriteLine("ваш отве: ");
                chislo = Convert.ToInt32(Console.ReadLine());

                if ( chislo == cislo)
                {
                    Console.WriteLine("вы угодали");
                    break;
                }
            }

            if (cisloPopitok <= 0)
            {
                Console.WriteLine($"увы, это было число {cislo}");
            }
        }
    }
}
