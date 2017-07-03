using System;

namespace _05.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int rows = 2 * n + 2;
            int cols = (4 * n) + 3;
            //draw firs part
            for (int i = 0; i < n+1; i++)
            {
                var dots = new string('.', (n + 1) - i);
                if (i==0)
                {
                    var lowDash = new string('_', 2 * n + 1);
                    Console.Write(dots);
                    Console.Write(lowDash);
                    Console.Write(dots);
                    Console.WriteLine();
                }
                else
                {
                    var lowDash = new string('_',(2 * n - 3)+i*2);                   
                    Console.Write(dots);
                    Console.Write("//");
                    Console.Write(lowDash);
                    Console.Write("\\\\");
                    Console.Write(dots);
                    Console.WriteLine();
                    
                }
            }
            //middle line
            Console.Write("//");
            int lowDashLenght = (4 * n) -6;
            Console.Write(new string('_', lowDashLenght / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', lowDashLenght / 2));
            Console.Write("\\\\");
            Console.WriteLine();
            // last part
            int lowDashPrt2 = 4 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("\\\\");
                Console.Write(new string('_',lowDashPrt2-i));
                lowDashPrt2--;
                Console.Write("//");
                Console.Write(new string('.', i));
                Console.WriteLine();
            }
        }
    }
}
