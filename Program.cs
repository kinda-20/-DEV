// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sayı Giriniz");

Console.WriteLine("BirinciSayı");
Double  BirinciSayı = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ikinciSayı");
Double ikinciSayı = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ortalama");
Double Ortalama = (BirinciSayı + ikinciSayı) / 2;

Console.WriteLine("Sonuc: " + Ortalama.ToString());