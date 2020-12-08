using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp05
{
	//Мухаметшин Евгений
	
	//Условия
	/*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
	б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ваша ваш рост (м.)?");
			double height = Double.Parse(Console.ReadLine());

			Console.WriteLine("Ваша ваш вес (кг.)?");
			double weight = Double.Parse(Console.ReadLine());

			double index = weight / (height * height);
			double a = Convert.ToDouble(10000);
			double _index = index * a;
			double i = (Double)Math.Floor(_index * 100) / 100.0;

			//>=18.5 & < 25 Нормальный вес
			//< 18.5 Маленький вес
			//>=25 & < 30 Большой вес
			if (_index < 18.5)
			{
				Console.WriteLine("Вам нужно набрать вес");
			}
			else if (_index >= 18.5 && _index < 25)
			{
				Console.WriteLine("Вашь вес в норме");
			}
			else if (_index >= 25 && _index < 30)
			{
				Console.WriteLine("У вас ожирение");
			}
			Console.WriteLine("Ваш индекс массы тела: " + i);

			/*double upWeight = height - 100;
			double upWeight1 = upWeight - weight;

			Console.WriteLine("До нормального веса вам надо набрать: " + upWeight1);*/

		}
	}
}
