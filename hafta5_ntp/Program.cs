using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hafta5_ntp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int sayi;
            //while (true) //ne gelirse gelsin bu while döngüsü sonsuza kadar çalışacaktır
            //{
            //    Console.WriteLine("pozitif bir sayı girin (negatif çıkış)");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if(sayi<0)
            //    {
            //        Console.WriteLine("negatif bir sayı girildi. döngü sonlandırılıyor");
            //        break;//break ile bu döngü kırılabilir veya bool değişkeni atayıp false'a çevirerek döngüyü sonlandırabiliriz
            //    }
            //}

            //break kullanımı

            //int x = 0;
            //while (x < 10)
            //{
            //    if (x == 5)
            //    {
            //        break; //x 5'e geldiğinde döngü sonlandırılır. 4'e kadar yazar
            //    }
            //    Console.WriteLine(x);
            //    x++;
            //}

            //continue kullanımı

            //int y = 0;
            //while (y < 10)
            //{
            //    y++;
            //    if (y % 2 == 0)
            //    {
            //        continue; //çift sayı olanları yazdırmıcak
            //    }
            //    Console.WriteLine(y);
            //}

            //iç içe döngüler

            //int satirsayisi = 5;
            //int i = 1;
            //while (i <= satirsayisi)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write("+");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}
            //int w = 1;
            //while (w <= satirsayisi) 
            //{
            //    int q = 5;
            //    while(w <= q)
            //    {
            //        Console.Write("+");
            //        q--;
            //    }
            //    Console.WriteLine();
            //    w++;
            //}

            //do while döngüsü

            //int secim;
            //do
            //{
            //    Console.WriteLine("1 - yeni oyun");
            //    Console.WriteLine("2 - ayarlar");
            //    Console.WriteLine("3 - çıkış");
            //    Console.Write("seçiminizi yapın (1-3)") ;
            //    secim = Convert.ToInt32(Console.ReadLine());
            //} while (secim < 1 || secim > 3);
            //Console.WriteLine("seciminiz: " + secim);

            //int cardnumber;
            //do
            //{
            //    Console.Write("keredi kartı numarası giriniz (16 haneli)");
            //    cardnumber = Convert.ToInt32(Console.ReadLine());

            //    if(cardnumber.l != 16 || long.TryParse(cardnumber, out _))
            //    {

            //    }
            //}

            //int x = 0;
            //do
            //{
            //    Console.WriteLine("x değeri: " + x);
            //    x++;
            //    if (x == 3)
            //    {
            //        break;
            //    }
            //} while (x < 10);

            //int y = 0;
            //do
            //{
            //    y++;
            //    if (y% 2==0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(y);
            //}while(y < 10);


            //int secim;
            //int sayi1; 
            //int sayi2;
            //do
            //{
            //    Console.WriteLine("1 - +");
            //    Console.WriteLine("2 - -");
            //    Console.WriteLine("3 - *");
            //    Console.WriteLine("4 - /");
            //    Console.WriteLine("5 -  çıkış");
            //    Console.Write("seçiminizi yapın (1-5)");
            //    secim = Convert.ToInt32(Console.ReadLine());
            //    if (secim == 5)
            //    {
            //        break;
            //    }
            //    else if (secim == 1)
            //    {
            //        Console.WriteLine("ilk sayıyı girin");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("ikinci sayıyı girin");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        int sonuc = sayi1 + sayi2;
            //        Console.WriteLine(sonuc);

            //    }
            //    else if (secim == 2)
            //    {
            //        Console.WriteLine("ilk sayıyı girin");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("ikinci sayıyı girin");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        int sonuc = sayi1 - sayi2;
            //        Console.WriteLine(sonuc);

            //    }
            //    else if (secim == 3)
            //    {
            //        Console.WriteLine("ilk sayıyı girin");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("ikinci sayıyı girin");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());

            //        int sonuc = sayi1 * sayi2;
            //        Console.WriteLine(sonuc);

            //    }
            //    else if (secim == 4)
            //    {
            //        Console.WriteLine("ilk sayıyı girin");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("ikinci sayıyı girin");
            //        sayi2 = Convert.ToInt32(Console.ReadLine());
            //        int sonuc = sayi1 / sayi2;
            //        Console.WriteLine(sonuc);
            //    }

            //} while (true);
            //Console.WriteLine("seciminiz: " + secim);

            //int toplam = 0;
            //while (toplam < 100)
            //{
            //    Console.WriteLine("bir sayı girin");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    if (toplam == 100) break;
            //    Console.WriteLine("toplam: "+ toplam);
            //}

            //şifre kodu

            //for döngüsü

            //int sayi = 5;
            //int fakt = 1;
            //for(int i = 1; i <= sayi; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine($"{sayi}! = {fakt}");

            //iç içe for 

            //for(int i = 0;i <= 3; i++)
            //{
            //    for(int j = 0;j <= 3; j++)
            //    {
            //        Console.WriteLine($"i: {i}, j: {j}");
            //    }
            //}

            //for(int i = 0, j = 10; i < j; i++, j--)
            //{
            //    Console.WriteLine($"i: {i}, j: {j}");
            //}

            //for (int i = 0; i <= 10; i++) //i+=2 yazarak da yazdırılabilir
            //{
            //    if (i %2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //büyükten küçüğe sıralama uygulaması

            //while (true)
            //{
            //    Random rnd = new Random();
            //    int tutulansayi = rnd.Next(1, 101);
            //    int tahmin;
            //    do
            //    {
            //        Console.WriteLine("bir sayı tahmin edin(1-100). çıkmak için 'q' yazın.");
            //        tahmin = Convert.ToInt32(Console.ReadLine());
            //        if (tahmin > tutulansayi)
            //        {
            //            Console.WriteLine("daha küçük bir sayı tutun");
            //        }
            //        else if (tahmin < tutulansayi)
            //        {
            //            Console.WriteLine("daha büyük bir sayı tutun");
            //        }
            //    } while (tahmin != tutulansayi);
            //    Console.WriteLine("tebrikler bildiniz");
            //}
        }
    }
}
