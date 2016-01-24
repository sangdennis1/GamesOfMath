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
    public partial class Levelbittireverse : PhoneApplicationPage
    {
        public Levelbittireverse()
        {
            InitializeComponent();
            if (IsolatedStorageSettings.ApplicationSettings["level?"] == "1")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "2";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "2")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "3";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "3")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "4";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "4")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "5";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "5")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "6";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "6")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "7";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "7")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "8";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "8")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "9";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "9")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "10";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "10")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "11";
            else if (IsolatedStorageSettings.ApplicationSettings["level?"] == "11")
                IsolatedStorageSettings.ApplicationSettings["level?"] = "12";
            if (IsolatedStorageSettings.ApplicationSettings["level?"] == "12")
            {

                txt.Text = "Congratulations!,Levels over";
               
            }
        }

        private void rtnbtn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelevel.xaml", UriKind.Relative));
        }
        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void nextbtn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings["level?"] == "12")
            {
                NavigationService.Navigate(new Uri("/Sayfalar/reversegamelevel.xaml", UriKind.Relative));
               
            }
            else  
            NavigationService.Navigate(new Uri("/Sayfalar/reservegame.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelevel.xaml", UriKind.Relative));
        }

      
       
    }
}