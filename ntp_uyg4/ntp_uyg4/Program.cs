using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_uyg4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tarife secenek = new tarife();
            //secenek.HangiTarifeSecimi();
            //secenek.Internet();
            //secenek.SonucGoster();

            restoran secimler = new restoran();
            bool devam = true;

            while (devam)
            {
                secimler.MenuyuGoster();
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 8)
                {
                    devam = false;
                    continue;
                }

                secimler.SiparisEkle(secim);
                secimler.ToplamTutarGoster();

                Console.Write("Başka bir sipariş eklemek ister misiniz? (evet/hayır)");
                string cevap = Console.ReadLine();
                
                if (cevap == "hayır")
                {
                    devam = false;
                    secimler.ToplamTutarGoster();
                    Console.WriteLine("sipariş tamamlandı iyi günler!");
                }
            }
        }
    }

    class tarife
    {
        private string standart = "standart";
        private string aile = "aile";
        private string genc = "genç";
        private string sonuc;
        private int intsonuc;

        public string HangiTarifeSecimi()
        {
            Console.WriteLine("Lütfen hangi tarifeden yararlanmak istediğinizi yazınız. (standart, genç, aile)");
            string tarifeSecimi = Console.ReadLine();

            if (tarifeSecimi == standart || tarifeSecimi == aile || tarifeSecimi == genc)
            {
                sonuc = tarifeSecimi;
            }
            else
            {
                Console.WriteLine("Geçersiz tarife seçimi.");
                sonuc = null;
            }

            return sonuc;
        }

        public int Internet()
        {
            if (sonuc == null) return 0;

            Console.WriteLine("Kullanmak istediğiniz GB'ı giriniz.");
            if (!int.TryParse(Console.ReadLine(), out int intSecimi))
            {
                Console.WriteLine("Geçersiz bir değer girdiniz.");
                return 0;
            }


            if (sonuc == "standart")
            {
                if (intSecimi <= 10)
                {
                    intsonuc = intSecimi * 7;
                }
                else
                {
                    intsonuc = intSecimi * 10;
                }
            }
            else if (sonuc == "aile")
            {
                if (intSecimi <= 10)
                {
                    intsonuc = intSecimi * 10;
                }
                else
                {
                    intsonuc = intSecimi * 15;
                }
            }
            else if (sonuc == "genç")
            {
                if (intSecimi <= 10)
                {
                    intsonuc = intSecimi * 5;
                }
                else
                {
                    intsonuc = intSecimi * 7;
                }
            }

            return intsonuc;

        }

        public void SonucGoster()
        {
            if (sonuc != null)
            {
                Console.WriteLine($"Seçtiğiniz tarife: {sonuc}, toplam tutarınız: {intsonuc}TL");
            }
        }
    }

    class restoran
    {
        public decimal toplamTutar { get; private set; } = 0;

        public void MenuyuGoster()
        {
            Console.WriteLine("*** Restoran Menüsü ***");
            Console.WriteLine("1. Pizza - 50TL");
            Console.WriteLine("2. Hamburger - 40TL");
            Console.WriteLine("3. Salata - 30TL");
            Console.WriteLine("4. Makarna - 35TL");
            Console.WriteLine("5. Kola - 10TL");
            Console.WriteLine("6. Su - 5TL");
            Console.WriteLine("7. Çay - 7TL");
            Console.WriteLine("8. Çıkış");
            Console.Write("Lütfen bir seçenek girin (1-8): ");
        }

        public void SiparisEkle(int secim)
        {
            switch(secim)
            {
                case 1:
                    Console.WriteLine("Pizza siparişi verdiniz.");
                    toplamTutar += 50;
                    break;
                case 2:
                    Console.WriteLine("Hamburger siparişi verdiniz.");
                    toplamTutar += 40;
                    break;
                case 3:
                    Console.WriteLine("Salata siparişi verdiniz.");
                    toplamTutar += 30;
                    break;
                case 4:
                    Console.WriteLine("Makarna siparişi verdiniz.");
                    toplamTutar += 35;
                    break;
                case 5:
                    Console.WriteLine("Kola siparişi verdiniz.");
                    toplamTutar += 10;
                    break;
                case 6:
                    Console.WriteLine("Su siparişi verdiniz.");
                    toplamTutar += 5;
                    break;
                case 7:
                    Console.WriteLine("Çay siparişi verdiniz.");
                    toplamTutar += 7;
                    break;
                case 8:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default: 
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen (1-8) arası bir değer giriniz.");
                    break;
            }
        }

        public void ToplamTutarGoster()
        {
            Console.WriteLine($"Toplam tutarınız: {toplamTutar}TL");
        }
    }
}
