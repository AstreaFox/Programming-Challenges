using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Control_System
{
	public partial class Customers : Form
	{
		string[] customer_entry = new string[14];

		public Customers()
		{
			InitializeComponent();
		}

		private void Customers_label_Load(object sender, EventArgs e)
		{

		}

		private void Button_Orders_Click(object sender, EventArgs e)
		{
			Orders orders_form = new Orders();
			orders_form.Show();
		}

		private void Button_Stock_Click(object sender, EventArgs e)
		{
			Stock stock_form = new Stock();
			stock_form.Show();
		}

		private void Button_staff_Click(object sender, EventArgs e)
		{

		}

		private void Button_customers_Click(object sender, EventArgs e)
		{

		}

		private void Button_create_customer_Click(object sender, EventArgs e)
		{
			string msgbox_contents = "Enter: ";

			if (txtbox_forenames.Text == string.Empty) { msgbox_contents += "\nForename\n"; }
			else { customer_entry[0] = txtbox_forenames.Text; }

			if (txtbox_surnames.Text == string.Empty) { msgbox_contents += "Surname\n"; }
			else { customer_entry[1] = txtbox_surnames.Text; }

			if (txtbox_alias.Text == string.Empty) { msgbox_contents += "Alias\n"; }
			else { customer_entry[2] = txtbox_alias.Text; }

			if (dtp_birthday.Text == string.Empty) { msgbox_contents += "Birthday\n"; }
			else { customer_entry[3] = dtp_birthday.Text; }

			if (combobox_gender.Text == string.Empty) { msgbox_contents += "Gender\n"; }
			else { customer_entry[4] = txtbox_forenames.Text; }

			if (txtbox_email.Text == string.Empty) { msgbox_contents += "Email\n"; }
			else { customer_entry[5] = txtbox_email.Text; }

			if (txtbox_phone.Text == string.Empty) { msgbox_contents += "Phone No.\n"; }
			else { customer_entry[6] = txtbox_phone.Text; }

			if (txtbox_address_line_1.Text == string.Empty) { msgbox_contents += "Address Line 1\n"; }
			else { customer_entry[7] = txtbox_address_line_1.Text; }

			if (txtbox_address_line_2.Text == string.Empty) { msgbox_contents += "Address Line 2\n"; }
			else { customer_entry[8] = txtbox_address_line_2.Text; }

			if (txtbox_city.Text == string.Empty) { msgbox_contents += "City\n"; }
			else { customer_entry[9] = txtbox_city.Text; }

			if (txtbox_state_province.Text == string.Empty) { msgbox_contents += "State/Province\n"; }
			else { customer_entry[10] = txtbox_state_province.Text; }

			if (txtbox_post_zip_code.Text == string.Empty) { msgbox_contents += "Postal/Zip Code\n"; }
			else { customer_entry[11] = txtbox_post_zip_code.Text; }

			if (combobox_countries.Text == string.Empty) { msgbox_contents += "Country\n"; }
			else { customer_entry[12] = combobox_countries.Text; }

			if (rtb_notes.Text == string.Empty) { msgbox_contents += "Notes\n"; }
			else { customer_entry[13] = rtb_notes.Text; }

			if (msgbox_contents.Contains('\n')) { msgbox_contents = msgbox_contents.Remove(msgbox_contents.LastIndexOf('\n')); }

			if (msgbox_contents != "Enter: ") { MessageBox.Show(msgbox_contents); }
			else
			{
				var listViewItem = new ListViewItem(customer_entry);
				listview_existing_customers.Items.Add(listViewItem);

				ClearTextBoxes();
				dtp_birthday.ResetText();
				combobox_gender.Items.Clear();
				combobox_countries.Items.Clear();
				rtb_notes.Clear();

				//SaveToFile(customer_entry, file_path);
			}
		}

		private void Listview_existing_customers_Click(object sender, EventArgs e)
		{
			var message =
				"Forenames(s): " + customer_entry[0] + '\n' +
				"Surnames(s): " + customer_entry[1] + '\n' +
				"Alias: " + customer_entry[2] + '\n' +
				"Birthday: " + customer_entry[3] + '\n' +
				"Gender: " + customer_entry[4] + '\n' +
				"Email: " + customer_entry[5] + '\n' +
				"Phone.: " + customer_entry[6] + '\n' +
				"Address Line 1: " + customer_entry[7] + '\n' +
				"Address Line 2: " + customer_entry[8] + '\n' +
				"City: " + customer_entry[9] + '\n' +
				"State/Province " + customer_entry[10] + '\n' +
				"Postal/Zip Code: " + customer_entry[11] + '\n' +
				"Country: " + customer_entry[12] + '\n' +
				"Notes: " + customer_entry[13];

			MessageBox.Show(message);
		}

		private void ClearTextBoxes()
		{
			Action<Control.ControlCollection> func = null;

			func = (controls) =>
			{
				foreach (Control control in controls)
					if (control is TextBox)
						(control as TextBox).Clear();
					else
						func(control.Controls);
			};

			func(Controls);
		}

		private void SaveToFile(string[] data, string file_location)
		{
			var customer_entry = data;
			var file_path = file_location;

			TextWriter writer = new StreamWriter(file_path);
			writer.Write(customer_entry.ToString());
			writer.Close();
		}
	}
}
