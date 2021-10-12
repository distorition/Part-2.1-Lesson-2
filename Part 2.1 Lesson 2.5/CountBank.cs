using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_2._5
{
    class CountBank
    {
        private int NumCount { get; set; }
        private decimal Balans { get; set; }
        private void TakeCount()
        {

            if (Rand(NumCount) == NumCount)
            {
                Rand(NumCount);
            }

        }
        public void AddToBalans(int value)
        {
            Balans += value;
        }
        public void TakeMoney(int value)
        {
            if(Balans>value)
            {
                Balans -= value;
            }
            else
            {
                Console.WriteLine("на балансе недостаточно средств");
            }
        }
        private int Rand(int coout)
        {
            Random random = new Random();
            coout = random.Next(1, 1000);
            NumCount = coout;
            return coout;
        }
        public void TakeInfo()
        {
            //Random random = new Random();
            TakeCount();
            Console.WriteLine($"ваш номер счёта №{NumCount}, ваш баланс{Balans} ");
            //TypeCount count = (TypeCount)random.Next(1, 4);
            //Console.WriteLine($" ваш тип счёта {count}");
        }
    }
}
