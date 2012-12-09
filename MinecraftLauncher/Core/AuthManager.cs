using System;
using System.Net;

namespace MinecraftLauncher.Core
{
	/// <summary>
	/// Клиент регистрация / авторизации.
	/// </summary>
	static class AuthManager
	{
		/// <summary>
		/// Производит авторизация на сервер.
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="password">Пароль</param>
		/// <returns>Возвращает строку сессии</returns>
		public static string Authentificate(string login, string password)
		{
			var webClient = new WebClient
			{
				Proxy = null
			};

			var pwdHash = Tools.GetMd5HashFromString(password);
			var clientHash = Tools.GetMd5HashFromFile(FileManager.MinecraftJarPath);

			var response = webClient.DownloadString(String.Format(ServerManager.AuthLink, login, pwdHash, clientHash));

			if (String.IsNullOrEmpty(response))
				throw new InvalidOperationException(Errors.UnknownResponse);

			if (response.Equals(Responses.Checksum, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidVersion);

			if (response.Equals(Responses.BadLogin, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidLoginOrPassword);

			return response;
		}

		/// <summary>
		/// Производит регистрацию на сервере.
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="password">Пароль</param>
		public static void Register(string login, string password)
		{
			var webClient = new WebClient
			{
				Proxy = null
			};

			var pwdHash = Tools.GetMd5HashFromString(password);
			var response = webClient.DownloadString(String.Format(ServerManager.RegLink, login, pwdHash));

			if (response.Equals(Responses.BadLogin, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidLoginFormat);

			if (response.Equals(Responses.LoginInUse, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.LoginInUse);

			if (response.Equals(Responses.Fail, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.RegistrationFail);
		}
	}
}
