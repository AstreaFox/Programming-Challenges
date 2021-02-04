using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace Challnge8._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			program.HomeMenu();
		}





		public void HomeMenu()
		{
			Console.Write(
				"ASCII encoder/decoder loaded!" +
				"\nSelect an option:\n" +
				"\n1 - Encode Menu\n" +
				"2 - Decode Menu\n" +
				"3 - Exit program\n" +
				"\nYour chosen option: ");

			var choice = Console.ReadLine();

			switch (choice)
			{
				case "1": EncodeMenu(); break;
				case "2": DecodeMenu(); break;
				case "3": Environment.Exit(0); break;
				default: Console.WriteLine("Error - Enter '1', '2', or '3'"); break;
			}

		}





		public void EncodeMenu()
		{
			Console.Write(
				"\nEncode Menu:\n" +
				"Select an option:\n" +
				"1 - Type a string to be encoded\n" +
				"2 - Load a file to be encoded\n" +
				"3 - Return to the Home Menu\n" +
				"4 - Exit program\n" +
				"\nYour chosen option: ");

			var choice = Console.ReadLine();

			switch (choice)
			{
				case "1": inputEncoder(); break;
				case "2": fileEncoder(); break;
				case "3": HomeMenu(); break;
				case "4": Environment.Exit(0); break;
				default: Console.WriteLine("Error - Enter '1', '2', '3' or '4'"); break;
			}

		}





		public void inputEncoder()
		{
			Console.Write("\nEnter the string you wish to encode: ");
			var strToEncode = Console.ReadLine();

			Console.Write("\nThe encoded result is shown below:\n\n");
			foreach (char character in strToEncode) { Console.WriteLine((int)character); }

			Console.Write(
				"\nSelect an option\n" +
				"1 - Encode another string\n" +
				"2 - Save the result to a file\n" +
				"3 - Return to the Encode Menu\n" +
				"4 - Return to the Home Menu\n" +
				"5 - Exit program\n" +
				"\nYour chosen option: ");

			var choice = Console.ReadLine();

			switch (choice)
			{
				case "1": inputEncoder(); break;
				case "2": saveEncodedToFile(strToEncode); break;
				case "3": EncodeMenu(); break;
				case "4": HomeMenu(); break;
				case "5": Environment.Exit(0); break;
				default: Console.WriteLine("Error - Enter '1', '2', '3', '4' or '5'"); break;
			}
		}





		public void saveEncodedToFile(string input)
		{
			string strToEncode = input;

			Console.Write("\nEnter the full name, filepath with extension of the txt file: ");
			var fileLocation = Console.ReadLine();

			

		}









			public void fileEncoder()
			{

			}





			public void DecodeMenu()
			{
				Console.Write(
					"\nDecode Menu:\n" +
					"Select an option:\n" +
					"1 - Type a string to be decoded\n" +
					"2 - Load a file to be decoded\n" +
					"3 - Return to the Home Menu\n" +
					"4 - Exit program" +
					"\nYour chosen option: ");

				var choice = Console.ReadLine();
			}

			public void inputDecoder()
			{

			}

			public void saveDecodedToFile()
			{

			}

			public void fileDecoder()
			{

			}

		}
	}


