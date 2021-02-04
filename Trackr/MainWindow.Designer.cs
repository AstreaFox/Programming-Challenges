namespace Trackr
{
	partial class MainWindow
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
			this.scrollPanel = new System.Windows.Forms.Panel();
			this.notePanel = new System.Windows.Forms.Panel();
			this.trackBar = new System.Windows.Forms.TrackBar();
			this.noteCountLabel = new System.Windows.Forms.Label();
			this.noteCountBox = new System.Windows.Forms.NumericUpDown();
			this.npmBox = new System.Windows.Forms.NumericUpDown();
			this.npmLabel = new System.Windows.Forms.Label();
			this.stopButton = new System.Windows.Forms.Button();
			this.playButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.scrollPanel.SuspendLayout();
			this.notePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.noteCountBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.npmBox)).BeginInit();
			this.SuspendLayout();
			// 
			// scrollPanel
			// 
			this.scrollPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scrollPanel.AutoScroll = true;
			this.scrollPanel.Controls.Add(this.notePanel);
			this.scrollPanel.Location = new System.Drawing.Point(52, 12);
			this.scrollPanel.Name = "scrollPanel";
			this.scrollPanel.Size = new System.Drawing.Size(629, 437);
			this.scrollPanel.TabIndex = 0;
			// 
			// notePanel
			// 
			this.notePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.notePanel.Controls.Add(this.trackBar);
			this.notePanel.Location = new System.Drawing.Point(0, 0);
			this.notePanel.Name = "notePanel";
			this.notePanel.Size = new System.Drawing.Size(619, 437);
			this.notePanel.TabIndex = 0;
			// 
			// trackBar
			// 
			this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.trackBar.LargeChange = 8;
			this.trackBar.Location = new System.Drawing.Point(3, 389);
			this.trackBar.Maximum = 15;
			this.trackBar.Name = "trackBar";
			this.trackBar.Size = new System.Drawing.Size(570, 45);
			this.trackBar.TabIndex = 0;
			this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// noteCountLabel
			// 
			this.noteCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.noteCountLabel.AutoSize = true;
			this.noteCountLabel.Location = new System.Drawing.Point(695, 25);
			this.noteCountLabel.Name = "noteCountLabel";
			this.noteCountLabel.Size = new System.Drawing.Size(61, 13);
			this.noteCountLabel.TabIndex = 1;
			this.noteCountLabel.Text = "Note Count";
			// 
			// noteCountBox
			// 
			this.noteCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.noteCountBox.Location = new System.Drawing.Point(698, 46);
			this.noteCountBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.noteCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.noteCountBox.Name = "noteCountBox";
			this.noteCountBox.Size = new System.Drawing.Size(90, 20);
			this.noteCountBox.TabIndex = 2;
			this.noteCountBox.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
			this.noteCountBox.ValueChanged += new System.EventHandler(this.OnRender);
			// 
			// npmBox
			// 
			this.npmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.npmBox.Location = new System.Drawing.Point(698, 108);
			this.npmBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.npmBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.npmBox.Name = "npmBox";
			this.npmBox.Size = new System.Drawing.Size(90, 20);
			this.npmBox.TabIndex = 4;
			this.npmBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.npmBox.ValueChanged += new System.EventHandler(this.OnTempoChange);
			// 
			// npmLabel
			// 
			this.npmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.npmLabel.AutoSize = true;
			this.npmLabel.Location = new System.Drawing.Point(695, 87);
			this.npmLabel.Name = "npmLabel";
			this.npmLabel.Size = new System.Drawing.Size(89, 13);
			this.npmLabel.TabIndex = 3;
			this.npmLabel.Text = "Notes Per Minute";
			// 
			// stopButton
			// 
			this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stopButton.Location = new System.Drawing.Point(698, 168);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(38, 38);
			this.stopButton.TabIndex = 5;
			this.stopButton.Text = "⏹";
			this.stopButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.OnStop);
			// 
			// playButton
			// 
			this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playButton.Location = new System.Drawing.Point(750, 168);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(38, 38);
			this.playButton.TabIndex = 6;
			this.playButton.Text = "▶";
			this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.OnPlay);
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(698, 247);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(90, 32);
			this.openButton.TabIndex = 7;
			this.openButton.Text = "Open...";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.OnOpen);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(698, 291);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(90, 32);
			this.saveButton.TabIndex = 8;
			this.saveButton.Text = "Save...";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.OnSave);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 461);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.npmBox);
			this.Controls.Add(this.npmLabel);
			this.Controls.Add(this.noteCountBox);
			this.Controls.Add(this.noteCountLabel);
			this.Controls.Add(this.scrollPanel);
			this.Name = "MainWindow";
			this.Text = "Trackr";
			this.Load += new System.EventHandler(this.OnLoad);
			this.scrollPanel.ResumeLayout(false);
			this.notePanel.ResumeLayout(false);
			this.notePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.noteCountBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.npmBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel scrollPanel;
		private System.Windows.Forms.Panel notePanel;
		private System.Windows.Forms.TrackBar trackBar;
		private System.Windows.Forms.Label noteCountLabel;
		private System.Windows.Forms.NumericUpDown noteCountBox;
		private System.Windows.Forms.NumericUpDown npmBox;
		private System.Windows.Forms.Label npmLabel;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button saveButton;
	}
}

