using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
	//Мухаметшин Евгений

	//Условия
	//Написать метод, возвращающий минимальное из трёх чисел
	class Program
	{
		static int minNumbers (int a, int b, int c)
		{
			int min = 0;
			if(a < b && a < c){
				min = a;
				return min;
			}else if(b < a && b < c){
				min = b;
				return min;
			}else if(c < a && c < b){
				min = c;
				return min;
			}else{
				min = 0;
				return min;
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите число 1: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите число 2: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите число 3: ");
			int c = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Минимальное число = " + minNumbers(a,b,c));

		}
	}
}
