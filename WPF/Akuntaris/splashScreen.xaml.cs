
using System;
using System.Windows;
using System.Windows.Threading;

namespace Akuntaris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {

        DispatcherTimer dt = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();

            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 2);
            dt.Start();
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            dt.Stop();
            this.Close();
        }
    }
}
