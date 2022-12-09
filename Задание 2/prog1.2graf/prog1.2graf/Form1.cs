using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog1._2graf
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";

			int x = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			if ((x > -10 || x < -99) && (x < 10 || x > 99))
			{
				MessageBox.Show("Х не должен быть меньше +-10 и больше +-99");
				return;
			}

			int res = 0;
			while (Math.Abs(x) > 0)
			{
				res += x % 10;
				x = x / 10;
			}
			if (res % 2 == 0)
			{
				textBox2.Text += $"Сумма цифр вашего числа: {Math.Abs(res)}\r\nОна является Четным." + Environment.NewLine;
			}
			else textBox2.Text += $"Сумма цифр вашего числа: {Math.Abs(res)}\r\nОна является Нечетным." + Environment.NewLine;

		}
	}
}
