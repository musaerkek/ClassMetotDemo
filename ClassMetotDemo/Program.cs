using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Tom";
            musteri1.Soyadi = "Hanks";
            musteri1.Id = 1456987;
            musteri1.HesapTuru = "ABD Dolar";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Leonardo";
            musteri2.Soyadi = "DiCaprio";
            musteri2.Id = 3498527;
            musteri2.HesapTuru = "Euro";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Jack";
            musteri3.Soyadi = "Nicholson";
            musteri3.Id = 4952789;
            musteri3.HesapTuru = "İngiliz Sterlini";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            foreach(Musteri musteri in musteriler) 
            {
                Console.WriteLine("Müşteri Adı:"+" "+musteri.Adi);
                Console.WriteLine("Müşteri Soyadı:"+" "+musteri.Soyadi);
                musteriManager.HesapOlustur(musteri);
                musteriManager.HesapEkle(musteri);
                Console.WriteLine("----------------------------------------------------------");
            }
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------------------------------------------------");
            musteriManager.Sil(musteri1);
            Console.WriteLine("----------------------------------------------------------");
            musteriManager.Listele(musteri2);


        }
    }
}
