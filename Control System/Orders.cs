using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_System
{
	public partial class Orders : Form
	{
		public Orders()
		{
			InitializeComponent();
		}

		private void Button_create_order_Click(object sender, EventArgs e)
		{
			Create_Order create_order_form = new Create_Order();
			create_order_form.Show();
		}

		private void Orders_Load(object sender, EventArgs e)
		{

		}
	}
}
