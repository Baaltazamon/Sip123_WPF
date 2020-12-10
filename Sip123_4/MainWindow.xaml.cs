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

namespace Sip123_4
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

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void tbFN_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890,-".IndexOf(e.Text) < 0;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lResult.Content = double.Parse(tbFN.Text) + double.Parse(tbSN.Text);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lResult.Content = double.Parse(tbFN.Text) - double.Parse(tbSN.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lResult.Content = double.Parse(tbFN.Text) * double.Parse(tbSN.Text);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lResult.Content = double.Parse(tbFN.Text) / double.Parse(tbSN.Text);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lResult.Content = double.Parse(tbFN.Text) * double.Parse(tbSN.Text) / 100;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            lResult.Content = Math.Sin(double.Parse(tbFN.Text));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tbFN.Clear();
            tbSN.Clear();
            lResult.Content = "0";
        }
    }
}
