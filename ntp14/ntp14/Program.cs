using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;
using System.ComponentModel.Design;

namespace ntp14
{
	internal class Program
	{

		static void Main(string[] args)
		{
			//Console.WriteLine("yazdırılıyor");
			//Thread thread = new Thread(say);
			//thread.Start();
			//thread.Join();
			//Console.WriteLine("yazdırıldı");

			//hata ayıklama
			//syntax, runtime ve mantık hataları
			//syntax: sözdizimsel hatalar

			//int number = 5 // noktalı virgüller eksik
			//Console.WriteLine("merhaba")

			//runtime: kodun yapamayacağı bir şey yapmaya çalışmak
			//programın çökmesine neden olabilir

			//int[] numbers = { 1, 2, 3 };
			//Console.WriteLine(numbers[5]); // dizide 5. eleman diye bir şey yok

			//mantık: program çalışır ancak yanlış sonuç üretir

			//int a = 5;
			//int b = 10;
			//int toplam = a * b; //toplama yerine çarpma işareti

			//exception: hataların ne olduğunu gösterir

			//nullreferenceexception

			//string isim = null;
			//Console.WriteLine(isim.Length);

			//indexoutofrangeexception

			//int[] dizi = { 1, 2, 3 };
			//Console.WriteLine(dizi[10]);

			//dividebyzeroexception

			//int a = 10;
			//int b = 0;
			//Console.WriteLine(a/b);

			//try
			//{
			//	//hata oluşturabilecek kod
			//	int a = 10;
			//	int b = 0;
			//	Console.WriteLine(a / b);
			//}
			//catch (DivideByZeroException ex)
			//{
			//	//hatanın ele alınması
			//	Console.WriteLine("hata: bir sayı 0'a bölünemez");
			//}

			//try
			//{
			//	int[] sayilar = { 1, 2, 3};
			//	Console.WriteLine(sayilar[5]);
			//}
			//catch (IndexOutOfRangeException ex)
			//{
			//Console.WriteLine("hata: dizi sınırlarının dışına çıkıldı");
			//}
			//catch(Exception ex)
			//{
			//Console.WriteLine($"bilinmeyen bir hata meydana geldi: {ex.Message}");
			//}

			//finally bloğu: hata oluşsa da oluşmasa da çalışır

			//StreamReader reader = null;
			//try
			//{
			//	reader = new StreamReader("dosya.txt");
			//      Console.WriteLine(reader.ReadToEnd());
			//}
			//catch (FileNotFoundException ex)
			//{
			//      Console.WriteLine("hata: dosya bulunamadı");
			//}
			//finally
			//{
			//	if (reader != null)
			//	{
			//		reader.Close();
			//		Console.WriteLine("dosya kapatıldı");
			//}
			//}
			//try
			//{
			//	Console.WriteLine("bir sayı giriniz");
			//	Console.Write("sayı:");
			//	int sayi = Convert.ToInt32(Console.ReadLine());
			//}
			//catch (FormatException ex)
			//{
			//   Console.WriteLine("hata: sayı dışında bir şey girildi");
			//}
			//finally
			//{
			//   Console.WriteLine("işlem tamamlandı");
			//}

			//try
			//{
			//	int a = 10;
			//	int b = 0;
			//	Console.WriteLine(a / b);
			//}
			//catch (DivideByZeroException ex)
			//{
			//	Console.WriteLine("hata mesajı: " + "bölünemez");
			//
			//try
			//{
			//	int[] sayilar = { 1, 2, 3 };
			//	Console.WriteLine(sayilar[5]);
			//}
			//catch (IndexOutOfRangeException ex)
			//{
			//      Console.WriteLine("hata: " + ex.StackTrace); // satırı söyler
			//}

			//exception sınıfları

			//try
			//{
			//             Console.Write("yaşınızı girin: ");
			//	int age = int.Parse(Console.ReadLine());
			//	CheckAge(age);
			//         }
			//catch(CustomException ex)
			//{
			//	Console.WriteLine("özel hata: " + ex.Message);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine("genel hata: " + ex.Message);
			//}
			//catch (ArgumentException ex)
			//{
			//             Console.WriteLine("hata: " + ex.Message);
			//         }

			//try
			//{

			//}
			//catch(DivideByZeroException ex)
			//{
			//	Console.WriteLine("hata: " + ex.Message);
			//}

			//while (true)
			//{
			//	try
			//	{
			//		Console.Write("yaşınızı girin: ");
			//		int yas = int.Parse(Console.ReadLine());
			//		CheckAge(yas);
			//		break;
			//	}
			//	catch (FormatException)
			//	{
			//		Console.WriteLine("hata: lütfen geçerli bir sayı girin");
			//	}
			//	catch (ArgumentException ex)
			//	{
			//		Console.WriteLine("hata: " + ex.Message);
			//	}
			//	catch (Exception ex)
			//	{
			//		Console.WriteLine("hata: " + ex.Message);
			//	}
			//}
		    int bakiye = 1000;
			while (true)
			{
				try
				{
                    Console.WriteLine("mevcut bakiye: " + bakiye);
                    Console.Write("çekmek istediğiniz tutarı girin: ");
					int tutar = int.Parse(Console.ReadLine());
                }
			}
	}
	//static void CheckAge(int age)
	//{
	//	if(age < 0)
	//	{
	//		throw new CustomException("yaş negatif olamaz");
	//	}
	//	else if(age < 18)
	//	{
	//		throw new CustomException("yaş 18'den küçük olamaz");
	//	}
	//}
	//static double Divide(double numerator, double dominator)
	//{
	//	if(numerator < 0) { }
	//}
	static void ParaCekme(int tutar)
		{
			
			if (bakiye < tutar)
			{
				throw new ArgumentException("bakiye yetersiz");
			}
            Console.WriteLine("para çekildi. kalan bakiye: "  + (bakiye - tutar));
        }
		static void CheckAge(int age)
		{
			if (age < 0)
			{
				throw new ArgumentException("yaş negatif olamaz");
			}
			else if(age > 150)
			{
				throw new ArgumentException("yaş 150'den büyük olamaz");
			}
            Console.WriteLine("yaş geçerli: " + age);
        }
		static void say()
		{
			for (int i = 1; i <= 5; i++)
			{
                Console.WriteLine($"sayaç: {i}");
                Thread.Sleep(1000);
            }
		}
	
	public class CustomException : Exception
	{
		public CustomException(string message) : base(message) { }
	}
}
