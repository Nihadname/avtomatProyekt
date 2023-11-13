using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomatProyekt.Models
{
    internal class Avtomat
    {
     public   string Ad;
       public int UmumiGulleSayi;
        public int ElimezdeQalanGulleSayi;

        public Avtomat(string ad, int umumiGulleSayi)
        {
            Ad = ad;
            UmumiGulleSayi = umumiGulleSayi;
            ElimezdeQalanGulleSayi = umumiGulleSayi;
        }
        public void BirGulle()
        {
           
            if(ElimezdeQalanGulleSayi>0) {
                Console.WriteLine("1 gulle atilir");
                ElimezdeQalanGulleSayi--;
                QalanGulleSayiniGostermek();

            }
            else
            {
                GulleninDoldurulmasi();
               
               
            }
            
        }
        public void AvtomatikEtas()
        {
            int HerAvtomatikGulleEtasSayisi = 3;
            if (HerAvtomatikGulleEtasSayisi >= ElimezdeQalanGulleSayi)
            {
                Console.WriteLine("avtomatik etas baslamisdir");
                ElimezdeQalanGulleSayi -= HerAvtomatikGulleEtasSayisi;
                QalanGulleSayiniGostermek();
            }
            else
            {
                Console.WriteLine("gullemiz qurtarib");
            }
        }
        public void GulleninDoldurulmasi()
        {
            if (ElimezdeQalanGulleSayi == 0)
            {
                Console.WriteLine("gulle doldurulur");
                ElimezdeQalanGulleSayi = UmumiGulleSayi;
                QalanGulleSayiniGostermek() ;
            }
        }
        public void QalanGulleSayiniGostermek()
        {
            Console.WriteLine($"{ElimezdeQalanGulleSayi}/{UmumiGulleSayi}");
        }

    }
}
