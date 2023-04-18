using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gladeatorialСombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            float HP1 = rnd.Next(0, 101);
            float HP2 = rnd.Next(0, 101);
            int DMG1 = rnd.Next(0, 101);
            int DMG2 = rnd.Next(0, 101);
            int ARM1 = rnd.Next(0, 100);
            int ARM2 = rnd.Next(0, 100);

            Console.WriteLine($"fighter1 HP = {HP1} DMG = {DMG1} ARM = {ARM1}");
            Console.WriteLine($"fighter2 HP = {HP2} DMG = {DMG2} ARM = {ARM2}");

            while( HP1 > 0 && HP2 > 0 )
            {
                HP1 -= Convert.ToSingle(rnd.Next(0, DMG2) * rnd.Next(0,ARM1) / 100);
                HP2 -= Convert.ToSingle(rnd.Next(0, DMG1) * rnd.Next(0,ARM2) / 100);
                Console.WriteLine($"fighter1 HP = {HP1}");
                Console.WriteLine($"fighter2 HP = {HP2}");
            }
            if ( HP1 <= 0 && HP2 <= 0 )
            {
                Console.WriteLine("ничья");
            }
            else if ( HP1 <= 0)
            {
                Console.WriteLine("fighter2 win");
            }
            else
            {
                Console.WriteLine("fighter1 win");
            }
        }
    }
}
