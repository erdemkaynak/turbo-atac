using System;

namespace KullaniciBilgileriProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan adını al
            Console.Write("Adınızı giriniz: ");
            string ad = Console.ReadLine();
            
            // Kullanıcıdan soyadını al
            Console.Write("Soyadınızı giriniz: ");
            string soyad = Console.ReadLine();
            
            // Kullanıcıdan yaşını al
            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());
            
            // Bilgileri belirtilen formatta yazdır
            Console.WriteLine($"Merhaba {ad} {soyad}, {yas} yaşındasınız. Hoş geldiniz!");
            
            // Programın hemen kapanmaması için
            Console.ReadKey();
        }
    }
}