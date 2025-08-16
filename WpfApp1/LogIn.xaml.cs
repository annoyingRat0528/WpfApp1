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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// LogIn.xaml 的交互逻辑
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private string correctPassword = "shuge666-";


        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            string input = Pswdbox.Password;
            if (input == correctPassword)
            {
                var success = new AmericanPresident();
                success.Show();
            }
            else
            {
                MessageBox.Show("Password or Username is invalid!","",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void WtHs_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WtHs.Source = new BitmapImage(
                new Uri(@"/WpfApp1;component/Images/Picture.png", UriKind.Relative));
        }
    }
}
