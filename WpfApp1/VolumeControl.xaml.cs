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
    /// VolumeControl.xaml 的交互逻辑
    /// </summary>
    public partial class VolumeControl : Window
    {
        public VolumeControl()
        {
            InitializeComponent();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VolumeIndicator != null)
            {
                VolumeIndicator.Text = "Volume is now: " + VolumeSlider.Value.ToString();
            }
        }

        private void ChargeLimit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ChargelimitIndicator != null)
            {
                ChargelimitIndicator.Text = "Charge limit: " + ChargeLimit.Value.ToString();
            }
        }
    }
}
