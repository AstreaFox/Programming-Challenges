using System;
using System.Windows.Forms;


namespace Control_System
{

	public partial class form_label : Form
	{
		public form_label()
		{
			InitializeComponent();
		}

		private void Form_label_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
		}

		private void Form_label_Load(object sender, EventArgs e)
		{

		}

		private void Button_customers_Click(object sender, EventArgs e)
		{
			Customers customers_form = new Customers();
			customers_form.Show();
			
		}
	}
}