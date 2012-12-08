using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftLauncher.Core
{
	/// <summary>
	/// Запускатор клиента.
	/// </summary>
	static class Launcher
	{
		/// <summary>
		/// Запускает клиент Minecraft, дожидается полного запуска и закрывает ланчер.
		/// </summary>
		/// <param name="context">Контекст запуска</param>
		public static void Run(LaunchContext context)
		{
			try
			{
				FileManager.LocateJava(context);
				FileManager.LocateMinecraft();

				var pi = new ProcessStartInfo
				{
					UseShellExecute = false,
					FileName = FileManager.JavaFilePath,
					Arguments = String.Format(
						"-cp \"{0}\";\"{1}\";\"{2}\";\"{3}\"; -Djava.library.path=\"{4}\" -Xms{5}M -Xmx{6}M {7}{8}{9}{10} net.minecraft.client.Minecraft {11} {12}",
						Path.Combine(FileManager.MinecraftBinDirectory, "minecraft.jar"),
						Path.Combine(FileManager.MinecraftBinDirectory, "lwjgl.jar"),
						Path.Combine(FileManager.MinecraftBinDirectory, "lwjgl_util.jar"),
						Path.Combine(FileManager.MinecraftBinDirectory, "jinput.jar"),
						Path.Combine(FileManager.MinecraftBinDirectory, "natives"),
						context.InitialJavaHeapSize,
						context.MaximumJavaHeapSize,
						"-Dsun.java2d.noddraw=true",
						"-Dsun.java2d.d3d=false",
						"-Dsun.java2d.opengl=false",
						"-Dsun.java2d.pmoffscreen=false",
						context.Login,
						context.SessionID)
				};

				var directoryInfo = new DirectoryInfo(FileManager.MinecraftDirectory).Parent;

				if (directoryInfo != null)
					pi.EnvironmentVariables["appdata"] = directoryInfo.FullName;

				var game = new Process
				{
					StartInfo = pi
				};

				game.Start();
				var clientStarted = false;

				var waitForClientTask = new Task(() =>
				{
					for (var count = 0; count < 10; count++)
					{
						if (game.MainWindowHandle != IntPtr.Zero && game.MainWindowTitle == "Minecraft")
						{
							clientStarted = true;
							break;
						}

						Thread.Sleep(1000);
					}
				});

				// ReSharper disable ImplicitlyCapturedClosure
				waitForClientTask.ContinueWith(x =>
				{
					if (clientStarted)
					{
						Application.Exit();
					}
				},
				TaskScheduler.FromCurrentSynchronizationContext());
				// ReSharper restore ImplicitlyCapturedClosure
				waitForClientTask.Start();
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
			}
		}
	}
}