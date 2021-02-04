using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DoubleBuffered = true;

			Timer myTimer = new Timer();

			var frameInt = 0;

			myTimer.Tick += (object _sender, EventArgs _e) =>
			{
				this.BackgroundImage = new Bitmap($"horse-animation-frames/frame_{frameInt}.png");

				frameInt++;

				if (frameInt == 12) { frameInt = 0; }
			};

			myTimer.Interval = 100;
			myTimer.Start();

		}
	}
}
