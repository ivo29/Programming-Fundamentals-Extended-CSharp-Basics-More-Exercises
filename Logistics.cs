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
                    van = van + load;
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
task:
Логистика
Отговаряте за логистиката на различни товари. В зависимост от теглото на товара е нужно различно превозно средство.
    Цената на тон, за която се превозва товара е различна за всяко превозно средство:
До 3 тона – микробус (200 лева на тон);
От 4 до 11 тона – камион (175 лева на тон);
12 и повече тона – влак (120 лева на тон).
Вашата задача е да изчислите средната цена на тон превозен товар, както и процента на тоновете  превозвани с всяко превозно средство, 
спрямо общото тегло(в тонове) на всички товари.
Вход
От конзолата се четат поредица от числа, всяко на отделен ред:
На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала [1...1000]
Изход
Да се отпечатат на конзолата 4 реда, както следва:
Първи ред – средната цена на тон превозен товар (закръглена до втория знак след дес. запетая);
Втори ред – процентът тона превозвани с микробус (процент между 0.00% и 100.00%);
Трети ред – процентът  тона превозвани с камион (процент между 0.00% и 100.00%);
Четвърти ред – процентът тона превозвани с влак (процент между 0.00% и 100.00%).
Примерен вход и изход
 
