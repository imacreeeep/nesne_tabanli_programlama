using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ntp_hafta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi = int.MaxValue;
            //sayi = sayi + 1; // overflow gerçekleşir sayı negatif bir değer alır
            //Console.WriteLine(sayi);

            //float ondalık sayıların saklanması için kullanılır. double daha yüksek hassasiyet gerektiren bilimsel hesaplamalarda kullanılır.

            //float sayi1 = 1.123456789f;
            //double sayi2 = 1.1234567879;
            //Console.WriteLine(sayi1);
            //Console.WriteLine(sayi2);

            //int sayi = 10;
            //float yenisayi = sayi; //dolaylı dönüşüm

            //float pi = 3.14f;
            //int yenipi = (int)pi; //açık dönüşüm

            //double sayi = 9.8;
            //int tamsayi = (int)sayi; //doubledan inte açık dönüşüm

            //string metin = "123";
            //int sayi = Convert.ToInt32(metin); //stringden inte dönüşüm

            //string metin = "123";
            //int sayi = int.Parse(metin); //stringden inte dönüşüm

            //string rakamlar = "12345";
            //char[] rakamlarlistesi = rakamlar.ToCharArray();
            //foreach(char rakam in rakamlarlistesi)
            //{
            //    Console.WriteLine(rakam); //her bir rakam ayrı ayrı yazdırılır
            //}

            //string paradegeri = "123.45";
            //decimal tutar = Convert.ToDecimal(paradegeri);
            //Console.WriteLine(tutar);

            //int a = 10;
            //int b = 20;
            //int toplam = a + b;
            //string sonuc = toplam.ToString();
            //Console.WriteLine($"toplam sonucu {sonuc}");

            //string tarihmetni = "2024-09-28";
            //DateTime tarih =DateTime.Parse(tarihmetni);
            //Console.WriteLine(tarih);

            //int x = 5;
            //x += 3; //8
            //x -= 2; //6
            //x *= 4; //24
            //x /= 2; //12
            //x %= 5;//2

            //int a = 5;
            //int b = 10;
            //if(a < b)
            //{
            //    Console.WriteLine("a b'den küçüktür.");
            //}
            //if(a != b)
            //{
            //    Console.WriteLine("a b'ye eşit değildir.");
            //}

            //uygulama

            //double saatlikucret = 20.5;
            //int calismasaatleri = 40;
            //int mesaisaatleri = 5;
            //double mesaiucreti = saatlikucret * 1.5;

            //double toplammaas = (calismasaatleri * saatlikucret) + (mesaisaatleri * mesaiucreti);
            //Console.WriteLine($"toplam maaş = {toplammaas}");

            //uygulama 2

            //Console.Write("kilonuzu girin: ");
            //double kilo = Convert.ToDouble(Console.ReadLine());

            //Console.Write("boyunuzu girin: ");
            //double boy = Convert.ToDouble(Console.ReadLine());

            //double bmi = kilo / (boy * boy);
            //Console.WriteLine($"vücut kitle indeksiniz: {bmi}");

            //uygulama 3

            //Random rnd = new Random();
            //int tutulansayi = rnd.Next(1,101);

            //int tahmin;
            //do
            //{
            //    Console.Write("bir sayı tahmin edin(1-100): ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin > tutulansayi)
            //    {
            //        Console.WriteLine("daha küçük bir sayı tutun");
            //    }
            //    else if (tahmin < tutulansayi)
            //    {
            //        Console.WriteLine("daha büyük bir sayı tutun");
            //    }
                

            //} while (tahmin != tutulansayi);

            //Console.WriteLine("tebrikler bildiniz");

            //uygulama 4

            

        }
    }
}

class Kutuphane
{
    public string KitapAdi;
    public string Yazar;
    public string KiralamaUcreti;
    public string UyeAdi;
    public string UyeSoyadi;
    public string ParaBakiyesi;

    public Kitap()

}
