using System;

namespace _05.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                int dotsCount = 3 * n - 2;
                int spaceCount=0;
                Console.Write(new string('.', (3 * n - 2) / 2 - row)
                    + "/");                              
                    Console.Write(new string(' ', spaceCount+row*2));
                spaceCount=+2;
                Console.Write( "\\" + new string
                    ('.', (3 * n - 2) / 2 - row));
                Console.WriteLine();
            }
            int secondLineStars = 2 * n;
            int secondLineDots = 3 * n - 2 * n;
            Console.WriteLine(new string('.', secondLineDots / 2) + new string
                ('*', secondLineStars) + new string('.', secondLineDots / 2));
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(new string('.', secondLineDots / 2));
                Console.Write("|");
                Console.Write(new string('\\', secondLineStars - 2));
                Console.Write("|");
                Console.Write(new string('.', secondLineDots / 2));
                Console.WriteLine();
            }
            for (int i = 0; i < n/2; i++)
            {
                int dotsCount = 3 * n - (2 * n - 2)-2 ;
                int starsCount = 3 * n - dotsCount-2;
                Console.Write(new string('.', (dotsCount / 2)-i));
                Console.Write("/");
                Console.Write(new string('*',starsCount+i*2));
                Console.Write("\\");
                Console.Write(new string('.', (dotsCount / 2) - i));
                Console.WriteLine();

            }
        }
    }
}
task:
Ракета
Да се напише програма, която прочита от конзолата цяло четно число N и чертае ракета, като в примерите по-долу.
    Ракетата има ширина – 3 * N колони. 
Вход
Входът се чете от конзолата и съдържа само едно цяло четно число в интервала [4…100].
Изход
Да се отпечата на конзолата ракета, точно както в примерите.
Примерен вход и изход
 
Вход	Изход			   
4
...../\.....
..../  \....
.../    \...
../      \..
..********..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
..|\\\\\\|..
../******\..
./********\.	
