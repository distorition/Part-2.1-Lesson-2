using System;

namespace Part_2._1_Lesson_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            CountBank countBank = new CountBank();
            countBank.AddToBalans(12);
            countBank.TakeInfo();
            countBank.AddToBalans(12);
            countBank.AddToBalans(12);
            countBank.TakeInfo();
            countBank.TakeMoney(12);
            countBank.TakeInfo();
            countBank.TakeMoney(99);
            countBank.TakeInfo();
        }
    }
}
