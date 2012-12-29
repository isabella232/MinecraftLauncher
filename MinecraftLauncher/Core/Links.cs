using System;

namespace MinecraftLauncher.Core
{
	static class Links
	{
		/// <summary>Адрес сервера Minecraft.</summary>
		public static string Server { get; private set; }

		/// <summary>Порт сервера Minecraft.</summary>
		public static int ServerPort { get; private set; }

		/// <summary>Адрес веб сервера.</summary>
		public static string WebServer { get; private set; }

		/// <summary>Ссылка на скрипт показа скина.</summary>
		public static string SkinLink { get; private set; }

		/// <summary>Ссылка на скрипт авторизации.</summary>
		public static string AuthLink { get; private set; }

		/// <summary>Ссылка на скрипт регистрации.</summary>
		public static string RegLink { get; private set; }

		/// <summary>Ссылка на скрипт смены пароля.</summary>
		public static string ChangePwdLink { get; private set; }

		/// <summary>Ссылка на скрипт смены скина.</summary>
		public static string UploadSkinLink { get; private set; }

		static Links()
		{
			Server = "mc1.zhyk.ru";
			ServerPort = 25565;

			WebServer = String.Format("http://{0}", Server);

			AuthLink = String.Format("{0}/{1}", WebServer, "auth.php?login={0}&password={1}&hash={2}");
			RegLink = String.Format("{0}/{1}", WebServer, "reg.php?login={0}&password={1}");
			ChangePwdLink = String.Format("{0}/{1}", WebServer, "changepwd.php?login={0}&password={1}&session={2}&newpassword={3}");
			SkinLink = String.Format("{0}/{1}", WebServer, "showskin.php?login={0}");
			UploadSkinLink = String.Format("{0}/{1}", WebServer, "uploadskin.php");
		}
	}
}
