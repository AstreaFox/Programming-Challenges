using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Closen_t
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Random random = new Random();
			Timer myTimer = new Timer();

			var screenWidth = Screen.PrimaryScreen.Bounds.Width;
			var screenHeight = Screen.PrimaryScreen.Bounds.Height;

			myTimer.Tick += (object _sender, EventArgs _e) =>
			{
				var x = this.Location.X;
				var y = this.Location.Y;

				var h = this.Height;
				var w = this.Width;

				var closeX = x + w;
				var closeY = y;

				var cursorX = Cursor.Position.X;
				var cursorY = Cursor.Position.Y;

				var distance = Math.Sqrt(Math.Pow((closeX - cursorX), 2) + Math.Pow((closeY - cursorY), 2));
				
				if (distance < 75)
				{
					this.Location = new Point(random.Next(0, screenWidth - w), random.Next(0, screenHeight - h));
				}
			};
			myTimer.Interval = 16;
			myTimer.Start();
		}

		const int WM_CONTEXTMENU = 0x007B;
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_CONTEXTMENU)
				m.Result = IntPtr.Zero;
			else
				base.WndProc(ref m);
		}
	}
}
