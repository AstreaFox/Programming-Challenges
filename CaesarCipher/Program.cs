using System;

namespace CaesarCipher
{
	class Program
	{

		static void Main(string[] args) { init(); }

		private static void init()
		{
			Console.Write("Message: ");
			var text = Console.ReadLine(); ;

			Console.Write("Shift (-/+): ");
			int shift = Convert.ToInt32(Console.ReadLine());

			Encode_Decode(text, shift);

			Console.ReadLine();
		}

		private static void Encode_Decode(string user_text, int user_shift)
		{
			
			var text = user_text.ToCharArray();
			var shift = user_shift;

			foreach (char character in text)
			{
				var byt = (byte)character;

				if (byt >= 97 && byt <= 122)
				{
					var enc_byt = Mod((byt - 97) + shift, 26) + 97;
					Console.Write((char)enc_byt);
				}
				else if (byt >= 65 && byt <= 90)
				{
					var enc_byt = Mod((byt - 65) + shift, 26) + 65;
					Console.Write((char)enc_byt);
				}
				else if (byt >= 48 && byt <= 57)
				{
					var enc_byt = Mod((byt - 48) + shift, 10) + 48;
					Console.Write((char)enc_byt);
				}
				else Console.Write((char)byt);
			}
		}

		private static int Mod(int x, int m)
		{
			//x - Letter + Shift
			//m - 26 for alphabet, 10 for numbers

			return (x % m + m) % m;
		}
	}
}