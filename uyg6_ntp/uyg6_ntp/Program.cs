using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg6_ntp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uyg1 
            //string[] liste = {"muz", "ekmek", "süt", "çilek"};
            //Console.WriteLine("alışveriş listeniz:");

            //foreach (string alincaklar in liste)
            //{
            //    Console.WriteLine(alincaklar);
            //}

            //liste[3] = "çikolata";
            //Console.WriteLine();
            //Console.WriteLine("sipariş listeniz güncellendi. \nyeni listeniz:");
            //foreach (string yeni in liste)
            //{
            //    Console.WriteLine(yeni);
            //}

            //uyg2
            //bool[] koltuklar = {true, true, true, true, true, true, true, true, true, true};
            //Console.WriteLine("koltuk seçiminizi yapınız(1-10). çıkmak için '0' yazın.");
            //for (int i = 0; i < koltuklar.Length; i++)
            //{
            //    int secim = Convert.ToInt32(Console.ReadLine());
            //    if (koltuklar[secim - 1] == true)
            //    {
            //        Console.WriteLine("koltuk başarıyla alındı. çıkmak için '0' yazın.");
            //        koltuklar[secim - 1] = false;
            //    }
            //    else if(secim == 0)
            //    {
            //        Console.WriteLine("çıkış yapılıyor...");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("koltuk dolu başka seçim yapın. çıkmak için '0' yazın.");
            //    }
            //}

            //uyg3
            var kitap1 = Tuple.Create("kürk mantolu madonna", "sabahattin ali", 1990);
            var kitap2 = Tuple.Create("1984", "george orwell", 2000);
            var kitap3 = Tuple.Create("hayvan çiftliği", "george orwell", 2005);

            Console.WriteLine("kitaplıktaki mevcut kitaplar:");
            Console.WriteLine($"1. {kitap1.Item1}, yazarın adı: {kitap1.Item2}, yayın yılı: {kitap1.Item3}");
            Console.WriteLine($"2. {kitap2.Item1}, yazarın adı: {kitap2.Item2}, yayın yılı: {kitap2.Item3}");
            Console.WriteLine($"3. {kitap3.Item1}, yazarın adı: {kitap3.Item2}, yayın yılı: {kitap3.Item3}");

            Console.WriteLine("ayrıntısını görmek istediğiniz kitap numarasını seçin:");
            int secim = Convert.ToInt32( Console.ReadLine() );
            if(secim == 1 )
            {
                Console.WriteLine($"seçilen kitap: {kitap1.Item1}");
                Console.WriteLine($"yazarın adı: {kitap1.Item2}");
                Console.WriteLine($"sayfa sayısı: 175");
                Console.WriteLine($"yayın yılı: {kitap1.Item3}");
            }
            else if(secim == 2 )
            {
                Console.WriteLine($"seçilen kitap: {kitap2.Item1}");
                Console.WriteLine($"yazarın adı: {kitap2.Item2}");
                Console.WriteLine($"sayfa sayısı: 200");
                Console.WriteLine($"yayın yılı: {kitap2.Item3}");
            }
            else if(secim == 3 )
            {
                Console.WriteLine($"seçilen kitap: {kitap3.Item1}");
                Console.WriteLine($"yazarın adı: {kitap3.Item2}");
                Console.WriteLine($"sayfa sayısı: 145");
                Console.WriteLine($"yayın yılı: {kitap3.Item3}");
            }
            else
            {
                Console.WriteLine("lütfen geçerli bir sayı girin.");
            }

        }
    }
}
