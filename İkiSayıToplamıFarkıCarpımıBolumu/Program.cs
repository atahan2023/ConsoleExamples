﻿internal class Program
{
    private static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam, fark, carpim, bolum;
            Console.WriteLine("1. Sayı : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayı : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, toplam);
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, fark);
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, carpim);
            Console.WriteLine("{0} ve {1} Sayısının Toplamı : {2}", sayi1, sayi2, bolum);
            Console.ReadKey();
        }
    }
}