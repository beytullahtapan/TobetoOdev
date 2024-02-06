using System;

namespace ConsoleTobeto
{
    public class Homework5
    {
        public static void StringMethod()
        {
            string text = "Merhaba dünya!";
            string subString = text.Substring(8); // "dünya!"

            string text2 = "Merhaba Dünya!";
            string upperCase = text2.ToUpper(); // "MERHABA DÜNYA!"
            string lowerCase = text2.ToLower(); // "merhaba dünya!"

            string text3 = "   Merhaba Dünya!   ";
            string trimmedText = text3.Trim(); // "Merhaba Dünya!"

            string text4 = "Merhaba Dünya!";
            string replacedText = text4.Replace("Dünya", "Mars"); // "Merhaba Mars!"

            string text5 = "Merhaba Dünya!";
            bool contains = text5.Contains("Dünya"); // true

            string text6 = "Merhaba Dünya!";
            int firstIndex = text6.IndexOf("a"); // 3
            int lastIndex = text6.LastIndexOf("a"); // 11

            string text7 = "Merhaba,Dünya,Nasılsınız?";
            string[] parts = text7.Split(','); // ["Merhaba", "Dünya", "Nasılsınız?"]

            Console.WriteLine("Substring: " + subString);
            Console.WriteLine("UpperCase: " + upperCase);
            Console.WriteLine("LowerCase: " + lowerCase);
            Console.WriteLine("TrimmedText: " + trimmedText);
            Console.WriteLine("ReplacedText: " + replacedText);
            Console.WriteLine("Contains: " + contains);
            Console.WriteLine("FirstIndex: " + firstIndex);
            Console.WriteLine("LastIndex: " + lastIndex);
            Console.WriteLine("Parts:");
            foreach (var part in parts)
            {
                Console.WriteLine("- " + part);
            }
        }
    }
}
