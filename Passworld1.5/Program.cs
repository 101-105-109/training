using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passworld1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Pasworld = "123";
            string user_Input;
            int numberOfAttempts = 3;

            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.WriteLine($"{numberOfAttempts - i} попыток осталось. Введите пароль");
                user_Input = Console.ReadLine();

                if (user_Input == Pasworld)
                {
                    Console.WriteLine("пароль верный");
                    break;
                }
            }
        }
    }
}
