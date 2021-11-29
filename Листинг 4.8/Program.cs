using System;

namespace Листинг_4._8
{
    class Program
    {
        static void consoleWrite(){
            Console.WriteLine("Число 1 = 1");
            Console.WriteLine("Число 2 = 1");
        }
        static void Main(string[] args)
        {
            int k = 3;
            int l = 1;
            int p = 1;

            Console.Write("До кое число на Фибонаяи иска те да се изписшат на конзолата : ");
            int n = int.Parse(Console.ReadLine());
            
            if(n == 1){
                Console.WriteLine("Число 1 = 1");
            }
            else if(n == 2){
                consoleWrite();
            }
            else if(n == 3){
                    consoleWrite();
                    Console.WriteLine("Число 3 = " + (l + p));
            }
            else{
                    consoleWrite();
                    for(int i = 3;i <= n;i++){
                        int fib = l + p;
                        Console.WriteLine("Число " + k + " = " + (fib));
                        l = p;
                        p = fib;
                        k++;
                    }
            }
            Console.ReadLine();
        }
    }
}
