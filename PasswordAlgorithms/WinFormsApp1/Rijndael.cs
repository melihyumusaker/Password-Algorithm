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
	public partial class Rijndael : Form
	{
		private string encryptedString, decryptedString;

		public Rijndael(string encryptedString, string decryptedString)
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			this.encryptedString = encryptedString;
			this.decryptedString = decryptedString;
			InitializeComponent();
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			lbl1.Text = encryptedString;
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			lbl2.Text = decryptedString;
		}
	}
}
