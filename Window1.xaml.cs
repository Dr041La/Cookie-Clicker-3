using Microsoft.SqlServer.Server;
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

namespace Cookie_Clicker_3
{
	/// <summary>
	/// Логика взаимодействия для Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (ClickPower.Score >= ClickPower.price1)
			{
				ClickPower.Click_Power += 1;
				ClickPower.Score -= ClickPower.price1;
				ClickPower.price1 *= 2;
			}

		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			if (ClickPower.Score >= ClickPower.price2)
			{
				ClickPower.Cookies_Per_Sec += 1;
				ClickPower.Score -= ClickPower.price2;
				ClickPower.price2 *= 2;
			}
		}

		private void b3_Click(object sender, RoutedEventArgs e)
		{
			if (ClickPower.Score >= ClickPower.price3)
			{
				ClickPower.Cookies_Per_Sec += 10;
				ClickPower.Score -= ClickPower.price3;
				ClickPower.price3 *= 2;
			}
		}

		private void b4_Click(object sender, RoutedEventArgs e)
		{
			if (ClickPower.Score >= ClickPower.price4)
			{
				ClickPower.Cookies_Per_Sec += 100;
				ClickPower.Score -= ClickPower.price4;
				ClickPower.price4 *= 2;
			}
		}

		private void b5_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
		}
	}
}
