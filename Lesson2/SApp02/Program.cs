using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
	//Мухаметшин Евгений

	//Условия
	//Написать метод подсчета количества цифр числа.
	class Program
	{
		static int Numbers(){
			int number = Convert.ToInt32(Console.ReadLine());
			int count = 0;
			while (number > 0)
				{
					count++;
					number = number / 10;
				}
			return count;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Numbers());
		}
	}
}
