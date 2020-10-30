using System;
using System.Windows;

namespace Stopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime startTime;
        private System.Timers.Timer aTimer;
        TimeSpan totalTime;
        public MainWindow()
        {
            InitializeComponent();
            aTimer = new System.Timers.Timer(100);
            aTimer.Elapsed += OnTimerElapsed;
            aTimer.AutoReset = true;
            totalTime = TimeSpan.Zero;
        }

        private void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            totalTime += TimeSpan.FromMilliseconds(100);

            Display.Dispatcher.Invoke(() =>
            {
                Display.Content = totalTime.TotalSeconds.ToString();
            });
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            startTime = DateTime.Now;
            aTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            totalTime = TimeSpan.Zero;
            aTimer.Enabled = false;
            Display.Content = string.Empty;
        }
    }
}
