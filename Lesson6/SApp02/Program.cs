using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace SApp02
{
	//Мухаметшин Евгений

	//Условия
	/*Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
		а) Сделайте меню с различными функциями и предоставьте пользователю выбор,
		для какой функции и на каком отрезке находить минимум.
		б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
		в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.
		Пусть она возвращает минимум через параметр.*/

	public delegate double InFun(double x);

	class Program
	{
		//Метод расчета значений
		public static void SaveFun(string fileName, double start, double end, double step, InFun F)
		{
			FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			while (start <= end)
			{
				bw.Write(F(start));
				start += step;
			}
			bw.Close();
			fs.Close();
		}

		//Массив значения файла возврат
		public static double[] Load(string fileName, out double min)
		{
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader bw = new BinaryReader(fs);
			double[] array = new double[fs.Length / sizeof(double)];
			min = double.MaxValue;
			double d;
			for (int i = 0; i < fs.Length / sizeof(double); i++)
			{
				d = bw.ReadDouble();
				array[i] = d;
				if (d < min) min = d;
			}
			bw.Close();
			fs.Close();
			return array;
		}

		//Возведение в квадрат
		static double secondDegree(double x)
		{
			return x * x;
		}

		//Возведение в третью степень
		static double thirdDegree(double x)
		{
			return x * x * x;
		}

		//Квадратный корень
		static double mySqrt(double x)
		{
			return Math.Sqrt(x);
		}

		//Синус
		static double Sin(double x)
		{
			return Math.Sin(x);
		}

		//Проверка ввода значения
		static int GetInt(int max)
		{
			while (true)
			{
				if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
					Console.Write("Неверный ввод");
				else return x;
			}
		}

		//Получает значения начала отрезка и конца строки
		static void GetInterval(out double start, out double end)
		{
			string[] interval = Console.ReadLine().Split(' ');
			start = double.Parse(interval[0], CultureInfo.InvariantCulture);
			end = double.Parse(interval[1], CultureInfo.InvariantCulture);
		}

		//Вывод на экран значение функции
		static void PrintResult(double start, double end, double step, double[] values)
		{
			Console.WriteLine("--------- X -------- Y -----");
			int index = 0;
			while (start <= end)
			{
				Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", start, values[index]);
				start += step;
				index++;
			}
			Console.WriteLine("------------------------------");
		}

		static void Main(string[] args)
		{
			List<InFun> functions = new List<InFun> { new InFun(secondDegree), new InFun(thirdDegree), new InFun(mySqrt), new InFun(Sin) };
			Console.WriteLine("Выберети функцию");
			Console.WriteLine("1. f(x) = y^2");
			Console.WriteLine("2. f(x) = y^3");
			Console.WriteLine("3. f(x) = y^1/2");
			Console.WriteLine("4. f(x) = Sin(y)");
			int userChoose = GetInt(functions.Count);

			Console.WriteLine("Задайте отрезок для нахождения минимума (x1, x2)");
			double start = 0;
			double end = 0;
			GetInterval(out start, out end);

			Console.WriteLine("Задайте величине шага");
			double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			SaveFun("data.bin", start, end, step, functions[userChoose-1]);
			double min = double.MaxValue;
			Console.WriteLine("Получены значения функции: ");
			PrintResult(start, end, step, Load("data.bin", out min));
			Console.WriteLine("Минимальное значение равно: {0:0.00}", min);
			Console.ReadKey();
		}
	}
}
