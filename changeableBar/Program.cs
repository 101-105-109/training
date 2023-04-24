using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeableBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxZn = 10;
            int MinZn = 8;
            int Mana = 8;

            while (true)
            {
                changeableBar(MinZn, MaxZn, ConsoleColor.DarkRed, 0);
                changeableBar(Mana, MaxZn, ConsoleColor.DarkBlue, 1);

                Console.SetCursorPosition(0, 5);

                Console.Write("Hp:");
                MinZn = Convert.ToInt32(Console.ReadLine());
                Console.Write("Man:");
                Mana = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();

            }
        }
        static void changeableBar(int MinZn, int MaxZn, ConsoleColor color, int positione)
        {
            string Bar = "";

            for (int i = 0; i < MinZn; i++)
            {
                Bar += " ";
            }

            Console.Write("[");
            Console.SetCursorPosition(0, positione);
            Console.BackgroundColor = color;
            Console.Write(Bar);
            Console.BackgroundColor = default;

            for (int i = MinZn; i < MaxZn; i++)
            {
                Bar += " ";
            }

            Console.Write(Bar + "]");
        }
    }
}
