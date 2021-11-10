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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4._1___
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = pervoe.Text;
            string b = vtoroe.Text;
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c = a1 + b1;
            int c1 = Convert.ToInt32(c);
            vivod.Content = c1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = pervoe.Text;
            string b = vtoroe.Text;
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c = a1 - b1;
            int c1 = Convert.ToInt32(c);
            vivod.Content = c1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = pervoe.Text;
            string b = vtoroe.Text;
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c = a1 * b1;
            int c1 = Convert.ToInt32(c);
            vivod.Content = c1;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //string a = pervoe.Text;
            //string b = vtoroe.Text;
            //double a1 = double.Parse(a);
            //double b1 = double.Parse(b);
            //double c = a1/b1;
            //double c1 = Convert.ToDouble(c);
            //vivod.Content = c1;
        }

        private void pervoe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void vtoroe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
