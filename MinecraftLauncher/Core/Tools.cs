using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MinecraftLauncher.Core
{
	static class Tools
	{
		private static readonly MD5 md5 = MD5.Create();

		public static void InfoBoxShow(string text)
		{
			MessageBox.Show(text, Strings.InformationTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void InfoBoxShow(string text, string title)
		{
			MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult QuestionBoxShow(string text, string title)
		{
			return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		public static string EncodePassword(string source)
		{
			if (string.IsNullOrEmpty(source))
				return string.Empty;

			var crypted = new String(source.Select(x => (char) (x ^ 231)).ToArray());
			var toEncode = Encoding.Unicode.GetBytes(crypted);
			return Convert.ToBase64String(toEncode);
		}

		public static string DecodePassword(string source)
		{
			if (string.IsNullOrEmpty(source))
				return string.Empty;

			var toDecode = Convert.FromBase64String(source);
			var crypted = Encoding.Unicode.GetString(toDecode);
			return new String(crypted.Select(x => (char)(x ^ 231)).ToArray());
		}

		public static string GetMd5HashFromString(string password)
		{
			return CalculateMd5Hash(Encoding.UTF8.GetBytes(password));
		}

		public static string GetMd5HashFromFile(string filePath)
		{
			if (!File.Exists(filePath))
				return string.Empty;

			var fs = new FileStream(filePath, FileMode.Open);
			var hash = md5.ComputeHash(fs);
			fs.Close();

			var builder = new StringBuilder();

			foreach (var b in hash)
			{
				builder.AppendFormat("{0:x2}", b);
			}

			return builder.ToString();
		}

		private static string CalculateMd5Hash(byte[] bytes)
		{
			var hash = md5.ComputeHash(bytes);
			var builder = new StringBuilder();

			foreach (var b in hash)
			{
				builder.AppendFormat("{0:x2}", b);
			}

			return builder.ToString();
		}
	}
}
