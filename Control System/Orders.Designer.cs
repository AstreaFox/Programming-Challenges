namespace Control_System
{
	partial class Orders
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
			this.button_create_order = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_create_order
			// 
			this.button_create_order.Location = new System.Drawing.Point(23, 30);
			this.button_create_order.Name = "button_create_order";
			this.button_create_order.Size = new System.Drawing.Size(95, 68);
			this.button_create_order.TabIndex = 0;
			this.button_create_order.Text = "Create Order";
			this.button_create_order.UseVisualStyleBackColor = true;
			this.button_create_order.Click += new System.EventHandler(this.Button_create_order_Click);
			// 
			// Orders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1562, 1019);
			this.Controls.Add(this.button_create_order);
			this.Name = "Orders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orders";
			this.Load += new System.EventHandler(this.Orders_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_create_order;
	}
}