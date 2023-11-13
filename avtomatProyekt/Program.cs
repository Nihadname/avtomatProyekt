// See https://aka.ms/new-console-template for more information
using avtomatProyekt.Models;

Console.WriteLine("Hello, World!");

Avtomat avtomat = new Avtomat("Ak-47",30);
char OyunMeqsediniBelirleyen=char.Parse(Console.ReadLine());

Console.WriteLine("oyun baslayacaq amma optionlariniz olacaq birini secin");
Console.WriteLine("1-tek-tek ates");
Console.WriteLine("2-Avtomatik modda etas");
Console.WriteLine("3-daragin doldurulmasi");
while (true)
{
    switch (OyunMeqsediniBelirleyen) {
        case '1':
            avtomat.BirGulle();
            break;
        case '2':
            avtomat.AvtomatikEtas();
            break;
        case '3':
            avtomat.GulleninDoldurulmasi();
            break;
            default:
            Console.WriteLine("oyun baslamaq ucun duzgun reqem secin");
             OyunMeqsediniBelirleyen = char.Parse(Console.ReadLine());
            break;  

    
    }

}