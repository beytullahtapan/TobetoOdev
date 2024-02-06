using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTobeto
{
    public class Homework2
    {
        public static void OrdersTotal()
        {
            Console.WriteLine("Kaç Ürün Almak İstiyorsunuz");
            int kacurun = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= kacurun; i++)
            {
                Console.WriteLine(i +".ürünün fiyatı");
                toplam += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ürünlerin Toplamı:" + toplam);
        }
    }
}
