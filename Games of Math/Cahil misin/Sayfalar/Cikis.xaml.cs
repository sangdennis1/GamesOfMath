using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Cahil_misin.Sayfalar
{
    public partial class Cikis : PhoneApplicationPage
    {
        public Cikis()
        {
            InitializeComponent();
            var prog = new ProgressIndicator { Text = "Games of Math", IsVisible = true, IsIndeterminate = false, Value = 0 };
            SystemTray.SetProgressIndicator(this, prog);
        }

        private void Border_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void Border_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void grid4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}