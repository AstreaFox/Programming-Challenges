namespace Control_System
{
	partial class Customers
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listview_existing_customers = new System.Windows.Forms.ListView();
			this.col_forenames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_surnames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label_existing_customers = new System.Windows.Forms.Label();
			this.rtb_notes = new System.Windows.Forms.RichTextBox();
			this.label_notes = new System.Windows.Forms.Label();
			this.button_create_customer = new System.Windows.Forms.Button();
			this.combobox_countries = new System.Windows.Forms.ComboBox();
			this.combobox_gender = new System.Windows.Forms.ComboBox();
			this.txtbox_post_zip_code = new System.Windows.Forms.TextBox();
			this.txtbox_state_province = new System.Windows.Forms.TextBox();
			this.label_state_province = new System.Windows.Forms.Label();
			this.label_post_zip_code = new System.Windows.Forms.Label();
			this.label_country = new System.Windows.Forms.Label();
			this.txtbox_city = new System.Windows.Forms.TextBox();
			this.txtbox_address_line_2 = new System.Windows.Forms.TextBox();
			this.txtbox_address_line_1 = new System.Windows.Forms.TextBox();
			this.label_address_line_1 = new System.Windows.Forms.Label();
			this.label_city = new System.Windows.Forms.Label();
			this.label_address_line_2 = new System.Windows.Forms.Label();
			this.txtbox_phone = new System.Windows.Forms.TextBox();
			this.txtbox_email = new System.Windows.Forms.TextBox();
			this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
			this.txtbox_alias = new System.Windows.Forms.TextBox();
			this.txtbox_surnames = new System.Windows.Forms.TextBox();
			this.txtbox_forenames = new System.Windows.Forms.TextBox();
			this.label_forenames = new System.Windows.Forms.Label();
			this.label_gender = new System.Windows.Forms.Label();
			this.label_email = new System.Windows.Forms.Label();
			this.label_phone = new System.Windows.Forms.Label();
			this.label_alias = new System.Windows.Forms.Label();
			this.label_birthday = new System.Windows.Forms.Label();
			this.label_surnames = new System.Windows.Forms.Label();
			this.button_staff = new System.Windows.Forms.Button();
			this.button_customers = new System.Windows.Forms.Button();
			this.button_Stock = new System.Windows.Forms.Button();
			this.button_Orders = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listview_existing_customers
			// 
			this.listview_existing_customers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_forenames,
            this.col_surnames});
			this.listview_existing_customers.FullRowSelect = true;
			this.listview_existing_customers.GridLines = true;
			this.listview_existing_customers.HideSelection = false;
			this.listview_existing_customers.Location = new System.Drawing.Point(827, 172);
			this.listview_existing_customers.Name = "listview_existing_customers";
			this.listview_existing_customers.Size = new System.Drawing.Size(459, 835);
			this.listview_existing_customers.TabIndex = 89;
			this.listview_existing_customers.UseCompatibleStateImageBehavior = false;
			this.listview_existing_customers.View = System.Windows.Forms.View.Tile;
			// 
			// col_forenames
			// 
			this.col_forenames.Text = "Forename(s)";
			this.col_forenames.Width = 453;
			// 
			// col_surnames
			// 
			this.col_surnames.Text = "Surname(s)";
			// 
			// label_existing_customers
			// 
			this.label_existing_customers.AutoSize = true;
			this.label_existing_customers.Location = new System.Drawing.Point(985, 118);
			this.label_existing_customers.Name = "label_existing_customers";
			this.label_existing_customers.Size = new System.Drawing.Size(149, 20);
			this.label_existing_customers.TabIndex = 88;
			this.label_existing_customers.Text = "Existing Customers:";
			// 
			// rtb_notes
			// 
			this.rtb_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtb_notes.Location = new System.Drawing.Point(321, 804);
			this.rtb_notes.Name = "rtb_notes";
			this.rtb_notes.Size = new System.Drawing.Size(322, 108);
			this.rtb_notes.TabIndex = 87;
			this.rtb_notes.Text = "";
			// 
			// label_notes
			// 
			this.label_notes.AutoSize = true;
			this.label_notes.ForeColor = System.Drawing.Color.Red;
			this.label_notes.Location = new System.Drawing.Point(182, 804);
			this.label_notes.Name = "label_notes";
			this.label_notes.Size = new System.Drawing.Size(55, 20);
			this.label_notes.TabIndex = 86;
			this.label_notes.Text = "Notes:";
			// 
			// button_create_customer
			// 
			this.button_create_customer.Location = new System.Drawing.Point(321, 957);
			this.button_create_customer.Name = "button_create_customer";
			this.button_create_customer.Size = new System.Drawing.Size(150, 50);
			this.button_create_customer.TabIndex = 85;
			this.button_create_customer.Text = "Create";
			this.button_create_customer.UseVisualStyleBackColor = true;
			this.button_create_customer.Click += new System.EventHandler(this.Button_create_customer_Click);
			// 
			// combobox_countries
			// 
			this.combobox_countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combobox_countries.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.combobox_countries.FormattingEnabled = true;
			this.combobox_countries.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
			this.combobox_countries.Location = new System.Drawing.Point(321, 758);
			this.combobox_countries.Name = "combobox_countries";
			this.combobox_countries.Size = new System.Drawing.Size(322, 28);
			this.combobox_countries.TabIndex = 84;
			// 
			// combobox_gender
			// 
			this.combobox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combobox_gender.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.combobox_gender.FormattingEnabled = true;
			this.combobox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-binary",
            "Genderfluid",
            "Other"});
			this.combobox_gender.Location = new System.Drawing.Point(321, 363);
			this.combobox_gender.Name = "combobox_gender";
			this.combobox_gender.Size = new System.Drawing.Size(200, 28);
			this.combobox_gender.TabIndex = 83;
			// 
			// txtbox_post_zip_code
			// 
			this.txtbox_post_zip_code.Location = new System.Drawing.Point(321, 711);
			this.txtbox_post_zip_code.Name = "txtbox_post_zip_code";
			this.txtbox_post_zip_code.Size = new System.Drawing.Size(322, 26);
			this.txtbox_post_zip_code.TabIndex = 82;
			// 
			// txtbox_state_province
			// 
			this.txtbox_state_province.Location = new System.Drawing.Point(321, 660);
			this.txtbox_state_province.Name = "txtbox_state_province";
			this.txtbox_state_province.Size = new System.Drawing.Size(322, 26);
			this.txtbox_state_province.TabIndex = 81;
			// 
			// label_state_province
			// 
			this.label_state_province.AutoSize = true;
			this.label_state_province.ForeColor = System.Drawing.Color.Red;
			this.label_state_province.Location = new System.Drawing.Point(182, 661);
			this.label_state_province.Name = "label_state_province";
			this.label_state_province.Size = new System.Drawing.Size(116, 20);
			this.label_state_province.TabIndex = 80;
			this.label_state_province.Text = "State/Province:";
			// 
			// label_post_zip_code
			// 
			this.label_post_zip_code.AutoSize = true;
			this.label_post_zip_code.ForeColor = System.Drawing.Color.Red;
			this.label_post_zip_code.Location = new System.Drawing.Point(182, 711);
			this.label_post_zip_code.Name = "label_post_zip_code";
			this.label_post_zip_code.Size = new System.Drawing.Size(125, 20);
			this.label_post_zip_code.TabIndex = 79;
			this.label_post_zip_code.Text = "Postal/Zip Code:";
			// 
			// label_country
			// 
			this.label_country.AutoSize = true;
			this.label_country.ForeColor = System.Drawing.Color.Red;
			this.label_country.Location = new System.Drawing.Point(182, 758);
			this.label_country.Name = "label_country";
			this.label_country.Size = new System.Drawing.Size(68, 20);
			this.label_country.TabIndex = 78;
			this.label_country.Text = "Country:";
			// 
			// txtbox_city
			// 
			this.txtbox_city.Location = new System.Drawing.Point(321, 606);
			this.txtbox_city.Name = "txtbox_city";
			this.txtbox_city.Size = new System.Drawing.Size(322, 26);
			this.txtbox_city.TabIndex = 77;
			// 
			// txtbox_address_line_2
			// 
			this.txtbox_address_line_2.Location = new System.Drawing.Point(321, 555);
			this.txtbox_address_line_2.Name = "txtbox_address_line_2";
			this.txtbox_address_line_2.Size = new System.Drawing.Size(322, 26);
			this.txtbox_address_line_2.TabIndex = 76;
			// 
			// txtbox_address_line_1
			// 
			this.txtbox_address_line_1.Location = new System.Drawing.Point(321, 511);
			this.txtbox_address_line_1.Name = "txtbox_address_line_1";
			this.txtbox_address_line_1.Size = new System.Drawing.Size(322, 26);
			this.txtbox_address_line_1.TabIndex = 75;
			// 
			// label_address_line_1
			// 
			this.label_address_line_1.AutoSize = true;
			this.label_address_line_1.ForeColor = System.Drawing.Color.Red;
			this.label_address_line_1.Location = new System.Drawing.Point(182, 511);
			this.label_address_line_1.Name = "label_address_line_1";
			this.label_address_line_1.Size = new System.Drawing.Size(119, 20);
			this.label_address_line_1.TabIndex = 74;
			this.label_address_line_1.Text = "Address Line 1:";
			// 
			// label_city
			// 
			this.label_city.AutoSize = true;
			this.label_city.ForeColor = System.Drawing.Color.Red;
			this.label_city.Location = new System.Drawing.Point(182, 612);
			this.label_city.Name = "label_city";
			this.label_city.Size = new System.Drawing.Size(39, 20);
			this.label_city.TabIndex = 73;
			this.label_city.Text = "City:";
			// 
			// label_address_line_2
			// 
			this.label_address_line_2.AutoSize = true;
			this.label_address_line_2.ForeColor = System.Drawing.Color.Red;
			this.label_address_line_2.Location = new System.Drawing.Point(182, 561);
			this.label_address_line_2.Name = "label_address_line_2";
			this.label_address_line_2.Size = new System.Drawing.Size(119, 20);
			this.label_address_line_2.TabIndex = 72;
			this.label_address_line_2.Text = "Address Line 2:";
			// 
			// txtbox_phone
			// 
			this.txtbox_phone.Location = new System.Drawing.Point(321, 466);
			this.txtbox_phone.Name = "txtbox_phone";
			this.txtbox_phone.Size = new System.Drawing.Size(322, 26);
			this.txtbox_phone.TabIndex = 71;
			// 
			// txtbox_email
			// 
			this.txtbox_email.Location = new System.Drawing.Point(321, 419);
			this.txtbox_email.Name = "txtbox_email";
			this.txtbox_email.Size = new System.Drawing.Size(322, 26);
			this.txtbox_email.TabIndex = 70;
			// 
			// dtp_birthday
			// 
			this.dtp_birthday.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dtp_birthday.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
			this.dtp_birthday.Location = new System.Drawing.Point(321, 318);
			this.dtp_birthday.Name = "dtp_birthday";
			this.dtp_birthday.Size = new System.Drawing.Size(200, 26);
			this.dtp_birthday.TabIndex = 69;
			// 
			// txtbox_alias
			// 
			this.txtbox_alias.Location = new System.Drawing.Point(321, 267);
			this.txtbox_alias.Name = "txtbox_alias";
			this.txtbox_alias.Size = new System.Drawing.Size(322, 26);
			this.txtbox_alias.TabIndex = 68;
			// 
			// txtbox_surnames
			// 
			this.txtbox_surnames.Location = new System.Drawing.Point(321, 216);
			this.txtbox_surnames.Name = "txtbox_surnames";
			this.txtbox_surnames.Size = new System.Drawing.Size(322, 26);
			this.txtbox_surnames.TabIndex = 67;
			// 
			// txtbox_forenames
			// 
			this.txtbox_forenames.Location = new System.Drawing.Point(321, 172);
			this.txtbox_forenames.Name = "txtbox_forenames";
			this.txtbox_forenames.Size = new System.Drawing.Size(322, 26);
			this.txtbox_forenames.TabIndex = 66;
			// 
			// label_forenames
			// 
			this.label_forenames.AutoSize = true;
			this.label_forenames.ForeColor = System.Drawing.Color.Red;
			this.label_forenames.Location = new System.Drawing.Point(182, 172);
			this.label_forenames.Name = "label_forenames";
			this.label_forenames.Size = new System.Drawing.Size(95, 20);
			this.label_forenames.TabIndex = 65;
			this.label_forenames.Text = "Forname(s):";
			// 
			// label_gender
			// 
			this.label_gender.AutoSize = true;
			this.label_gender.ForeColor = System.Drawing.Color.Red;
			this.label_gender.Location = new System.Drawing.Point(182, 372);
			this.label_gender.Name = "label_gender";
			this.label_gender.Size = new System.Drawing.Size(67, 20);
			this.label_gender.TabIndex = 64;
			this.label_gender.Text = "Gender:";
			// 
			// label_email
			// 
			this.label_email.AutoSize = true;
			this.label_email.ForeColor = System.Drawing.Color.Red;
			this.label_email.Location = new System.Drawing.Point(182, 419);
			this.label_email.Name = "label_email";
			this.label_email.Size = new System.Drawing.Size(52, 20);
			this.label_email.TabIndex = 63;
			this.label_email.Text = "Email:";
			// 
			// label_phone
			// 
			this.label_phone.AutoSize = true;
			this.label_phone.ForeColor = System.Drawing.Color.Red;
			this.label_phone.Location = new System.Drawing.Point(182, 466);
			this.label_phone.Name = "label_phone";
			this.label_phone.Size = new System.Drawing.Size(87, 20);
			this.label_phone.TabIndex = 62;
			this.label_phone.Text = "Phone No.:";
			// 
			// label_alias
			// 
			this.label_alias.AutoSize = true;
			this.label_alias.ForeColor = System.Drawing.Color.Red;
			this.label_alias.Location = new System.Drawing.Point(182, 273);
			this.label_alias.Name = "label_alias";
			this.label_alias.Size = new System.Drawing.Size(47, 20);
			this.label_alias.TabIndex = 61;
			this.label_alias.Text = "Alias:";
			// 
			// label_birthday
			// 
			this.label_birthday.AutoSize = true;
			this.label_birthday.ForeColor = System.Drawing.Color.Red;
			this.label_birthday.Location = new System.Drawing.Point(182, 323);
			this.label_birthday.Name = "label_birthday";
			this.label_birthday.Size = new System.Drawing.Size(71, 20);
			this.label_birthday.TabIndex = 60;
			this.label_birthday.Text = "Birthday:";
			// 
			// label_surnames
			// 
			this.label_surnames.AutoSize = true;
			this.label_surnames.ForeColor = System.Drawing.Color.Red;
			this.label_surnames.Location = new System.Drawing.Point(182, 222);
			this.label_surnames.Name = "label_surnames";
			this.label_surnames.Size = new System.Drawing.Size(96, 20);
			this.label_surnames.TabIndex = 59;
			this.label_surnames.Text = "Surname(s):";
			// 
			// button_staff
			// 
			this.button_staff.Location = new System.Drawing.Point(180, 103);
			this.button_staff.Name = "button_staff";
			this.button_staff.Size = new System.Drawing.Size(150, 50);
			this.button_staff.TabIndex = 58;
			this.button_staff.Text = "Staff";
			this.button_staff.UseVisualStyleBackColor = true;
			// 
			// button_customers
			// 
			this.button_customers.Location = new System.Drawing.Point(337, 103);
			this.button_customers.Name = "button_customers";
			this.button_customers.Size = new System.Drawing.Size(150, 50);
			this.button_customers.TabIndex = 57;
			this.button_customers.Text = "Customers";
			this.button_customers.UseVisualStyleBackColor = true;
			// 
			// button_Stock
			// 
			this.button_Stock.Location = new System.Drawing.Point(337, 47);
			this.button_Stock.Name = "button_Stock";
			this.button_Stock.Size = new System.Drawing.Size(150, 50);
			this.button_Stock.TabIndex = 56;
			this.button_Stock.Text = "Stock";
			this.button_Stock.UseVisualStyleBackColor = true;
			// 
			// button_Orders
			// 
			this.button_Orders.Location = new System.Drawing.Point(180, 47);
			this.button_Orders.Name = "button_Orders";
			this.button_Orders.Size = new System.Drawing.Size(150, 50);
			this.button_Orders.TabIndex = 55;
			this.button_Orders.Text = "Orders";
			this.button_Orders.UseVisualStyleBackColor = true;
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1467, 1054);
			this.Controls.Add(this.listview_existing_customers);
			this.Controls.Add(this.label_existing_customers);
			this.Controls.Add(this.rtb_notes);
			this.Controls.Add(this.label_notes);
			this.Controls.Add(this.button_create_customer);
			this.Controls.Add(this.combobox_countries);
			this.Controls.Add(this.combobox_gender);
			this.Controls.Add(this.txtbox_post_zip_code);
			this.Controls.Add(this.txtbox_state_province);
			this.Controls.Add(this.label_state_province);
			this.Controls.Add(this.label_post_zip_code);
			this.Controls.Add(this.label_country);
			this.Controls.Add(this.txtbox_city);
			this.Controls.Add(this.txtbox_address_line_2);
			this.Controls.Add(this.txtbox_address_line_1);
			this.Controls.Add(this.label_address_line_1);
			this.Controls.Add(this.label_city);
			this.Controls.Add(this.label_address_line_2);
			this.Controls.Add(this.txtbox_phone);
			this.Controls.Add(this.txtbox_email);
			this.Controls.Add(this.dtp_birthday);
			this.Controls.Add(this.txtbox_alias);
			this.Controls.Add(this.txtbox_surnames);
			this.Controls.Add(this.txtbox_forenames);
			this.Controls.Add(this.label_forenames);
			this.Controls.Add(this.label_gender);
			this.Controls.Add(this.label_email);
			this.Controls.Add(this.label_phone);
			this.Controls.Add(this.label_alias);
			this.Controls.Add(this.label_birthday);
			this.Controls.Add(this.label_surnames);
			this.Controls.Add(this.button_staff);
			this.Controls.Add(this.button_customers);
			this.Controls.Add(this.button_Stock);
			this.Controls.Add(this.button_Orders);
			this.Name = "Customers";
			this.Text = "Customers";
			this.Load += new System.EventHandler(this.Customers_label_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listview_existing_customers;
		private System.Windows.Forms.ColumnHeader col_forenames;
		private System.Windows.Forms.ColumnHeader col_surnames;
		private System.Windows.Forms.Label label_existing_customers;
		private System.Windows.Forms.RichTextBox rtb_notes;
		private System.Windows.Forms.Label label_notes;
		private System.Windows.Forms.Button button_create_customer;
		private System.Windows.Forms.ComboBox combobox_countries;
		private System.Windows.Forms.ComboBox combobox_gender;
		private System.Windows.Forms.TextBox txtbox_post_zip_code;
		private System.Windows.Forms.TextBox txtbox_state_province;
		private System.Windows.Forms.Label label_state_province;
		private System.Windows.Forms.Label label_post_zip_code;
		private System.Windows.Forms.Label label_country;
		private System.Windows.Forms.TextBox txtbox_city;
		private System.Windows.Forms.TextBox txtbox_address_line_2;
		private System.Windows.Forms.TextBox txtbox_address_line_1;
		private System.Windows.Forms.Label label_address_line_1;
		private System.Windows.Forms.Label label_city;
		private System.Windows.Forms.Label label_address_line_2;
		private System.Windows.Forms.TextBox txtbox_phone;
		private System.Windows.Forms.TextBox txtbox_email;
		private System.Windows.Forms.DateTimePicker dtp_birthday;
		private System.Windows.Forms.TextBox txtbox_alias;
		private System.Windows.Forms.TextBox txtbox_surnames;
		private System.Windows.Forms.TextBox txtbox_forenames;
		private System.Windows.Forms.Label label_forenames;
		private System.Windows.Forms.Label label_gender;
		private System.Windows.Forms.Label label_email;
		private System.Windows.Forms.Label label_phone;
		private System.Windows.Forms.Label label_alias;
		private System.Windows.Forms.Label label_birthday;
		private System.Windows.Forms.Label label_surnames;
		private System.Windows.Forms.Button button_staff;
		private System.Windows.Forms.Button button_customers;
		private System.Windows.Forms.Button button_Stock;
		private System.Windows.Forms.Button button_Orders;
	}
}