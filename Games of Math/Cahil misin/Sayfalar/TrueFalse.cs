using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lord_of_The_Math.Sayfalar
{
    class TrueFalse
    {
        int text1;
        int text2;
        int sonuc;
        bool dogrumu ;
        
        Random random = new Random();
        public void sayiuret()
        {
          text1 = random.Next(1, 10);
          text2 = random.Next(1, 10);
          sonuc = text1 + text2;
          int x = random.Next(1, 3);
          if (x == 1)
          {
              dogrumu=true;
          }
          else if(x==2)
          {
              dogrumu = false;
          }

         }
        public string txt1yaz()
        {

            return text1.ToString();
        }
        public string txt2yaz()
        {
            return text2.ToString();
        }
        public string sonucyaz()
        {
            if (dogrumu == true)
            {
                return sonuc.ToString();
            }
            //sonuç yanlışsa yanlış sonuç döndürecek
            else
            {
                int yanlıssonuc=0;
                if (sonuc > 10) {
                    yanlıssonuc = random.Next(10, 19);
                    for (; sonuc == yanlıssonuc; )
                    {
                        yanlıssonuc = random.Next(10, 19);
                    }
                    return yanlıssonuc.ToString();

                }
                else if(sonuc>5) {
                    yanlıssonuc = random.Next(sonuc-5, 10);
                    for (; sonuc == yanlıssonuc; )
                    {
                        
                        yanlıssonuc = random.Next(sonuc-5, 10);
                    }
                    return yanlıssonuc.ToString();
                }
                else
                {
                    yanlıssonuc = random.Next(sonuc - 1, 6);
                    for (; sonuc == yanlıssonuc; )
                    {

                        yanlıssonuc = random.Next(sonuc - 1, 6);
                    }
                    return yanlıssonuc.ToString();
                }
                
               
            }
        }
        public bool dogrumuyaz()
        {
            return dogrumu;
        }
       
    }
}
