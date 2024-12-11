using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.IO.Ports;
using System.Net.Sockets;
using System.Threading;

namespace ntp_hafta14
{
    internal class Program
    {
        private static bool calisiyor = true;
        private static int sayac = 1;
        private static object kilit = new object();
        static void Main(string[] args)
        {
            //donanım erişimi
            //kamera, yazıcı, mikrofon
            //yüksek seviyeli (kolaylık sağlar) API ya da C#
            //system.io = hard diske erişim
            //system.drawing = görünmtü erişimi
            //system.net = ağ erişimi

            //string dosyayolu = "test.txt";
            //File.WriteAllText(dosyayolu, "merhaba dünya");

            //aforge.net
            //c# yazıcı örneği (print....

            //dosyaya erişme(okuma) ve dosya kaydetme önemli

            //donanım tabanlı çoklu görev
            //threading

            //Thread thread = new Thread(Yazdir); 
            //thread.Start();
            //Console.WriteLine("ana thread çalışmaya devam ediyor");

            //Thread thread = new Thread(YaziciIslemi);
            //thread.Start();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("ana işlem çalışıyor");
            //    Thread.Sleep(1000);
            //}

            //thread.abort() threadi zorla sonlandırmak için kullanılır

            //Thread thread = new Thread(Yazdir);
            //thread.Start();

            //Console.WriteLine("thread çalışıyor. durduramk için bir tuşa basın");
            //Console.ReadKey();

            //calisiyor = false;

            //Thread thread1 = new Thread(Arttir);
            //Thread thread2 = new Thread(Arttir);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();

            //Console.WriteLine($"sonuç: {sayac}");

            //Thread thread = new Thread(Yazdir);
            //thread.Start();
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"sayaç: {sayac}");
            //    sayac++;
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine("dosya okunuyor");

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"sayaç: {sayac}");
            //    sayac++;
            //    Thread.Sleep(1000);
            //}

            //Thread thread = new Thread(Oku);
            //thread.Start();


        }
        //static void Yazdir()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"thread: {i}");
        //        Thread.Sleep(1000); // 1 saniye beklet
        //    }
        //}

        //static void YaziciIslemi()
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("yazıcı çalışıyor...");
        //        Thread.Sleep(2000); // 2 saniye beklet
        //    }
        //}

        //static void Yazdir()
        //{
        //    while(calisiyor)
        //    {
        //        Console.WriteLine("thread çalışıyor...");
        //        Thread.Sleep(500);
        //    }
        //    Console.WriteLine("thread durduruldu");
        //}

        //static void Arttir()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        lock (kilit)
        //        {
        //            sayac++;
        //        }
        //    }
        //}

        //static void Yazdir()
        //{
        //    Console.WriteLine("yazıcıya işlem gönderildi");
        //    Thread.Sleep(5000);
        //    Console.WriteLine("yazdırıldı");
        //}

        //static void Oku()
        //{
        //    string dosyayolu = "ornek.txt";
        //    File.WriteAllText(dosyayolu, "aaaaaaaAAAAAAAAAA!!");
        //    using (StreamReader reader = new StreamReader(dosyayolu))
        //    {
        //        string content = reader.ReadToEnd();
        //        Console.WriteLine("dosyanın içeriği: ");
        //        Console.WriteLine(content);

        //    }
        //}
    }
}
