using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Words();
                Console.ReadKey();
            }
        }
        static void RandomWords()
        {
            Random random = new Random();
            int True = random.Next(0, 2);

            if (True == 0)
            {

                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.BackgroundColor = (ConsoleColor)random.Next(0, 16);

            }
            else
            {
                Console.ResetColor();
            }
        }
        static void Words()
        {
            bool isOpen = true;
            int line, column;
            char[,] words = {
            {'ё','й','ц','у','к','е','н','г','ш','щ','з'},
            {'д','л','о','р','п','а','в','ы','ф','ъ','х'},
            {'ж','э','я','ч','с','м','и','т','ь','б','ю'},
            {'1','2','3','4','5','6','7','8','9','0',' '}
            };

            Random random = new Random();

            int number_of_characters = random.Next(0, words.Length);

            while (isOpen)
            {

                for (int i = 0; i < number_of_characters; i++)
                {
                    line = random.Next(0, words.GetLength(0));
                    column = random.Next(0, words.GetLength(1));
                    Console.Write(words[line, column]);
                    RandomWords();
                }
                Console.WriteLine();
                isOpen = false;
            }

        }
    }
}
