using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planeFlight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rid=0, kolMest=0;
            bool isOpen = true;
            string chous;
            int[] samalet = {6, 15, 20, 15, 6};

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                for (int i = 0; i < samalet.Length; i++)
                {
                    Console.WriteLine($"{i+1} ряду свободно {samalet[i]} мест");
                }
                Console.SetCursorPosition(0, 0);

                Console.Write("1 - зарегестрировать место\n\n0 - выход\n\nваш выбр:");
                chous = Console.ReadLine();

                switch (chous)
                {
                    case "1":

                        Console.Write("ряд:");
                        rid = Convert.ToInt32(Console.ReadLine())-1;

                        if (rid > samalet.Length || rid < 0)
                        {
                            Console.WriteLine("такого ряда нет");
                            break;
                        }

                        Console.Write("количество мест:");
                        kolMest = Convert.ToInt32(Console.ReadLine());

                        if (kolMest > samalet[rid])
                        {
                            Console.WriteLine($"мест меньше. свободно {samalet[rid]} мест");
                            break;
                        }  

                        if (kolMest < 0)
                        {
                            Console.WriteLine($"мест больше. свободно {samalet[rid]} мест");
                            break;
                        }


                        samalet[rid] -= kolMest;
                        Console.WriteLine("все прошло усешно");

                        break;

                    case "0":
                        isOpen=false;
                        break;

                    default:
                        Console.WriteLine("не ясная команда");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
