using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
	//Мухаметшин Евгений

	//Условия:
	//Написать программу «Анкета». Последовательно задаются вопросы 
	//(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ваше имя и фамилия? ");
			var a = Console.ReadLine();
			Console.WriteLine("Здравствуйте " + a);
			Console.ReadLine();

			Console.WriteLine("Ваш возраст? ");
			var b = Console.ReadLine();

			Console.WriteLine("Ваш рост? ");
			var c = Console.ReadLine();

			Console.WriteLine("Ваш вес? ");
			var d = Console.ReadLine();

			Console.WriteLine("Имя, Фамилия: " + a + " Возраст: " + b + " Рост: " + c + " Вес: " + d);// используя  склеивание
			Console.ReadLine();

			Console.WriteLine("Имя, Фамилия: {0} Возраст: {1} Рост: {2} Вес: {3}",a,b,c,d);//используя форматированный вывод;
			Console.ReadLine();

			Console.WriteLine($"Имя, Фамилия: {a} Возраст: {b} Рост: {c} Вес: {d}");//используя вывод со знаком $.
			Console.ReadLine();

		}
	}
}
