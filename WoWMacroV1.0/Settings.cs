using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWMacroV1._0
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
			this.Icon = new Icon("king-face.ico");
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			macroGrid.Rows.Add();
			macroGrid.Focus();
			macroGrid.CurrentCell = macroGrid[0, macroGrid.Rows.Count - 1];
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			macroGrid.Rows.RemoveAt(macroGrid.CurrentCell.RowIndex);
		}

		private void macroGrid_KeyDown(object sender, KeyEventArgs e)
		{
			if (macroGrid.CurrentCell.ColumnIndex < 3)
			{
				macroGrid.CurrentCell.Value = e.KeyCode;
				macroGrid.CurrentCell = macroGrid[macroGrid.CurrentCell.ColumnIndex + 1, macroGrid.CurrentCell.RowIndex];
			}
		}
	}
}
