using System;
using System.Linq;

namespace CharOccurance
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a string to process:");
			var input_string = Console.ReadLine().ToCharArray();

			var unique_string = new String(input_string.Distinct().ToArray());

			Console.WriteLine();

			foreach (char c in unique_string)
			{
				int occurances = input_string.Count(f => f == c);
				Console.WriteLine(c + ": " + occurances);
			}
			Console.ReadKey();
		}
	}
}
