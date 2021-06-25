using System;
using System.IO;

namespace RecursiveFileSearch
{
	class Program
	{
		static void Main(string[] args)
		{
			var search_str = args[0];
			var search_dir = args[1];

			Search(search_str, search_dir);
			Console.ReadLine();
		}

        private static void Search(string search_string, string search_directory)
		{
			try
			{
				foreach (string directory in Directory.GetDirectories(search_directory))
				{
					if (Path.GetFileName(directory).ToLower().Contains(search_string.ToLower()))
					{
						Console.WriteLine("[D]	" + directory);
					}
					Search(search_string, directory);
				}
				foreach (string file in Directory.GetFiles(search_directory))
				{
					if (Path.GetFileName(file).ToLower().Contains(search_string.ToLower()))
					{
						Console.WriteLine("[F]	" + file);
					}
				}
			}
			catch (Exception) {};			
		}
    }
}