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
    /// Calendar.xaml 的交互逻辑
    /// </summary>
    public partial class Calendar : Window
    {
        bool dpIsInitailized = false;
        public Calendar()
        {
            InitializeComponent();
            MyTextblock.Text = myCalendar.SelectedDate.ToString();
            dpIsInitailized = true;
        }

        private void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyTextblock != null)
            {
                MyTextblock.Text = myCalendar.SelectedDate.ToString();
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as DatePicker).SelectedDate != null && dpIsInitailized)
            {
                string myDate = (sender as DatePicker).SelectedDate.ToString();
                MessageBox.Show("Date has been changed to: " + myDate);
            }
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Expanded");
        }
    }
}
