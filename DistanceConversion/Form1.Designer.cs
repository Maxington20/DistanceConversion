namespace DistanceConversion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.SourceListBox = new System.Windows.Forms.ListBox();
			this.TargetListbox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.InputTextbox = new System.Windows.Forms.TextBox();
			this.AnswerTextbox = new System.Windows.Forms.TextBox();
			this.ConvertButton = new System.Windows.Forms.Button();
			this.exitBox = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SourceListBox
			// 
			this.SourceListBox.BackColor = System.Drawing.Color.Navy;
			this.SourceListBox.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceListBox.ForeColor = System.Drawing.SystemColors.Window;
			this.SourceListBox.FormattingEnabled = true;
			this.SourceListBox.ItemHeight = 23;
			this.SourceListBox.Location = new System.Drawing.Point(55, 175);
			this.SourceListBox.Name = "SourceListBox";
			this.SourceListBox.Size = new System.Drawing.Size(141, 96);
			this.SourceListBox.TabIndex = 0;
			this.SourceListBox.SelectedIndexChanged += new System.EventHandler(this.SourceListBox_SelectedIndexChanged);
			// 
			// TargetListbox
			// 
			this.TargetListbox.BackColor = System.Drawing.Color.Navy;
			this.TargetListbox.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TargetListbox.ForeColor = System.Drawing.Color.White;
			this.TargetListbox.FormattingEnabled = true;
			this.TargetListbox.ItemHeight = 23;
			this.TargetListbox.Location = new System.Drawing.Point(472, 175);
			this.TargetListbox.Name = "TargetListbox";
			this.TargetListbox.Size = new System.Drawing.Size(145, 96);
			this.TargetListbox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("AR ESSENCE", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(126, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(422, 58);
			this.label1.TabIndex = 2;
			this.label1.Text = "The Distance Converter";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(55, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "Base Unit";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(466, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 33);
			this.label3.TabIndex = 4;
			this.label3.Text = "Target Unit";
			// 
			// InputTextbox
			// 
			this.InputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputTextbox.Location = new System.Drawing.Point(225, 158);
			this.InputTextbox.Name = "InputTextbox";
			this.InputTextbox.Size = new System.Drawing.Size(210, 26);
			this.InputTextbox.TabIndex = 5;
			this.InputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InputTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextbox_KeyPress);
			// 
			// AnswerTextbox
			// 
			this.AnswerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnswerTextbox.Location = new System.Drawing.Point(225, 275);
			this.AnswerTextbox.Name = "AnswerTextbox";
			this.AnswerTextbox.ReadOnly = true;
			this.AnswerTextbox.Size = new System.Drawing.Size(210, 26);
			this.AnswerTextbox.TabIndex = 6;
			this.AnswerTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ConvertButton
			// 
			this.ConvertButton.Enabled = false;
			this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConvertButton.Location = new System.Drawing.Point(290, 190);
			this.ConvertButton.Name = "ConvertButton";
			this.ConvertButton.Size = new System.Drawing.Size(87, 40);
			this.ConvertButton.TabIndex = 7;
			this.ConvertButton.Text = "Convert";
			this.ConvertButton.UseVisualStyleBackColor = true;
			this.ConvertButton.Click += new System.EventHandler(this.Convert_Click);
			// 
			// exitBox
			// 
			this.exitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitBox.Location = new System.Drawing.Point(290, 327);
			this.exitBox.Name = "exitBox";
			this.exitBox.Size = new System.Drawing.Size(87, 38);
			this.exitBox.TabIndex = 9;
			this.exitBox.Text = "Exit";
			this.exitBox.UseVisualStyleBackColor = true;
			this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(211, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(250, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Enter number in the box below";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(286, 253);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 19);
			this.label5.TabIndex = 11;
			this.label5.Text = "Converts to";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(664, 377);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.exitBox);
			this.Controls.Add(this.ConvertButton);
			this.Controls.Add(this.AnswerTextbox);
			this.Controls.Add(this.InputTextbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TargetListbox);
			this.Controls.Add(this.SourceListBox);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Distance Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox SourceListBox;
		private System.Windows.Forms.ListBox TargetListbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox InputTextbox;
		private System.Windows.Forms.TextBox AnswerTextbox;
		private System.Windows.Forms.Button ConvertButton;
		private System.Windows.Forms.Button exitBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

