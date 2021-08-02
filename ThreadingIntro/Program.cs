using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			Task.Run(() =>
			{
				while (true)
				{
					Console.WriteLine("Thread 1!");
					Thread.Sleep(1000);
				}
			});

			Task.Run(() =>
			{
				while (true)
				{
					Console.WriteLine("Thread 2!");
					Thread.Sleep(1000);
				}
			});

			Task.Run(() =>
			{
				while (true)
				{
					Console.WriteLine("Thread 3!");
					Thread.Sleep(1000);
				}
			});

			Thread.Sleep(Timeout.Infinite);
		}
	}
}
