using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp01
{
	
	//Мухаметшин Евгений

	//Условия
	/*Дан целочисленный массив из 20 элементов.
	 Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
	Написать программу, позволяющую найти и вывести количество пар элементов массива, 
	в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд 
	идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.*/
	class Program
	{
		static int inputNumbers(int[] array, int length) 
		{

			int numbers = 0;
			for (int i = 0; i < length - 1; i++)
			{

				if (array[i] % 3 == 0 || array[i + 1] % 3 == 0) 
				{

					numbers++;
				
				}

			}

			return numbers;
		
		}
		
		static void Main(string[] args)
		{

			const int aLength = 20;
			int[] mArray = new int[aLength];
			Random rand = new Random();
			int result;

			/*Console.WriteLine("");
			Console.Write("");*/
			for (int i = 0; i < aLength; i++) 
			{

				mArray[i] = rand.Next(-10000, 10001);
				Console.Write(mArray[i] + ",");
			
			}
			Console.WriteLine("");
			result = inputNumbers(mArray, aLength);

			Console.WriteLine($"Количество пар: {result}");
			Console.ReadKey();

		}
		
	}
}
