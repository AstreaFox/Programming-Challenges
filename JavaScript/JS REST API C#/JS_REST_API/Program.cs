using System;
using System.Collections.Generic;
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
			var messages = new List<string>();

			var server = new HttpServer(80);

			server.AddExactRoute("GET", "/", (request, response) =>
			{
				response.WriteBodyText("OK");
			});

			server.AddExactRoute("PUT", "/messages", (request, response) =>
			{
				messages.Add(request.ReadBodyText());
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
