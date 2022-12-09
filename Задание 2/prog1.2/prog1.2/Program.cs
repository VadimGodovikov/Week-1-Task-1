using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1._2
{
	class Program
	{
		private static int readInt()
		{
			do
			{
				int result;
				bool parsed = int.TryParse(Console.ReadLine(), out result);
				if (parsed) return result;
				else Console.WriteLine("Введите корректное число");
			} while (true);
		}

		static void Main(string[] args)
		{
			x1: Console.WriteLine("Введите двухзначное число: ");
			int x = readInt();
			if((x > -10 || x < -99) && (x < 10 || x > 99))
			{
				Console.WriteLine("Х не должен быть меньше +-10 и больше +-99");
				goto x1;
			}

			int res = 0;
			while(Math.Abs(x) > 0)
			{
				res += x % 10;
				x = x / 10;
			}

			Console.WriteLine(Math.Abs(res));

			if (res % 2 == 0)
			{
				Console.WriteLine("Сумма цифр числа: четная");
			}
			else Console.WriteLine("Сумма цифр числа: нечетная");

		}
	}
}
