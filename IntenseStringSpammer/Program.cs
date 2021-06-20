using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace IntenseStringSpammer
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Enter string: ");
			var spam_string = Console.ReadLine();

			Console.Write("Enter the limit: ");
			var limit = Convert.ToInt32(Console.ReadLine());

			var nums = Enumerable.Range(1, limit);

			var strs = nums.Select(i =>
			{
				var rep_arr = Enumerable.Repeat(spam_string, i);
				var rep_str = "*" + string.Join(" ", rep_arr) + "*";
				return rep_str;
			});

			var result = string.Join("\n", strs);

			Console.WriteLine(result);
			Clipboard.SetText(result);

			Console.ReadKey(true);
		}
	}
}