using System;

namespace ConsoleTobeto
{
    public class Homework4
    {
        public static void PerfectNumber()
        {
            Console.WriteLine("Bir sayı girin:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} mükemmel bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{number} mükemmel bir sayı değildir.");
            }
        }
    }
}
