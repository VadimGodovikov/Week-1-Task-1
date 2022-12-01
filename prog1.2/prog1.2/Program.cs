using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1._2
{
	class Program
	{
		
		static void Main(string[] args)
		{
			x1: Console.WriteLine("Введите двухзначное число: ");
			int x = int.Parse(Console.ReadLine());
			if(x < 10 || x > 99)
			{
				Console.WriteLine("Х не должен быть меньше 10 и больше 99");
				goto x1;
			}

			int res = 0;
			while(x > 0)
			{
				res += x % 10;
				x = x / 10;
			}

			if (res % 2 == 0)
			{
				Console.WriteLine("Сумма цифр числа: четная");
			}
			else Console.WriteLine("Сумма цифр числа: нечетная");

		}
	}
}
