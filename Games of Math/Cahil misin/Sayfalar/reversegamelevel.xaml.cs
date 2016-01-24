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

namespace Lord_of_the_Math.Sayfalar
{
    public partial class reversegamelevel : PhoneApplicationPage
    {
        IsolatedStorageSettings stroge;
        public reversegamelevel()
        {
            InitializeComponent();


            var prog = new ProgressIndicator { Text = "Lord of The Math", IsVisible = true, IsIndeterminate = false, Value = 0 };
            SystemTray.SetProgressIndicator(this, prog);



            stroge = IsolatedStorageSettings.ApplicationSettings;

            if (!stroge.Contains("levelreverse"))
            {
                IsolatedStorageSettings.ApplicationSettings["levelreverse"] = "1";
                IsolatedStorageSettings.ApplicationSettings.Save();

            }
            //gameoverden gelince limitsizi açması için
            if (stroge.Contains("hangigrid"))
            {
                if (IsolatedStorageSettings.ApplicationSettings["hangigrid"] == "1")
                {
                    kırmızı.Visibility = Visibility.Visible;
                    yesil.Visibility = Visibility.Collapsed;
                    imgkırmızı.Opacity = 100;
                    imgyesil.Opacity = 0;
                }

            }
            levelresimleri();


        }
        //yeşil ve kırmızı grid isimleri burda görünürlükleri değişüyor
        private void campaign__Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            yesil.Visibility = Visibility.Visible;
            kırmızı.Visibility = Visibility.Collapsed;
            imgkırmızı.Opacity = 0;
            imgyesil.Opacity = 100;
        }

        private void Limitless_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            kırmızı.Visibility = Visibility.Visible;
            yesil.Visibility = Visibility.Collapsed;
            imgkırmızı.Opacity = 100;
            imgyesil.Opacity = 0;
        }

        private void play1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            IsolatedStorageSettings.ApplicationSettings["level?"] = "1";
            IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman1";
            NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));


        }

        private void play2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 1)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "2";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman2";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }
        public void levelresimleri()
        {
            int a = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (a >= 1)
            {
                open1.Visibility = Visibility.Visible;
                okey1.Visibility = Visibility.Collapsed;
            }
            if (a >= 2)
            {
                open1.Visibility = Visibility.Collapsed;
                okey1.Visibility = Visibility.Visible;
                close2.Visibility = Visibility.Collapsed;
                open2.Visibility = Visibility.Visible;
            }
            if (a >= 3)
            {
                open2.Visibility = Visibility.Collapsed;
                okey2.Visibility = Visibility.Visible;
                close3.Visibility = Visibility.Collapsed;
                open3.Visibility = Visibility.Visible;

            }
            if (a >= 4)
            {
                open3.Visibility = Visibility.Collapsed;
                okey3.Visibility = Visibility.Visible;
                close4.Visibility = Visibility.Collapsed;
                open4.Visibility = Visibility.Visible;

            }
            if (a >= 5)
            {
                open4.Visibility = Visibility.Collapsed;
                okey4.Visibility = Visibility.Visible;
                close5.Visibility = Visibility.Collapsed;
                open5.Visibility = Visibility.Visible;

            }
            if (a >= 6)
            {
                open5.Visibility = Visibility.Collapsed;
                okey5.Visibility = Visibility.Visible;
                close6.Visibility = Visibility.Collapsed;
                open6.Visibility = Visibility.Visible;

            }
            if (a >= 7)
            {
                open6.Visibility = Visibility.Collapsed;
                okey6.Visibility = Visibility.Visible;
                close7.Visibility = Visibility.Collapsed;
                open7.Visibility = Visibility.Visible;

            }
            if (a >= 8)
            {
                open7.Visibility = Visibility.Collapsed;
                okey7.Visibility = Visibility.Visible;
                close8.Visibility = Visibility.Collapsed;
                open8.Visibility = Visibility.Visible;

            }
            if (a >= 9)
            {
                open8.Visibility = Visibility.Collapsed;
                okey8.Visibility = Visibility.Visible;
                close9.Visibility = Visibility.Collapsed;
                open9.Visibility = Visibility.Visible;

            }
            if (a >= 10)
            {
                open9.Visibility = Visibility.Collapsed;
                okey9.Visibility = Visibility.Visible;
                close10.Visibility = Visibility.Collapsed;
                open10.Visibility = Visibility.Visible;

            }
            if (a >= 11)
            {
                open10.Visibility = Visibility.Collapsed;
                okey10.Visibility = Visibility.Visible;
                close11.Visibility = Visibility.Collapsed;
                open11.Visibility = Visibility.Visible;

            }
            if (a >= 12)
            {
                open11.Visibility = Visibility.Collapsed;
                okey11.Visibility = Visibility.Visible;


            }
        }

        private void play3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);

            if (c > 2)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "3";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman3";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);

            if (c > 3)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "4";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman4";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 4)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "5";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman5";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 5)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "6";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman6";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 6)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "7";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman7";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 7)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "8";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman8";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 8)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "9";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman9";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void play10_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);
            if (c > 9)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "10";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman10";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }
        private void play12_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            int c = Convert.ToInt32(IsolatedStorageSettings.ApplicationSettings["levelreverse"]);

            if (c > 10)
            {
                IsolatedStorageSettings.ApplicationSettings["level?"] = "11";
                IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman11";
                NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
                grid1.Visibility = Visibility.Visible;
            }
        }
        //Limitless modu eventleri
        private void play_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["puançarpanı"] = "1";
            IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman1";
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelimitless.xaml", UriKind.Relative));
        }

        private void play11_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["puançarpanı"] = "2";
            IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman2";
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelimitless.xaml", UriKind.Relative));
        }

        private void play13_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["puançarpanı"] = "3";
            IsolatedStorageSettings.ApplicationSettings["zaman"] = "zaman3";
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelimitless.xaml", UriKind.Relative));
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            txtmessega.Text = "Please,Complete the previous levels.";
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;
        }

        private void grid1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;
        }

        private void about_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            txtmessega.Text = "3 seconds for each question";
            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Visible;
        }

        private void about1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            txtmessega.Text = "2 seconds for each question";
            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Visible;
        }

        private void about2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            txtmessega.Text = "1.5 seconds for each question";
            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Visible;
        }

        private void PhoneApplicationPage_BackKeyPress_2(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
        }


    }
}