using System;
using System.Windows.Forms;

namespace ScreenBlackoutCSharp
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
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) { this.Close(); }
		}
	}
}
