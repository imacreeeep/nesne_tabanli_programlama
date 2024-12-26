using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp15_uyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yazilimuzmani uzman1 = new yazilimuzmani("esra","sql","veri tabanı hazırlama");
            uzman1.GorevGoster();
            uzman1.DurumGoruntule();
            uzman1.Tamamlandi();

        }
    }
    class gorev
    {
        public bool gorevTamamlandi { get; set; } = false;
        public string gorevad { get; set; }
        public string gorevaciklama { get; set; }
        public gorev(string gorevad, string gorevaciklama)
        {
            this.gorevad = gorevad;
            this.gorevaciklama = gorevaciklama;
        }
    }
    class yazilimuzmani : gorev
    {
        public string uzman {  get; set; }
        public List<gorev> gorevler;
        
        public yazilimuzmani(string uzman, string gorevad, string gorevaciklama) : base(gorevad, gorevaciklama)
        {
            this.uzman = uzman;
            gorevler = new List<gorev>();
        }
        public void DurumGoruntule()
        {
            if (gorevTamamlandi)
            {
                Console.WriteLine("görev tamamlandı");
            }
            else
            {
                Console.WriteLine("görev henüz tamamlanmadı");
            }
        }
        public void Tamamlandi()
        {

            if (!gorevTamamlandi)
            {
                Console.WriteLine("görev tamamlandı olarak güncellendi");
                gorevTamamlandi = true;
            }
            else
            {
                Console.WriteLine("bu görev zaten tamamlanmış");
            }
        }
        public void GorevGoster()
        {
            Console.WriteLine($"uzman adı: {uzman}\ngörev adı: {gorevad}\ngörev açıklaması: {gorevaciklama}");
        }
    }
}
