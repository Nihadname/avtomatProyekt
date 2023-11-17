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
        avtomat1 = new Avtomat(35, selectedGun);
        break;
    case "m4":
        avtomat1 = new Avtomat(50, selectedGun); 
        break;
    case "aug":
        avtomat1 = new Avtomat(40, selectedGun); 
        break;
    default:
        Console.WriteLine("bilinmeyen silah");
        return;

}

Console.ForegroundColor
            = ConsoleColor.Blue;


Console.WriteLine("oyun baslayacaq entere");
if (Console.ReadKey().Key == ConsoleKey.Enter)
{
   

    Console.WriteLine("1-tek-tek ates ve sonrasi procesde ise a basin");
    Console.WriteLine("2-Avtomatik modda etas bunda ise b");
    //Console.WriteLine("3-daragin doldurulmasi");
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
            
            case ConsoleKey.D4:
                Console.WriteLine("cixma");
                ProgramdanCixma = true;
                break;

            default:
                Console.WriteLine("oyun baslamaq ucun duzgun reqem secin");
                System.Environment.Exit(0);

                break;


        }

    }
}