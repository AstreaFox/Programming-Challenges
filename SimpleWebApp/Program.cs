using System;
using System.IO;
using System.Threading;
using SimpleHttp;

//from browser - always get
//from js - always post

namespace SimpleWebApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var server = new HttpServer(80);

			server.AddExactRoute("GET", "/hello", (request, response) =>
			{
				response.WriteBodyText("Hello World");
			});

			server.AddExactRoute("GET", "/time", (request, response) =>
			{
				var time = DateTime.Now.ToString();
				response.ContentType = "text/html; charset=UTF-8";
				response.WriteBodyText(
					"<html>" + 
					"<head><meta http-equiv=\"refresh\" content=\"1\"></head>" + 
					$"<body><h1>{time}</h1></body>" + 
					"</html>");
			});

			server.AddExactRoute("GET", "/browser", (request, response) =>
			{
				var userAgent = request.Headers["user-agent"];

				var browser =
					userAgent.IndexOf("Chrome") >= 0 ? "Chrome" :
					userAgent.IndexOf("Firefox") >= 0 ? "Firefox" :
					"Other";

				response.ContentType = "text/html; charset=UTF-8";
				response.WriteBodyText($"<h1>{browser}</h1>");
			});

			server.SetDefaultRoute((request, response) =>
			{
				response.ContentType = "image/png";
				response.WriteBodyData(File.ReadAllBytes("hooty.png"));
			});

			server.Start();
			Thread.Sleep(Timeout.Infinite);

		}
	}
}
