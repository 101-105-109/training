using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Brodilca2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");

            int PersonX = 1;
            int PersonY = 1;
            int score = 0;

            ConsoleKeyInfo key = new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            Task.Run(() =>
            {
                while (true)
                {
                    key = Console.ReadKey();
                }
            });

            while (true)
            {
                Console.Clear();
                Input(key, ref PersonX, ref PersonY, map, ref score);

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                DrewMap(map);

                Console.SetCursorPosition(PersonX, PersonY);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("@");

                Console.SetCursorPosition(32, 0);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"Oчки: {score}");

                key = Console.ReadKey();

                //Thread.Sleep(1000);
            }
        }
        private static void Input(ConsoleKeyInfo key, ref int PersonX, ref int PersonY, char[,] map, ref int score) //проврерка на приграду
        {
            int[] direction = GetDirection(key);

            int NexctPersonPositionX = PersonX + direction[0];
            int NexctPersonPositionY = PersonY + direction[1];

            char nextCell = map[NexctPersonPositionX, NexctPersonPositionY];

            if (nextCell == ' ' || nextCell == '.')
            {
                PersonX = NexctPersonPositionX;
                PersonY = NexctPersonPositionY;

                if (nextCell == '.')
                {
                    score++;
                    map[NexctPersonPositionX, NexctPersonPositionY] = ' ';
                }
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo key) //перемещение с возратом 
        {
            int[] direct = { 0, 0 };

            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                direct[1] = -1;
            else if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
                direct[1] = 1;
            else if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow)
                direct[0] = 1;
            else if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow)
                direct[0] = -1;

            return direct;
        }
        static char[,] ReadMap(string path) //считывает карту
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLeng(file), file.Length];

            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }
        private static int GetMaxLeng(string[] lines)  //максимальный размер кальты
        {
            int Maxline = lines[0].Length;

            foreach (string line in lines)
                if (line.Length > Maxline)
                    Maxline = line.Length;

            return Maxline;
        }

        private static void DrewMap(char[,] map)  //ресует карту
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
