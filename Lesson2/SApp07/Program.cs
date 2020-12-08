using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp07
{
	//Мухаметшин Евгений

	//Условия
	/*a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
	б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
	class Program
	{
		static void Main(string[] args)
		{

			Loop(3, 13);

		}

		static void Loop(int a, int b)
		{
			Console.Write("{0,4} ", a);
			if (a < b) Loop(a + 1, b);
		}


		}
}
