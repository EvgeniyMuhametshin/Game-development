using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp03
{	
	//Мухаметшин Евгений

	//Условия
	//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
	class Program
	{
		static void Main(string[] args)
		{
            int b = 0;
            while (true)
            {
                Console.Write("Введите число: \n" + "Для выходы введите 0\n");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    if (a % 2 == 0)
                    { }
                    else
                    {
                        b += a;
                    }
                }
                else
                {
                    break;
                }
		    }
            Console.WriteLine(b);
		}
		
    }
}

