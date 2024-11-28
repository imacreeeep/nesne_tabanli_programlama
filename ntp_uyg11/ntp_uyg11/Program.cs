using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_uyg11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //uzman uzman = new uzman();
            //uzman.ad = "esra";
            //uzman.maas = 20000;
            //muhendis muhendis = new muhendis();
            //muhendis.ad = "elif";
            //muhendis.maas = 10000;
            //uzman.maasHesapla();
            //muhendis.maasHesapla();
        }
    }
    //public abstract class calisan
    //{
    //    public string ad { get; set; }
    //    public decimal maas { get; set; }
    //    public abstract void maasHesapla();
    //}
    //public class uzman : calisan
    //{
    //    public override void maasHesapla()
    //    {
    //        maas += maas * 10 / 100;
    //        Console.WriteLine($"uzman adı: {ad}, maaşı: {maas}");
    //    }
    //}
    //public class muhendis : calisan
    //{
    //    public override void maasHesapla()
    //    {
    //        maas += maas * 20 / 100;
    //        Console.WriteLine($"mühendis adı: {ad}, maaşı: {maas}");
    //    }
    //}

    public abstract class kredi
    {
        public string krediAdi { get; set; }
        public string krediTuru { get; set; }
        public double krediFaizi { get; set; }
        public int krediOdemeSuresi { get; set; }
        public kredi()
        {
            krediAdi = "genel kredi";
            krediTuru = "standart";
            krediFaizi = 1.2;
            krediOdemeSuresi = 12;
        }

        public virtual void krediAl()
        {

        }
        public virtual void krediBilgi()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public class ciftci : kredi
    {
        public ciftci()  
        {
            krediAdi = "çiftçi kredisi";
            krediTuru = "özel çiftçi kredisi";
            krediFaizi = 0.8;
            krediOdemeSuresi = 24;
        }
        public override void krediAl()
        {

        }
        public override void krediBilgi()
        {

        }
        public void krediIndirimi(double indirimOrani)
        {

        }
    }
    public class konut : kredi
    {
        public konut() 
        {
            krediAdi = "konut kredisi";
            krediTuru = "ev alım kredisi";
            krediFaizi = 1.0;
            krediOdemeSuresi = 120;
        }
        public override void krediAl()
        {

        }
        public override void krediBilgi()
        {

        }
        public void krediIndirimi(double indirimOrani)
        {

        }
    }
}
