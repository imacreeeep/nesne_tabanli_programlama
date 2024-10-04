using System;

class BankaHesabi
{
    public string HesapSahibi;
    public double Bakiye;
    public int HesapNumarasi;

    private static int hesapSayisi = 0;

    public BankaHesabi(string hesapSahibi, double bakiye, int hesapNumarasi)
    {
        HesapSahibi = hesapSahibi;
        Bakiye = bakiye;
        HesapNumarasi = hesapNumarasi;
        hesapSayisi++; 
    }

    public void ParaYatir(double miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL hesaba yatırıldı. Yeni bakiye: {Bakiye}TL'dir");
    }

    public void ParaCek(double miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL hesaptan çekildi. Yeni bakiyeniz: {Bakiye} TL'dir");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Hesap Sahibi: {HesapSahibi}");
        Console.WriteLine($"Hesap Numarası: {HesapNumarasi}");
        Console.WriteLine($"Bakiye: {Bakiye}TL");
    }

    public static void ToplamHesapSayisi()
    {
        Console.WriteLine($"Bugün toplamda {hesapSayisi} hesap açılmıştır");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankaHesabi hesap1 = new BankaHesabi("Fazlı Teoman Yakupoğlu", 100000000, 1967);
        hesap1.BilgiGoster();
        hesap1.ParaYatir(50000);
        hesap1.ParaCek(20000);
        hesap1.BilgiGoster();

        Console.WriteLine();

        BankaHesabi hesap2 = new BankaHesabi("Sezen Aksu", 200000000, 1954);
        hesap2.BilgiGoster();
        hesap2.ParaYatir(30000);
        hesap2.ParaCek(25000); 
        hesap2.BilgiGoster();

        Console.WriteLine();

        BankaHesabi.ToplamHesapSayisi();

    }
}
