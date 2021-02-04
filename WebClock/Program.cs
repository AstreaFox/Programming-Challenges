using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SimpleHttp;

namespace WebClock
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			var form = new Form1();

			var server = new HttpServer(80);

			server.AddExactRoute("GET", "/clock.png", (request, response) =>
			{
				response.ContentType = "image/png";

				if (form.screenshot != null)
					response.WriteBodyData(form.screenshot);
			});

			server.AddStaticFile("/clock.html", "clock.html");

			server.Start();

			Application.EnableVisualStyles();
			Application.Run(form);

		}
	}
}
