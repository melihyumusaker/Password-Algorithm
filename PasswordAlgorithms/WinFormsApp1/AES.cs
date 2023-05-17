using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class AES : Form
	{
		private string encryptedString, decryptedString,userName;
		public AES(string encryptedString , string decryptedString)
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			this.encryptedString = encryptedString;
			this.decryptedString = decryptedString;
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AES_Load(object sender, EventArgs e)
		{
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lbl1.Text = encryptedString;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			lbl2.Text = decryptedString;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AES_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
