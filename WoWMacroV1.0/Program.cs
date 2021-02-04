using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWMacroV1._0
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			var form = new Settings();

			var taskbarIcon = new NotifyIcon();

			taskbarIcon.Icon = form.Icon;
			taskbarIcon.Text = "Fox's WoW Helper";
			taskbarIcon.Visible = true;

			taskbarIcon.ContextMenu = new ContextMenu(new MenuItem[]
			{
				new MenuItem("Settings", (sender, e) => form.Show()),

				new MenuItem("Exit", (sender, e) =>
				{
					taskbarIcon.Dispose();
					form.Close();
					Application.Exit();
				}),
			});

			// Temporary!
			form.Show();

			Application.EnableVisualStyles();
			Application.Run();
		}
	}
}
