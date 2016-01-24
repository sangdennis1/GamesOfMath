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
    public partial class reversegamelimitless : PhoneApplicationPage
    {
        int text1;
        int text2;
        int sonuc;
        bool dogrumu;
        int puan;
        int puanson = 10;
        int cevap1text, cevap2text, cevap3text, cevap4text;
        Random random = new Random();
        public reversegamelimitless()
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


        }
        //zaman bitti
        void zaman_Completed(object sender, EventArgs e)
        {
            animasyon().Pause();
            IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
            IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "0";
            NavigationService.Navigate(new Uri("/Sayfalar/GameOverreverse.xaml", UriKind.Relative));
        }
        int y;
        //yeni gelecek sayıları üretir
        public void sayiuret()
        {
            text1 = random.Next(2, 10);
            text2 = random.Next(2, 10);
            IsolatedStorageSettings.ApplicationSettings["bölmemi"] = "0";
            int c = 1;
            y = random.Next(1, 5);


            if (y == 1)
            {

                sonuc = text1 + text2;

                textleriyaz();
            }
            else if (y == 2)
            {


                sonuc = text1 - text2;

                textleriyaz();
            }
            else if (y == 3)
            {

                sonuc = text1 * text2;

                textleriyaz();
            }
            else if (y == 4)
            {
                IsolatedStorageSettings.ApplicationSettings["bölmemi"] = "1";

                sonuc = text1 * text2;

                textleriyaz2();
            }



        }
        public void textleriyaz()
        {
            txt1.Text = txt1yaz();
            txt2.Text = txt2yaz();
            sonuc1.Text = sonucyaz();
            puantext.Text = puan.ToString();
          

        }
        public void textleriyaz2()
        {
            txt1.Text = sonucyaz();
            txt2.Text = txt2yaz();
            sonuc1.Text = txt1yaz();
            puantext.Text = puan.ToString();
           

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
            else
                return zaman3;
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

            return sonuc.ToString();


        }
        public bool dogrumuyaz()
        {
            return dogrumu;
        }

        //dogru butonu tiki       
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            animasyon().Pause();
            NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
        }

     

        private void btn1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (y == 1)
            {
                media.Stop();
                media.Play();
                puan++;
                işlemler();
            }
            else
            {

                animasyon().Pause();
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOverreverse.xaml", UriKind.Relative));
            }

        }

        private void btn2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (y == 3)
            {
                media.Stop();
                media.Play();
                puan++;
                işlemler();
            }
            else
            {

                animasyon().Pause();
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOverreverse.xaml", UriKind.Relative));
            }

        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelevel.xaml", UriKind.Relative));

        }

        private void btn3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (y == 4)
            {
                media.Stop();
                media.Play();
                puan++;
                işlemler();
            }
            else
            {

                animasyon().Pause();
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOverreverse.xaml", UriKind.Relative));
            }

        }

        private void btn4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            if (y == 2)
            {
                media.Stop();
                media.Play();
                puan++;
                işlemler();
            }
            else
            {

                animasyon().Pause();
                IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
                IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "1";
                NavigationService.Navigate(new Uri("/Sayfalar/GameOverreverse.xaml", UriKind.Relative));
            }

        }

      

    }
}