using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomatProyekt.Models
{
    internal class SilahNovleri
    {
        public void SilahNovleriTeyinEden()
        {
            Console.WriteLine("5 - ak-47");
            Console.WriteLine("6 - m4");
            Console.WriteLine("7 - aug");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D5:
                    Console.WriteLine("\nak-47");
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("\nm4");
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("\naug");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please choose a valid option (5, 6, or 7).");
                    break;
            }
        }
    }
}
