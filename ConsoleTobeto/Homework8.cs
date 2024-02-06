using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTobeto
{
    public class Homework8
    {
        public static void Bolum()
        {
            int count = 0;

            for(int i = 1; i <= 200; i++)
            {
                if(i % 3 == 0 || i  % 5 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Toplam Sayı {count}");
        }
    }
}
