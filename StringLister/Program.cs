using System;
using System.Collections.Generic;

namespace StringLister
{
	class Program
	{
		static List<string> list = new List<string>();

		static void Main(string[] args)
		{
			while (true)
			{
				
				var inputString = Console.ReadLine();
				if (inputString != "") 
				list.Add(inputString);

				var result = String.Join("\n", list.ToArray());
				Console.WriteLine(result);

			}
			
		}
	}
}
