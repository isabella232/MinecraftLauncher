using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MinecraftLauncher.Core
{
	/// <summary>
	/// Помощник в работе с файловой системой.
	/// </summary>
	static class FileManager
	{
		private const string SettingsFileName = "settings.xml";

		private const string MinecraftFolderName = ".minecraft";
		private const string MinecraftBinFolderName = "bin";
		private const string MinecraftModsFolderName = "mods";
		private const string MinecraftJarFileName = "minecraft.jar";

		private const string JavaFileName = "java.exe";

		private const long SkinMaxSize = 5 * 1024;
		private const int SkinMaxWidth = 64;
		private const int SkinMaxHeight = 32;

		/// <summary>Путь к директории, из которой запущено приложение.</summary>
		public static string StartupDirectory { get; private set; }
		/// <summary>Путь к файлу настроек приложения.</summary>
		public static string SettingsFilePath { get; private set; }

		/// <summary>Путь к домашней директории Java.</summary>
		public static string JavaHomePath { get; private set; }
		/// <summary>Путь к исполняемому файлу Java.</summary>
		public static string JavaFilePath { get; private set; }

		/// <summary>Путь к директории клиента Minecraft.</summary>
		public static string MinecraftDirectory { get; private set; }
		/// <summary>Путь к bin директории клиента Minecraft.</summary>
		public static string MinecraftBinDirectory { get; private set; }
		/// <summary>Путь к mods директории клиента Minecraft.</summary>
		public static string MinecraftModsDirectory { get; private set; }
		/// <summary>Путь к исполняемому файлу клиента Minecraft.</summary>
		public static string MinecraftJarPath { get; private set; }

		static FileManager()
		{
			var directoryInfo = new FileInfo(Application.ExecutablePath).Directory;

			if (directoryInfo != null)
				StartupDirectory = directoryInfo.FullName;

			SettingsFilePath = Path.Combine(StartupDirectory, SettingsFileName);
		}

		/// <summary>
		/// Определяет местоположение Java на комьютере, если оно не задано в контексте.
		/// </summary>
		/// <param name="context">Контекст запуска</param>
		public static void LocateJava(LaunchContext context)
		{
			if (!String.IsNullOrEmpty(context.JavaHomePath))
				return;

			string javaHome;

			if (LocateJavaHome(out javaHome))
			{
				context.JavaHomePath = javaHome;
			}
			else
				throw new Exception(Errors.UnableToFindJava);

			JavaHomePath = javaHome;

			var javawFilePath = Path.Combine(JavaHomePath, "bin", JavaFileName);

			if (!File.Exists(javawFilePath))
				throw new InvalidOperationException(String.Format(Errors.UnableToFindJavaExe, JavaFileName));

			JavaFilePath = javawFilePath;
		}

		/// <summary>
		/// Определяет местоположение Java на компьютере, используя контекст запуска.
		/// </summary>
		/// <param name="context">Контекст запуска</param>
		public static void LocateJavaFromSettings(LaunchContext context)
		{
			var javawFilePath = Path.Combine(context.JavaHomePath, "bin", JavaFileName);

			if (!File.Exists(javawFilePath))
				throw new InvalidOperationException(String.Format(Errors.UnableToFindJavaExe, JavaFileName));

			JavaFilePath = javawFilePath;
		}

		/// <summary>
		/// Определяет/проверяет целостность структуры клиента Minecraft.
		/// </summary>
		public static void LocateMinecraft()
		{
			var tempPath = Path.Combine(StartupDirectory, MinecraftFolderName);

			if (!Directory.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Errors.MinecraftFolderMissing, MinecraftFolderName));

			MinecraftDirectory = tempPath;
			tempPath = Path.Combine(MinecraftDirectory, MinecraftBinFolderName);

			if (!Directory.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Errors.MinecraftBinFolderMissing, MinecraftFolderName, MinecraftBinFolderName));

			MinecraftBinDirectory = tempPath;
			// Необязательная папка, может и не быть.
			MinecraftModsDirectory = Path.Combine(MinecraftDirectory, MinecraftModsFolderName);

			tempPath = Path.Combine(MinecraftBinDirectory, MinecraftJarFileName);

			if (!File.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Errors.MinecraftJarMissing, MinecraftFolderName, MinecraftBinFolderName, MinecraftJarFileName));

			MinecraftJarPath = tempPath;
		}

		private static Boolean LocateJavaHome(out string javaHomePath)
		{
			javaHomePath = string.Empty;

			try
			{
				javaHomePath = Environment.GetEnvironmentVariable("JAVA_HOME");

				if (!string.IsNullOrEmpty(javaHomePath))
				{
					return true;
				}

				const string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment\\";

				using (var rk = Registry.LocalMachine.OpenSubKey(javaKey))
				{
					if (rk == null)
						return false;

					var currentVersion = rk.GetValue("CurrentVersion").ToString();

					using (var key = rk.OpenSubKey(currentVersion))
					{
						if (key == null)
							return false;

						javaHomePath = key.GetValue("JavaHome").ToString();
						return true;
					}
				}
			}
			catch
			{
				return false;
			}
		}

		public static Image ValidateAndLoadSkinFile(string file)
		{
			var info = new FileInfo(file);

			if (info.Length > SkinMaxSize)
				throw new InvalidOperationException(Errors.InvalidSkinFileLength);

			Image rtnImage;

			try
			{
				rtnImage = Image.FromFile(file);
			}
			catch
			{
				throw new InvalidOperationException(Errors.InvalidSkinFormat);
			}

			if (rtnImage.Width != SkinMaxWidth || rtnImage.Height != SkinMaxHeight)
			{
				rtnImage.Dispose();
				throw new InvalidOperationException(Errors.InvalidSkinSize);
			}

			return rtnImage;
		}
	}
}
