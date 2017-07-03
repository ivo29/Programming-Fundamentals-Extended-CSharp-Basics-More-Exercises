using System;

namespace _06.PokemonBattles
{
    class PokemonBattles
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= firstPlayer; i++)
            {
                for (int j = 1; j <= secondPlayer; j++)
                {
                    if (maxBattles <= counter)
                    {
                        break;
                    }
                    counter++;
                    Console.Write("({0} <-> {1}) ", i, j);
                    
                }
            }
        }
    }
}


task:
Битки
Да се напише програма, която отпечатва всички възможни битки между покемоните на двама играчи. Като на входа програмата чете броя покемони на всеки играч и максимален брой битки. Ако бъде достигнат максималният брой битки, програмата трябва да приключи.
Вход
От конзолата се четат точно 3 числа, всяко на отделен ред:
Броя покемони на първия играч – цяло число в интервала [1...100]
Броя покемони на втория играч – цяло число в интервала [1...100]
Максималният брой битки – цяло число в интервала [1...100]
Изход
На конзолата се принтират на един ред, разделени с интервал всички битки в следният формат:

Примерен вход и изход
 
Вход	Изход	   
2
2
6	(1 <-> 1) (1 <-> 2) (2 <-> 1) (2 <-> 2)
	 
