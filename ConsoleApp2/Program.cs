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

		//string array to hold loaded encoded file data
		string[] inFileData;

		//store all lines of encoded file loaded and put into string array
		inFileData = File.ReadAllLines(args[0]);

		//byte array to hold decoded data of the message
		byte[] inputTextData;

		//byte array to hold the SHA checksum of the message
		byte[] inputChecksum;

		//string to hold the decoded message
		string inputText;




		//store the base64 decoded message
		inputTextData = Convert.FromBase64String(inFileData[0]);

		//store the checksum of the encoded message
		inputChecksum = Convert.FromBase64String(inFileData[1]);

		//store decoded data of the message
		inputText = Encoding.UTF8.GetString(inputTextData);

		//store the sha hash into a byte array
		byte[] trueChecksum = Sha256(inputTextData);

		//if the hash != correct hash
		if (!inputChecksum.SequenceEqual(trueChecksum))
		{

			Console.Error.WriteLine("ERROR: Bad input file checksum.");
			return 3;

		}

		//else output the decoded message
		Console.WriteLine(inputText);
		return 0;

	}

}