using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 10000;
            musteri1.MusteriAdi = "Burçin";
            musteri1.MusteriSoyad = "KAĞAN";
            musteri1.MusteriAdres = "Antalya/TÜRKİYE";
            Console.WriteLine("\n");

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 10001;
            musteri2.MusteriAdi = "Ayşe";
            musteri2.MusteriSoyad = "KARA";
            musteri2.MusteriAdres = "İstanbul/TÜRKİYE";
            Console.WriteLine("\n");

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 10002;
            musteri3.MusteriAdi = "Fatma";
            musteri3.MusteriSoyad = "DOĞAN";
            musteri3.MusteriAdres = "Kayseri/TÜRKİYE";
            Console.WriteLine("\n");

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 10003;
            musteri4.MusteriAdi = "Hayriye";
            musteri4.MusteriSoyad = "AĞAÇ";
            musteri4.MusteriAdres = "Adana/TÜRKİYE";
            Console.WriteLine("\n");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("\n************MÜŞTERİ BİLGİSİ EKLEME************\n");
            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }

            Console.WriteLine("\n************MÜŞTERİ BİLGİSİ SİLME************\n");
            foreach (var musteri in musteriler)
            {
                 musteriManager.MusteriSil(musteri);
            }

            Console.WriteLine("\n************MÜŞTERİ BİLGİLERİNİ LİSTELEME************\n");
            musteriManager.MusteriListesi(musteriler);   
        }
    }
}
