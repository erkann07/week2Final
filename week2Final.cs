using System.Globalization;
using System.Runtime.CompilerServices;

void Selamlas()
{
    Console.WriteLine("Merhaba");
    Console.WriteLine("Nasılsın ?");
    Console.WriteLine("İyiyim");
    Console.WriteLine("Sen nasılsın ?");
}
Selamlas();
Console.WriteLine("Bir adet tam sayı giriniz.");
int tamSayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bir adet metinsel ifade giriniz.");
string metinsel = Console.ReadLine();
Console.WriteLine($"Girdiğiniz tam sayı --> {tamSayi}");
Console.WriteLine($"Girdiğiniz metinsel ifade --> {metinsel}");
Console.WriteLine("----------------------------------------");
Random rndSayi = new Random();
int rastgeleSayi = rndSayi.Next(0, 100);
Console.WriteLine($"Üretilen rastgele sayi --> {rastgeleSayi}");
Console.WriteLine($"Üretilen rastgele sayinin 3'e bölümünden kalan --> {rastgeleSayi % 3}");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Yaşınızı giriniz.");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas < 18)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("+");
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
Console.WriteLine("----------------------------------------");
Console.WriteLine("Birinci metninizi giriniz.");
string metinsel1 = Console.ReadLine();
Console.WriteLine("İkinici metninizi giriniz.");
string metinsel2 = Console.ReadLine();
void yerDegistir()
{
    string gecici = metinsel1;
    metinsel1 = metinsel2;
    metinsel2 = gecici;
}
yerDegistir();
Console.WriteLine("Metinlerinizin yeri değişmiş hali");
Console.WriteLine(metinsel1);
Console.WriteLine(metinsel2);
Console.WriteLine("----------------------------------------");
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
Console.WriteLine("----------------------------------------");
Console.WriteLine("Birinci sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int Topla(int a, int b)
{
    return a + b;
}
Topla(sayi1, sayi2);
Console.WriteLine($"Toplama işleminin sonucu --> {Topla(sayi1, sayi2)}");
Console.WriteLine("----------------------------------------");

string DurumMesaji(bool durum)
{
    if (durum)
        return "Evet dediz.";
    else
        return "Hayır dediniz.";
}

void trueFalse()
{
    Console.Write("true ya da false giriniz: ");
    string giris = Console.ReadLine();

    bool boolDeger;
    if (bool.TryParse(giris, out boolDeger))
    {
        string sonuc = DurumMesaji(boolDeger);
        Console.WriteLine("Sonuç: " + sonuc);
    }
    else
    {
        Console.WriteLine("Geçersiz giriş! true ya da false yazmalısınız.");
    }
}
trueFalse();
Console.WriteLine("----------------------------------------");
Console.WriteLine("1. kişinin yaşını giriniz.");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. kişinin yaşını giriniz.");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. kişinin yaşını giriniz.");
int yas3 = Convert.ToInt32(Console.ReadLine());
int yasliBul(int yas1 , int yas2 , int yas3)
{
    int enYasli = yas1;
    if (yas2 > yas1)
    {
        enYasli = yas2;
    }
    if (yas3 > enYasli)
    {
        enYasli = yas3;
    }
    return enYasli;
}
Console.WriteLine("En büyük yaş --> " + yasliBul(yas1, yas2, yas3));
Console.WriteLine("----------------------------------------");





    static void EnBuyukSayiyiBul()
    {
        int enBuyuk = int.MinValue;
        string giris;

        Console.WriteLine("Lütfen sayılar girin. Çıkmak için 'q' tuşuna basın.");

        while (true)
        {
            Console.Write("Sayı girin: ");
            giris = Console.ReadLine();

            if (giris.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(giris, out int sayi))
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girin veya çıkmak için 'q' tuşuna basın.");
            }
        }

        if (enBuyuk == int.MinValue)
        {
            Console.WriteLine("Hiç geçerli sayı girilmedi.");
        }
        else
        {
            Console.WriteLine("Girilen en büyük sayı: " + enBuyuk);
        }
    }

EnBuyukSayiyiBul();
Console.WriteLine("----------------------------------------");
static void yerDegistir1(string kelime1, string kelime2)
{
    string gecici = kelime1;
    kelime1 = kelime2;
    kelime2 = gecici;
    Console.WriteLine("Kelime 1: " + kelime1);
    Console.WriteLine("Kelime 2: " + kelime2);
}
Console.WriteLine("Birinci kelimeyi giriniz.");
string kelime1 = Console.ReadLine();
Console.WriteLine("İkinci kelimeyi giriniz.");
string kelime2 = Console.ReadLine();
yerDegistir1(kelime1, kelime2);

Console.WriteLine("----------------------------------------");
Console.WriteLine("Bir sayı giriniz.");
int sayi3 = Convert.ToInt32(Console.ReadLine());

bool SayiCiftMi(int sayi3)
{
    return sayi3 % 2 == 0;
}
if (SayiCiftMi(sayi3))
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}

Console.WriteLine("----------------------------------------");

Console.Write("Hızınızı giriniz.(km/sa)");
int hız = Convert.ToInt32(Console.ReadLine());
Console.Write("Zamanı giriniz.(saat)");
int zaman = Convert.ToInt32(Console.ReadLine());
int alinanYol()
{
    return hız * zaman;
}
Console.WriteLine("Toplam gidilen yol " + alinanYol() + " km'dir");
Console.WriteLine("------------------------------------------");

Console.WriteLine("Alanını hesaplamak istediğiniz dairenin yarıçapını giriniz.");
double yarıcap = double.Parse(Console.ReadLine());
double pi = 3.14;
double alanHesapla(double yarıcap)
{
    return yarıcap * 2 * pi;
}
Console.WriteLine("Girdiğiniz dairenin alanı --> " + alanHesapla(yarıcap));

string cumle = "Zaman bir GeRi SayIm";

Console.WriteLine(cumle.ToLower());
Console.WriteLine(cumle.ToUpper());

string selam = "    Selamlar   ";
Console.WriteLine(selam.Trim());
