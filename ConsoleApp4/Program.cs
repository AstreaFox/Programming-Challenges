// Program
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

internal static class Program
{
	private static byte[] Sha256(byte[] input)
	{
		using (SHA256 sha256 = SHA256.Create())
		{
			return sha256.ComputeHash(input);
		}
	}

	private static int Main(string[] args)
	{
		string[] inFileData;
		try
		{
			inFileData = File.ReadAllLines(args[0]);
		}
		catch (Exception)
		{
			Console.Error.WriteLine("ERROR: Couldn't read input file.");
			return 1;
		}
		byte[] inputTextData;
		byte[] inputChecksum;
		string inputText;
		try
		{
			inputTextData = Convert.FromBase64String(inFileData[0]);
			inputChecksum = Convert.FromBase64String(inFileData[1]);
			inputText = Encoding.UTF8.GetString(inputTextData);
		}
		catch (Exception)
		{
			Console.Error.WriteLine("ERROR: Bad input file format.");
			return 2;
		}
		byte[] trueChecksum = Sha256(inputTextData);
		if (!inputChecksum.SequenceEqual(trueChecksum))
		{
			Console.Error.WriteLine("ERROR: Bad input file checksum.");
			return 3;
		}
		Console.WriteLine(inputText);
		return 0;
	}
}
