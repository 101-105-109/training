using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Day;
            Console.WriteLine("Whate day?");
            Console.Write(" is day:");
            Day = Console.ReadLine();

            switch (Day)
            {
                case "понедельник":
                    Console.WriteLine("школа");
                    break;
                case "вторник":
                    Console.WriteLine("курсы");
                    break;
                case "среда":
                    Console.WriteLine("футбольчик");
                    break;
                case "четверг":
                    Console.WriteLine("mama");
                    break;
                case "пятница":
                    Console.WriteLine("papa");
                    break;
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("e-e-e-e-e-e");
                    break;
                default:
                    Console.WriteLine($"i dont thince day {Day}");
                    break;
            }
            Console.WriteLine("хорошо провести день");
        }
    }
}
