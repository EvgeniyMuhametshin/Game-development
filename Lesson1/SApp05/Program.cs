using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp05
{
	//Мухаметшин Евгений

	//Условия
	 /*	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
		б) * Сделать задание, только вывод организовать в центре экрана.
		в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).*/
	class Program
	{
		static void Print(string msg, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(msg);
		}

		static void Main(string[] args)
		{
			
			Print($"Мухаметшин Евгений, город Санкт-Петербург ", 40, 15);
			Console.ReadLine();

		}
	}
}
