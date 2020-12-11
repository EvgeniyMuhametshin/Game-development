using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
	//Мухаметшин Евгений

	//Условия
	/*а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
	б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/
	class Complex
	{
		private double _im;
		public double Re{get; set;}

		public double Im
		{
			get {return _im;}
			set {
				if(value > 0)
					_im = value;
				else 
					throw new Exception("Минимальная часть комплексного числа > 0");
			}
		}

		public Complex(double re, double im){
			Re = re;
			if(im > 0)
				this._im = im;
			else
				throw new Exception("Минимальная часть комплексного числа должна быть > 0");
		}

		public Complex(){
		
		}

		public Complex Plus(Complex x){
			Complex y = new Complex();
			y.Re = Re + x.Re;
			y._im = _im + x._im;
			return y;
		}

		public Complex Minus(Complex x){
			Complex y = new Complex();
			y.Re = Re - x.Re;
			y._im = _im - x._im;
			return y;
		}

		public Complex Composition(Complex x){
			Complex y = new Complex();
			y.Re = Re * x.Re;
			y._im = _im * x._im;
			return y;
		}

		public override string ToString()
		{
			return $"{Re} + {_im}i";
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Complex complex1 = new Complex(-2, 5);

			Complex complex2 = new Complex(10, 1);

			Console.WriteLine($"Работа с комплексными числами: {complex1} и {complex2}");
			Console.WriteLine($"Результат сложения комплексных чисел: {complex1.Plus(complex2)}");
			Console.WriteLine($"Результат вычетания комплексных чисел: {complex1.Minus(complex2)}");
			Console.WriteLine($"Результат произведения комплексных чисел: {complex1.Composition(complex2)}");
			Console.ReadLine();
		}
	}
}
