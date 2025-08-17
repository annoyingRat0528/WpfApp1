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
    /// Cat_Ages.xaml 的交互逻辑
    /// </summary>
    public partial class Cat_Ages : Window
    {
        public Cat_Ages()
        {
            InitializeComponent();
        }
            string resultHumanAge = "";

        private void InputCatAge_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Enter)
                {
                    int inputCatAge = Int32.Parse(InputCatAge.Text);

                    if(inputCatAge >= 0 && inputCatAge <= 1)
                    {
                        resultHumanAge = "0-15";
                        DisplayAge();
                    }
                    else if(inputCatAge >=2 && inputCatAge < 25)
                    {
                        resultHumanAge = (((inputCatAge - 2) * 4) + 24).ToString();
                        DisplayAge();
                    }
                    else
                    {
                        ResultTextBlock.Text = "You entered a value that is not between 0-25." +
                                                "Your cat cannot be super old or not yet born!";
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Not a valid number, please enter a numeric value!\n" + ex);
            }
        }

        private void DisplayAge()
        {
            ResultTextBlock.Text = "Your cat is " + resultHumanAge + " years old";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextDelete.Text = "";
        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ComboBoxItem comboBoxItem = (ComboBoxItem)comboBox.SelectedItem;
            string newFontSize = (string)comboBoxItem.Content;

            int temp;
            if (Int32.TryParse(newFontSize, out temp)) {
                if (TextDelete != null) {
                    TextDelete.FontSize = temp;
                }
            }
        }


        private void MenuItemCheck_Checked(object sender, RoutedEventArgs e)
        {
            TextDelete.TextDecorations = TextDecorations.Underline;
        }

        private void MenuItemCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            TextDelete.TextDecorations = null;
        }

        private void MenuItemItalic_Checked(object sender, RoutedEventArgs e)
        {
                TextDelete.FontStyle = FontStyles.Italic;

        }

        private void MenuItemItalic_Unchecked(object sender, RoutedEventArgs e)
        {
                TextDelete.FontStyle = FontStyles.Normal;
        }

        private void MenuItemBold_Checked(object sender, RoutedEventArgs e)
        {
                TextDelete.FontWeight = FontWeights.Bold;
        }

        private void MenuItemBold_Unchecked(object sender, RoutedEventArgs e)
        {
                TextDelete.FontWeight = FontWeights.Normal;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ButtonNameChange.Content = "Don't click me anymore!";
            ButtonNameChange.IsEnabled = false;
        }

        bool isFullyLoaded;
        private void CheckIsLoaded()
        {
            if (Progress.Value == 100)
            {
                isFullyLoaded= true;
            }
            else
            {
                isFullyLoaded= false;
            }

            if (isFullyLoaded)
            {
                LoadStatus.Content = "Done!";
            }
            else
            {
                LoadStatus.Content = "Loading...";
            }
        }
        private void ButtonNameChange_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value += 10;
            CheckIsLoaded();
        }

        private void Decrease_Click(object sender, RoutedEventArgs e)
        {
            Progress.Value -= 10;
            CheckIsLoaded();
        }
    }
}
