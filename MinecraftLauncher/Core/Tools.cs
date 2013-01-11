using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern IntPtr SetFocus(IntPtr hWnd);

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

		public static bool SetAllowUnsafeHeaderParsing20()
		{
			//Get the assembly that contains the internal class
			var aNetAssembly = Assembly.GetAssembly(typeof (System.Net.Configuration.SettingsSection));

			if (aNetAssembly != null)
			{
				//Use the assembly in order to get the internal type for the internal class
				var aSettingsType = aNetAssembly.GetType("System.Net.Configuration.SettingsSectionInternal");

				if (aSettingsType != null)
				{
					//Use the internal static property to get an instance of the internal settings class.
					//If the static instance isn't created allready the property will create it for us.
					var anInstance = aSettingsType.InvokeMember("Section",
					                                            BindingFlags.Static | BindingFlags.GetProperty | BindingFlags.NonPublic,
					                                            null, null, new object[] {});

					if (anInstance != null)
					{
						//Locate the private bool field that tells the framework is unsafe header parsing should be allowed or not
						var aUseUnsafeHeaderParsing = aSettingsType.GetField("useUnsafeHeaderParsing",
						                                                     BindingFlags.NonPublic | BindingFlags.Instance);

						if (aUseUnsafeHeaderParsing != null)
						{
							aUseUnsafeHeaderParsing.SetValue(anInstance, true);
							return true;
						}
					}
				}
			}

			return false;
		}
	}
}
