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

namespace knv1
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


        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            Class1 loginpass = new Class1();
            userwindow userwindow = new userwindow();

            if (txtBox.Text == loginpass.LoginUser() && pswBox.Password == loginpass.LoginUser();
            {
                userwindow.Show();
            }

            void exitBtn_Click(object sender, RoutedEventArgs e)
            {
               
            }
        }
    }
}


