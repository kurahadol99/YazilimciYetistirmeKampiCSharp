// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;

int a = 36;
string adi = "Engin";


Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demirog";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "C++";
kurs2.Egitmen = "Tarık";
kurs2.IzlenmeOrani = 70;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Kerem";
kurs3.IzlenmeOrani = 60;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "Java";
kurs4.Egitmen = "Murat";
kurs4.IzlenmeOrani = 50;

Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " %"+kurs1.IzlenmeOrani);

Console.WriteLine("1-10 Arasında  bir sayı tutunuz");
int sayi = int.Parse(Console.ReadLine());
string cevap = "";
cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
Console.WriteLine(cevap);

Kurs[] kurslar = new Kurs[]
{

    kurs1,
    kurs2,
    kurs3,
    kurs4
};

Console.WriteLine();

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : "+kurs.Egitmen);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}



