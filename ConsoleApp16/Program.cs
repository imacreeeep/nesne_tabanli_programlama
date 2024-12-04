using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HAFTA 13

            //dosya işlemleri
            //sürekli olarak girilen verilerin kaybolmayacak şekilde kayıt altına alınmasını sağlar

            //dosyaları okuma

            //string filePath = "C:\\Users\\HBV\\Desktop\\bilmem\\example.txt";
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    string content = reader.ReadToEnd(); //dosyanın içeriği küçükse kullanılır tek seferede okuyabilmemizi sağlar
            //    Console.WriteLine("dosyanın içeriği: ");
            //    Console.WriteLine(content);
            //}

            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    Console.WriteLine("dosyadan okunan satırlar: ");
            //    string line; //dosyanın içeriği büyükse tek seferde okuyamıyorsak satır satır okuyabilmemizi sağlar
            //    while((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //string content = File.ReadAllText(filePath); //dosyanın içeriği büyükse kullanılır tek seferede okuyabilmemizi sağlar (üsttekinin kısa hali
            //Console.WriteLine("dosyanın içeriği: ");
            //Console.WriteLine(content);

            //string[] readLines = File.ReadAllLines(filePath); 
            //Console.WriteLine("dosyanın içeriği: ");
            //foreach(var  line in readLines)
            //{
            //    Console.WriteLine(line); //satır satır tek seferde okuyabilmemizi sağlar
            //}

            //dosya oluşturma

            //string filePath = "C:\\Users\\HBV\\Desktop\\log.txt";
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    writer.WriteLine("satır 1: işlem başlatıldı");
            //    writer.WriteLine("satır 2: işlem devam ediyor");
            //    writer.WriteLine("satır 3: işlem tamamlandı");
            //    Console.WriteLine("veriler dosyaya başarıyla yazıldı");
            //}

            //string filePath = "settings.txt";
            //string content = "Kullanıcı Ayarları: \n- Dil: Türkçe\n- Tema: Karanlık";
            //File.WriteAllText(filePath, content);

            //dosya dizin ve yolları

            //string filePath = "example2.txt";

            //if(File.Exists(filePath))
            //{
            //    Console.WriteLine("dosya mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("dosya bulunamadı, yeni bir dosya oluşturuluyor");
            //    File.WriteAllText(filePath, "merhaba, bu bir örnek dosyadır");
            //}

            //klasör oluşturma

            //string directoryPath = "example_directory";

            //if(!Directory.Exists(directoryPath))
            //{
            //    Console.WriteLine("dizin bulunamadı. yeni bir dizin oluşturuluyor");
            //    Directory.CreateDirectory(directoryPath);
            //}
            //else
            //{
            //    Console.WriteLine("dizin zaten mevcut");
            //}

            //string directory = "example_directory";
            //string fileName = "file.txt";

            //string fullPath = Path.Combine(directory, fileName);
            //Console.WriteLine("birleştirilen yol: " + fullPath);

            //string fullPath = @"C:\Users\HBV\Desktop\bilmem\example.txt";
            //Console.WriteLine("dizin adı: " + Path.GetDirectoryName(fullPath));
            //Console.WriteLine("dosya adı: " + Path.GetFileName(fullPath));

            //string filePath = "document.docx";

            //Console.WriteLine("dosya uzantısı: " + Path.GetExtension(filePath));

            //string newFilePath = Path.ChangeExtension(filePath, ".pdf");
            //Console.WriteLine("yeni dosya yolu: " + newFilePath);

            //string relativePath = "example.txt";
            //string absolutePath = Path.GetFullPath(relativePath);

            //Console.WriteLine("mutlak yol: " + absolutePath);

            //var person = new
            //{
            //    ad = "ahmet",
            //    soyad = "yılmaz",
            //    yas = 30,
            //    hobiler = new[] { "yüzme", "okuma", "satranç" }
            //};

            //json dosyasına yazdırma
            //string filePath = "person.json";
            //string jsonString = JsonSerializer.Serialize(person, new SerializerOptions { WriteIndented = true });
            //File.WriteAllText(filePath, jsonString);
            //Console.WriteLine("veri json dosyasına başarıyla yazıldı: " + jsonString);

            //kaydedilen dosyayı okuma

            //string filePath = "person.json";

            //if(File.Exists(filePath))
            //{
            //    string jsonString = File.ReadAllText(filePath);
            //    var person = JsonSerializer.Deserialize<person>(jsonString);

            //    Console.WriteLine("json dosyasından okunan veri:");
            //    Console.WriteLine($"ad: {person.ad}");
            //    Console.WriteLine($"soyad: {person.soyad}");
            //    Console.WriteLine($"yaş: {person.yas}");
            //    Console.WriteLine("hobiler:");
            //    foreach(var hobi in person.Hobi)
            //    {
            //        Console.WriteLine($"- {hobi}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("hata: json dosyası bulunamadı");
            //}

            while (true)
            {
                Console.WriteLine("yapmak istediğiniz işelmi seçin");
                Console.WriteLine("1. yeni başvuru ekle");
                Console.WriteLine("2. pozisyona başvuranları listele");
                Console.WriteLine("3. çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("geçersiz seçim yaptınız tekrar girin.");
                        break;
                }
            }
        }
    }

    class person
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
        public List<string> hobiler { get; set; }
    }
}
