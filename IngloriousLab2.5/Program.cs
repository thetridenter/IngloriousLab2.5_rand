using System;

namespace IngloriousLab2._5
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введіть розмірність масиву nxn:");
            Console.WriteLine("n");
            n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            const int initRnd = 77;
            Random realRnd = new Random();
            Random repeatRnd = new Random(initRnd);

            Console.WriteLine("Введіть мінімальне значення");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть максимальнe значення");
            int max = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Елементи масиву");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = realRnd.Next(min, max);
                    Console.WriteLine("[" + i + "," + j + "] — " + a[i, j]);
                }
            }

            int p = 1;
            for (int i = n - 1;  i > -1; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    p *= a[i,j];
                }
            }

            Console.WriteLine("\n Добуток бічної діагоналі = " + p);
        }
    }
}
