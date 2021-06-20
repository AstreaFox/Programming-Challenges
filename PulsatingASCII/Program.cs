using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PulsatingASCII
{
	static class Program
	{
		static void PrintArray(string[] lines) =>
			Console.WriteLine(string.Join("\n", lines));

		static string LineOfDots(int innerWidth, int outerWidth) =>
			new string(' ', (outerWidth - innerWidth) / 2) +
			new string('.', innerWidth) +
			new string(' ', (outerWidth - innerWidth) / 2);

		static void DrawDiamond(int size)
		{
			Console.Clear();

			var center = size / 2;
			var lines = new string[size];

			lines[center] = LineOfDots(size, size);
			for (var i = 1; i <= size / 2; i++)
			{
				lines[center - i] = LineOfDots(size - i * 2, size);
				lines[center + i] = LineOfDots(size - i * 2, size);
			}

			PrintArray(lines);

			Thread.Sleep(50);
		}

		static void Main(string[] args)
		{
			var size = 11;

			while (true)
			{
				for (var i = 1; i <= size; i += 2) DrawDiamond(i);
				for (var i = size; i >= 1; i -= 2) DrawDiamond(i);
			}
		}
	}
}