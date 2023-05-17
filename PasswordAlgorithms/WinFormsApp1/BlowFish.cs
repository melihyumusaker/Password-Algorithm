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
	public partial class BlowFish : Form
	{
		private string encryptedString, decryptedString;
		public BlowFish(string encryptedString, string decryptedString)
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			this.encryptedString = encryptedString;
			this.decryptedString = decryptedString;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lbl1.Text = encryptedString;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			lbl2.Text = decryptedString;
		}

		private void BlowFish_Load(object sender, EventArgs e)
		{
			

		}
	}
}
