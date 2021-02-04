using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPaint
{
	public partial class Form1 : Form
	{

		bool mouseDown = false;
		public Form1()
		{
			InitializeComponent();
		}

		void Form1_Load(object sender, EventArgs e)
		{
			var image = new Bitmap(this.Width, this.Height);
			this.BackgroundImage = image;
			DoubleBuffered = true;
			
			
			

		}

		void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseDown = true;
			DrawCircle(e.X, e.Y);

		}

		void DrawCircle(int x, int y)
		{
			var graphics = Graphics.FromImage(this.BackgroundImage);
			graphics.FillEllipse(Brushes.Red, x, y, 10, 10);
			graphics.Dispose();

			this.Refresh();
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (!mouseDown) { return; }
			DrawCircle(e.X, e.Y);
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}
	}
}
