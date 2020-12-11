using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    //Мухаметшин Евгений

    //Условия
   /*а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
        При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/
	class Program
	{   

        #region Проверка ввода с исключением неправельного ввода.
        static int AddNumbers()
        {
            int result = 0;
            bool _Numbers;
            do
            {
                _Numbers = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception n)
                {
                    _Numbers = true;
                    string mes = n.Message;
                    Console.WriteLine("Введите число: " + mes);
                    Console.Write("Повторите ввод: ");
                }
            }
            while(_Numbers);
            return result;
        }
        #endregion

		static void Main(string[] args)
		{
            
            Console.Write("Введите число: \n" + "Для выходы введите 0\n");
            int b = 0;
            while (true)
            {
                int a = AddNumbers();
                if (a == 0)
                {
                    break;
                }
                else if (a > 0 && a % 2 ==1)
                {
                    b++;
                }
            }
            Console.WriteLine("Количество чисел: " + b);
            Console.ReadLine();
        }
	}
}
