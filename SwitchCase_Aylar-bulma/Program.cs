
Console.WriteLine("LÜTFEN 12'YE KADAR BİR SAYI GİRİNİZ");

        int sayi = (Console.ReadLine());
Console.WriteLine();

switch ("sayi")  //switch ifadesinde koşul için gerekli olan değişken girilir.
{
    case 1: Console.WriteLine("Ocak"); break; //Case ifadesinde durumları kontrol etmek için kullanılır ve karşılaşılacak durumlar girilir.

    case 2: Console.WriteLine("Şubat"); break;

    case 3: Console.WriteLine("Mart"); break;
        
    case 4: Console.WriteLine("Nisan"); break;

    case 5: Console.WriteLine("Mayıs"); break;

    case 6: Console.WriteLine("Haziran"); break;

    case 7: Console.WriteLine("Temmuz"); break;

    case 8: Console.WriteLine("Ağustos"); break;

    case 9: Console.WriteLine("Eylül"); break;

    case 10: Console.WriteLine("Ekim"); break;

    case 11: Console.WriteLine("Kasım"); break;

    case 12: Console.WriteLine("Aralık"); break; //Break komutu döngüyü kırmak ve döngüden çıkmak için kullanılır.

    default: Console.WriteLine(); break; //Default ifadesi durumlardan herhangibi biri yok ise yapılacak işlemler içindir. 

}
    Console.ReadLine();
