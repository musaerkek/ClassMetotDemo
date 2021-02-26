using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void HesapOlustur(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler!"+" "+musteri.Adi+" "+musteri.Soyadi+" "+"Hesabınız Oluşturuldu");
        }
        public void HesapEkle(Musteri musteri) 
        {
            Console.WriteLine( musteri.HesapTuru + " " + "Hesabınız Açılmıştır!");
        }
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Adı:"+" "+musteri.Adi);
            Console.WriteLine("Müşteri Soyadı:" + " " + musteri.Soyadi);
            Console.WriteLine("Müşteri ID:"+" "+musteri.Id);
            Console.WriteLine("Müşteri Başarıyla Eklendi");
        }
        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Silinecek Müşterinin Adı Soyadı:"+" "+musteri.Adi+" "+musteri.Soyadi);
            Console.WriteLine("Silinecek Müşterinin ID'si:"+" "+musteri.Id);
            Console.WriteLine("Müşteri Silinmiştir ;(");
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Bilgileri:");
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi);
            Console.WriteLine(musteri.Id);
            Console.WriteLine("Açılan Hesap:"+" "+musteri.HesapTuru);
        }

    }
}
