using System;
using static System.Console;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = {'R', 'S', 'X', 'H', 'B', 'Y'};

            Array.Reverse(symbs);
            
            for(int i =0;i<symbs.Length;i++){
                Write(symbs[i]+ " ");
            }
            WriteLine();
            
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
