namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnaes = new System.Windows.Forms.Button();
			this.txtkullaniciadi = new System.Windows.Forms.Label();
			this.txtsifre = new System.Windows.Forms.Label();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.btnblowfish = new System.Windows.Forms.Button();
			this.btnrijndael = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.progresBarText = new System.Windows.Forms.Label();
			this.buttonRSA = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnaes
			// 
			this.btnaes.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btnaes.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnaes.Location = new System.Drawing.Point(45, 368);
			this.btnaes.Name = "btnaes";
			this.btnaes.Size = new System.Drawing.Size(163, 53);
			this.btnaes.TabIndex = 0;
			this.btnaes.Text = "Register With AES";
			this.btnaes.UseVisualStyleBackColor = false;
			this.btnaes.Click += new System.EventHandler(this.btnaes_Click);
			// 
			// txtkullaniciadi
			// 
			this.txtkullaniciadi.AutoSize = true;
			this.txtkullaniciadi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtkullaniciadi.Location = new System.Drawing.Point(72, 175);
			this.txtkullaniciadi.Name = "txtkullaniciadi";
			this.txtkullaniciadi.Size = new System.Drawing.Size(97, 23);
			this.txtkullaniciadi.TabIndex = 1;
			this.txtkullaniciadi.Text = "User Name";
			this.txtkullaniciadi.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtsifre
			// 
			this.txtsifre.AutoSize = true;
			this.txtsifre.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtsifre.Location = new System.Drawing.Point(83, 228);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.Size = new System.Drawing.Size(86, 23);
			this.txtsifre.TabIndex = 1;
			this.txtsifre.Text = "Password";
			// 
			// textBoxUser
			// 
			this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxUser.Location = new System.Drawing.Point(186, 173);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(165, 27);
			this.textBoxUser.TabIndex = 2;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textBoxPassword.Location = new System.Drawing.Point(186, 228);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(165, 27);
			this.textBoxPassword.TabIndex = 2;
			this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// btnblowfish
			// 
			this.btnblowfish.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btnblowfish.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnblowfish.Location = new System.Drawing.Point(225, 368);
			this.btnblowfish.Name = "btnblowfish";
			this.btnblowfish.Size = new System.Drawing.Size(163, 53);
			this.btnblowfish.TabIndex = 0;
			this.btnblowfish.Text = "Register With BlowFish ";
			this.btnblowfish.UseVisualStyleBackColor = false;
			this.btnblowfish.Click += new System.EventHandler(this.btnblowfish_Click);
			// 
			// btnrijndael
			// 
			this.btnrijndael.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btnrijndael.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnrijndael.Location = new System.Drawing.Point(225, 436);
			this.btnrijndael.Name = "btnrijndael";
			this.btnrijndael.Size = new System.Drawing.Size(163, 53);
			this.btnrijndael.TabIndex = 0;
			this.btnrijndael.Text = "Register With Rijndael";
			this.btnrijndael.UseVisualStyleBackColor = false;
			this.btnrijndael.Click += new System.EventHandler(this.btnrijndael_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(35, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(369, 78);
			this.label1.TabIndex = 1;
			this.label1.Text = "Register Page";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// progressBar
			// 
			this.progressBar.ForeColor = System.Drawing.Color.Aqua;
			this.progressBar.Location = new System.Drawing.Point(186, 278);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(165, 39);
			this.progressBar.TabIndex = 3;
			this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
			// 
			// progresBarText
			// 
			this.progresBarText.AutoSize = true;
			this.progresBarText.Location = new System.Drawing.Point(357, 287);
			this.progresBarText.Name = "progresBarText";
			this.progresBarText.Size = new System.Drawing.Size(45, 20);
			this.progresBarText.TabIndex = 1;
			this.progresBarText.Text = "Weak";
			// 
			// buttonRSA
			// 
			this.buttonRSA.BackColor = System.Drawing.Color.AntiqueWhite;
			this.buttonRSA.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonRSA.Location = new System.Drawing.Point(45, 436);
			this.buttonRSA.Name = "buttonRSA";
			this.buttonRSA.Size = new System.Drawing.Size(163, 53);
			this.buttonRSA.TabIndex = 5;
			this.buttonRSA.Text = "Register With RSA";
			this.buttonRSA.UseVisualStyleBackColor = false;
			this.buttonRSA.Click += new System.EventHandler(this.buttonRSA_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(443, 543);
			this.Controls.Add(this.buttonRSA);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.progresBarText);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtkullaniciadi);
			this.Controls.Add(this.btnrijndael);
			this.Controls.Add(this.btnblowfish);
			this.Controls.Add(this.btnaes);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnaes;
		private Label txtkullaniciadi;
		private Label txtsifre;
		private TextBox textBoxUser;
		private TextBox textBoxPassword;
		private Button btnblowfish;
		private Button btnrijndael;
		private Label label1;
		private ProgressBar progressBar;
		private Label progresBarText;
		private Button buttonRSA;
	}
}