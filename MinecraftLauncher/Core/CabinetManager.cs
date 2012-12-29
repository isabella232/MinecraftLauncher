using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace MinecraftLauncher.Core
{
	static class CabinetManager
	{
		/// <summary>
		/// Производит смену пароля.
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="password">Текущий пароль</param>
		/// /// <param name="session">Сессия</param>
		/// <param name="newpassword">Новый пароль</param>
		public static void ChangePassword(string login, string password, string session, string newpassword)
		{
			var webClient = new WebClient
			{
				Proxy = null
			};

			var currentHash = Tools.GetMd5HashFromString(password);
			var newHash = Tools.GetMd5HashFromString(newpassword);
			var response = webClient.DownloadString(String.Format(Links.ChangePwdLink, login, currentHash, session, newHash));

			if (response.Equals(Responses.BadLogin, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidLoginOrPassword);

			if (response.Equals(Responses.Fail, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.RegistrationFail);
		}

		/// <summary>
		/// Получает скин игрока.
		/// </summary>
		/// <param name="login">Логин</param>
		/// <returns></returns>
		public static Image GetSkin(string login)
		{
			var request = WebRequest.Create(String.Format(Links.SkinLink, login));

			Image skin;

			using (var response = request.GetResponse())
			{
				using (var stream = response.GetResponseStream())
				{
					if (stream == null)
						return null;

					skin = Image.FromStream(stream);
				}
			}

			return skin;
		}

		/// <summary>
		/// Загржуает скин игрока.
		/// </summary>
		/// <param name="login">Логин</param>
		/// <param name="session">Сессия</param>
		/// <param name="skin">Скин</param>
		public static void UploadSkin(string login, string session, Image skin)
		{
			var response = InnerUploadFile(Links.UploadSkinLink, skin, "skin", "image/png", new NameValueCollection
            {
                { "login", login },
                { "session", session },
            });

			if (response.Equals(Responses.BadLogin, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidLoginOrPassword);

			if (response.Equals(Responses.Fail, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException(Errors.InvalidSkinFormat);
		}

		private static string InnerUploadFile(string url, Image image, string paramName, string contentType, NameValueCollection nvc)
		{
			var converter = new ImageConverter();
			var imageData = (byte[])converter.ConvertTo(image, typeof(byte[]));

			if (imageData == null)
				return string.Empty;

			if (imageData.Length == 0)
				return string.Empty;

			// Создаем "границу" и получаем её байты.
			var boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			var boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

			// Создаем веб-запрос
			var webRequest = (HttpWebRequest)WebRequest.Create(url);
			webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
			webRequest.Method = "POST";
			webRequest.KeepAlive = true;
			webRequest.Proxy = null;
			webRequest.Credentials = CredentialCache.DefaultCredentials;

			// Получаем поток нашего запроса, куда мы будем писать данные
			var requestStream = webRequest.GetRequestStream();

			// Шаблон шапки параметра формы
			const string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";

			// Записываем в поток все наши параметры
			foreach (string key in nvc.Keys)
			{
				// Записываем "границу"
				requestStream.Write(boundarybytes, 0, boundarybytes.Length);
				// Формируем запись о параметра и переводим в байты
				var formitem = string.Format(formdataTemplate, key, nvc[key]);
				var formitembytes = Encoding.UTF8.GetBytes(formitem);
				// Записываем параметр в поток
				requestStream.Write(formitembytes, 0, formitembytes.Length);
			}

			// Записываем границу параметра, который будет содержать данные файла
			requestStream.Write(boundarybytes, 0, boundarybytes.Length);
			// Шаблон шапки параметра формы с файлом
			const string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
			// Формируем шапку и переводим в байты
			var header = string.Format(headerTemplate, paramName, "skin.png", contentType);
			var headerbytes = Encoding.UTF8.GetBytes(header);
			// Записываем полученную шапку в поток
			requestStream.Write(headerbytes, 0, headerbytes.Length);
			// Записываем файл в поток
			requestStream.Write(imageData, 0, imageData.Length);
			// Формируем хвост и переводим в байты
			var trailer = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
			// Записываем хвост в поток и закрываем его.
			requestStream.Write(trailer, 0, trailer.Length);
			requestStream.Close();

			WebResponse webResponse = null;
			try
			{
				// Получаем ответ сервера
				webResponse = webRequest.GetResponse();
				// Получаем поток ответа сервера
				var responseStream = webResponse.GetResponseStream();

				if (responseStream == null)
					return string.Empty;

				// Вычитываем его полностью и возрващаем вычитанные данные
				return new StreamReader(responseStream).ReadToEnd();
			}
			catch (Exception)
			{
				if (webResponse != null)
				{
					webResponse.Close();
				}
			}

			return string.Empty;
		}
	}
}
