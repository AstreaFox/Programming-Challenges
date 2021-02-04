//HELP RECIEVED - YES



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_7
{

	class Program
	{

		static void Main(string[] args)
		{

			/*string userInput = Console.ReadLine().ToLower();
			var char_userInput = userInput.ToCharArray();

			for (int index = 0; index < userInput.Length; index++)
			{

				if (index % 2 != 0)
				{

					char_userInput[index] = Char.ToUpper(char_userInput[index]);

				}
				
			}

			Console.WriteLine(char_userInput);*/


			//Write result to console after computation
			Console.WriteLine(
				//Take input
				Console.ReadLine()
					//.Select - for every element (chr) in the array (each char in str), run the function below then store corresponding result
				.Select((chr, i) =>
					i % 2 == 0 ?
						char.ToLower(chr) : 
						char.ToUpper(chr))
				//convert result of select statement above to an array
				.ToArray());

			Console.ReadKey(true);

		}

	}

}