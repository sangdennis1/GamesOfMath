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
using GoogleAds;

namespace Lord_of_the_Math.Sayfalar
{
    public partial class sürebitticlassic : PhoneApplicationPage
    {
        private InterstitialAd interstitialAd;
        IsolatedStorageSettings stroge;
        //reklam hazırlama
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

            interstitialAd.ReceivedAd += İnterstitialAd_ReceivedAd;

        }


        //reklam hazırsa olacaklar
        private void İnterstitialAd_ReceivedAd(object sender, AdEventArgs e)
        {
           
            if (IsolatedStorageSettings.ApplicationSettings["reklam1"] == "0")
            {

                interstitialAd.ShowAd();
                IsolatedStorageSettings.ApplicationSettings["reklam"] = "0";
            }
            else
            {
                IsolatedStorageSettings.ApplicationSettings["reklam"] = "2";
                IsolatedStorageSettings.ApplicationSettings.Save();
            }

        }
        public sürebitticlassic()
        {
           
            InitializeComponent();
            //reklamın farklı yerde gösterilmesini engelleme
            IsolatedStorageSettings.ApplicationSettings["reklam1"] = "0";
            IsolatedStorageSettings.ApplicationSettings.Save();
            //reklam gösterilsinmi ?
            if (IsolatedStorageSettings.ApplicationSettings["reklam"] == "2")
            {
                OnRequestInterstitialClick();
               
            }
            else
            {
                if (IsolatedStorageSettings.ApplicationSettings["reklam"] == "0")
                {
                    IsolatedStorageSettings.ApplicationSettings["reklam"] = "1";
                    IsolatedStorageSettings.ApplicationSettings.Save();
                }
                else if (IsolatedStorageSettings.ApplicationSettings["reklam"] == "1")
                {
                    IsolatedStorageSettings.ApplicationSettings["reklam"] = "2";
                    IsolatedStorageSettings.ApplicationSettings.Save();
                }

            }
                if (IsolatedStorageSettings.ApplicationSettings["nasıbitti"] == "1")
            {
                txt.Text = "Answer is wrong!";
            }
        }

        private void rtnbtn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["reklam1"] = "1";
            IsolatedStorageSettings.ApplicationSettings.Save();
            NavigationService.Navigate(new Uri("/Sayfalar/classicgame.xaml", UriKind.Relative));
        }
        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["reklam1"] = "1";
            IsolatedStorageSettings.ApplicationSettings.Save();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsolatedStorageSettings.ApplicationSettings["reklam1"] = "1";
            IsolatedStorageSettings.ApplicationSettings.Save();
            NavigationService.Navigate(new Uri("/Sayfalar/classicgamelevel.xaml", UriKind.Relative));
        }


    }
}