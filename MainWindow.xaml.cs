using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cookie_Clicker_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		Window1 window = new Window1();

        public MainWindow()
        {
            InitializeComponent();
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval += new TimeSpan(10000000);
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        public void timerTick(object sender, EventArgs e)
        {
            ClickPower.Score += ClickPower.Cookies_Per_Sec;
			label1.Content = ClickPower.Score.ToString();
            window.b1.Content = ClickPower.price1 + " печенек";
			window.b2.Content = ClickPower.price2 + " печенек";
			window.b3.Content = ClickPower.price3 + " печенек";
			window.b4.Content = ClickPower.price4 + " печенек";
		}

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            ClickPower.Score += ClickPower.Click_Power;
			label1.Content = ClickPower.Score.ToString();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window.Show();
        }
    }
}
