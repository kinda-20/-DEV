// See https://aka.ms/new-console-template for more information
Console.WriteLine("number Giriniz!");

Console.WriteLine("AnaPara");
double AnaPara = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("FaizOrani");
double FaizOrani = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Vade");
DateTime Vade = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Gun");
double Gun = Convert.ToDouble(Console.ReadLine());

Double Faiz = (AnaPara * FaizOrani * Gun) / 360;

Console.WriteLine("Faiz: " + Faiz.ToString());