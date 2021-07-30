
namespace WLRC___Windows_Location_Reworker_Companion
{
	partial class Form1
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
			this.button_select_directory = new System.Windows.Forms.Button();
			this.TreeView = new System.Windows.Forms.TreeView();
			this.label_directory = new System.Windows.Forms.Label();
			this.ComboBox_operation = new System.Windows.Forms.ComboBox();
			this.ListViewBox_bat_commands = new System.Windows.Forms.ListView();
			this.column_operation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.column_command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textbox_command = new System.Windows.Forms.TextBox();
			this.button_submit_command = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_operation_info = new System.Windows.Forms.Label();
			this.button_export = new System.Windows.Forms.Button();
			this.button_usage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_select_directory
			// 
			this.button_select_directory.Location = new System.Drawing.Point(12, 12);
			this.button_select_directory.Name = "button_select_directory";
			this.button_select_directory.Size = new System.Drawing.Size(130, 40);
			this.button_select_directory.TabIndex = 0;
			this.button_select_directory.Text = "DIRECTORY";
			this.button_select_directory.UseVisualStyleBackColor = true;
			this.button_select_directory.Click += new System.EventHandler(this.Button_select_directory_Click);
			// 
			// TreeView
			// 
			this.TreeView.Location = new System.Drawing.Point(12, 65);
			this.TreeView.Name = "TreeView";
			this.TreeView.Size = new System.Drawing.Size(1200, 500);
			this.TreeView.TabIndex = 1;
			this.TreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
			// 
			// label_directory
			// 
			this.label_directory.AutoSize = true;
			this.label_directory.Location = new System.Drawing.Point(148, 22);
			this.label_directory.Name = "label_directory";
			this.label_directory.Size = new System.Drawing.Size(111, 20);
			this.label_directory.TabIndex = 2;
			this.label_directory.Text = "label_directory";
			this.label_directory.Visible = false;
			// 
			// ComboBox_operation
			// 
			this.ComboBox_operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_operation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ComboBox_operation.FormattingEnabled = true;
			this.ComboBox_operation.Items.AddRange(new object[] {
            "CD",
            "CMD",
            "COPY",
            "DEL",
            "EXIT",
            "MD",
            "MORE",
            "MOVE",
            "PAUSE",
            "RD",
            "REM",
            "REN",
            "TASKLIST",
            "TITLE",
            "HELP"});
			this.ComboBox_operation.Location = new System.Drawing.Point(12, 579);
			this.ComboBox_operation.Name = "ComboBox_operation";
			this.ComboBox_operation.Size = new System.Drawing.Size(121, 28);
			this.ComboBox_operation.TabIndex = 3;
			this.ComboBox_operation.SelectedIndexChanged += new System.EventHandler(this.ComboBox_operation_SelectedIndexChanged);
			// 
			// ListViewBox_bat_commands
			// 
			this.ListViewBox_bat_commands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_operation,
            this.column_command});
			this.ListViewBox_bat_commands.FullRowSelect = true;
			this.ListViewBox_bat_commands.GridLines = true;
			this.ListViewBox_bat_commands.HideSelection = false;
			this.ListViewBox_bat_commands.Location = new System.Drawing.Point(12, 677);
			this.ListViewBox_bat_commands.Name = "ListViewBox_bat_commands";
			this.ListViewBox_bat_commands.Size = new System.Drawing.Size(1200, 500);
			this.ListViewBox_bat_commands.TabIndex = 6;
			this.ListViewBox_bat_commands.UseCompatibleStateImageBehavior = false;
			this.ListViewBox_bat_commands.View = System.Windows.Forms.View.Details;
			// 
			// column_operation
			// 
			this.column_operation.Text = "Operation";
			this.column_operation.Width = 105;
			// 
			// column_command
			// 
			this.column_command.Text = "Command";
			this.column_command.Width = 1091;
			// 
			// textbox_command
			// 
			this.textbox_command.Location = new System.Drawing.Point(140, 580);
			this.textbox_command.Name = "textbox_command";
			this.textbox_command.Size = new System.Drawing.Size(945, 26);
			this.textbox_command.TabIndex = 7;
			// 
			// button_submit_command
			// 
			this.button_submit_command.Location = new System.Drawing.Point(1091, 579);
			this.button_submit_command.Name = "button_submit_command";
			this.button_submit_command.Size = new System.Drawing.Size(121, 34);
			this.button_submit_command.TabIndex = 9;
			this.button_submit_command.Text = "SUBMIT";
			this.button_submit_command.UseVisualStyleBackColor = true;
			this.button_submit_command.Click += new System.EventHandler(this.Button_submit_command_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-164, 701);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Select an Operation";
			// 
			// label_operation_info
			// 
			this.label_operation_info.AutoSize = true;
			this.label_operation_info.Location = new System.Drawing.Point(139, 626);
			this.label_operation_info.Name = "label_operation_info";
			this.label_operation_info.Size = new System.Drawing.Size(342, 20);
			this.label_operation_info.TabIndex = 11;
			this.label_operation_info.Text = "Select an Operation to View Usage and Submit";
			// 
			// button_export
			// 
			this.button_export.Enabled = false;
			this.button_export.Location = new System.Drawing.Point(1091, 626);
			this.button_export.Name = "button_export";
			this.button_export.Size = new System.Drawing.Size(121, 34);
			this.button_export.TabIndex = 12;
			this.button_export.Text = "EXPORT";
			this.button_export.UseVisualStyleBackColor = true;
			this.button_export.Click += new System.EventHandler(this.Button_export_Click);
			// 
			// button_usage
			// 
			this.button_usage.Enabled = false;
			this.button_usage.Location = new System.Drawing.Point(12, 618);
			this.button_usage.Name = "button_usage";
			this.button_usage.Size = new System.Drawing.Size(121, 34);
			this.button_usage.TabIndex = 13;
			this.button_usage.Text = "USAGE";
			this.button_usage.UseVisualStyleBackColor = true;
			this.button_usage.Click += new System.EventHandler(this.Button_usage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1226, 1190);
			this.Controls.Add(this.button_usage);
			this.Controls.Add(this.button_export);
			this.Controls.Add(this.label_operation_info);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_submit_command);
			this.Controls.Add(this.textbox_command);
			this.Controls.Add(this.ListViewBox_bat_commands);
			this.Controls.Add(this.ComboBox_operation);
			this.Controls.Add(this.label_directory);
			this.Controls.Add(this.TreeView);
			this.Controls.Add(this.button_select_directory);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WLRC - Windows Location Reworker Companion";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_select_directory;
		private System.Windows.Forms.TreeView TreeView;
		private System.Windows.Forms.Label label_directory;
		private System.Windows.Forms.ComboBox ComboBox_operation;
		private System.Windows.Forms.ColumnHeader column_operation;
		private System.Windows.Forms.ColumnHeader column_command;
		private System.Windows.Forms.TextBox textbox_command;
		private System.Windows.Forms.Button button_submit_command;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_operation_info;
		private System.Windows.Forms.Button button_export;
		private System.Windows.Forms.Button button_usage;
		private System.Windows.Forms.ListView ListViewBox_bat_commands;
	}
}

