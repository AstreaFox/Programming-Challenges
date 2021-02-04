using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Trackr
{
	public partial class MainWindow : Form
	{
		const int rowCount = 14;

		readonly int[] notesFreq = new int[]
		{
			(int)440.00,
			(int)493.88,
			(int)523.25,
			(int)587.33,
			(int)659.25,
			(int)698.46,
			(int)783.99,
			(int)880.00,
			(int)987.77,
			(int)1046.50,
			(int)1174.66,
			(int)1318.51,
			(int)1396.91,
			(int)1567.98,
		};

		readonly Timer timer;

		CheckBox GetButton(int column, int row) =>
			notePanel.Controls
				.OfType<CheckBox>()
				.Where(button => ((Point)button.Tag).X == column && ((Point)button.Tag).Y == row)
				.FirstOrDefault();

		public MainWindow()
		{
			InitializeComponent();

			this.MinimumSize = new Size(this.Width, this.Height);
			this.MaximumSize = new Size(int.MaxValue, this.Height);

			typeof(Panel).InvokeMember(
				"DoubleBuffered",
				BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, 
				null, notePanel, new object[] { true });

			timer = new Timer();
			timer.Tick += OnTick;
			timer.Interval = 500;
		}

		void OnTick(object sender, EventArgs e)
		{
			var column = (trackBar.Value + 1) % (trackBar.Maximum + 1);
			trackBar.Value = column;

			var selectedButton = Enumerable.Range(0, rowCount)
				.Select(row => (int?)row)
				.Where(row => GetButton(column, (int)row).Checked)
				.FirstOrDefault() ?? -1;

			if (selectedButton >= 0)
				Console.Beep(notesFreq[rowCount - selectedButton - 1], (int)(timer.Interval * 0.9));
		}

		void OnLoad(object sender, EventArgs e)
		{
			OnRender(this, null);
			OnTempoChange(this, null);
			OnPlay(this, null);
		}

		void OnRender(object sender, EventArgs e)
		{
			notePanel.SuspendLayout();

			var columnCount = (int)noteCountBox.Value;

			var oldNotes = new bool[columnCount, rowCount];
			var oldButtons = notePanel.Controls.OfType<CheckBox>().ToArray();
			foreach (var button in oldButtons)
			{
				var pt = (Point)button.Tag;
				try { oldNotes[pt.X, pt.Y] = button.Checked; }
				catch (IndexOutOfRangeException) { }
				button.Dispose();
			}

			for (var column = 0; column < columnCount; column++)
			{
				for (var row = 0; row < rowCount; row++)
				{
					var button = new CheckBox();
					button.Appearance = Appearance.Button;
					button.Size = new Size(20, 20);
					button.Tag = new Point(column, row);
					button.Checked = oldNotes[column, row];
					button.Location = new Point(8 + 36 * column, 26 * row);
					button.Parent = notePanel;
				}
			}

			notePanel.Width = 36 * columnCount;
			trackBar.Width = notePanel.Width - 8;
			trackBar.Maximum = columnCount - 1;

			notePanel.ResumeLayout();
		}

		void OnTempoChange(object sender, EventArgs e)
		{
			timer.Interval = (int)(1000 / ((double)npmBox.Value / 60));
		}

		void OnStop(object sender, EventArgs e) => timer.Stop();

		void OnPlay(object sender, EventArgs e) => timer.Start();

		void OnOpen(object sender, EventArgs e)
		{
			var fd = new OpenFileDialog();
			fd.Filter = "Text files (*.txt)|*.txt";
			var fdResult = fd.ShowDialog(this);
			if (fdResult != DialogResult.OK) return;
			var path = fd.FileName;

			var lines = File.ReadAllLines(path);
			if (lines.Length < 2) return;
			var setup = lines[0].Split(' ');
			if (setup.Length < 2) return;

			int.TryParse(setup[0], out int columnCount);
			int.TryParse(setup[1], out int npm);
			if (columnCount == 0 || npm == 0) return;

			noteCountBox.Value = columnCount;
			npmBox.Value = npm;

			var noteStrs = lines[1].Split(' ');
			if (noteStrs.Length != columnCount) return;

			var notes = noteStrs
				.Select(noteStr => { int.TryParse(noteStr, out int note); return note; })
				.ToArray();

			var noteCtr = 0;
			foreach (var note in notes)
			{
				for (var i = 0; i < rowCount; i++)
					GetButton(noteCtr, i).Checked = false;

				if (note >= 0)
					GetButton(noteCtr, note).Checked = true;

				noteCtr++;
			}
		}

		void OnSave(object sender, EventArgs e)
		{
			var fd = new SaveFileDialog();
			fd.Filter = "Text files (*.txt)|*.txt";
			var fdResult = fd.ShowDialog(this);
			if (fdResult != DialogResult.OK) return;
			var path = fd.FileName;

			var columnCount = (int)noteCountBox.Value;

			var wr = new StreamWriter(path, false, Encoding.ASCII);

			wr.WriteLine($"{columnCount} {(int)npmBox.Value}");

			wr.WriteLine(string.Join(" ", 
				Enumerable.Range(0, columnCount).Select(column =>
					Enumerable.Range(0, rowCount)
						.Select(row => (int?)row)
						.Where(row => GetButton(column, (int)row).Checked)
						.FirstOrDefault() ?? -1)));

			wr.Close();
		}
	}
}
