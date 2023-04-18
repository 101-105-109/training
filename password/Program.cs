using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passworld = "1234567890";
            string usingPassworld;

            Console.Write("введите пароль:");

            usingPassworld = Console.ReadLine();

            if (usingPassworld == passworld)
            {
                Console.WriteLine("доступ открыт");
            }
            else
            {
                Console.WriteLine("не верный пароль");
            }
        }
    }
}
