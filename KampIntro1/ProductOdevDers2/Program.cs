// See https://aka.ms/new-console-template for more information
using ProductOdevDers2;

Console.WriteLine("Hello, World!");


Product product1 = new Product();
product1.UrunAdi = "Tükenmez Kalem";
product1.UrunFiyat = 5;
product1.UrunID = 0;

Product product2 = new Product();
product2.UrunAdi = "Uçlu Kalem";
product2.UrunFiyat = 8;
product2.UrunID = 1;


Product[] Urunler = new Product[]
{
    product1,
    product2
};

foreach (Product abc in Urunler)
{
    Console.WriteLine($"[{abc.UrunID}]"+ " "+ abc.UrunAdi + " " +abc.UrunFiyat);
}

Console.WriteLine("Foreach Bitti");

for (int i = 0; i < Urunler.Length; i++)
{
    Console.WriteLine($"[{Urunler[i].UrunID}]" + " " + Urunler[i].UrunAdi + " " + Urunler[i].UrunFiyat);
}

Console.WriteLine("For Bitti");

int sayac = 0;

while (sayac<Urunler.Length)
{
    Console.WriteLine($"[{Urunler[sayac].UrunID}]" + " " + Urunler[sayac].UrunAdi + " " + Urunler[sayac].UrunFiyat);
    sayac++;

}
Console.WriteLine("While Bitti");