using System;

namespace Листинг_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] symbs = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };
            Console.WriteLine("Изходен Масив: ");
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i, j] + " ");
                }
                Console.WriteLine();
            }
            Random rnd = new Random();
            int rows = rnd.Next(symbs.GetLength(0) + 1);
            int cols = rnd.Next(symbs.GetLength(1) + 1);
            
            Console.WriteLine("Добавя се {0}-ят ред и {1}-ата колона", rows, cols);
            char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];
            int a, b;
            char s = 'a';
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                if (i < rows) a = i;
                else a = i + 1;
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    if (j < cols) b = j;
                    else b = j + 1;
                    tmp[a, b] = symbs[i, j];
                }
            }
            for (int j = 0; j < tmp.GetLength(1); j++)
            {
                tmp[rows, j] = s;
                s++;
            }
            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                if (i != rows)
                {
                    tmp[i, cols] = s;
                    s++;
                }
            }
            Console.WriteLine("Нов масив: ");
            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {
                    Console.Write(tmp[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
