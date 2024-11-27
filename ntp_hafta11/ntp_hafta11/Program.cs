using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ntp_hafta11
{
    internal class Program
    {
        //static List<person> people = new List<person>();
        //static List<urun> urunler = new List<urun>();

        static void Main(string[] args)
        {
            //string name = "John Doe";
            //Console.WriteLine(name.ToUpper());//JOHN DOE
            //Console.WriteLine(name.ToLower());//john doe

            //string input = "    hello world    ";
            //Console.WriteLine($"orijinal: '{input}'");
            //Console.WriteLine($"trim kısmı: '{input.Trim()}'");

            //string message = "merhaba dünya";
            //string part =  message.Substring(8, 5);
            //Console.WriteLine(part);//dünya

            //string text = "merhaba dünya";
            //string replacedText = text.Replace("dünya", "c#");
            //Console.WriteLine(replacedText);

            //string data = "ad, soyad, yaş";
            //string[] prts = data.Split(',');
            //foreach(string prt in prts)
            //{
            //    Console.WriteLine(prt.Trim());
            //}

            //string[] names = { "ali", "ayşe", "mehmet" };
            //string result = string.Join(", ", names);
            //Console.WriteLine(result);

            //string fileName = "report.pdf";
            //Console.WriteLine(fileName.EndsWith(".pdf"));//true
            //Console.WriteLine(fileName.StartsWith("rep"));//true

            //string sentence = "c# programlama oldukça güçlü bir dildir";
            //Console.WriteLine(sentence.Contains("programlama"));//bu kelime geçiyorsa true döndürür

            //string txt = "bu bir c# programıdır ve programdır c#";
            //int firstIndex = txt.IndexOf("c#");
            //int lastIndex = txt.LastIndexOf("program");
            //Console.WriteLine(firstIndex);//16
            //Console.WriteLine(lastIndex);//34

            //string original = "merhaba dünya";
            //string modified = original.Insert(8, "güzel ");
            //Console.WriteLine(modified);

            //string dt = "123-45-6789";
            //string mdf = dt.Remove(3, 1);//3. indexten başla 1 tane sil
            //Console.WriteLine(mdf);//12345-6789

            //string value = "42";
            //string paddedLeft = value.PadLeft(5, '0');//5 karakterden oluşsun. soluna 3 tane 0 ekler
            //string paddedRight = value.PadRight(5, '-');//5 karakterden oluşsun. sağına 3 tane - ekler

            //Console.Write("e posta adresi girin: ");
            //string mail = Console.ReadLine();
            //bool gecerliMi(string email)
            //{
            //    return false;
            //}
            //List<string> list = new List<string>
            //{
            //    {"a.pdf"},
            //    {"b.doc"},
            //    {"c.png"},
            //    {"d.doc"},
            //    {"e.pdf"},
            //    {"f.pdf"},
            //    {"g.png"},
            //    {"h.pdf"},
            //    {"i.doc"},
            //    {"j.pdf"},
            //    {"k.png"},
            //    {"l.pdf"}
            //};
            //Console.WriteLine("PDF DOSYALARI");
            //foreach (string item in list)
            //{
            //    if (item.EndsWith(".pdf"))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //datetime
            //DateTime now = DateTime.Now;
            //Console.WriteLine("şu anki tarih ve saat: " + now);

            //DateTime customDate = new DateTime(2000, 5, 15);
            //Console.WriteLine("özel tarih: " + customDate);

            //DateTime startsDate = new DateTime(2024, 1, 1);
            //DateTime endsDate = DateTime.Now;
            //TimeSpan difference = endsDate - startsDate;

            //Console.WriteLine($"fark: { difference.Days} gün");
            //Console.WriteLine($"toplam saat: {difference.TotalHours} saat");

            //DateTime dg = new DateTime(2005, 8, 29);
            //DateTime simdi = DateTime.Now;
            //int yas = simdi.Year - dg.Year;
            //Console.WriteLine("yaşınız: " + yas);

            //person[] people =
            //{
            //    new ogrenciler { name = "esra", id = 367, bolum = "ybs" },
            //    new ogretmen { name = "esra", id = 763, alan = "ybs" },
            //    new calisan { name = "esra", id = 637, departman = "ybs" },
            //};
            //foreach (var person in people)
            //{
            //    person.showinfo();
            //}
            //int secim;
            //while(true)
            //{
            //    Console.WriteLine("----menü----");
            //    Console.WriteLine("yapmak isediğniz işlemi seçin");
            //    Console.WriteLine("1. yeni kişi ekle (öğrenci, öğretmen, çalışan)");
            //    Console.WriteLine("2. mevcut kişiyi güncelle");
            //    Console.WriteLine("3. kişi sil");
            //    Console.WriteLine("4. tüm kişilerin bilgilerini listele");
            //    Console.WriteLine("5. çıkış");
            //    Console.Write("seçiminiz: ");
            //    secim = Convert.ToInt32(Console.ReadLine());
            //    switch (secim)
            //    {
            //        case 1:
            //            ekle();
            //            break;
            //        case 2:
            //            break;
            //        case 3:
            //            break;
            //        case 4:
            //            break;
            //        case 5:
            //            break;
            //        default:
            //            Console.WriteLine("geçersiz seçim");
            //            break;
            //    }
            //}
        }
        
        //static void ekle()
        //{
        //    Console.WriteLine("ekleyeceğiniz personel türünü seçiniz");
        //    Console.WriteLine("1. öğrenci");
        //    Console.WriteLine("2. öğretmen");
        //    Console.WriteLine("3. çalışan");
        //    int secim = Convert.ToInt32(Console.ReadLine());
        //    switch (secim)
        //    {
        //        case 1:
        //            break; 
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //    }
        //    Console.Write("ad girin: ");
        //    string name =
        //}
    }


    //public abstract class person
    //{
    //    public string name { get; set; }
    //    public int id { get; set; }



    //    public abstract void showinfo();

    //}

    //public class ogrenciler : person
    //{
    //    public string bolum { get; set; }

    //    public override void showinfo()
    //    {
    //        Console.WriteLine($"öğrenci id: {id}, öğrenci adı: {name}, bölümü: {bolum} ");
    //    }
    //}

    //public class ogretmen : person
    //{
    //    public string alan { get; set; }

    //    public override void showinfo()
    //    {
    //        Console.WriteLine($"öğretmen id: {id}, öğrentmen adı: {name}, alanı: {alan} ");
    //    }
    //}

    //public class calisan : person
    //{
    //    public string departman { get; set; }
    //    public override void showinfo()
    //    {
    //        Console.WriteLine($"çalışan id: {id}, çalışan adı: {name}, depertmanı: {departman} ");
    //    }
    //}
    //public abstract class urun
    //{
    //    public string name { get; set; }
    //    public int price { get; set; }

    //    public abstract void bilgigoster();
        
    //}
    //public class elektronik : urun
    //{
    //    public string garantisuresi {  get; set; }
    //    public override void bilgigoster()
    //    {

    //    }
    //}
    //public class kiyafet : urun
    //{
    //    public string beden {  get; set; }
    //    public override void bilgigoster()
    //    {

    //    }
    //}
    //public class kitap : urun
    //{
    //    public string yazar {  get; set; }
    //    public override void bilgigoster()
    //    {

    //    }
    //}
}
