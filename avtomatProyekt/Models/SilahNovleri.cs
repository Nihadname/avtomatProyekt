using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomatProyekt.Models
{
    internal class SilahNovleri
    {
        public string SilahNovleriTeyinEden()
        {
            Console.WriteLine("5 - ak-47");
            Console.WriteLine("6 - m4");
            Console.WriteLine("7 - aug");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D5:
                    return "ak-47";
       
                case ConsoleKey.D6:
                    return "m4";
                   
                case ConsoleKey.D7:
                    return "aug";
                    
                default:
                    return "bilinmeyen silah secdinis";
                 
            }
        }
    }
}
