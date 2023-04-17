using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        float HP;
        int DMG;
        int ARM;
        float Percent = 100f;

        Console.Write("HP=");
        HP = Convert.ToSingle(Console.ReadLine());
        Console.Write("DMG=");
        DMG = Convert.ToInt32(Console.ReadLine());
        Console.Write("ARM=");
        ARM = Convert.ToInt32(Console.ReadLine());

        HP -= DMG * ARM / Percent;

        Console.WriteLine(HP);
    }
}