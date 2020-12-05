using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{
	//Мухаметшин Евгений

	//Условия
	//а) Написать программу, которая подсчитывает расстояние между точками с координатами 
	//x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
	//Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
	class Program
	{
		/*static double CalcDist(double x1, double y1, double x2, double y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));	//Решение с методом
		}*/

		static void Main(string[] args)
		{
			

			Console.Write("Введите значение x1 ");
			double x1 = Convert.ToDouble(Console.ReadLine());		
			Console.Write("Введите значение y1 ");
			double y1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите значение x2 ");
			double x2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите значение y2 ");
			double y2 = Convert.ToDouble(Console.ReadLine());

			/*Console.WriteLine("Расстояние между точками = {0;f}", r);
			Console.ReadLine();*/

			double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
			Console.WriteLine("Расстояние между точками = {0:f}", r);		//Решение без метода
		}
	}
}
