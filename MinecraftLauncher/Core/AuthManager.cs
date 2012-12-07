using System;
using System.Net;

namespace MinecraftLauncher.Core
{
	static class AuthManager
	{
		public static string Authentificate(string login, string password)
		{
			var webClient = new WebClient
			{
				Proxy = null
			};

			return webClient.DownloadString(
				String.Format("{0}?login={1}&password={2}&hash={3}",
				              FileManager.AuthLink,
				              login,
				              Tools.GetMd5HashFromString(password),
				              Tools.GetMd5HashFromFile(FileManager.MinecraftJarPath)));

		}

		public static string Register(string login, string password)
		{
			var webClient = new WebClient
			{
				Proxy = null
			};

			return webClient.DownloadString(String.Format("{0}?login={1}&password={2}", FileManager.RegLink, login, Tools.GetMd5HashFromString(password)));
		}
	}
}
