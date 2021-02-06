using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioProjectRenamer
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length < 2)
			{
				Console.WriteLine("Usage:");
				Console.WriteLine("VisualStudioProjectRenamer [solution_directory_path] [new_name] [edit_extensions]");
				return;
			}

			var fileTypesToSearch =
				args.Length >= 3 ? args[2].Split('|') :
				new string[] { ".sln", ".csproj", ".cs" };

			var inputPath = Path.GetFullPath(args[0]);

			if (!Directory.Exists(inputPath))
			{
				Console.WriteLine("Solution directory does not exist.");
				return;
			}

			var oldName = Path.GetFileName(inputPath);
			var newName = args[1];

			var allItems = new List<string>();

			void AddAllFiles(string path) // recursive searching function
			{
				allItems.Add(path);
				allItems.AddRange(Directory.EnumerateFiles(path));
				var directories = Directory.EnumerateDirectories(path);
				foreach (var dir in directories)
					AddAllFiles(dir);
			}

			AddAllFiles(inputPath);

			for (var i = 0; i < allItems.Count; i++)
			{
				var path = allItems[i];
				var name = Path.GetFileName(path);

				if (name.Contains(oldName))
				{
					var parent = Path.GetDirectoryName(path);
					var newPath = Path.Combine(parent, name.Replace(oldName, newName));

					Console.WriteLine($"Renaming '{path}' to '{newPath}'.");

					if (Directory.Exists(path))
					{
						Directory.Move(path, newPath);

						for (var j = 0; j < allItems.Count; j++)
						{
							var item = allItems[j];
							if (item.StartsWith(path + Path.DirectorySeparatorChar))
								allItems[j] = newPath + item.Substring(path.Length);
						}
					}
					else if (File.Exists(path))
					{
						File.Move(path, newPath);
					}
					else
					{
						Console.WriteLine("Failed.");
						continue;
					}

					path = newPath;
					allItems[i] = newPath;
				}

				var extension = Path.GetExtension(path);

				if (fileTypesToSearch.Contains(extension))
				{
					Console.WriteLine($"Editing '{path}'.");

					var contents = File.ReadAllText(path);
					var newContents = contents.Replace(oldName, newName);
					File.WriteAllText(path, newContents);
				}
			}
		}
	}
}
