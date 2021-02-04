using System.Media;
using System.Threading;

namespace DrumMachine1
{
	static class Program
	{
		static SoundPlayer mixtape1;
		static SoundPlayer mixtape2;

		static void Main(string[] args)
		{
			loadLow();
			loadHigh();

			do
			{
				PlayLow();
				Thread.Sleep(20);
				PlayLow();
				Thread.Sleep(300);
				PlayLow();
				Thread.Sleep(100);
				PlayHigh();
				Thread.Sleep(300);
				PlayHigh();
				Thread.Sleep(300);
			} while (true);
		}

		private static void loadLow() { mixtape2 = new SoundPlayer(); mixtape2.SoundLocation = "2.wav"; }
		private static void loadHigh() { mixtape1 = new SoundPlayer(); mixtape1.SoundLocation = "1.wav"; }

		private static void PlayLow() { mixtape2.PlaySync(); }
		private static void PlayHigh() { mixtape1.PlaySync(); }
	}
}