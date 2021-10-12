using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patr_2_Lesson_2._1
{
    class CountBank
    {
       
        private decimal NumCount { get; set; }
        private decimal Balance { get; set; }
        enum TypeCount
        {
            
            settlement,
            subsetlement,
            credit,
            current
        }

        public void TakeInfo()
        {
            Random random = new Random();
            Console.WriteLine($"ваш номер счёта №{NumCount}, ваш баланс{Balance} ");
            TypeCount count = (TypeCount)random.Next(1, 4);
            Console.WriteLine($" ваш тип счёта {count}");
        }
        public void AddBalce(int value)
        {
            Balance = value;
            
        }
        
    }
}
