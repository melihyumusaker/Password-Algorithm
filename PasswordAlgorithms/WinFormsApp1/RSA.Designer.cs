namespace WinFormsApp1
{
	partial class RSA
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(255, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(275, 78);
			this.label1.TabIndex = 16;
			this.label1.Text = "RSA Page";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(30, 53);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(97, 31);
			this.btn3.TabIndex = 15;
			this.btn3.Text = "Exit";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(30, 268);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(218, 39);
			this.btn2.TabIndex = 13;
			this.btn2.Text = "Decryrepted Password";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(30, 145);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(218, 39);
			this.btn1.TabIndex = 14;
			this.btn1.Text = "Encrypted Password";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl2.Location = new System.Drawing.Point(29, 337);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(205, 20);
			this.lbl2.TabIndex = 12;
			this.lbl2.Text = "Decyrepted Password Area";
			this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl1.Location = new System.Drawing.Point(30, 208);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(204, 20);
			this.lbl1.TabIndex = 11;
			this.lbl1.Text = "Encyrepted Password Area";
			this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// RSA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(556, 414);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Name = "RSA";
			this.Text = "RSA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Button btn3;
		private Button btn2;
		private Button btn1;
		private Label lbl2;
		private Label lbl1;
	}
}