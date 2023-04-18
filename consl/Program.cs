using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace consl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 25);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ResetColor(); // востанавливает консоль до нормального состояния ( цвет )
            //Console.Clear();
            Console.Beep(); // бип бип бип в наушники

            Console.WriteLine("я мыл деда");
            
        }
    }
}
