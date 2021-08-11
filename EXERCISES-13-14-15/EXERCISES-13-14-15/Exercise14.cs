using System;
namespace EXERCISES_13_14_15
{
    public class Exercise14
    {
        public Exercise14()
        {
            int counter;
            int square = 1;
            const int maxValue = 10;


            Console.WriteLine("Number  Square");
            Console.WriteLine("-------------------");

            for (counter = 1; counter <= maxValue; counter++)
            {
                square = counter * counter;
                Console.WriteLine("{0}   {1}", counter, square);
            }
        }
    }
}
