// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;




Musteri musteri1 = new Musteri();

musteri1.MusteriTc = 12321321;
musteri1.MusteriYas = 20;
musteri1.MusteriAd = "Ahmet";
musteri1.MusteriSoyAd = "Yılmaz";

MusteriManager manager = new MusteriManager();
manager.musteriEkleme(musteri1);
manager.musteriListele(musteri1);
manager.musteriSil(musteri1);





