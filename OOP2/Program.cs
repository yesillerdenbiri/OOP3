using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "DEmirog";
            musteri1.TcNo = "12345665";



            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "48427";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "93757559595";


            //Gerçek Müsteri - Tüzel Müsteri
            //SOLID
            Musteri musteri3 = new GercekMusteri(); //bu ikisi özelliklerini Musteri den alacak!
            Musteri musteri4 = new TuzelMusteri(); //Musteri klası hem gerçek musterinin hem de tüzel kisinin referans numarısını tutabiliyor.
           
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
