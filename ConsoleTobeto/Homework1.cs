using System;

namespace ConsoleTobeto
{
    public class Homework1
    {
        public static void UserOrder()
        {
            Console.WriteLine("Lütfen Sipariş Numaranızı Giriniz (1-5)");

            var userorders = Console.ReadLine();

            switch (userorders)
            {
                case "1":
                    Console.WriteLine("Bilgisayar Sipariş verdiniz.");
                    break;
                case "2":
                    Console.WriteLine("Laptop Sipariş Verdiniz.");
                    break;
                case "3":
                    Console.WriteLine("Kulaklık Sipariş Verdiniz");
                    break;
                case "4":
                    Console.WriteLine("Klavye Sipariş Verdiniz");
                    break;
                case "5":
                    Console.WriteLine("Mouse Sipariş Verdiniz");
                    break;
                default:
                    Console.WriteLine("Sipariş Numarası Yanlış");
                    break;
            }
        }
    }
}
