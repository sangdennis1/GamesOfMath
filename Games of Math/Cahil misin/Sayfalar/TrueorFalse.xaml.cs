using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Media.Animation;
using System.IO.IsolatedStorage;

namespace Lord_of_The_Math.Sayfalar
{
    public partial class TrueorFalse : PhoneApplicationPage
    { 


        int text1;
        int text2;
        int sonuc;
        bool dogrumu;
        int puan ;
        int puanson = 15;
        Random random = new Random();
        public TrueorFalse()
        {
            
            InitializeComponent();
            işlemler();
            IsolatedStorageSettings.ApplicationSettings["hangigrid"] = "0";
            animasyon().Stop();
            animasyon().Begin();



            animasyon().Completed += zaman_Completed;
        }
      
       public void işlemler()
        {
           //hedefe ulaşıldımı ?
            if (puan == puanson)
            {
                if (IsolatedStorageSettings.ApplicationSettings["level?"].ToString() == IsolatedStorageSettings.ApplicationSettings["level"].ToString())
                {
                    if (IsolatedStorageSettings.ApplicationSettings["level"] == "1")
                        IsolatedStorageSettings.ApplicationSettings["level"] = "2";
                    else
                    {
                        IsolatedStorageSettings.ApplicationSettings["level"] = (Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["level"]) + 1).ToString();
                    }
                    IsolatedStorageSettings.ApplicationSettings.Save();
                  // IsolatedStorageSettings.ApplicationSettings["level"] = (Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["level"]) + 1).ToString() ;
                }

                animasyon().Stop();
                NavigationService.Navigate(new Uri("/Sayfalar/Levelbitti.xaml", UriKind.Relative));
            }
            else
            {
                sayiuret();
                txt1.Text = txt1yaz();
                txt2.Text = txt2yaz();
                sonuc1.Text = sonucyaz();
                puantext.Text = puan.ToString();
                txtson.Text = puanson.ToString();
            }
        }
       //zaman bitti
       void zaman_Completed(object sender, EventArgs e)
       {
           animasyon().Stop();
           IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "0";
           NavigationService.Navigate(new Uri("/Sayfalar/sürebitti.xaml", UriKind.Relative));
       }

     //yeni gelecek sayıları üretir
       public void sayiuret()
       {
           text1 = random.Next(1, 10);
           text2 = random.Next(1, 10);
           int y = random.Next(1, 3);
           int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["level"]);
           if (c > 3)
           {
                y = random.Next(1, 4);
           }
           if (y == 1)
           {

               isaret.Text = "+";
               sonuc = text1 + text2;
           }
           else if(y==2)
           {
               isaret.Text = "-";
               sonuc = text1 - text2;
           }
           else if (y == 3)
           {

               isaret.Text = "x";
               sonuc = text1 * text2;
           }
           int x = random.Next(1, 3);
           if (x == 1)
           {
               dogrumu = true;
           }
           else if (x == 2)
           {
               dogrumu = false;
           }

       }
     //hangi animasyon olacağını belirliyor
       public Storyboard animasyon()
       {
           if ("zaman1" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman1;
           }

           if ("zaman2" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman2;
           }
           if ("zaman3" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman3;
           }

           if ("zaman4" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman4;
           }
           if ("zaman5" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman5;
           }

           if ("zaman6" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman6;
           }
           if ("zaman7" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman7;
           }

           if ("zaman8" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman8;
           }
           if ("zaman9" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman9;
           }

           if ("zaman10" == IsolatedStorageSettings.ApplicationSettings["zaman"])
           {
               return zaman10;
           }
           else
               return zaman11;
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
               int x1 = random.Next(1, 5);
               if (x1 == 1)
               {
                   return (sonuc - 1).ToString();
               }
               else if (x1 == 2)
               {
                   return (sonuc - 2).ToString();
               }
               else if (x1 == 3)
               {
                   return (sonuc +1).ToString();
               }
               else 
               {
                   return (sonuc +2).ToString();
               }
              
           }
       }
       public bool dogrumuyaz()
       {
           return dogrumu;
       }
      //dogru butonu tiki
       private void doğru_Tap(object sender, System.Windows.Input.GestureEventArgs e)
       {
           if (dogrumu == true)
           {
               media.Stop();
               media.Play();
              
               puan++;
               işlemler();
           }
           else
           {

               animasyon().Stop();
               IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
               NavigationService.Navigate(new Uri("/Sayfalar/sürebitti.xaml", UriKind.Relative));
           }
           
       }

       private void yanlıs_Tap(object sender, System.Windows.Input.GestureEventArgs e)
       {
           if (dogrumu == false)
           {
               media.Stop();
               media.Play();
               puan++;
               işlemler();
           }
           else
           {

               animasyon().Stop();
               IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
               NavigationService.Navigate(new Uri("/Sayfalar/sürebitti.xaml", UriKind.Relative));
           }
       }

       private void PhoneApplicationPage_BackKeyPress(object sender, CancelEventArgs e)
       {

           animasyon().Stop();
          NavigationService.Navigate(new Uri("/Sayfalar/trueorfalselevel.xaml", UriKind.Relative));
       }

       private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
       {
           animasyon().Stop();
           NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
       }
       
    }
}