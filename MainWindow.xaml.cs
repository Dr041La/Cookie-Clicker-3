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
        string mbtext;

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
			label1.Content = mbtext + " " + ClickPower.Score.ToString();
            window.b1.Content = ClickPower.price1 + " " + mbtext;
			window.b2.Content = ClickPower.price2 + " " + mbtext;
			window.b3.Content = ClickPower.price3 + " " + mbtext;
			window.b4.Content = ClickPower.price4 + " " + mbtext;

            if (this.IsLoaded == false)
            {
                window.Close();
            }
		}

        private void MainButton_Click(object sender, RoutedEventArgs e)
        {
            ClickPower.Score += ClickPower.Click_Power;
			label1.Content = mbtext + " " + ClickPower.Score.ToString();
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window.Show();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
			Grinder.Background = new SolidColorBrush(Color.FromArgb(70, 255, 102, 102));
		}

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
			Grinder.Background = new SolidColorBrush(Color.FromArgb(70, 229, 255, 204));
		}

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
			Grinder.Background = new SolidColorBrush(Color.FromArgb(70, 255, 204, 255));
		}

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
			window.Show();
		}

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbox.SelectedIndex == 0)
            {
                MainButton.Background = new SolidColorBrush(Color.FromArgb(100, 100, 255, 100));
            }

			if (cbox.SelectedIndex == 1)
			{
				MainButton.Background = new SolidColorBrush(Color.FromArgb(100, 100, 100, 255));
			}

			if (cbox.SelectedIndex == 2)
			{
				MainButton.Background = new SolidColorBrush(Color.FromArgb(100, 255, 100, 100));
			}
		}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            mbtext = tb1.Text;
        }
    }
}
