using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _181_UWP_Timer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Stopwatch stopwatch;
        TimeSpan ts;
        DispatcherTimer timer;
        bool themeFlag = true;
        public MainPage()
        {
            this.InitializeComponent();
            InitializeComponent();
            stopwatch = new Stopwatch();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(0.1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            ts = stopwatch.Elapsed;
            swBlock.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            swStatus.Text = "Stopwatch running!";
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            if(!stopwatch.IsRunning)
            {
                stopwatch.Reset();
                swStatus.Text = "Stopwatch ready!";
                return;
            }

            stopwatch.Stop();
            swStatus.Text = "Stopwatch stopped!";
        }

        private void themeToggle_Click(object sender, RoutedEventArgs e)
        {
            if(themeFlag)
            {
                myGrid.Background = new SolidColorBrush(Windows.UI.Colors.White);
                swBlock.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                themeFlag = false;
                return;
            }
            myGrid.Background = new SolidColorBrush(Windows.UI.Colors.Black);
            swBlock.Foreground = new SolidColorBrush(Windows.UI.Colors.Aqua);
            themeFlag = true;

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void shareButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
