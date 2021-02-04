using System;
using System.Drawing;
using System.Windows.Forms;

/*
 * 1. Blacken the screen
 * 2. Display scaled down image in centre of screen
 * 3. On timer and double buffer, move image in random direction until edge touches edge of screen
 * 4. Loop this so it moves at the correct angle to achieve the bouncing effect
 */

namespace Screensaver
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Cursor.Hide();

			Timer myTimer = new Timer();

			var image = new Bitmap(this.Width, this.Height);
			this.BackgroundImage = image;

			var sprite = new Bitmap(@"C:\Users\Fox\Pictures\fox.png");

			var sprite_x_pos = 0;
			var sprite_y_pos = 0;
			var sprite_x_delta = 3;
			var sprite_y_delta = 3;

			this.DoubleBuffered = true;

			myTimer.Tick += (object _sender, EventArgs _e) =>
			{
				var graphics = Graphics.FromImage(image);
				graphics.Clear(Color.Black);

				graphics.DrawImage(sprite, sprite_x_pos, sprite_y_pos, 200, 170);

				sprite_x_pos += sprite_x_delta;
				if (sprite_x_delta > 0 && sprite_x_pos >= this.Width - 200 ||
					sprite_x_delta < 0 && sprite_x_pos <= 0)
					sprite_x_delta = -sprite_x_delta;

				sprite_y_pos += sprite_y_delta;
				if (sprite_y_delta > 0 && sprite_y_pos >= this.Height - 170 ||
					sprite_y_delta < 0 && sprite_y_pos <= 0)
					sprite_y_delta = -sprite_y_delta;

				graphics.Dispose();
				this.Refresh();
			};

			myTimer.Interval = 16;
			myTimer.Start();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) => this.Close();
		private void Form1_MouseDown(object sender, MouseEventArgs e) => this.Close();
	}
}
