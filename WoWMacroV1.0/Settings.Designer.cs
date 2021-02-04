namespace WoWMacroV1._0
{
	partial class Settings
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
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.macroGrid = new System.Windows.Forms.DataGridView();
			this.startKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.repeatKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stopKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.macroGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(12, 218);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Location = new System.Drawing.Point(96, 218);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(75, 23);
			this.removeButton.TabIndex = 2;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// macroGrid
			// 
			this.macroGrid.AllowUserToAddRows = false;
			this.macroGrid.AllowUserToDeleteRows = false;
			this.macroGrid.AllowUserToResizeColumns = false;
			this.macroGrid.AllowUserToResizeRows = false;
			this.macroGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.macroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.macroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.macroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startKey,
            this.repeatKey,
            this.stopKey,
            this.interval});
			this.macroGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.macroGrid.Location = new System.Drawing.Point(12, 12);
			this.macroGrid.Name = "macroGrid";
			this.macroGrid.RowHeadersVisible = false;
			this.macroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.macroGrid.Size = new System.Drawing.Size(432, 196);
			this.macroGrid.TabIndex = 3;
			this.macroGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.macroGrid_KeyDown);
			// 
			// startKey
			// 
			this.startKey.HeaderText = "Start Key";
			this.startKey.Name = "startKey";
			this.startKey.ReadOnly = true;
			// 
			// repeatKey
			// 
			this.repeatKey.HeaderText = "Repeat Key";
			this.repeatKey.Name = "repeatKey";
			this.repeatKey.ReadOnly = true;
			// 
			// stopKey
			// 
			this.stopKey.HeaderText = "Stop Key";
			this.stopKey.Name = "stopKey";
			this.stopKey.ReadOnly = true;
			// 
			// interval
			// 
			this.interval.HeaderText = "Interval";
			this.interval.Name = "interval";
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 251);
			this.Controls.Add(this.macroGrid);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.addButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.macroGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.DataGridView macroGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn startKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn repeatKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn stopKey;
		private System.Windows.Forms.DataGridViewTextBoxColumn interval;
	}
}

