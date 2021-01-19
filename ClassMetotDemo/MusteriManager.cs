using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.ID + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Kimlik);
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kayıt Eklendi ! \n" + " = " + musteri.ID + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Kimlik+"\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kayıt Silindi ! \n" + " = " + musteri.ID + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Kimlik+"\n");
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı Güncellendi ! \n" + " = " + musteri.ID + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Kimlik+"\n");
        }
    }
}
