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

namespace Lord_of_the_Math
{
    public partial class Highscore : PhoneApplicationPage
    {
        IsolatedStorageSettings stroge;
        public Highscore()
        {
            InitializeComponent();
            var prog = new ProgressIndicator { Text = "High Scores", IsVisible = true, IsIndeterminate = false, Value = 0 };
            SystemTray.SetProgressIndicator(this, prog);
            stroge = IsolatedStorageSettings.ApplicationSettings;
            scoreyaz();

        }
        public void scoreyaz()
        {
            if (stroge.Contains("hgkolaypuan"))
            tf1.Text = IsolatedStorageSettings.ApplicationSettings["hgkolaypuan"].ToString();
            if (stroge.Contains("hgortapuan"))
            tf2.Text = IsolatedStorageSettings.ApplicationSettings["hgortapuan"].ToString();
            if (stroge.Contains("hgzorpuan"))
            tf3.Text = IsolatedStorageSettings.ApplicationSettings["hgzorpuan"].ToString();
            if (stroge.Contains("hgkolaypuan1"))
            cg1.Text = IsolatedStorageSettings.ApplicationSettings["hgkolaypuan1"].ToString();
            if (stroge.Contains("hgortapuan1"))
            cg2.Text = IsolatedStorageSettings.ApplicationSettings["hgortapuan1"].ToString();
            if (stroge.Contains("hgzorpuan1"))
            cg3.Text = IsolatedStorageSettings.ApplicationSettings["hgzorpuan1"].ToString();
            if (stroge.Contains("hgkolaypuan2"))
            rg1.Text = IsolatedStorageSettings.ApplicationSettings["hgkolaypuan2"].ToString();
            if (stroge.Contains("hgortapuan2"))
            rg2.Text = IsolatedStorageSettings.ApplicationSettings["hgortapuan2"].ToString();
            if (stroge.Contains("hgzorpuan3"))
            rg3.Text = IsolatedStorageSettings.ApplicationSettings["hgzorpuan2"].ToString();



        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (stroge.Contains("hgkolaypuan"))
                IsolatedStorageSettings.ApplicationSettings["hgkolaypuan"] = "0";
            if (stroge.Contains("hgortapuan"))
                IsolatedStorageSettings.ApplicationSettings["hgortapuan"] = "0";
            if (stroge.Contains("hgzorpuan"))
                IsolatedStorageSettings.ApplicationSettings["hgzorpuan"] = "0";
            if (stroge.Contains("hgkolaypuan1"))
                IsolatedStorageSettings.ApplicationSettings["hgkolaypuan1"] = "0";
            if (stroge.Contains("hgortapuan1"))
                IsolatedStorageSettings.ApplicationSettings["hgortapuan1"] = "0";
            if (stroge.Contains("hgzorpuan1"))
                IsolatedStorageSettings.ApplicationSettings["hgzorpuan1"] = "0";
            if (stroge.Contains("hgkolaypuan2"))
                IsolatedStorageSettings.ApplicationSettings["hgkolaypuan2"] = "0";
            if (stroge.Contains("hgortapuan2"))
                IsolatedStorageSettings.ApplicationSettings["hgortapuan2"] = "0";
            if (stroge.Contains("hgzorpuan3"))
                IsolatedStorageSettings.ApplicationSettings["hgzorpuan2"] = "0";
            scoreyaz();
        }
    }
}