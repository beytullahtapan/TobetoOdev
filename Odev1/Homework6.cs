using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTobeto
{
    public class Homework6
    {
        public static void Orders()
        {
            Console.WriteLine("Ürünün Fiyatını Giriniz");
            int product = Convert.ToInt32(Console.ReadLine());
            if(product < 300)
            {
                product += 50;
                Console.WriteLine($"Ödemeniz Gereken Tutar : {product}");
            }
            else 
            {
                Console.WriteLine($"Ödemeniz Gereken Tutar: {product}");
            }
        }
    }
}
