using System;

namespace DiziMinMaxBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 elemanlı tam sayı dizisi oluştur
            int[] sayilar = new int[5];
            
            // Kullanıcıdan 5 adet tam sayı al
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i+1}. sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // MinMax fonksiyonunu çağır ve sonuçları al
            (int enKucuk, int enBuyuk) = MinMaxBul(sayilar);
            
            // Sonuçları ekrana yazdır
            Console.WriteLine($"Girilen en küçük sayı: {enKucuk}");
            Console.WriteLine($"Girilen en büyük sayı: {enBuyuk}");
            
            // Programın hemen kapanmaması için
            Console.ReadKey();
        }
        
        // En küçük ve en büyük değerleri bulan fonksiyon
        static (int, int) MinMaxBul(int[] dizi)
        {
            // Başlangıç değerleri olarak dizinin ilk elemanını ata
            int enKucuk = dizi[0];
            int enBuyuk = dizi[0];
            
            // Dizinin tüm elemanlarını kontrol et
            for (int i = 1; i < dizi.Length; i++)
            {
                // En küçük değeri güncelle
                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
                
                // En büyük değeri güncelle
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }
            
            // En küçük ve en büyük değerleri tuple olarak döndür
            return (enKucuk, enBuyuk);
        }
    }
}