using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
	//Мухаметшин Евгений

	//Условия
	/*Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
	Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).*/

	public delegate double inFunkhin(double a, double b);

	class Program
	{
		//Принимающий делегат
		public static void inTable(inFunkhin C, double a, double x, double b)
		{
			Console.WriteLine("----- A ------ X ------ Y ------");
			while (x <= b)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, C(a, x));
				x += 1;
			}
			Console.WriteLine("----------------------------");
		}

		//a*x^2
		public static double myFunkhin(double a, double x)
		{
			return a * x * x;
		}

		//a*sin(x)
		public static double mySin(double a, double x)
		{
			return a * Math.Sin(x);
		}

		static void Main(string[] args)
		{
			//New delegate
			Console.WriteLine("Функции a*x^2: ");
			inTable(new inFunkhin(myFunkhin), -1.5, -2, 2);

			Console.WriteLine("Функции a*sin(x): ");
			inTable(new inFunkhin(mySin), 3, -2, 2);

			Console.ReadKey();
		}
	}
}
