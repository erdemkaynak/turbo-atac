using System;

namespace CiftTekKontrolProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı al
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            // Sayının negatif olup olmadığını kontrol et
            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayı girdiniz!");
            }
            // Sayının çift mi tek mi olduğunu kontrol et
            else if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} bir çift sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} bir tek sayıdır.");
            }
            
            // Programın hemen kapanmaması için
            Console.ReadKey();
        }
    }
}