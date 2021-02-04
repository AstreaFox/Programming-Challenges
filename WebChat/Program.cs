using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SimpleHttp;
using RedisWrapper;
using Newtonsoft.Json.Linq;

namespace WebChat
{
	class Program
	{
		static void Main(string[] args)
		{
			var server = new HttpServer(80);
			var db = new RedisDb("10.0.2.7,password=eRHrHGTTf6vDnvKFkqDV3Mg2NLKhbqM41mMmTIoy"); //would be in a root-read-only config file

			server.AddExactRoute("GET", "/test", (request, response) =>
			{
				response.WriteBodyText("OK.");
			});

			server.AddExactRoute("GET", "/messages", (request, response) =>
			{
				var messages = db.ListGet("chatApp", "", "messages");

				var outArray = new JArray();
				foreach (var message in messages)
					outArray.Add(JObject.Parse(message));

				response.WriteBodyJson(outArray);
			});

			server.AddExactRoute("GET", "/message", (request, response) =>
			{
				var outObj = new JObject();
				foreach (var param in request.QueryParams)
					outObj[param.Key] = param.Value;

				db.ListInsertAfter("chatApp", "", "messages", outObj.ToString());

			});

			server.AddStaticFile("/", "FrontEnd/index.html");

			server.Start();
			Thread.Sleep(Timeout.Infinite);
		}
	}
}
