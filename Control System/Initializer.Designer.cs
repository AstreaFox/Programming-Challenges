namespace Control_System
{
	partial class Initializer
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
			this.label_enter_key = new System.Windows.Forms.Label();
			this.txtbox_key = new System.Windows.Forms.TextBox();
			this.btn_decrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_enter_key
			// 
			this.label_enter_key.AutoSize = true;
			this.label_enter_key.Location = new System.Drawing.Point(204, 24);
			this.label_enter_key.Name = "label_enter_key";
			this.label_enter_key.Size = new System.Drawing.Size(80, 20);
			this.label_enter_key.TabIndex = 0;
			this.label_enter_key.Text = "Enter key:";
			// 
			// txtbox_key
			// 
			this.txtbox_key.Location = new System.Drawing.Point(62, 57);
			this.txtbox_key.Name = "txtbox_key";
			this.txtbox_key.Size = new System.Drawing.Size(375, 26);
			this.txtbox_key.TabIndex = 1;
			// 
			// btn_decrypt
			// 
			this.btn_decrypt.Location = new System.Drawing.Point(119, 101);
			this.btn_decrypt.Name = "btn_decrypt";
			this.btn_decrypt.Size = new System.Drawing.Size(249, 43);
			this.btn_decrypt.TabIndex = 2;
			this.btn_decrypt.Text = "Decrypt and Load";
			this.btn_decrypt.UseVisualStyleBackColor = true;
			this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
			// 
			// Initializer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(502, 162);
			this.Controls.Add(this.btn_decrypt);
			this.Controls.Add(this.txtbox_key);
			this.Controls.Add(this.label_enter_key);
			this.Name = "Initializer";
			this.Text = "Initializer";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_enter_key;
		private System.Windows.Forms.TextBox txtbox_key;
		private System.Windows.Forms.Button btn_decrypt;
	}
}