namespace WinFormsApp1
{
	partial class AES
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
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl1.Location = new System.Drawing.Point(11, 204);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(204, 20);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "Encyrepted Password Area";
			this.lbl1.Click += new System.EventHandler(this.label1_Click);
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl2.Location = new System.Drawing.Point(10, 333);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(205, 20);
			this.lbl2.TabIndex = 1;
			this.lbl2.Text = "Decyrepted Password Area";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(11, 141);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(218, 39);
			this.button1.TabIndex = 2;
			this.button1.Text = "Encrypted Password";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(11, 264);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(218, 39);
			this.button2.TabIndex = 2;
			this.button2.Text = "Decryrepted Password";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(11, 47);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 31);
			this.button3.TabIndex = 3;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(245, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 78);
			this.label1.TabIndex = 4;
			this.label1.Text = "AES Page";
			// 
			// AES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(536, 412);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Name = "AES";
			this.Text = "AES";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AES_FormClosed);
			this.Load += new System.EventHandler(this.AES_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lbl1;
		private Label lbl2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;
	}
}