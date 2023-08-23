// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 10; i=i+2) //i+=2
{
    Console.WriteLine(i);
}

string kurs1 = "Yazılımcı Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java Kursu";
string kurs4 = "Python Kursu";


//Console.WriteLine(kurs1);
//Console.WriteLine(kurs2);
//Console.WriteLine(kurs3);
//Console.WriteLine(kurs4);

// array - dizi

string[] kurslar = new string[]
{
    "Yazılımcı Geliştirme Kampı",
    "Programlamaya başlangıç için temel kurs",
    "Java Kursu",
    "Python"
};


for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("Sayfa sonu");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}