

namespace avtomatProyekt.Models
{
    internal class GirisEkrani
    {
        public void GirisEkraniHissesi()
        {
            Console.ForegroundColor
                 = ConsoleColor.Blue;

            Console.WriteLine("OYUNA BASLAYIRIQ");
            Console.WriteLine("9 GIRIS ");
            Console.WriteLine("q-QUIT");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key) {
                case ConsoleKey.D9:
                    Console.WriteLine("oyun menu hissesine daxil oldunuz");
                    break;
                    case  ConsoleKey.Q:
                    System.Environment.Exit(0);
                    break;


            }


        }
    }
}
