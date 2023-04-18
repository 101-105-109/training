using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakery
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int food, many, prace = 10;
            bool isFood;

            Console.WriteLine($"1 food = {prace}");
            Console.Write("whate many =");
            many = Convert.ToInt32(Console.ReadLine());
            Console.Write("whate food =");
            food = Convert.ToInt32(Console.ReadLine());

            isFood = many >= food * prace;
            food *= Convert.ToInt32(isFood);
            many -= food * prace;

            Console.WriteLine($"many = {many} food = {food}");
        }
    }
}
