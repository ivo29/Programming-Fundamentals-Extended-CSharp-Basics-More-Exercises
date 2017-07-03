using System;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {            
            int cargos = int.Parse(Console.ReadLine());
            int van = 0;
            int lorry = 0;
            int train = 0;
            for (int i = 0; i < cargos; i++)
            {
                int load = int.Parse(Console.ReadLine());
                if (load >= 12)
                {
                    train=train+load;
                }
                else if (load>=4)
                {
                    lorry=lorry+load;
                }
                else if (load<=3)
                {
                    van=van+load;
                }                
            }
            int totalLoad = van + lorry + train;
            double vanPrice = van * 200;
            double lorryPrice = lorry*175;
            double trainPrice = train * 120;
            double averagePrice = (vanPrice + lorryPrice + trainPrice) / totalLoad;
            double vanPcent = (van / (double)totalLoad) * 100;
            double lorryPcent = (lorry / (double)totalLoad) * 100;
            double trainPcent = (train/(double)totalLoad)*100;
            Console.WriteLine("{0:0.00}",averagePrice);
            Console.WriteLine("{0:0.00}%", vanPcent);
            Console.WriteLine("{0:0.00}%", lorryPcent);
            Console.WriteLine("{0:0.00}%", trainPcent);
        }
    }
}
