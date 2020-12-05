using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp04
{
	//Мухаметшин Евгений 

	//Условия
	/*Написать программу обмена значениями двух переменных:
		а) с использованием третьей переменной;*/

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число А: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите число B: ");
			int b = Convert.ToInt32(Console.ReadLine());

			int c = a;
			a = b;
			b = c;

			Console.WriteLine("Число A = " + a + "Число B = " + b);

			//б) *без использования третьей переменной.

			Console.WriteLine("Введите число А: ");
			int a1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите число B: ");
			int b1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Число A = " + b1 + "Число B = " + a1);

		}
	}
}
