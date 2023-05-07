

{
    int sayi, yuzler, onlar, birler;
    Console.Write("SAYIYI GİRİN");
    sayi = Convert.ToInt32(Console.ReadLine());
    yuzler = sayi / 100;
    sayi = sayi - yuzler * 100;
    onlar = sayi / 10;
    sayi = sayi - onlar * 10;
    birler = sayi;
    Console.WriteLine("Yüzler Basamağı : {0}", yuzler);
    Console.WriteLine("Onlar Basamağı : {0}", onlar);
    Console.WriteLine("Birler Basamağı : {0}", birler);
    Console.ReadKey();
}
