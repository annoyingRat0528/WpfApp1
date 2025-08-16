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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// iPhone_16.xaml 的交互逻辑
    /// </summary>
    public partial class iPhone_16 : Window
    {
        public iPhone_16()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri)
                {
                    UseShellExecute = true
                });
                e.Handled = true;
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show($"打开链接失败：{ex.Message} (错误代码: {ex.NativeErrorCode})", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
