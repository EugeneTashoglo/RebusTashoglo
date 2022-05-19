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
    /// Логика взаимодействия для Физкультура.xaml
    /// </summary>
    public partial class Физкультура : Window
    {
        public Физкультура()
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
            if (eee.Text == "Физкультура")
            {
                eee.Background = Brushes.LightGreen;
            }
            else
            {
                eee.Background = Brushes.Red;
            }
            if (eee1.Text == "Спорт")
            {
                eee1.Background = Brushes.LightGreen;
            }
            else
            {
                eee1.Background = Brushes.Red;
            }
            if (eee2.Text == "Коньки")
            {
                eee2.Background = Brushes.LightGreen;
            }
            else
            {
                eee2.Background = Brushes.Red;
            }
        }
    }
}
