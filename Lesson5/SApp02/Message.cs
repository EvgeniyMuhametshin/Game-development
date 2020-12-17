using System;
using System.Text;
using System.Collections.Generic;

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

	static class Message
	{
		static public string text;
		static Message()
		{ 
			text = "Перед Новым Годом в детском саду нарядили красивую пушистую ёлочку. " +
				"Дети сами вешали на неё разные игрушки, шары, шишки, гирлянды и флажки. " +
				"А мальчик Саша надел на макушку ёлки красную звезду. " +
				"Дети с нетерпением ждали Деда Мороза и дружно кричали: «Дед Мороз!»." + 
				"Дед Мороз пришел к детишкам с большим мешком подарков. Подарков хватило всем. Повторим несколько слов для частотного анализа: неё, на, вешали, дети, Дед Мороз ";
		}

		//выводит слова определенной длины
		static public void GetWordsByLength(int len)
		{
			string[] words = text.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t' });
			foreach (string word in words)
			{
				if (word == "")
					continue;
				if (word.Length <= len)
					Console.Write(word + " ");
			}
		}
		
		//Удаляет из сообщения все слова которые заканчиваются на заданную букву
		static public void DeleteWordByEndChar(char ch)
		{
			string[] words = text.Split(new Char[] {' ', ',', '.', '-', '\n', '\t'});
			foreach(string word in words)
				{ 
					if(word == "")
						continue;
					if(word[word.Length - 1] == ch)
					{
						Console.Write(word + "");
						text.Replace(word, "");
					}
				}
		}

		//самое длинное слово
		static public string FindMaxLengthWord()
		{
			string[] words = text.Split(new Char[] {' ', ',', '.', '-', '\n', '\t'});	
			string maxWord = words[0];
			int max = words[0].Length;

			foreach(string word in words)
			{
				if(word.Length > max)
				{
					max = word.Length;
					maxWord = word;
				}
			}
			return maxWord;
		}
		
		//StringBuilder
		static public StringBuilder GetLongWordsString()
		{
			string[] words = text.Split(new Char[] {' ', ',', '.', '-', '\n', '\t'});
			StringBuilder result = new StringBuilder();
			int max = Message.FindMaxLengthWord().Length;
			foreach(string word in words)
			{
				if(word.Length == max)
				{
					result.Append(word.ToLower() + "");
				}
			}
			return result;
		}

		//Производит анализ текста
		static public void FrequencyAlalysis(string[] words, string text)
		{
			Dictionary<string, int> wordFrequence = new Dictionary<string, int>();

			string[] textWords = text.Split(new Char[] {' ', ',', '.', '-', '\n', '\t'});
			foreach(string word in words)
			{
				foreach(string wordInText in textWords)
				{
					if(word == "")
						continue;
					if(wordInText == word)
					{
						if(word == "")
							continue;
						if(wordFrequence.ContainsKey(word))
							wordFrequence[word] += 1;
						else
							wordFrequence.Add(word, 1);
					}
				}
			}

			ICollection<string> keys = wordFrequence.Keys;

			String result = String.Format("{0, -10} {1, -10}\n\n", "Слово", "Частота появления");
			foreach(string key in keys)
				result += String.Format("{0, -10} {1, -10:N0}\n", key, wordFrequence[key]);
			Console.WriteLine($"\n{result}");
		}
	}
}
