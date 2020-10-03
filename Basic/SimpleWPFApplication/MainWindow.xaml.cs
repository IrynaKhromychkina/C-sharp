using System.Windows;

namespace Simple.WPF.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoveText_Click(object sender, RoutedEventArgs e)
        {
            Target.Text = Source.Text;
            Source.Text = "";
        }
    }
}
