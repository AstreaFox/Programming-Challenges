using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WebClock
{
	public partial class Form1 : Form
	{
		public byte[] screenshot = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var updateTimer = new Timer();
			updateTimer.Interval = 500;

			updateTimer.Tick += (_sender, _e) =>
			{
				clockText.Text = DateTime.Now.ToString();

				var bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
				clockText.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
				var stream = new MemoryStream();
				bitmap.Save(stream, ImageFormat.Png);
				screenshot = stream.ToArray();
				bitmap.Dispose();
				stream.Dispose();
			};

			updateTimer.Start();
		}
	}
}
