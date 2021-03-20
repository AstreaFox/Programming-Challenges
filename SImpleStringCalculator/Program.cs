using System;
using System.Data;

namespace SImpleStringCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Calculation: ");
				var input = Console.ReadLine();
				DataTable dt = new DataTable();
				Console.WriteLine("Answer: " + dt.Compute(input, ""));
				Console.WriteLine();
			}
		}
	}
}