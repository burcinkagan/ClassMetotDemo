using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine("Müşteri Bilgileri: " + musteri.MusteriId + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + musteri.MusteriAdres);
        }

        public void MusteriSil (Musteri musteri)
        {
            Console.WriteLine( musteri.MusteriId + " Id Numaralı " + musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + musteri.MusteriAdres + ", Kişisi Silindi!");
        } 

        public void MusteriListesi (Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine("Müşteri Id: " + musteri.MusteriId);
                Console.WriteLine("Müşteri Adı: " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.MusteriSoyad);
                Console.WriteLine("Müşteri Adres: " + musteri.MusteriAdres);
                Console.WriteLine("****************************************");
            }    
        }
    }
}
