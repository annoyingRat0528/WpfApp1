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
    }
}
