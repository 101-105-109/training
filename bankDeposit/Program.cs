using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankDeposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float many;
            int yers;
            int prochente;

            Console.WriteLine("добро в банк!");
            Console.Write("количество денег: ");
            many = Convert.ToSingle(Console.ReadLine());
            Console.Write("какой процент: ");
            prochente = Convert.ToInt32(Console.ReadLine());
            Console.Write("сколько лет: ");
            yers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < yers; i++)
            {
                many += many * prochente / 100;  
                Console.WriteLine($"сумма: {many}");
                Console.ReadKey();
            }

        }
    }
}
