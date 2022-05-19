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

namespace RebusTashoglo
{
    /// <summary>
    /// Логика взаимодействия для Русский_язык.xaml
    /// </summary>
    public partial class Русский_язык : Window
    {
        public Русский_язык()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (num1.Text == "Глагол")
            {
                num1.Background = Brushes.LightGreen;
            }
            else
            {
                num1.Background = Brushes.Red;
            }
            if (num2.Text == "Суффикс")
            {
                num2.Background = Brushes.LightGreen;
            }
            else
            {
                num2.Background = Brushes.Red;
            }
            if (num3.Text == "Прилагательное")
            {
                num3.Background = Brushes.LightGreen;
            }
            else
            {
                num3.Background = Brushes.Red;
            }
        }


    }
}
