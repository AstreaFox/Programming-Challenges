using System;
using System.IO;
using System.Linq;

namespace BinFileConcat
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Provide binary file 1: ");
			var file_1_contents = File.ReadAllBytes(args[0]);

			Console.Write("\nProvide binary file 2: ");
			var file_2_contents = File.ReadAllBytes(args[1]);

			Console.Write("\nProvide name for output bin file");
			BinaryWriter bin_writer = new BinaryWriter(File.Open(args[2], FileMode.Create));

			var file_3_contents = file_1_contents.Concat(file_2_contents).ToArray();

			bin_writer.Write(file_3_contents);
		}
	}
}