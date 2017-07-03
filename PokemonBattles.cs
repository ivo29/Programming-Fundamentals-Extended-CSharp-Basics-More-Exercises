using System;

namespace _06.PokemonBattles
{
    class PokemonBattles
    {
        static void Main(string[] args)
        {
            int pokemonCountFirst = int.Parse(Console.ReadLine());
            int pokemonCountSecond = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= pokemonCountFirst; i++)
            {
                for (int j = 1; j <= pokemonCountSecond; j++)
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
