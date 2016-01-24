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


namespace Lord_of_The_Math.Sayfalar
{
    public partial class Oyunlar : PhoneApplicationPage
    {
        IsolatedStorageSettings stroge;
        // Constructor
     
      
        public Oyunlar()
        {
            
            IsolatedStorageSettings.ApplicationSettings["hangigrid"] = "0";
            var prog = new ProgressIndicator { Text = "Games of Math", IsVisible = true, IsIndeterminate = false, Value = 0 };
            SystemTray.SetProgressIndicator(this, prog);
            InitializeComponent();
            

        }

        private void play_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
          
            NavigationService.Navigate(new Uri("/Sayfalar/trueorfalselevel.xaml", UriKind.Relative));
         
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void exit_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            trueorfalsehelp.Visibility = Visibility.Collapsed;
        }

        private void about_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            trueorfalsehelp.Visibility = Visibility.Visible;
        }

        private void play1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/classicgamelevel.xaml", UriKind.Relative));
        }

        private void exit1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            classichelp.Visibility = Visibility.Collapsed;
        }

        private void about1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            classichelp.Visibility = Visibility.Visible;
        }

        private void play2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sayfalar/reversegamelevel.xaml", UriKind.Relative));
        }

        private void exit2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Reversehelp.Visibility = Visibility.Collapsed;
        }

        private void about2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Reversehelp.Visibility = Visibility.Visible;
                
        }
    }
}