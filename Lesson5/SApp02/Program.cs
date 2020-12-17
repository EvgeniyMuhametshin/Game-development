using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
	//Мухаметшин Евгеницй

	//Условия
	/*Разработать класс Message, содержащий следующие статические методы для обработки
	текста:
		а) Вывести только те слова сообщения, которые содержат не более n букв.
		б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
		в) Найти самое длинное слово сообщения.
		г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
	Продемонстрируйте работу программы на текстовом файле с вашей программой.*/

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\nТекст: \n" + Message.text);
			
			Console.WriteLine("\nСлова текста не более пяти букв: \n");
			Message.GetWordsByLength(5);

			Console.WriteLine();
			Console.Write("\nУдалим из текста слова заканчивающиеся на 'я': \n");
			Message.DeleteWordByEndChar('я');

			Console.WriteLine("\nСамое длинное слово в тексте: \n" + Message.FindMaxLengthWord());

			Console.Write("\nСтрока StringBuilder из длинных слов: \n" + Message.GetLongWordsString());

			Console.WriteLine("\nПроизведем частотный анализ текста: ");
			string[] arr = {"неё", "на", "вешали", "дети", "Дед Мороз"};
			Message.FrequencyAlalysis(arr, Message.text);

			Console.ReadKey();
		}
	}
}
