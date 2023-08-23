// See https://aka.ms/new-console-template for more information

using MethodsFunctions;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya Elması";

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya";
urun1.StokAdedi = 10;

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";
urun2.StokAdedi = 9;

Urun[] urunler = new Urun[] {urun1,urun2 };

foreach (Urun item in urunler)
{
    Console.WriteLine(item.Adi);
    Console.WriteLine(item.Fiyati);
    Console.WriteLine(item.Aciklama);
    Console.WriteLine(item.StokAdedi);
    Console.WriteLine("--------------");
}

Console.WriteLine("----------METODLAR----------");

// instance-class örneği oluşturmak
// encapsulation
SepetManager sepetManager = new SepetManager();

sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil Armut", 50,10);
sepetManager.Ekle2("Elma", "Yeşil Elma",45,9);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 85,8);

