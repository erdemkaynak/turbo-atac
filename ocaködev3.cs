using System;

namespace SayiToplamaProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı al
            Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            // Geçersiz giriş kontrolü
            if (sayi <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
                Console.ReadKey();
                return;
            }
            
            // For döngüsü ile toplam hesaplama
            int forToplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                forToplam += i;
            }
            
            // While döngüsü ile toplam hesaplama
            int whileToplam = 0;
            int j = 1;
            while (j <= sayi)
            {
                whileToplam += j;
                j++;
            }
            
            // Sonuçları ekrana yazdırma
            Console.WriteLine($"1'den {sayi}'ya kadar olan sayıların toplamı:");
            Console.WriteLine($"For döngüsü ile: {forToplam}");
            Console.WriteLine($"While döngüsü ile: {whileToplam}");
            
            // Matematiksel formül ile kontrol (n*(n+1)/2)
            int formulToplam = sayi * (sayi + 1) / 2;
            Console.WriteLine($"Formül ile hesaplanan sonuç: {formulToplam}");
            
            // Programın hemen kapanmaması için
            Console.ReadKey();
        }
    }
}