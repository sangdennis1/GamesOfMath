using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Windows.Media.Animation;

namespace Lord_of_the_Math.Sayfalar
{
    public partial class Trueorfalselimitless : PhoneApplicationPage
    {
        int text1;
        int text2;
        int sonuc;
        bool dogrumu;
        int puan;
        int puancarpanı = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["puançarpanı"]);
        Random random = new Random();
        public Trueorfalselimitless()
        {
            InitializeComponent();
            işlemler();
            IsolatedStorageSettings.ApplicationSettings["hangigrid"] = "1";
         



           
        }
        public void işlemler()
        {
            animasyon().Stop();
            animasyon().Begin();
            animasyon().Completed += zaman_Completed;
            sayiuret();
            txt1.Text = txt1yaz();
            txt2.Text = txt2yaz();
            sonuc1.Text = sonucyaz();
            puantext.Text = puan.ToString();
            
        }
        void zaman_Completed(object sender, EventArgs e)
        {
            animasyon().Stop();
            IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
            IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "0";
            NavigationService.Navigate(new Uri("/Sayfalar/GameOver.xaml", UriKind.Relative));
        }
        public void sayiuret()
        {
            text1 = random.Next(1, 10);
            text2 = random.Next(1, 10);
            int y = random.Next(1, 4);
            if (IsolatedStorageSettings.ApplicationSettings["puançarpanı"] == "1")
            {
                y = random.Next(1, 3);
            }
            if (y == 1)
            {

                isaret.Text = "+";
                sonuc = text1 + text2;
            }
            else if (y == 2)
            {
                isaret.Text = "-";
                sonuc = text1 - text2;
            }
            else 
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

            else
                return null;
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
                    return (sonuc + 1).ToString();
                }
                else
                {
                    return (sonuc + 2).ToString();
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
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOver.xaml", UriKind.Relative));
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
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOver.xaml", UriKind.Relative));
            }
        }
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/trueorfalselevel.xaml", UriKind.Relative));
        }
    }
}