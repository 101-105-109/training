using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "";
            int i1 = 0, j1 = 0;
            bool isOpen = true;
            int chous = 0;
            bool yes = false;

            string[,] name =
            {
                {"Адукард","Кирилл","Анатолий"},
                {"Кристафор","Юнити","БэБэй"},
                {"Юра","Пертураба","Ивангай"},
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 25);

                Console.WriteLine("именна:");

                for (int i = 0; i < name.GetLength(0); i++)
                {
                    for (int j = 0; j < name.GetLength(1); j++)
                    {
                        Console.Write(name[i,j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 15);

                for (int i = 0; i < name.GetLength(0); i++)
                {
                    for (int j = 0; j < name.GetLength(1); j++)
                    {
                        Console.Write($"{i+1}|{j+1} |");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);

                Console.Write("\n1 - найти имя\n\n2 - узнать расположение имени\n\n3 - выйти\n\nваш выбр:");

                chous = Convert.ToInt32(Console.ReadLine());

                switch(chous)
                {
                    case 1:
                        Console.Write("\nвведите номер строки:");
                        i1 = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (i1 > name.GetLength(0))
                        {
                            Console.WriteLine($"не коректное количество строк. В библеотеке всего {name.GetLength(0)} строк");
                            break;
                        }
                        Console.Write("\nвведите номер сталбца:");
                        i1 = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (j1 > name.GetLength(1))
                        {
                            Console.WriteLine($"не коректное количество столбцев. В библеотеке всего {name.GetLength(1)} столбцев");
                            break;
                        }

                        Console.WriteLine("\n" + name[i1,j1]);

                        break; 
                    case 2:
                        Console.Write("имя:");
                        name1 = Console.ReadLine();


                        for (int i = 0; i < name.GetLength(0); i++)
                        {
                            for (int j = 0; j < name.GetLength(1); j++)
                            {
                                if (name[i,j].ToLower() == name1.ToLower())
                                {
                                    Console.WriteLine($"намер строка:{j + 1} номер столбца:{i + 1}");
                                    yes = true;
                                    break;
                                }
                            }
                            if (yes == true) break;
                        }

                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("\nне ясная команда");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
