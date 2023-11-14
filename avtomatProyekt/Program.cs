// See https://aka.ms/new-console-template for more information
using avtomatProyekt.Models;

Console.WriteLine("Hello, World!");
GirisEkrani girisEkrani = new GirisEkrani();
girisEkrani.GirisEkraniHissesi();
SilahNovleri silahNovleri = new SilahNovleri();
string selectedGun = silahNovleri.SilahNovleriTeyinEden();
Avtomat avtomat1;
//char OyunMeqsediniBelirleyen=char.Parse(Console.ReadLine());
switch (selectedGun) {

    case "ak-47":
        avtomat1 = new Avtomat(35, selectedGun); // Pass 35 bullets for AK-47
        break;
    case "m4":
        avtomat1 = new Avtomat(50, selectedGun); // Specify M4 bullet count if different
        break;
    case "aug":
        avtomat1 = new Avtomat(40, selectedGun); // Pass 40 bullets for AUG
        break;
    default:
        Console.WriteLine("Unknown gun selected");
        return;

}

Console.BackgroundColor = ConsoleColor.Red;

Console.WriteLine("oyun baslayacaq entere");
if (Console.ReadKey().Key == ConsoleKey.Enter)
{
   

    Console.WriteLine("1-tek-tek ates");
    Console.WriteLine("2-Avtomatik modda etas");
    Console.WriteLine("3-daragin doldurulmasi");
    Console.WriteLine("4-eger oyunu bu hisseden cixmax istesez");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    bool ProgramdanCixma = false;
    while (!ProgramdanCixma)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                avtomat1.BirGulle();
                break;
            case ConsoleKey.D2:
                avtomat1.AvtomatikEtas();
                break;
            case ConsoleKey.D3:
                avtomat1.GulleninDoldurulmasi();
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