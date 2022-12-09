using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1._1
{
	class Program
	{
		private static double readDouble()
		{
			do
			{
				double result;
				bool parsed = double.TryParse(Console.ReadLine(), out result);
				if (parsed) return result;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}
		static void Main(string[] args)
		{

			v1: Console.WriteLine("Введите объём куба: ");
			double v = readDouble();

			if(v <= 0)
			{
				Console.WriteLine("Объём куба не может быть равен нулю и быть меньше нуля.");
				goto v1;
			}

			double a = Math.Pow(v, 1.0/3.0);
			Console.WriteLine($"Ребро куба равняется: {a}");

		}
	}
}
