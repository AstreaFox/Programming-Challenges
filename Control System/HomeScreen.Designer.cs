namespace Control_System
{
	partial class form_label
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
			this.button_Orders = new System.Windows.Forms.Button();
			this.button_Stock = new System.Windows.Forms.Button();
			this.button_customers = new System.Windows.Forms.Button();
			this.button_staff = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_Orders
			// 
			this.button_Orders.Location = new System.Drawing.Point(12, 12);
			this.button_Orders.Name = "button_Orders";
			this.button_Orders.Size = new System.Drawing.Size(150, 50);
			this.button_Orders.TabIndex = 0;
			this.button_Orders.Text = "Orders";
			this.button_Orders.UseVisualStyleBackColor = true;
			// 
			// button_Stock
			// 
			this.button_Stock.Location = new System.Drawing.Point(169, 12);
			this.button_Stock.Name = "button_Stock";
			this.button_Stock.Size = new System.Drawing.Size(150, 50);
			this.button_Stock.TabIndex = 1;
			this.button_Stock.Text = "Stock";
			this.button_Stock.UseVisualStyleBackColor = true;
			// 
			// button_customers
			// 
			this.button_customers.Location = new System.Drawing.Point(169, 68);
			this.button_customers.Name = "button_customers";
			this.button_customers.Size = new System.Drawing.Size(150, 50);
			this.button_customers.TabIndex = 2;
			this.button_customers.Text = "Customers";
			this.button_customers.UseVisualStyleBackColor = true;
			this.button_customers.Click += new System.EventHandler(this.Button_customers_Click);
			// 
			// button_staff
			// 
			this.button_staff.Location = new System.Drawing.Point(12, 68);
			this.button_staff.Name = "button_staff";
			this.button_staff.Size = new System.Drawing.Size(150, 50);
			this.button_staff.TabIndex = 3;
			this.button_staff.Text = "Staff";
			this.button_staff.UseVisualStyleBackColor = true;
			// 
			// form_label
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1142, 987);
			this.Controls.Add(this.button_staff);
			this.Controls.Add(this.button_customers);
			this.Controls.Add(this.button_Stock);
			this.Controls.Add(this.button_Orders);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "form_label";
			this.ShowIcon = false;
			this.Text = "Control System V1.0";
			this.Load += new System.EventHandler(this.Form_label_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_label_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_Orders;
		private System.Windows.Forms.Button button_Stock;
		private System.Windows.Forms.Button button_customers;
		private System.Windows.Forms.Button button_staff;
	}
}

