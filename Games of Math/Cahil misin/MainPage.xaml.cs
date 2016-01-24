using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.IO.IsolatedStorage;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System.Windows.Media;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Threading;
using GoogleAds;

using Windows.Phone.UI.Input;

namespace Cahil_misin
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Popup popup;
        private BackgroundWorker backroungWorker;
        IsolatedStorageSettings stroge;

       
        private InterstitialAd interstitialAd;
        private void OnRequestInterstitialClick()
        {
            // NOTE: Edit "MY_AD_UNIT_ID" with your interstitial
            // ad unit id.
            interstitialAd = new InterstitialAd("ca-app-pub-9952422283209342/4928163069");
            // NOTE: You can edit the event handler to do something custom here. Once the
            // interstitial is received it can be shown whenever you want.


            AdRequest adRequest = new AdRequest();
            adRequest.ForceTesting = false;
            interstitialAd.LoadAd(adRequest);



        }


        public MainPage()
        {

            InitializeComponent();
            OnRequestInterstitialClick();
           

            IsolatedStorageSettings.ApplicationSettings["reklam"] = "0";
            IsolatedStorageSettings.ApplicationSettings.Save();
            Application.Current.UnhandledException += Current_UnhandledException;
            


            var prog = new ProgressIndicator { Text = "Games of Math", IsVisible = true, IsIndeterminate = false, Value = 0 };
            SystemTray.SetProgressIndicator(this, prog);

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }


        //HATA ALIRSA ÇIKACAK MESAJ
        void Current_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("upps!! Bad day :(");
        }






        private void about_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            grid1.Visibility = Visibility.Visible;
            grid2.Visibility = Visibility.Visible;

        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //market değerlendir butonu
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void play_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {



            
            NavigationService.Navigate(new Uri("/Sayfalar/Oyunlar.xaml", UriKind.Relative));
        }





      
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask email = new EmailComposeTask();
            email.To = "ugurkubat1@yandex.com";

            email.Subject = "Games of Math";
            email.Show();
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void hakkındaçıkış_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            grid1.Visibility = Visibility.Collapsed;
            grid2.Visibility = Visibility.Collapsed;

        }

        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Highscore.xaml", UriKind.Relative));
        }

        private void Border_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void Border_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            grid3.Visibility = Visibility.Collapsed;
            grid4.Visibility = Visibility.Collapsed;
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/Cikis.xaml", UriKind.Relative));
        }

     
        private void image_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();

            webBrowserTask.Uri = new Uri("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=54K99M2NVACTU", UriKind.Absolute);

            webBrowserTask.Show();
        }
    }
    }