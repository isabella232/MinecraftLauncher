using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace md5Calculator
{
	public partial class Main : Form
	{
		private bool firstTime = true;
		private readonly MD5 md5 = MD5.Create();

		public Main()
		{
			InitializeComponent();

			textBox1.AllowDrop = true;
			textBox1.DragEnter += (s, e) =>
			{
				e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
			};

			textBox1.DragDrop += (s, e) =>
			{
				if (firstTime)
				{
					textBox1.Clear();
					firstTime = false;
				}

				var data = e.Data.GetData(DataFormats.FileDrop);

				if (data == null)
					return;

				var files = data as string[];

				if (files == null)
					return;

				foreach (var file in files.Where(File.Exists))
				{
					textBox1.AppendText(String.Format("File: {0}\r\nMD5: {1}\r\n\r\n", file,GetMd5HashFromFile(file)));
					textBox1.ScrollToCaret();
				}
			};
		}

		public string GetMd5HashFromFile(string filePath)
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
	}
}
