using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class DamageSystem
    {
        static void Main(string[] args)
        {
            float HP, DMG, ARM, PROCH = 100f;

            Console.Write("HP=");
            HP = Convert.ToSingle(Console.ReadLine());
            Console.Write("DMG=");
            DMG = Convert.ToSingle(Console.ReadLine());
            Console.Write("ARM=");
            ARM = Convert.ToSingle(Console.ReadLine());

            HP -= DMG * ARM / PROCH;

            Console.WriteLine($"HP={HP}");
        }
    }
}
