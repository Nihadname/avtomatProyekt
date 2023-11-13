// See https://aka.ms/new-console-template for more information
using avtomatProyekt.Models;

Console.WriteLine("Hello, World!");
GirisEkrani girisEkrani = new GirisEkrani();
girisEkrani.GirisEkraniHissesi();
Avtomat avtomat = new Avtomat(30);
SilahNovleri silahNovleri = new();
silahNovleri.SilahNovleriTeyinEden();
//char OyunMeqsediniBelirleyen=char.Parse(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine("oyun baslayacaq entere");
if (Console.ReadKey().Key == ConsoleKey.Enter)
{
   

    Console.WriteLine("1-tek-tek ates");
    Console.WriteLine("2-Avtomatik modda etas");
    Console.WriteLine("3-daragin doldurulmasi");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    bool ProgramdanCixma = false;
    while (!ProgramdanCixma)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                avtomat.BirGulle();
                break;
            case ConsoleKey.D2:
                avtomat.AvtomatikEtas();
                break;
            case ConsoleKey.D3:
                avtomat.GulleninDoldurulmasi();
                break;
            case ConsoleKey.D4:
                Console.WriteLine("cixma");
                ProgramdanCixma = true;
                break;

            default:
                Console.WriteLine("oyun baslamaq ucun duzgun reqem secin");
              
                break;


        }

    }
}