using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //myTextBlock.Text = "Hello there.";
            //myTextBlock.Foreground = Brushes.Blue;
            myTextBlock.Inlines.Add(new Run(" Run text that I added in code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            myTextBlock.TextWrapping = TextWrapping.Wrap;
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
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Text = "Great Phone. Everything works so well";
            MyButton.Content = "Successfully Generated!";
            MyButton.IsEnabled= false;
            revLabel.Foreground = Brushes.Gold;
        }

        private void Enlarge_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.FontSize += 1;
        }

        private void Smaller_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyTextBox.FontSize -= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot be smaller anymore......", "Sorry", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void MyButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MyButton.IsEnabled)
                MyTextBox.Text = "Changes will be shown here.";
        }

        private void MyButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (MyButton.IsEnabled)
                MyTextBox.Text = null;
        }


        private void ToLeaveName()
        {
            MyButton.Content = "Click to generate good review";
            MyButton.IsEnabled = true;
            MessageBox.Show("Cannot leave name", "Sorry", MessageBoxButton.OK);
            cbLeaveName.IsChecked= false;
        }

        private void cbParent_Checked(object sender, RoutedEventArgs e)
        {
            cbStateOriginal();
            CheckState();
            cbPostPublic.IsChecked = true;
            cbLeaveName.IsChecked = true;
            cbPlatform.IsChecked = true;
        }
        private void cbParent_Unchecked(object sender, RoutedEventArgs e)
        {
            cbStateOriginal();
            CheckState();
            cbPostPublic.IsChecked = false;
            cbLeaveName.IsChecked = false;
            cbPlatform.IsChecked = false;

        }
        private void cbParent_Indeterminate(object sender, RoutedEventArgs e)
        { 
            cbParent.Content = "Use delicated settings";
        }
        private void ItemChecked(object sender, RoutedEventArgs e)
        {
            CheckState();
        }

        private void ItemUnchecked(object sender, RoutedEventArgs e)
        {
            CheckState();
        }

        private void cbStateOriginal()
        {
            cbParent.Content = "Use recommended settings";
        }
        private void CheckState()
        {
            int checkedCount = 0;
            int totalCount = 3;
            if (cbPostPublic.IsChecked == true) checkedCount++;
            if (cbLeaveName.IsChecked == true) checkedCount++;
            if (cbPlatform.IsChecked == true) checkedCount++;

            // 根据勾选数量更新父项
            if (checkedCount == totalCount)
                cbParent.IsChecked = true;
            else if (checkedCount == 0)
                cbParent.IsChecked = false;
            else
                cbParent.IsChecked = null;
        }
    }
}