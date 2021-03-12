using System;

namespace FibonacciGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			//ask what fibonacci number they want, then return it
			//then ask for how many they want, give that many starting at the one they asked for

			//Console.WriteLine("What number of the Fibonacci sequence would you like?:");
			//var n = Convert.ToDouble(Console.ReadLine());

			var Phi = (1 + Math.Sqrt(5)) / 2;
			var phi = (1 - Math.Sqrt(5)) / 2;

			//Console.WriteLine(
			//	(Math.Pow(Phi, n) - Math.Pow(phi, n)) / Math.Sqrt(5)
			//	);

			Console.WriteLine("At what position would you like to start");
			var position = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter amount of numbers to print:");
			var quantity = Convert.ToDouble(Console.ReadLine());

			for (int i = 0; i < quantity; i++)
			{
				Console.Write(
				(Math.Pow(Phi, i + position) - Math.Pow(phi, i + position)) / Math.Sqrt(5)
				+ " ");
			}
		}
	}
}
