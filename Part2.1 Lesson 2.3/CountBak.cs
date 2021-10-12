using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2._1_Lesson_2._3
{
    class CountBak
    {
        private decimal Balans { get; set; }
        private int NumCount{ get; set; }
      public   enum TypeCount
        {

            settlement,
            subsetlement,
            credit,
            current
        }

        public CountBak() { }
        public CountBak(decimal balanse)
        {
            Balans = balanse;
            TakeCount();
        }
        public CountBak(TypeCount type)
        {
            TypeCount op = type;
            TakeCount();
        }
        public CountBak(int balanse,int type)
        {
            Balans = balanse;
            TypeCount op = (TypeCount)type;
            TakeCount();
        }

        private void TakeCount()
        {

            if (Rand(NumCount) == NumCount)
            {
                Rand(NumCount);
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
