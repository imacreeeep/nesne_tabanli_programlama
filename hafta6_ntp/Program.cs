using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hafta6_ntp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays

            //aynı türden veriler saklanır
            //int[] sayilar = new int[5];
            //sayilar[0] = 10;
            //Console.WriteLine(sayilar[0]);

            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50};
            //Console.WriteLine(numbers[^1]);
            //Console.WriteLine(numbers[^2]);

            //int[] nmbrs = { 5, 2, 8, 1, 4 };
            //Array.Sort(nmbrs);

            //foreach (int nmbr in nmbrs)
            //{
            //    Console.WriteLine(nmbr);
            //}

            //lists

            //List<int> sayilarListesi = new List<int>();
            //sayilarListesi.Add(10);//listeye 10 sayısını ekledik
            //sayilarListesi.Add(10);
            //sayilarListesi.Add(10);
            //sayilarListesi.Add(10);
            //sayilarListesi.Add(20);

            //for (int i = 0; i < sayilarListesi.Count; i++)
            //{
            //    Console.WriteLine(sayilarListesi[i]);
            //}

            //sayilarListesi.Remove(10);//listeden 10 sayısını çıkardık
            //for (int i = 0; i < sayilarListesi.Count; i++)
            //{
            //    Console.WriteLine(sayilarListesi[i]);//sadece bir tane 10 sayısını çıkardı
            //}

            //sayilarListesi.Clear();//listeyi temizle
            //for (int i = 0; i < sayilarListesi.Count; i++)
            //{
            //    Console.WriteLine(sayilarListesi[i]);
            //}


            //employee emp1 = new employee("ahmet", 20, 30);
            //employee emp2 = new employee("ayşe", 45, 30);


            //emp1.CalculateSalary();
            //emp2.CalculateSalary();

            //uygulama
            //List<int> sayilar = new List<int>();
            //string girilen;

            //do
            //{
            //    Console.WriteLine("Lütfen bir rakam giriniz. 'tamam' yazdığınız zaman işlem yapılacak");
            //    girilen = Console.ReadLine();

            //    if (girilen != "tamam")
            //    {
            //        sayilar.Add(Convert.ToInt32(girilen));
            //    }

            //} while (girilen != "tamam");

            //Console.WriteLine("Tek sayılar:");
            //foreach (int tek in sayilar)
            //{
            //    if (tek % 2 == 1)
            //    {
            //        Console.WriteLine(tek);
            //    }
            //}

            //tuples
            //değiştirilmesi yanlışlıkla bile olsa istenmeyen durumlarda kullanılır

            //uygulama1

            List<int> list = new List<int>();
            List<int> listsifir = new List<int>();
            List<int> listtek = new List<int>();
            List<int> listcift = new List<int>();

            int sayi;
            int ekleme = 0;
            while (ekleme <= 15)
            {
                ekleme++;
                Console.WriteLine("15 adet sayı girin.");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                {
                    listsifir.Add(sayi);
                }
                else if (sayi % 2 == 0)
                {
                    listcift.Add(sayi);
                }
                else
                {
                    listtek.Add(sayi);
                }
            }

            //uygulama2


        }
        //quiz

        //public class employee
        //{
        //    public string name;
        //    public int workHouse;
        //    public decimal hourlyWage;

        //    public employee(string name, int workHouse, decimal hourlyWage )
        //    {
        //        this.name = name;
        //        this.workHouse = workHouse;
        //        this.hourlyWage = hourlyWage;
        //    }

        //    public void CalculateSalary()
        //    {
        //        int sonuc;
        //        if (workHouse <= 40)
        //        {
        //            sonuc = workHouse*(int)hourlyWage;
        //        }
        //        else if (workHouse > 40)
        //        {
        //             sonuc = workHouse*(int)((double)hourlyWage*1.5);

        //        }
        //    }
        //}
    }
}
