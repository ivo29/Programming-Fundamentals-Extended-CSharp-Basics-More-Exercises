using System;

namespace _05.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 3 * n + 2;
            int cols = 5 * n;
            string a = new string('*', 3 * n - 2);
            int middleDots = 3 * n;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("*");
                if (i == 0)
                {
                    Console.Write(a);
                }
                else
                {
                    
                    Console.Write(new string('.', middleDots));
                   
                    middleDots+=2;
                }
                Console.Write("*");
                Console.Write(new string('.', n - i));
                Console.WriteLine();
            }
            Console.Write(new string('*', cols));
            Console.WriteLine();
            int leftrightDots = 1;
            int midDots = cols - 4;
            for (int i = 0; i <2*n+1; i++)
            {
                Console.Write(new string('.', leftrightDots + i));
                Console.Write("*");
                if (i == 2 * n)
                {
                    Console.Write(new string('*', midDots - i));
                }
                else
                {
                    Console.Write(new string('.', midDots - i));
                }
                

                midDots--;
                Console.Write("*");
                Console.Write(new string('.', leftrightDots + i));
                Console.WriteLine();
            }
        }
    }
}
