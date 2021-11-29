using System;

namespace Листинг_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,,] symbs = new char[4, 3, 5];
            char[] s = { 'а', 'А', 'a', 'A' };
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                Console.WriteLine(" Слой №{0}:", i + 1);
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    for (int k = 0; k < symbs.GetLength(2); k++)
                    {
                        symbs[i, j, k] = s[i];
                        s[i]++;
                        Console.Write(symbs[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("----------");
            }
            Console.ReadLine();
        }
    }
}
