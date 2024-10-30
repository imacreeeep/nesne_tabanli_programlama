using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_hafta7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //dictionary: anahtar - değer saklar. 
            //avantajları; hızlı erişim, esneklik, kolay yönetim
            //aynı anahtar 2 kere atanamaz
            //Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            //ogrenciler.Add(101, "ahmet");
            //ogrenciler.Add(102, "ayşe");
            //ogrenciler.Add(101, "ali"); //hata

            //ogrenciler[101] = "mehmet"; //101i mehmet olarak güncelle
            //string isim = ogrenciler[101]; //"mehmet" değerini getirir
            //ogrenciler.Remove(101); //101 anahtarını ve değerini siler

            //if (ogrenciler.ContainsKey(102)) //anahtar sorgulama
            //{
            //    Console.WriteLine($"bu anahtar mevcut.");

            //}
            //if (ogrenciler.ContainsValue("ayşe"))
            //{
            //    Console.WriteLine($"bu öğrenci mevcut.");
            //}

            //eleman sayısı öğrenme
            //int elemanSayisi = ogrenciler.Count;
            //Console.WriteLine($"eleman sayısı: {elemanSayisi}");

            //foreach (int keys in ogrenciler.Keys)
            //{
            //    Console.WriteLine($"anahtar : {keys}");
            //}
            //foreach (string value in ogrenciler.Values) 
            //{ 
            //    Console.WriteLine($"değer: {value}"); 
            //}

            //foreach (var student in ogrenciler)
            //{
            //    Console.WriteLine($"Öğrenci No: {student.Key}, Öğrenci Adı: {student.Value}");
            //}
            //int secim;
            //while (true)
            //{
            //    Console.WriteLine("yapmak istediğiniz işlemi seçin");
            //    Console.WriteLine("1. öğrenci ekle");
            //    Console.WriteLine("2. öğrenci güncelle");
            //    Console.WriteLine("3. öğrenci sil");
            //    Console.WriteLine("4. öğrenci ara");
            //    Console.WriteLine("5. tüm öğrencileri listeleme");
            //    Console.WriteLine("6. çıkış");
            //    secim = Convert.ToInt32(Console.ReadLine());
            //    if (secim == 1)
            //    {
            //        ogrenciler.Add(101, "ahmet");
            //        ogrenciler.Add(102, "ayşe");
            //        Console.WriteLine("öğrenciler eklendi.");
            //        foreach (var student in ogrenciler)
            //        {
            //            Console.WriteLine($"Öğrenci No: {student.Key}, Öğrenci Adı: {student.Value}");
            //        }
            //    }
            //    else if (secim == 2)
            //    {
            //        ogrenciler[101] = "mehmet";
            //        Console.WriteLine($"öğrenci güncellendi.");
            //    }
            //    else if (secim == 3)
            //    {
            //        ogrenciler.Remove(101);
            //        Console.WriteLine("öğrenci silindi");
            //    }
            //    else if (secim == 4)
            //    {
            //        if (ogrenciler.ContainsValue("ayşe"))
            //        {
            //            Console.WriteLine($"bu öğrenci mevcut.");
            //        }
            //    }
            //    else if (secim == 5)
            //    {
            //        foreach (var student in ogrenciler)
            //        {
            //            Console.WriteLine($"Öğrenci No: {student.Key}, Öğrenci Adı: {student.Value}");
            //        }
            //    }
            //    else if (secim == 6)
            //    {

            //        Console.WriteLine("çıkış yapılıyor");
            //        break;
            //    }

            //}

            //sets
            HashSet<string> ogrenciIsimleri = new HashSet<string>();
            //listelerde tekrar yapılabilir setlerde tekrara izin verilmez birkaç kez yazılan veriyi 1 defa yazdırır.
            //ogrenciIsimleri.Add("ahmet");
            //ogrenciIsimleri.Add("ayşe");
            //ogrenciIsimleri.Remove("ahmet");

            ////set işlemleri
            //HashSet<int> setA= new HashSet<int> { 1,2,3 };
            //HashSet<int> setB = new HashSet<int> { 3,4,5 };
            //setA.UnionWith(setB); //birleşti
            //setA.Intersect(setB); //ortak elemanlar
            //setA.ExceptWith(setB); //ortak elemanları çıkardı
            //setA.SymmetricExceptWith(setB); //ortak elemanı çıkartıp birleştirdi

            //HashSet<string> grupA = new HashSet<string>();
            //HashSet<string> grupB = new HashSet<string>();
            //Console.WriteLine("grup a için etkinlik isimleri giriniz. bittiğinde 'done' yazın");
            //string ekle;
            //while ((ekle = Console.ReadLine()) != "done")
            //{
            //    grupA.Add(ekle);
            //}
            //Console.WriteLine("grup b için etkinlik isimleri girin. bittiğinde 'done' yazın");
            //while ((ekle = Console.ReadLine()) != "done")
            //{
            //    grupB.Add(ekle);
            //}
            //HashSet<string> kesisim = new HashSet<string>(grupA);
            //kesisim.IntersectWith(grupB);
            //------------------------------------

            //fonksiyonlar
            //yeniden kullanılabilir kod blokları

        }
        //class program
        //{
        //    private static void selamla()
        //    {
        //        Console.WriteLine("merhaba, bu özel (private) bir metottur.");
        //    }
        //    static void main(string[] args)
        //    {
        //        selamla();
        //    }
        //}
        //class digersinif
        //{
        //    public void privateMetotCagir()
        //    {
        //        program.selamla(); //koruma düzeyi nedeniyle erişilemeyecek çünkü private
        //    }
        //}
    }
}
