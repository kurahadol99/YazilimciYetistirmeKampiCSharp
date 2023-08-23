// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string kategoriEtiketi = "Kategori";


Console.WriteLine(kategoriEtiketi);

int ogrenciSayisi = 3000;

double faizOrani = 1.45;

bool sistemeGirisYapmisMi = true;

if (sistemeGirisYapmisMi==true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}


double dolarDun = 7.45;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Düşüş Oku");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Oku");
}
else
{
    Console.WriteLine("Eşittir Oku");
}