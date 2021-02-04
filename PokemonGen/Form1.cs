using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PokemonGen
{
	public partial class Form1 : Form
	{
		WebClient client;
		Random random;
		
		public Form1()
		{
			InitializeComponent();
			client = new WebClient();
			random = new Random();
			this.MouseClick += mouseClick;
		}

		private void mouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) { DisplayImage(); }
		}

		private void DisplayImage()
		{
			var index = random.Next(0, 500);
			var number = index.ToString().PadLeft(3, '0');
			byte[] responseData = client.DownloadData($"https://assets.pokemon.com/assets/cms2/img/pokedex/full/{number}.png");
			Stream stream = new MemoryStream(responseData);
			this.BackgroundImage = new Bitmap(stream);
		}

		private void Form1_Load(object sender, EventArgs e) { DisplayImage(); }
	}
}
