using System;

namespace ClassMetotDemo
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Ad = "Şükrü";
            musteri1.Soyad = "Özkoca";
            musteri1.Kimlik =12345678911;
         
            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Ad = "Berkay";
            musteri2.Soyad = "Çavuşoğlu";
            musteri2.Kimlik = 12345678912;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Uysal";
            musteri3.Kimlik = 42424242424;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach(var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }
            
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Güncelle(musteri3);

            Console.ReadLine();

            




        }
       
    }
}
