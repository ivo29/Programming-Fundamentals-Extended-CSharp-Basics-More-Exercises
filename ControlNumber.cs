using System;

namespace _06___Control_Number
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalSum = 0;
            bool cheker = false;
            for (int i = 1; i <= N; i++)
            {
                for (int j = M; j >= 1; j--)
                {
                    counter++;
                    totalSum = totalSum + (i * 2 + j * 3);
                    if (totalSum>=controlNumber)
                    {
                        cheker = true;
                        Console.WriteLine("{0} moves", counter);
                        Console.WriteLine("Score: {0} >= {1}", totalSum, controlNumber);
                        break;
                    }                  
                }
                if (cheker == true)
                {
                    break;
                }
            }
            if (cheker == false)
            {
                Console.WriteLine("{0} moves",counter);
            }
        }
    }
}
