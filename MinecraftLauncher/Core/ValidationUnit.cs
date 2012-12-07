using System;
using System.Text.RegularExpressions;

namespace MinecraftLauncher.Core
{
	/// <summary>
	/// Валидатор данных.
	/// </summary>
	static class ValidationUnit
	{
		private const int LoginMinLength = 4;
		private const int LoginMaxLength = 14;
		private const string LoginPattern = "[a-zA-Z0-9_-]+$";

		private static readonly Regex validator = new Regex(LoginPattern);

		/// <summary>
		/// Валидирует имя игрока.
		/// </summary>
		/// <param name="login">Имя</param>
		public static void ValidateLogin(string login)
		{
			if (String.IsNullOrEmpty(login) || login.Length < LoginMinLength || login.Length > LoginMaxLength)
				throw new InvalidOperationException(String.Format(Strings.InvalidLoginLength, LoginMinLength, LoginMaxLength));

			if (!validator.IsMatch(login))
				throw new InvalidOperationException(Strings.InvalidLoginFormat);
		}
	}
}
