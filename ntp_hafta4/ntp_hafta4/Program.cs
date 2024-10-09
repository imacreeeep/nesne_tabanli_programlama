using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ntp_hafta4
{
	internal class Program
	{

		static void Main(string[] args)
		{
			//if - else yapısı
			int sayi = 10;
			if (sayi > 5)
			{
				Console.WriteLine("sayı 5'ten büyüktür."); //koşul doğruysa çalışacak blok
			}
			else
			{
				Console.WriteLine("sayı 5'ten küçüktür"); //koşul yanlışsa çalışacak blok
			}


			int puan = 45;
			if (puan >= 50)
			{
				Console.WriteLine("sınavı geçtiniz");
			}
			else
			{
				Console.WriteLine("sınavda başarısız oldunuz");
			}


			//nested if yapısı
			int sadakatPuani = 120;
			double toplamTutar = 300.50;
			if (sadakatPuani > 100)
			{
				if (toplamTutar > 500)
				{
					Console.WriteLine("müşteriye %10 indirim uygulanacak"); //her iki koşul da doğruysa çalışacak blok
				}
				else
				{
					Console.WriteLine("toplam tutarı arttırınız");
				}
			}


			//if - else if - else yapısı
			int number = 7;
			if (number > 10)
			{
				Console.WriteLine("sayı 10'dan büyüktür");
			}
			else if (number > 5)
			{
				Console.WriteLine("sayı 5'ten büyük ama 10'dan küçük veya 10'a eşit");
			}
			else
			{
				Console.WriteLine("5 veya daha küçük");
			}

			//uygulama1
			int SadakatPuani = 120;
			double ToplamTutar = 600.50;
			if (SadakatPuani > 100)
			{
				if (ToplamTutar > 500)
				{
					Console.WriteLine("müşteriye %10 indirim uygulanacak");
				}
				else
				{
					Console.WriteLine("müşteriye %5 indirim uygulanacak");
				}
			}
			else if (SadakatPuani > 50)
			{
				if (ToplamTutar > 500)
				{
					Console.WriteLine("müşteriye %7 indirim uygulanacak");
				}
				else
				{
					Console.WriteLine("müşteriye %3 indirim uygulanacak");
				}
			}
			else
			{
				Console.WriteLine("müşteriye indirim uygulanmayacak");
			}


			//switch - case yapısı
			int gun = Convert.ToInt32(Console.ReadLine());
			switch (gun)
			{
				case 1:
                    Console.WriteLine("pazartesi");
					break;
				case 2:
					Console.WriteLine("salı");
					break;
				case 3:
					Console.WriteLine("çarşamba");
					break;
                default: 
					Console.WriteLine("geçersiz rakam");
					break;
            }

			int ay = Convert.ToInt32(Console.ReadLine());
			switch (ay)
			{
				case 1:
				case 2:
					Console.WriteLine("kış");
					break;
				case 3:
				case 4:
				case 5: 
					Console.WriteLine("ilkbahar");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine("yaz");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine("sonbahar");
					break;
				case 12:
					Console.WriteLine("kış");
					break;
				default:
					Console.WriteLine("geçersiz ay girdiniz");
					break;
			}

			//ternary operatör kullanımı
			int yas = 18;
			string uygunluk = (yas >= 18) ? "oy vermeye uygun" : "oy vermeye uygun değil"; //ilk bölüm doğruysa çalışır ikinci bölüm yanlışsa açılır
            Console.WriteLine(uygunluk);
        }
	}
	//uygulama2
	class bankaHesabi
	{
		
	}
	class uy3
	{

	}


	//uygulama3
	class kullanici
	{
		public string isim;
		private int yas { get; set; }

		public kullanici(string isim, int yas)
		{
			this.isim = isim;
			this.yas = yas;
		}
		public string YasKontrol()
		{
			string sonuc;
			if (yas > 18) return sonuc = "yetişkin";
			else if (yas > 13 && yas <= 18) return sonuc = "ergen";
			else return sonuc = "çocuk";
		}

		public int YasGoster()
		{
			return yas;
		}
	}
	class uyg3
	{
		static void main(string[] args)
		{
			kullanici k1 = new kullanici("beyonce", 60);
			kullanici k2 = new kullanici("kanye west", 43);

			k1.YasKontrol();
			k1.YasGoster();
			k2.YasKontrol();
			k2.YasGoster();
		}
	}

	class hasta
	{
		public string isim { get; set; }
		public int hastaID { get; set; }
		public bool randevuDurumu;
		public hasta (string isim, int hastaID) 
		{
			this.isim = isim;
			this.hastaID = hastaID;
			randevuDurumu = false;
		}
		
		public void RandevuAl()
		{
			if (randevuDurumu)
			{
                Console.WriteLine($"hasta: {isim}\n randevu zaten alınmış");
            }
			else
			{
				randevuDurumu = true;
                Console.WriteLine($"hasta: {isim}\n randevu alındı");
            }
		}

		public void RandevuIptalEt()
		{
			if (!randevuDurumu)
			{
				Console.WriteLine($"hasta {isim} için randevu bulunmadı.");
			}
			else
			{
				randevuDurumu = false;
				Console.WriteLine($"hasta: {isim}\n randevu iptal edildi");
			}
		}
	}
	class randevu
	{

	}

	class urun
	{
		public string urunAdi { get; set; }
		public int urunID { get; set;}
		public int stokMiktari;

		public urun(string urunAdi, int urunID, int baslangicStok)
		{
			this.urunID = urunID;
			this.urunAdi = urunAdi;
			stokMiktari = baslangicStok;
		}
		public void StokEkle(int miktar)
		{
			if(miktar > 0)
			{
				stokMiktari += miktar;
                Console.WriteLine($"stok miktarı eklendi. \n yeni stok miktarı: {stokMiktari}");
            }
			else
			{
                Console.WriteLine("geçersiz stok miktarı");
            }
		}

		public void StokCikar(int miktar)
		{
			if (miktar > stokMiktari)
			{
                Console.WriteLine($"yetersiz stok miktarı! \n mevcut stok: {stokMiktari}");
            }
			else
			{
				stokMiktari -= miktar;
				Console.WriteLine($"stok miktarı çıkartıldı. \n yeni stok miktarı: {stokMiktari}");
			}
		}


	}
}
