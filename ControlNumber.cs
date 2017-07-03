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

task:
Контролно число
Напишете програма която проверява всички възможни комбинации от двойка числа. Първото число от комбинацията е нарастващо от 1 до N, а второто е намаляващо от M до 1. Първото число умножено по 2 плюс второто умножено по 3 се прибавят към обща сума. Дадено е контролно число. Ако сумата стане равна или по-голяма от контролното число, програмата приключва. Пример: 
При N = 3, M = 4 и контролното число = 115 комбинаците са 12:
1 4 | 1 3 | 1 2 | 1 1 | 2 4 | 2 3 | 2 2 | 2 1 | 3 4 | 3 3 | 3 2 | 3 1
За всеки ход(комбинация) към общата сума се прибавя резултата по дадената формула:

1ви ход – 1*2 + 4*3 = 14
2ри ход – 14 + 1*2 + 3*3 = 25
3ти ход – 25 + 1*2 + 2*3 = 32
....
9ти ход = 102
10ти ход = 102 + 3*2 + 3*3 = 102 + 15 = 117
Сумата е равна на контролното число и се изипсва съобщение което показва броя ходове и сумата, след което програмата приключва. Ако сумата до края остане по-малко от контролното число се изписва броя на всички ходове(комбинации).

