using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageDisplay
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			bool sizing = false;

			Resize += (object sender, EventArgs e) =>
			{
				if (sizing) return;

				sizing = true;

				var newHeight = ClientSize.Width * this.BackgroundImage.Height / this.BackgroundImage.Width;
				var newSize = SizeFromClientSize(new Size(0, newHeight));

				MinimumSize = new Size(0, newSize.Height);
				MaximumSize = new Size(int.MaxValue, newSize.Height);

				if (Height != newSize.Height)
					Width = Height * this.BackgroundImage.Width / this.BackgroundImage.Height;

				sizing = false;
			};

			DoubleBuffered = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.BackgroundImage = new Bitmap(Environment.GetCommandLineArgs()[1]);
		}
	}
}