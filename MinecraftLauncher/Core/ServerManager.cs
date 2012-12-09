namespace MinecraftLauncher.Core
{
	static class ServerManager
	{
		/// <summary>Адрес сервера Minecraft.</summary>
		public static string ServerIp { get; private set; }

		/// <summary>Порт сервера Minecraft.</summary>
		public static int ServerPort { get; private set; }

		/// <summary>Ссылка на скрипт авторизации.</summary>
		public static string AuthLink { get; private set; }

		/// <summary>Ссылка на скрипт регистрации.</summary>
		public static string RegLink { get; private set; }

		static ServerManager()
		{
			ServerIp = "78.46.80.82";
			ServerPort = 25565;

			AuthLink = "http://78.46.80.82/auth.php?login={0}&password={1}&hash={2}";
			RegLink = "http://78.46.80.82/reg.php?login={0}&password={1}";
		}
	}
}
