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

namespace prog1._1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double v = double.Parse(numericUpDown1.Text, NumberStyles.Float);
			double a = Math.Pow(v, 1.0 / 3.0);

			if(v <= 0)
			{
				MessageBox.Show("Объём не должен быть меньше или равен 0");
				return;
			}

			textBox2.Text = $"Объём куба равен: {v}\r\nРезультат вычисления: \r\nРебро куба равняется: {a}";

		}
	}
}
