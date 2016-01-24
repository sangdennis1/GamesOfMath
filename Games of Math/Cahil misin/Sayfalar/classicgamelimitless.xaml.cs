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
    public partial class classicgamelimitless : PhoneApplicationPage
    {

        int text1;
        int text2;
        int sonuc;
        bool dogrumu;
        int puan;
        int puancarpanı = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["puançarpanı"]);
        int cevap1text, cevap2text, cevap3text, cevap4text;
        Random random = new Random();
        public classicgamelimitless()
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
            animasyon().Stop();
            IsolatedStorageSettings.ApplicationSettings["puan"] = puan;
            IsolatedStorageSettings.ApplicationSettings["nasıbitti"] = "0";
            NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
        }

        //yeni gelecek sayıları üretir
        public void sayiuret()
        {
            text1 = random.Next(2, 10);
            text2 = random.Next(2, 10);
            IsolatedStorageSettings.ApplicationSettings["bölmemi"] = "0";
            int c = 1;
            int y = random.Next(1, 5);
            if (IsolatedStorageSettings.ApplicationSettings["puançarpanı"] == "1")
            {
                y = random.Next(1, 3);
            }
          
            if (y == 1)
            {

                isaret.Text = "+";
                sonuc = text1 + text2;
                cevaplarıyaz();
                textleriyaz();
            }
            else if (y == 2)
            {

                isaret.Text = "-";
                sonuc = text1 - text2;
                cevaplarıyaz();
                textleriyaz();
            }
            else if (y == 3)
            {

                isaret.Text = "x";
                sonuc = text1 * text2;
                cevaplarıyaz();
                textleriyaz();
            }
            else if (y == 4)
            {
                IsolatedStorageSettings.ApplicationSettings["bölmemi"] = "1";
                isaret.Text = "/";
                sonuc = text1 * text2;
                cevaplarıyaz2();
                textleriyaz2();
            }



        }
        public void textleriyaz()
        {
            txt1.Text = txt1yaz();
            txt2.Text = txt2yaz();
            sonuc1.Text = sonucyaz();
            puantext.Text = puan.ToString();
           
            cevap1.Text = cevap1text.ToString();
            cevap2.Text = cevap2text.ToString();
            cevap3.Text = cevap3text.ToString();
            cevap4.Text = cevap4text.ToString();
        }
        public void textleriyaz2()
        {
            txt1.Text = sonuc.ToString();
            txt2.Text = txt2yaz();
            sonuc1.Text = sonucyaz();
            puantext.Text = puan.ToString();
            
            cevap1.Text = cevap1text.ToString();
            cevap2.Text = cevap2text.ToString();
            cevap3.Text = cevap3text.ToString();
            cevap4.Text = cevap4text.ToString();
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

            return "?";


        }
        public bool dogrumuyaz()
        {
            return dogrumu;
        }
        public void cevaplarıyaz2()
        {
            int x1 = random.Next(1, 5);
            int x2 = random.Next(1, 5);
            if (x1 == 1)
            {
                cevap1text = text1;
                if (x2 == 1)
                {
                    cevap2text = text1 - 1;
                    cevap3text = text1 + 1;
                    cevap4text = text1 - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = text1 + 1;
                    cevap3text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap4text = text1 + 1;
                }

            }
            else if (x1 == 2)
            {
                cevap2text = text1;
                if (x2 == 1)
                {
                    cevap1text = text1 - 1;
                    cevap3text = text1 + 1;
                    cevap4text = text1 - 2;
                }
                else if (x2 == 2)
                {
                    cevap1text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 3)
                {
                    cevap1text = text1 + 1;
                    cevap3text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 4)
                {
                    cevap1text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap4text = text1 + 1;
                }
            }
            else if (x1 == 3)
            {
                cevap3text = text1;
                if (x2 == 1)
                {
                    cevap2text = text1 - 1;
                    cevap1text = text1 + 1;
                    cevap4text = text1 - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = text1 - 2;
                    cevap1text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = text1 + 1;
                    cevap1text = text1 + 2;
                    cevap4text = text1 - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = text1 - 2;
                    cevap1text = text1 + 2;
                    cevap4text = text1 + 1;
                }
            }
            else if (x1 == 4)
            {
                cevap4text = text1;
                if (x2 == 1)
                {
                    cevap2text = text1 - 1;
                    cevap3text = text1 + 1;
                    cevap1text = text1 - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap1text = text1 - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = text1 + 1;
                    cevap3text = text1 + 2;
                    cevap1text = text1 - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = text1 - 2;
                    cevap3text = text1 + 2;
                    cevap1text = text1 + 1;
                }
            }
        }
        public void cevaplarıyaz()
        {
            int x1 = random.Next(1, 5);
            int x2 = random.Next(1, 5);
            if (x1 == 1)
            {
                cevap1text = sonuc;
                if (x2 == 1)
                {
                    cevap2text = sonuc - 1;
                    cevap3text = sonuc + 1;
                    cevap4text = sonuc - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = sonuc + 1;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc + 1;
                }

            }
            else if (x1 == 2)
            {
                cevap2text = sonuc;
                if (x2 == 1)
                {
                    cevap1text = sonuc - 1;
                    cevap3text = sonuc + 1;
                    cevap4text = sonuc - 2;
                }
                else if (x2 == 2)
                {
                    cevap1text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 3)
                {
                    cevap1text = sonuc + 1;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 4)
                {
                    cevap1text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap4text = sonuc + 1;
                }
            }
            else if (x1 == 3)
            {
                cevap3text = sonuc;
                if (x2 == 1)
                {
                    cevap2text = sonuc - 1;
                    cevap1text = sonuc + 1;
                    cevap4text = sonuc - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = sonuc - 2;
                    cevap1text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = sonuc + 1;
                    cevap1text = sonuc + 2;
                    cevap4text = sonuc - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = sonuc - 2;
                    cevap1text = sonuc + 2;
                    cevap4text = sonuc + 1;
                }
            }
            else if (x1 == 4)
            {
                cevap4text = sonuc;
                if (x2 == 1)
                {
                    cevap2text = sonuc - 1;
                    cevap3text = sonuc + 1;
                    cevap1text = sonuc - 2;
                }
                else if (x2 == 2)
                {
                    cevap2text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap1text = sonuc - 1;
                }
                else if (x2 == 3)
                {
                    cevap2text = sonuc + 1;
                    cevap3text = sonuc + 2;
                    cevap1text = sonuc - 1;
                }
                else if (x2 == 4)
                {
                    cevap2text = sonuc - 2;
                    cevap3text = sonuc + 2;
                    cevap1text = sonuc + 1;
                }
            }
        }
        //dogru butonu tiki       
        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/classicgamelevel.xaml", UriKind.Relative));
        }

        private void btn1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings["bölmemi"] == "0")
            {
                if (sonuc == cevap1text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
            else
            {
                if (text1 == cevap1text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
        }

        private void btn2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings["bölmemi"] == "0")
            {
                if (sonuc == cevap2text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
            else
            {
                if (text1 == cevap2text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
        }

        private void btn3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings["bölmemi"] == "0")
            {
                if (sonuc == cevap3text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
            else
            {
                if (text1 == cevap3text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
        }

        private void btn4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings["bölmemi"] == "0")
            {
                if (sonuc == cevap4text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
            else
            {
                if (text1 == cevap4text)
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
                    NavigationService.Navigate(new Uri("/Sayfalar/Gameoverclassic.xaml", UriKind.Relative));
                }
            }
        }

        private void PhoneApplicationPage_BackKeyPress_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            animasyon().Stop();
            NavigationService.Navigate(new Uri("/Sayfalar/classicgamelevel.xaml", UriKind.Relative));
        }

    }
}