using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SApp01
{
	//Мухаметшин Евгений

	//Условия
	/*Создать программу, которая будет проверять корректность ввода логина.
	 * Корректным логином будет строка от 2 до 10 символов, 
	 * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
	а)	без использования регулярных выражений;
	б)	с использованием регулярных выражений.*/
	class Program
	{
		//отображение слова попытка
		static string RightTryWord(int x)
		{
			string s = "";
			if (x % 10 == 1 && x != 11) s += "попытка";
			else
				if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x >= 41 && x <= 45)) s += "попытки";
			else
				if ((x==11)||(x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x <= 41) || (x >= 44 && x <= 51)) s += "попытки";
			return s;
		}

		//проверяет на соответствие логина и пароля
		static bool CheckLogin(string login)
		{
			int length = login.Length;
			if (length >= 2 && length <= 10)
			{
				bool check = true;
				char letter = login[0];
				if (Char.IsDigit(letter))
					return false;
				for (int i = 1; i < length; i++)
				{
					letter = login[i];
					if (!(Char.IsDigit(letter) || IsLatinLetter(letter)))
					{
						check = false;
						break;
					}
				}
				if (check)
					return true;
			}
			return false;
		}

		//проверка логина через регулярное выражение
		static bool CheckLoginReg(string login)
		{
			char letter = login[0];
			if (Char.IsDigit(letter))
				return false;
			if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
				return false;
			else
				return true;
		}

		//проверка символов - латинские
		private static bool IsLatinLetter(char letter)
		{
			int num = letter;
			if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
				return true;
			else
				return false;
		}

		static void Main(string[] args)
		{
			int AmountOfTries = 3;

			do
			{
				Console.Write("Введите логин: ");
				string login = Console.ReadLine();
				if (CheckLogin(login) && CheckLoginReg(login))
				{
					Console.WriteLine();
					break;
				}
				else
				{
					AmountOfTries--;
					Console.WriteLine("Неверный логин\n ");
					Console.WriteLine("Условия:\n длина строки 2 до 10 символов;\n буквы только латинского алфавита или цифры;\n цифра не может быть первой."
						+ Environment.NewLine + "У вас осталось" + AmountOfTries + RightTryWord(AmountOfTries));
				}
			}
			while (AmountOfTries > 0);
			Console.WriteLine("Правельный логин");
			Console.ReadKey();
		}
	}
}
