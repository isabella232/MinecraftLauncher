using System;
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

		private const string JavaFileName = "javaw.exe";

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

		/// <summary>Ссылка на скрипт авторизации.</summary>
		public static string AuthLink { get; private set; }
		/// <summary>Ссылка на скрипт регистрации.</summary>
		public static string RegLink { get; private set; }
		/// <summary>Ссылка на архив с клиентом.</summary>
		public static string ClientLink { get; private set; }
		/// <summary>Имя загружаемого архива клиента.</summary>
		public static string DownloadedClientFileName { get; private set; }

		static FileManager()
		{
			var directoryInfo = new FileInfo(Application.ExecutablePath).Directory;

			if (directoryInfo != null)
				StartupDirectory = directoryInfo.FullName;

			SettingsFilePath = Path.Combine(StartupDirectory, SettingsFileName);
			AuthLink = "http://78.46.80.82/auth.php";
			RegLink = "http://78.46.80.82/reg.php";
			ClientLink = "http://78.46.80.82/client.zip";
			DownloadedClientFileName = "client.zip";
		}

		/// <summary>
		/// Определяет местоположение Java на комьютере.
		/// </summary>
		/// <param name="context">Контекст запуска</param>
		public static void LocateJava(LaunchContext context)
		{
			string javaHome;

			if (LocateJavaHome(out javaHome))
			{
				context.JavaHomePath = javaHome;
			}
			else
				throw new Exception(Strings.UnableToFindJava);

			JavaHomePath = javaHome;

			var javawFilePath = Path.Combine(JavaHomePath, "bin", JavaFileName);

			if (!File.Exists(javawFilePath))
				throw new InvalidOperationException(String.Format(Strings.UnableToFindJavaExe, JavaFileName));

			JavaFilePath = javawFilePath;
		}

		/// <summary>
		/// Определяет/проверяет целостность структуры клиента Minecraft.
		/// </summary>
		public static void LocateMinecraft()
		{
			var tempPath = Path.Combine(StartupDirectory, MinecraftFolderName);

			if (!Directory.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Strings.MinecraftFolderMissing, MinecraftFolderName));

			MinecraftDirectory = tempPath;
			tempPath = Path.Combine(MinecraftDirectory, MinecraftBinFolderName);

			if (!Directory.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Strings.MinecraftBinFolderMissing, MinecraftFolderName, MinecraftBinFolderName));

			MinecraftBinDirectory = tempPath;
			// Необязательная папка, может и не быть.
			MinecraftModsDirectory = Path.Combine(MinecraftDirectory, MinecraftModsFolderName);

			tempPath = Path.Combine(MinecraftBinDirectory, MinecraftJarFileName);

			if (!File.Exists(tempPath))
				throw new InvalidOperationException(String.Format(Strings.MinecraftJarMissing, MinecraftFolderName, MinecraftBinFolderName, MinecraftJarFileName));

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
	}
}
