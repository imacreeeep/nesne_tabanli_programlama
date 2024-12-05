using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ntp_uyg13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("adınızı ve soyadınızı giriniz: ");
            //string adsoyad = Console.ReadLine();
            //string[] kelimeler = adsoyad.Split(' ');

            //for(int i = 0; i < kelimeler.Length; i++)
            //{
            //    Console.Write(duzenle(kelimeler[i]) + " ");
            //}

            //Console.Write("doğum tarihinizi giriniz (gg.aa.yyyy): ");
            //string tarih = Console.ReadLine();

            //try
            //{
            //    DateTime dg = DateTime.Parse(tarih);
            //    DateTime bugun = DateTime.Now;

            //    int yas = bugun.Year - dg.Year;

            //    if(dg.Day == bugun.Day&& dg.Month == bugun.Month)
            //    {
            //        Console.WriteLine($"doğum gününüz kutlu olsun. bugün {yas} yaşınıza girdiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"doğum gününüz yaklaşıyor. {yas} yaşındasınız.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("hatalı format lütfen geçerli bir doğum tarihi giriniz (ör: 01.01.2000)");
            //}

           
        }
        static string duzenle(string x)
        {
            x = x.ToLower();
            return char.ToUpper(x[0]) + x.Substring(1);
        }
    }
}
