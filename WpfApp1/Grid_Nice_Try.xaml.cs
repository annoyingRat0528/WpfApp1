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
    /// Grid_Nice_Try.xaml 的交互逻辑
    /// </summary>
    public partial class Grid_Nice_Try : Window
    {
        public Grid_Nice_Try()
        {
            InitializeComponent();
            //ColumnDefinition  can be "x*" related with other (Ratio)
            //                  can be "0.xx" as percentage
            //                  can be an absolute value
        }
    }
}
