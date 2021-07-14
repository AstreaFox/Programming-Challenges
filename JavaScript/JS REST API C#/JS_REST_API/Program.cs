using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using SimpleHttp;

namespace JS_REST_API
{
	static class Program
	{
		static void Main(string[] args)
		{
			var messageFile = Path.GetFullPath("messages.txt");
			if (!File.Exists(messageFile)) File.Create(messageFile).Close();

			var messages = new List<string>();
			messages.AddRange(File.ReadAllLines(messageFile));

			var server = new HttpServer(80);

			server.AddExactRoute("GET", "/", (request, response) =>
			{
				response.RedirectLocation = "/web/JSREST.html";
			});

			server.AddExactRoute("PUT", "/messages", (request, response) =>
			{
				var text = $"[{request.ClientIP}] {request.ReadBodyText()}";

				if (text.Length > 500)
					text = "** Messages greater than 500 characters are not allowed. **";

				// prevent clashing of user requests (messages) sent at the same time
				lock (messageFile) File.AppendAllText(messageFile, text + "\n");

				messages.Add(text);
			});

			server.AddExactRoute("GET", "/messages", (request, response) =>
			{
				response.WriteBodyJson(messages);
			});

			server.AddStaticDirectory("/web", @"C:\Users\Fox\Documents\Visual Studio 2019\Projects\JavaScript\JS REST API C#");

			server.Start();

			Thread.Sleep(Timeout.Infinite);
		}
	}
}
