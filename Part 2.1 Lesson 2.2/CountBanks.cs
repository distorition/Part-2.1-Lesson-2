﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2._1_Lesson_2._2
{
    class CountBanks
    {
         private int counts { get; set; }
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
            TakeCount();
            Console.WriteLine($"ваш номер счёта №{counts}, ваш баланс{Balance} ");
            TypeCount count = (TypeCount)random.Next(1, 4);
            Console.WriteLine($" ваш тип счёта {count}");
        }
        public void AddBalce(int value)
        {
            Balance = value;

        }
        private void TakeCount()
        {
           
           if( Rand(counts)==counts)
            {
                Rand(counts);
            }

        }
        private int Rand(int coout)
        {
            Random random = new Random();
            coout = random.Next(1, 1000);
            counts = coout;
            return coout;
        }
    }
}
