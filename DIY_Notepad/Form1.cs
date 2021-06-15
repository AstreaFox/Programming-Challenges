using System;
using System.Windows.Forms;
using System.IO;

namespace DIY_Notepad
{
	public partial class Form1 : Form
	{
		string file_name_for_saving = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtbox_main.Clear();
			file_name_for_saving = "";
			this.Text = "DIY Notepad";
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.Title = "Open File";
			openFileDialog.Filter = "All files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				file_name_for_saving = openFileDialog.FileName;
				txtbox_main.Text = File.ReadAllText(openFileDialog.FileName);
				this.Text = file_name_for_saving;
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(file_name_for_saving))
			{
				saveAsToolStripMenuItem_Click(sender, e);
				return;
			}

			File.WriteAllText(file_name_for_saving, txtbox_main.Text);
			this.Text = file_name_for_saving;
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();

			saveFileDialog1.Title = "Save File";
			saveFileDialog1.Filter = "All files (*.*)|*.*";
			saveFileDialog1.RestoreDirectory = true;

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				file_name_for_saving = saveFileDialog1.FileName;
				File.WriteAllText(saveFileDialog1.FileName, txtbox_main.Text);
				this.Text = file_name_for_saving;
			}

		}
	}
}
