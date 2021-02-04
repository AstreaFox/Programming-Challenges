//HELP RECIEVED = 


//REMOVE UNUSED USING STATEMENTS
//COMPLETE SAVING COMPATIBILITY FOR STRING OR BYTE ARRAY TO FILE
//ADD FUNCTIONALITY TO SUPPORT DIRECT USER INPUT, WITH FOLLOW UP OPTION TO WRITE TO A NEW/EXISTING FILE
//ADD FUNCTIONALITY TO SUPPORT CHANGING THE FILE LOADED
//REFORMAT LINES OF CODE TO MAKE SHORTER

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;

namespace Challenge_8
{

	class Program
	{

		static void Main(string[] args)
		{
			Program program = new Program();
			program.Begin();
		}

		public string Begin()
		{

			Console.Write("Enter txt file path (include file name and extension): ");
			string file = Console.ReadLine();
			Console.WriteLine();
			FileChecker(file);
			return file;

		}		

		public void FileChecker(string file)
		{

			string filePath = file;

			while (!File.Exists(filePath))
			{
				Console.WriteLine("File not found - check the path, filename and extension are correct");
				Console.WriteLine();
				Begin();
			}

			DisplayOptions(filePath);

		}

		public void DisplayOptions(string file)
		{
			string filePath = file;

			Console.WriteLine("File " + filePath + " is now loaded");
			Console.WriteLine();
			Console.WriteLine("Select an option:");
			Console.WriteLine("1 - View the file contents");
			Console.WriteLine("2 - Encode the file");
			Console.WriteLine("3 - Decode the file");
			Console.WriteLine("Or press ENTER to exit the program");
			Console.WriteLine();

			OptionSelect(filePath);
		}

		public void OptionSelect(string file)
		{
			string filePath = file;
			Console.Write("Enter your choice: ");
			var choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					DisplayFileContents(filePath);
					break;

				case "2":
					FileEncoder(filePath);
					break;

				case "3":
					FileDecoder(filePath);
					break;

				default:
					Console.WriteLine("Invalid input - enter '1, 2 or 3'");
					break;
			}

		}

		public void DisplayFileContents(string file)
		{

			string filePath = file;

			string[] fileContent = File.ReadAllLines(filePath);

			Console.WriteLine();
			Console.WriteLine("File contents:");
			Console.WriteLine();

			foreach (string line in fileContent)
			{

				Console.WriteLine(line);

			}

			Console.WriteLine();
			Console.Write("Press ENTER after reading this file's contents to return to the main menu");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			DisplayOptions(filePath);

		}

		public void FileEncoder(string file)
		{

			string filePath = file;

			//store file contents
			var fileContents = File.ReadAllText(filePath);

			//encode into a byte array
			ASCIIEncoding ascii = new ASCIIEncoding();
			Byte[] byteArray = ascii.GetBytes(fileContents);

			//display result
			Console.WriteLine();
			Console.WriteLine("The encoded result is provided below:");
			Console.WriteLine();

			foreach (var b in byteArray){Console.WriteLine(b);}

			Console.WriteLine();
			Console.Write("Would you like to save the result to a file? (y/n): ");

			var choice = Console.ReadLine();

			switch (choice)
			{

				case "y":
					SaveEncodeToFile(filePath, byteArray);
					break;

				case "n":
					Console.Clear();
					DisplayOptions(filePath);
					break;

				default:
					Console.WriteLine("Invalid input - enter 'y' or 'n'");
					break;
			}

			Console.Write("Press ENTER once done to return to the main menu: ");
			Console.ReadKey(true);
			Console.WriteLine();
			Console.Clear();
			DisplayOptions(filePath);

		}

		public void FileDecoder(string file)
		{

			string filePath = file;
			Console.WriteLine("decode ");

			string message = "abc cba";

			Console.WriteLine("Original: " + message);

			//encoding

			ASCIIEncoding ascii = new ASCIIEncoding();
			Byte[] byteArray = ascii.GetBytes(message);

			//decoding
			String original = ascii.GetString(byteArray);

			//display decoded
			Console.WriteLine(original);

			Console.ReadKey(true);
		}

		public void SaveEncodeToFile(string file, Byte[] encBytes)
		{

			string filePath = file;
			byte[] data = encBytes;
			string newFilePath;
			Console.WriteLine();
			Console.WriteLine("Select an option:");
			Console.WriteLine("1 - Replace the contents of " + filePath + " with the new data");
			Console.WriteLine("2 - Save the data to a new file");
			Console.WriteLine("3 - Cancel this operation and return to the main menu");

			var choice = Console.ReadLine();
			var fileStream = new FileStream(filePath, FileMode.Create);

			switch (choice)
			{

				case "1":
					var writer = new BinaryWriter(File.OpenWrite(filePath));
					writer.Write(data);
					writer.Flush();
					writer.Close();
					Console.WriteLine("Successfully replaced the contents of " + filePath);
					break;

				case "2":
					Console.Write("Please enter the filepath, name of the file and .txt extension: ");
					newFilePath = Console.ReadLine();
					File.WriteAllBytes(newFilePath, data);
					break;

				case "3":
					DisplayFileContents(filePath);
					break;

			}
		}

	}

}
