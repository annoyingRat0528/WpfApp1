using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// AmericanPresident.xaml 的交互逻辑
    /// </summary>
    public partial class AmericanPresident : Window
    {
        public AmericanPresident()
        {
            InitializeComponent();
        }

        bool IsChecked1=false;
        bool IsChecked2 = false;
        bool IsAdCreated=false;
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (!IsChecked1) {
                IsChecked1= true;
                Q1.Background=Brushes.Gold;
                Q1.Inlines.Add(new Run(" (done)"));
            }
            if (!IsAdCreated && IsChecked1)
            {
                CreateAd();
                IsAdCreated = true;
            } 
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (!IsChecked2)
            {
                IsChecked2 = true;
                Q2.Background = Brushes.Gold;
                Q2.Inlines.Add(new Run(" (done)"));
            }

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            if (IsChecked1)
            {
                RadioButton_Checked_2(sender, e);
                MessageBox.Show("How we did wrong?", "Question", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        int tariff = 1;
        bool isRepeating = true;
        bool isVirus = false;
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            RadioButton_Checked_2(sender, e);
            if (IsChecked1) {
                while (isRepeating)
                {
                    Repeat();
                }
            }
        }

        private async void Repeat()
        {
            if (tariff == 0)
            {
                MessageBox.Show("TARIFF FREE", "SURPRISE", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                isVirus=true;
            }
            else
            {
                MessageBox.Show($"Tariff is now {tariff} times than before!", "Message from President");
                tariff *= 2;
            }
            while (isVirus) { CreateAd(); await Task.Delay(500);}
            
        }

        private void CreateAd()
        {
            var dialog = new iPhone_16();
            dialog.Show();
            
        }
    }
}
