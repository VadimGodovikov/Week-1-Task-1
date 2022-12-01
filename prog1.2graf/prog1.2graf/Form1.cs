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
			int x = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			int res = 0;
			while (x > 0)
			{
				res += x % 10;
				x = x / 10;
			}
			if (res % 2 == 0)
			{
				textBox2.Text = $"Сумма цифр вашего числа: {res}\r\nОна является Четным.";
			}
			else textBox2.Text = $"Сумма цифр вашего числа: {res}\r\nОна является Нечетным.";

		}
	}
}
