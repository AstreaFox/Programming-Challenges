// Program
using System;
using System.Linq;
using System.Text;

internal static class Program
{
	private static byte[] Xor(byte[] a, byte[] b)
	{
		return a.Zip(b, (byte x, byte y) => (byte)(x ^ y)).ToArray();
	}

	private static void Main(string[] args)
	{
		byte[] responseBlock1 = new byte[144]
		{
			113,
			48,
			62,
			110,
			231,
			225,
			241,
			125,
			200,
			85,
			248,
			131,
			2,
			41,
			175,
			26,
			207,
			232,
			169,
			97,
			10,
			211,
			40,
			128,
			252,
			21,
			20,
			126,
			90,
			43,
			7,
			73,
			29,
			80,
			86,
			213,
			27,
			85,
			226,
			157,
			29,
			170,
			209,
			168,
			79,
			245,
			219,
			167,
			118,
			33,
			81,
			114,
			193,
			42,
			237,
			191,
			152,
			152,
			147,
			143,
			94,
			13,
			245,
			10,
			118,
			121,
			228,
			209,
			205,
			131,
			8,
			219,
			152,
			133,
			78,
			221,
			87,
			184,
			184,
			147,
			22,
			9,
			183,
			95,
			77,
			234,
			179,
			232,
			84,
			172,
			34,
			130,
			212,
			45,
			228,
			141,
			37,
			14,
			164,
			4,
			6,
			18,
			71,
			8,
			118,
			22,
			113,
			112,
			245,
			217,
			16,
			88,
			249,
			155,
			63,
			223,
			25,
			126,
			145,
			14,
			79,
			105,
			118,
			49,
			176,
			20,
			100,
			210,
			231,
			103,
			33,
			11,
			248,
			71,
			38,
			160,
			99,
			105,
			198,
			163,
			198,
			44,
			214,
			187
		};
		byte[] responseBlock2 = new byte[144]
		{
			56,
			23,
			83,
			78,
			158,
			142,
			132,
			15,
			232,
			34,
			151,
			237,
			102,
			76,
			221,
			124,
			186,
			132,
			133,
			65,
			125,
			182,
			65,
			242,
			152,
			57,
			52,
			31,
			62,
			68,
			117,
			40,
			127,
			60,
			51,
			249,
			59,
			58,
			129,
			254,
			124,
			217,
			184,
			199,
			33,
			148,
			183,
			203,
			15,
			1,
			48,
			28,
			175,
			69,
			148,
			214,
			246,
			255,
			179,
			227,
			55,
			121,
			129,
			102,
			19,
			89,
			151,
			184,
			190,
			173,
			40,
			159,
			253,
			228,
			34,
			253,
			32,
			209,
			204,
			251,
			54,
			96,
			195,
			113,
			109,
			208,
			227,
			226,
			21,
			192,
			81,
			237,
			248,
			13,
			157,
			226,
			80,
			46,
			211,
			109,
			104,
			50,
			111,
			124,
			30,
			127,
			2,
			80,
			129,
			176,
			125,
			61,
			208,
			186,
			31,
			140,
			118,
			82,
			177,
			98,
			38,
			2,
			19,
			29,
			144,
			115,
			11,
			189,
			131,
			71,
			75,
			100,
			154,
			107,
			6,
			233,
			67,
			14,
			179,
			198,
			181,
			95,
			248,
			177
		};

		/*
		 *   8 = 00001000
		 *  75 = 01001011
		 *  67 = 01000011
		 *  
		 *  112= 01110000
		 *  2  = 00000010
		 *  114= 01110010
		 */

		byte[] passwordBlock1 = new byte[21]
		{
			8,
			112,
			0,
			220,
			160,
			162,
			96,
			202,
			17,
			22,
			120,
			172,
			6,
			177,
			217,
			177,
			32,
			33,
			242,
			228,
			111
		};
		byte[] passwordBlock2 = new byte[21]
		{
			75,
			2,
			105,
			191,
			203,
			199,
			20,
			185,
			49,
			119,
			22,
			200,
			38,
			210,
			172,
			194,
			84,
			64,
			128,
			128,
			65
		};

		/*
		 * A		B		C
		 * 
		 * 0		0		0
		 * 1		0		1
		 * 0		1		1
		 * 1		1		0
		 * 
		 * A ^ B = C
		 * B ^ A = C
		 * A ^ C = B
		 * B ^ C = A
		 * 
		 * 0 ^ 0 = 0
		 * 1 ^ 1 = 0
		 * 0 ^ 1 = 1
		 * 1 ^ 0 = 1
		 * 
		 */


		Console.Write(Encoding.ASCII.GetString(Convert.FromBase64String("UGFzc3dvcmQ6IA==")));
		byte[] inputBlock = Encoding.ASCII.GetBytes(Console.ReadLine());
		Console.Write(Encoding.ASCII.GetString(Xor(passwordBlock1, passwordBlock2)));
		//	A				B				C
		// inputBlock ^ passwordBlock1 = passwordBlock2
		// passwordBlock1 ^ passwordBlock2 = inputBlock
		//

		/*if (Xor(inputBlock, passwordBlock1).SequenceEqual(passwordBlock2))
		{
			Console.Write(Encoding.ASCII.GetString(Xor(responseBlock1, responseBlock2)));
		}
		else
		{
			Console.Write(Encoding.ASCII.GetString(Convert.FromBase64String("Tm9wZS4K")));
		}*/
	}
}
