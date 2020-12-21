using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace DVA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            Class1 loginpass = new Class1();
            Master master = new Master();
            User user = new User();
            Slesar slesar = new Slesar();
            bool error = true;

            if (parol.Password == loginpass.passUser)
            {
                master.Show();
                error = false;
            }

            if (parol.Password == loginpass.passUser2)
            {
                user.Show();
                error = false;

            }

            if (parol.Password == loginpass.passUser3)
            {
                slesar.Show();
                error = false;
            }
            if (error == true)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
