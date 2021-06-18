using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_System
{
	public partial class Initializer : Form
	{
		public Initializer()
		{
			InitializeComponent();
		}

		private void btn_decrypt_Click(object sender, EventArgs e)
		{
			ScriptEngine engine = Python.CreateEngine();
			engine.ExecuteFile(@"enc_dec.py");
		}
	}
}