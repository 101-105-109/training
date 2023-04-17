using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currencyСonverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Rub;
            float Dolar;
            float To = 83.5f;
            float Skolko;
            string choice;

            Console.WriteLine("добро пожаловать в обменик валют");
            Console.Write("сколько у вас рублей:");
            Rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("сколько у вас доларов:");
            Dolar = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("что вы хотите сделать?");
            Console.WriteLine("1 - долары на рубли");
            Console.WriteLine("2 - рубли в долары");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("сколько доларов:");
                    Skolko = Convert.ToSingle(Console.ReadLine());
                    if (Dolar >= Skolko)
                    {
                        Rub += Dolar * To;
                        Dolar -= Skolko;
                    }
                    else
                    {
                        Console.WriteLine("вы вели не верную сумму");
                    }
                    break;
                case"2":
                    Console.WriteLine("сколько рублей:");
                    Skolko = Convert.ToSingle(Console.ReadLine());
                    if (Rub >= Skolko)
                    {
                        Dolar += Rub / To;
                        Rub -= Skolko;
                    }
                    else
                    {
                        Console.WriteLine("вы вели не верную сумму");
                    }
                    break;
                default:
                    Console.WriteLine("не ясная команда");
                    break;
            }
            Console.WriteLine($"баланс: рублей {Rub}, доларов {Dolar}");
        }
    }
}
