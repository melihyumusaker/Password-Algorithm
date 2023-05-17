using System.Security.Cryptography;
using System;
using System.IO;
using System.Security.Cryptography;
using System;
using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Paddings;
using System.Data.SqlClient;
using System.Data;



namespace WinFormsApp1
{

	public partial class Form1 : Form
	{

		private int progressBarValue= 0;
		public Form1()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}
		
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnaes.Enabled = false;
			btnblowfish.Enabled = false;
			btnrijndael.Enabled = false;
			buttonRSA.Enabled = false;
			
		}
		private void progressBar_Click(object sender, EventArgs e)
		{

		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			string password = textBoxPassword.Text;
			int score = 0;

			if(password.Length >= 8)
			{
				score++;
				if (password.Length >= 12) score++;													
				if (password.Any(char.IsUpper)) score++;													
				if (password.Any(char.IsDigit)) score++;									
				if (password.Any(c => !char.IsLetterOrDigit(c))) score++;
			}

			progressBar.Value = score * 20;

			progressBarValue= progressBar.Value;

			// Progressbar Text
			if (progressBarValue <= 33) progresBarText.Text = "Weak";
			else if (progressBarValue <= 66) progresBarText.Text = "Medium";
			else if (progressBarValue >= 99) progresBarText.Text = "Strong";
			
			//Button Control
			if (progressBarValue> 66 ) btnaes.Enabled = true;
			if (progressBarValue<= 66 ) btnaes.Enabled = false;
			if (progressBarValue> 66) btnblowfish.Enabled = true;		
			if (progressBarValue<= 66) btnblowfish.Enabled = false;
			if (progressBarValue > 66) btnrijndael.Enabled = true;
			if (progressBarValue <= 66) btnrijndael.Enabled = false;
			if (progressBarValue > 66) buttonRSA.Enabled = true;
			if (progressBarValue <= 66) buttonRSA.Enabled = false;

		}

		private void btnrijndael_Click(object sender, EventArgs e)
		{
			string encryptedString = encodeString();
			string decryptedString = decodeString(encryptedString);

			string username = textBoxUser.Text;
			string query = "INSERT INTO dbo.Rijndael (username, password) VALUES (@username, @encryptedString)";
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BC2LFAE\MELIH;Initial Catalog=CS;Integrated Security=True;"))
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@encryptedString", encryptedString);

				try
				{
					connection.Open();
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}

			Rijndael rijndael = new Rijndael(encryptedString, decryptedString);
			rijndael.Show();

		}

		public string encodeString()
		{
			string password = textBoxPassword.Text;
			string data = password;
			string answer = "";
			string publicKey = "PKEY1234";
			string privateKey = "RKEY4321";
			byte[] privateKeyBytes = { };
			privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
			byte[] publicKeyBytes = { };
			publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
			byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(data);
			using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
			{
				var memoryStream = new MemoryStream();
				var cryptoStream = new CryptoStream(memoryStream,
				provider.CreateEncryptor(publicKeyBytes, privateKeyBytes),
				CryptoStreamMode.Write);
				cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
				cryptoStream.FlushFinalBlock();
				answer = Convert.ToBase64String(memoryStream.ToArray());
			}
			return answer;
		}

		public static string decodeString(String data)
		{
			string answer = "";
			string publicKey = "PKEY1234";
			string privateKey = "RKEY4321";
			byte[] privateKeyBytes = { };
			privateKeyBytes = Encoding.UTF8.GetBytes(privateKey);
			byte[] publicKeyBytes = { };
			publicKeyBytes = Encoding.UTF8.GetBytes(publicKey);
			byte[] inputByteArray = new byte[data.Replace(" ", "+").Length];
			inputByteArray = Convert.FromBase64String(data.Replace(" ", "+"));
			using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
			{
				var memoryStream = new MemoryStream();
				var cryptoStream = new CryptoStream(memoryStream,
				provider.CreateDecryptor(publicKeyBytes, privateKeyBytes),
				CryptoStreamMode.Write);
				cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
				cryptoStream.FlushFinalBlock();
				answer = Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			return answer;
		}


		private void buttonRSA_Click(object sender, EventArgs e)
		{
			UnicodeEncoding ByteConverter = new UnicodeEncoding();
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			byte[] plaintext;
			byte[] encryptedtext;

			plaintext = ByteConverter.GetBytes(textBoxPassword.Text);
			encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
			byte[] decryptedtext = Decryption(encryptedtext, RSA.ExportParameters(true), false);

			string encryptedString = ByteConverter.GetString(encryptedtext);
			string decyrepted = ByteConverter.GetString(decryptedtext);

			string username = textBoxUser.Text;
			string query = "INSERT INTO dbo.RSA (username, password) VALUES (@username, @encryptedString)";
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BC2LFAE\MELIH;Initial Catalog=CS;Integrated Security=True;"))
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@encryptedString", encryptedString);

				try
				{
					connection.Open();
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}

			RSA rsa = new RSA(encryptedString, decyrepted);
			rsa.Show();

		}


		static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
		{
			try
			{
				byte[] decryptedData;
				using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
				{
					RSA.ImportParameters(RSAKey);
					decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
				}
				return decryptedData;
			}
			catch (CryptographicException e)
			{
				Console.WriteLine(e.ToString());
				return null;
			}
		}

		static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
		{
			try
			{
				byte[] encryptedData;
				using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
				{
					RSA.ImportParameters(RSAKey);
					encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
				}
				return encryptedData;
			}
			catch (CryptographicException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{


		}

		private void btnaes_Click(object sender, EventArgs e)
		{

			// Key ve IV'yi oluþtur
			byte[] key = new byte[32];
			byte[] iv = new byte[16];

			// Rastgele sayý üreteci kullanarak Key ve IV'yi oluþtur
			using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
			{
				rngCsp.GetBytes(key);
				rngCsp.GetBytes(iv);
			}

			// Þifrelenecek veri
			byte[] plaintext = System.Text.Encoding.UTF8.GetBytes(textBoxPassword.Text);

			// Aes sýnýfýný baþlat
			using (Aes aes = Aes.Create())
			{
				aes.Key = key;
				aes.IV = iv;

				// Þifreleme için kullanýlan modu belirt
				aes.Mode = CipherMode.CBC;

				// Þifreleme iþlemini gerçekleþtir
				byte[] encrypted = EncryptStringToBytes_Aes(plaintext, aes.Key, aes.IV);

				// Þifreli veriyi çöz
				byte[] decrypted = DecryptStringFromBytes_Aes(encrypted, aes.Key, aes.IV);

				// Þifrelenmiþ veriyi bir stringe dönüþtür
				string encryptedString = BitConverter.ToString(encrypted);
				string decryptedString = Encoding.UTF8.GetString(decrypted);

				//database 
				string username = textBoxUser.Text;
				string query = "INSERT INTO dbo.AES (username, password) VALUES (@username, @encryptedString)";
				using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BC2LFAE\MELIH;Initial Catalog=CS;Integrated Security=True;"))
				{
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@username", username);
					command.Parameters.AddWithValue("@encryptedString", encryptedString);

					try
					{
						connection.Open();
						command.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}

				//new form
				AES myAes = new AES(encryptedString , decryptedString);
				myAes.Show();		
			}

			static byte[] EncryptStringToBytes_Aes(byte[] plainText, byte[] Key, byte[] IV)
			{
				// Aes sýnýfýný baþlat
				using (Aes aesAlg = Aes.Create())
				{
					aesAlg.Key = Key;
					aesAlg.IV = IV;

					// Þifreleme için kullanýlan modu belirt
					aesAlg.Mode = CipherMode.CBC;

					// Þifreleme için CryptoStream oluþtur
					using (MemoryStream msEncrypt = new MemoryStream())
					{
						using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV), CryptoStreamMode.Write))
						{
							csEncrypt.Write(plainText, 0, plainText.Length);
							csEncrypt.FlushFinalBlock();
							return msEncrypt.ToArray();
						}
					}
				}
			}

			static byte[] DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
			{
				// Aes sýnýfýný baþlat
				using (Aes aesAlg = Aes.Create())
				{
					aesAlg.Key = Key;
					aesAlg.IV = IV;

					// Þifreleme için kullanýlan modu belirt
					aesAlg.Mode = CipherMode.CBC;

					// Çözümleme için CryptoStream oluþtur
					using (MemoryStream msDecrypt = new MemoryStream(cipherText))
					{
						using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV), CryptoStreamMode.Read))
						{
							byte[] decryptedText = new byte[cipherText.Length];
							int decryptedByteCount = csDecrypt.Read(decryptedText, 0, decryptedText.Length);
							return decryptedText;
						}
					}
				}
			}

		}
		
		private void btnblowfish_Click(object sender, EventArgs e)
		{
			string plaintext = textBoxPassword.Text;
			string key = "ComputerSecurityCS";

			string ciphertext = Blowfish.BlowEncrypt(plaintext, key);
			string decryptedText = Blowfish.BlowDecrypt(ciphertext, key);


			//database 
			string username = textBoxUser.Text;
			string query = "INSERT INTO dbo.BlowFish (username, password) VALUES (@username, @ciphertext)";
			using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BC2LFAE\MELIH;Initial Catalog=CS;Integrated Security=True;"))
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@ciphertext", ciphertext);

				try
				{
					connection.Open();
					command.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}

			BlowFish myBlowFish = new BlowFish(ciphertext, decryptedText);
			myBlowFish.Show();

		}

		private void btnblowrijndael_Click(object sender, EventArgs e)
		{

		}
	}

	public static class Blowfish
	{
		public static string BlowEncrypt(string plaintext, string key)
		{
			byte[] input = Encoding.UTF8.GetBytes(plaintext);
			byte[] keyBytes = Encoding.UTF8.GetBytes(key);

			PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new BlowfishEngine()));
			cipher.Init(true, new KeyParameter(keyBytes));

			byte[] output = new byte[cipher.GetOutputSize(input.Length)];
			int length = cipher.ProcessBytes(input, output, 0);
			cipher.DoFinal(output, length);

			return Convert.ToBase64String(output);
		}

		public static string BlowDecrypt(string ciphertext, string key)
		{
			byte[] input = Convert.FromBase64String(ciphertext);
			byte[] keyBytes = Encoding.UTF8.GetBytes(key);

			PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new BlowfishEngine()));
			cipher.Init(false, new KeyParameter(keyBytes));

			byte[] output = new byte[cipher.GetOutputSize(input.Length)];
			int length = cipher.ProcessBytes(input, output, 0);
			cipher.DoFinal(output, length);

			return Encoding.UTF8.GetString(output).TrimEnd("\0".ToCharArray());
		}
	}
}