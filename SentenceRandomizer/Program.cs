using System;
using System.Linq;

namespace SentenceRandomizer
{
	class Program
	{
		static void Main(string[] args)
		{
			//input of a string separated by " " to be randomized and returned
			
			Console.WriteLine("Enter your input string: ");
			var input_string = Console.ReadLine();

			string[] words = input_string.Split(' ');

			Random r = new Random();
			string[] shuffled_array = words.OrderBy(x => r.Next()).ToArray();

			var result = String.Join(" ", shuffled_array);

			Console.Write(result);
			Console.ReadKey();
		}
	}
}
