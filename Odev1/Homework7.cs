using System;

namespace ConsoleTobeto
{
    public class Homework7
    {
        public static void Order()
        {
            int urun1 = 0;
            int urun2 = 0;
            Console.WriteLine("Lütfen 1. Ürünün Fiyatını Giriniz");
            urun1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Ürünün Fiyatını Giriniz");
            urun2 = Convert.ToInt32(Console.ReadLine());
            int toplam = urun1 + urun2;
            if (toplam > 500)
            {
                int iskonto = urun2 * 40 / 100;
                urun2 -= iskonto; 
                toplam = urun1 + urun2;
                Console.WriteLine($"Ödemeniz Gereken Tutar: {toplam}");
            }
            else
            {
                Console.WriteLine($"Ödemeniz Gereken Tutar: {toplam}");
            }
        }
    }
}
