using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
	//Мухаметшин Евгений

	//Условия
	//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
	//по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

	class Program
	{

		static void Main(string[] args)
		{

			Console.WriteLine("Ваша ваш рост (м.)?");
		double height = Double.Parse(Console.ReadLine());
		
		Console.WriteLine("Ваша ваш вес (кг.)?");
		double weight = Double.Parse(Console.ReadLine());
		
		double index = weight / (height * height);
		
		Console.WriteLine("Ваш индекс массы тела: " + index.ToString("N2"));



			/*Console.WriteLine("Ваш вес? ");
			int m = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ваш рост? ");
			int h = Convert.ToInt32(Console.ReadLine());

			int i = m/h^2;
			Console.WriteLine("ИМТ = {0:f}",i*10);
			
			Console.ReadLine();*/

		}
	}
}
