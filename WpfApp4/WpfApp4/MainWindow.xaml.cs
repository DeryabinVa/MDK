using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp4.Windows;


namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, e) => { TIME.Text = DateTime.Now.ToLongTimeString(); };
            timer.Start();
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            WindowSettings window = new WindowSettings();
            window.Show();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void btn_page1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1 ());
        }

        private void btn_page2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page2 ());
        }

        private void btn_page3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page3());
        }
    }
}
