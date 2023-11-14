using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace avtomatProyekt.Models
{
    internal class Avtomat
    {
        public string SilahinAdi;
       public int UmumiGulleSayi;
        public int ElimezdeQalanGulleSayi;

        public Avtomat( int umumiGulleSayi,string SilahinAdiMueyyenEden)
        {
         
            UmumiGulleSayi = umumiGulleSayi;
            ElimezdeQalanGulleSayi = umumiGulleSayi;
            SilahinAdi = SilahinAdiMueyyenEden;
        }
        
        public void BirGulle()
        {

            if (ElimezdeQalanGulleSayi > 0) {
     
                if (Console.ReadKey().Key == ConsoleKey.A) {
                    Console.WriteLine("1 gulle atilir");
                    ElimezdeQalanGulleSayi--;
               
            }
                QalanGulleSayiniGostermek();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    ElimezdeQalanGulleSayi = UmumiGulleSayi;
                    QalanGulleSayiniGostermek();
                   // System.Environment.Exit(0);


                }

            }
            

        }
        public void AvtomatikEtas()
        {
            int HerAvtomatikGulleEtasSayisi = 3;
            if (ElimezdeQalanGulleSayi >=HerAvtomatikGulleEtasSayisi)
            {
                if (Console.ReadKey().Key == ConsoleKey.B)
                {
                    Console.WriteLine("avtomatik etas baslamisdir");
                    ElimezdeQalanGulleSayi -= HerAvtomatikGulleEtasSayisi;
                    QalanGulleSayiniGostermek();
                }
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    ElimezdeQalanGulleSayi = UmumiGulleSayi;
                    QalanGulleSayiniGostermek();
                   // System.Environment.Exit(0);
                }
            }
           
        }
        public void GulleninDoldurulmasi()
        {
           
            
                Console.WriteLine("gulle doldurulur");
                ElimezdeQalanGulleSayi = UmumiGulleSayi;

               
                QalanGulleSayiniGostermek();
            System.Environment.Exit(0);

        }
        public void QalanGulleSayiniGostermek()
        {
            Console.WriteLine($"{ElimezdeQalanGulleSayi}/{UmumiGulleSayi}");
        }

    }
}
