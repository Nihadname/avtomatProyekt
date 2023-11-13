using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtomatProyekt.Models
{
    internal class Avtomat
    {
  
       public int UmumiGulleSayi;
        public int ElimezdeQalanGulleSayi;

        public Avtomat( int umumiGulleSayi)
        {
         
            UmumiGulleSayi = umumiGulleSayi;
            ElimezdeQalanGulleSayi = umumiGulleSayi;
        }
        public void SilahiMueyyenlesdiren()
        {
            
        }
        public void BirGulle()
        {
           
            if(ElimezdeQalanGulleSayi>0) {
                Console.WriteLine("1 gulle atilir");
                ElimezdeQalanGulleSayi--;
                QalanGulleSayiniGostermek();
                if (ElimezdeQalanGulleSayi == 0)
                {
                    ElimezdeQalanGulleSayi = UmumiGulleSayi;
                    QalanGulleSayiniGostermek();
                    System.Environment.Exit(0);


                }

            }
            

        }
        public void AvtomatikEtas()
        {
            int HerAvtomatikGulleEtasSayisi = 3;
            if (ElimezdeQalanGulleSayi >=HerAvtomatikGulleEtasSayisi)
            {
                Console.WriteLine("avtomatik etas baslamisdir");
                ElimezdeQalanGulleSayi -= HerAvtomatikGulleEtasSayisi;
                QalanGulleSayiniGostermek();
                if (ElimezdeQalanGulleSayi == HerAvtomatikGulleEtasSayisi)
                {
                    ElimezdeQalanGulleSayi = UmumiGulleSayi;
                    QalanGulleSayiniGostermek();
                    System.Environment.Exit(0);


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
