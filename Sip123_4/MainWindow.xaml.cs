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
using System.Windows.Threading;

namespace Sip123_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long points = 1000;
        int PPC = 1;
        DispatcherTimer timer = new DispatcherTimer();
        double sol_b1;
        double sol_b2;
        double sol_b3;
        double sol_b4;
        double sol_b5;
        double sol_b6;
        double sol_b7;
        double sol_b8;
        double sol_b9;
        double sol_b10;
        double sol_b11;
        double sol_b12;
        double sol_b13;
        double sol_b14;
        double sol_b15;
        double sol_b16;

        public MainWindow()
        {
            InitializeComponent();
            sol_b1 = 10 + 10 * (30 + PPC * 0.2);
            sol_b2 = 20 + 20 * (60 + PPC * 0.4);
            sol_b3 = 30 + 30 * (90 + PPC * 0.6);
            sol_b4 = 40 + 40 * (120 + PPC * 0.8);
            sol_b5 = 50 + 50 * (150 + PPC * 1);
            sol_b6 = 60 + 60 * (180 + PPC * 1.2);
            sol_b7 = 70 + 70 * (210 + PPC * 1.4);
            sol_b8 = 80 + 80 * (240 + PPC * 1.6);
            sol_b9 = 90 + 90 * (270 + PPC * 1.8);
            sol_b10 = 100 + 100 * (300 + PPC * 2);
            sol_b11 = 110 + 110 * (330 + PPC * 2.2);
            sol_b12 = 120 + 120 * (360 + PPC * 2.4);
            sol_b13 = 130 + 130 * (390 + PPC * 2.6);
            sol_b14 = 140 + 140 * (420 + PPC * 2.8);
            sol_b15 = 150 + 150 * (450 + PPC * 3);
            sol_b16 = 160 + 160 * (480 + PPC * 3.2);

            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += Timer_Tick;
            timer.Start();
            Update();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            points += PPC;
            Update();
        }

        public void Update()
        {
            lPoints.Content = $"Очков: {points}";
            lPPC.Content = $"Очков за клик: {PPC}";
            btUp1.Content = sol_b1;
            btUp2.Content = sol_b2;
            btUp3.Content = sol_b3;
            btUp4.Content = sol_b4;
            btUp5.Content = sol_b5;
            btUp6.Content = sol_b6;
            btUp7.Content = sol_b7;
            btUp8.Content = sol_b8;
            btUp9.Content = sol_b9;
            btUp10.Content = sol_b10;
            btUp11.Content = sol_b11;
            btUp12.Content = sol_b12;
            btUp13.Content = sol_b13;
            btUp14.Content = sol_b14;
            btUp15.Content = sol_b15;
            btUp16.Content = sol_b16;
        }

        public void BuyUp(Button bt)
        {
            
            long price = long.Parse(bt.Content.ToString());
            if (points >= price)
            {
                points -= price;
                PPC += Convert.ToInt32(price / 100);
            }
            Update();
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

       

        
        private void imgCat_MouseDown(object sender, MouseButtonEventArgs e)
        {
            points += PPC;
            Update();
        }

        private void btUp1_Click(object sender, RoutedEventArgs e)
        {
            BuyUp(sender as Button);
        }
    }
}
