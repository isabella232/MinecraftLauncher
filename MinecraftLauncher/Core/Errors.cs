namespace MinecraftLauncher.Core
{
	static class Errors
	{
		// Авторизация
		public const string UnknownResponse = "Сервер авторизации не отвечает!";
		public const string RegistrationFail = "Ошибка во время регистрации, сообщите об этом администрации!";
		public const string InvalidLoginOrPassword = "Неверный логин или пароль!";
		public const string InvalidVersion = "Версия клиента устарела, выполните обновление!";

		// Регистрация
		public const string InvalidLoginLength = "Имя должно быть длиной от {0} до {1} символов.";
		public const string InvalidLoginFormat = "Имя может состоять только из малых/заглавных букв английского алфавита, цифр и знаков '-', '_'.";
		public const string PasswordsNotMatch = "Пароли не совпадают.";
		public const string InvalidPasswordsLength = "Минимальная длина пароля составляет {0} символов.";
		public const string LoginInUse = "Данное имя уже занято, придумайте другое.";

		// Кабинет
		public const string ChooseSkinFirst = "Выберите скин сначала!";
		public const string InvalidSkinFormat = "Неверный формат скина. Допускаются только картинки формата PNG.";
		public const string InvalidSkinFileLength = "Неверный размер файла. Допускаются файлы до 5 Кб.";
		public const string InvalidSkinSize = "Неверный размер скина. Допускаются изображения только 64х32.";

		// Настройки
		public const string SettingsLoadError = "Ошибка при загрузке настроек ланчера!\n";
		public const string SettingsSaveError = "Ошибка при сохранении настроек ланчера!\n";

		// Клиент
		public const string MinecraftFolderMissing = "Клиент поврежден!\n\nДиректория '{0}' не обнаружена!";
		public const string MinecraftBinFolderMissing = "Клиент поврежден!\n\nДиректория '{0}\\{1}' не обнаружена!";
		public const string MinecraftJarMissing = "Клиент поврежден!\n\nФайл '{0}\\{1}\\{2}' не найден!";
		public const string UnableToFindJava = "Неудалось определить местоположение Java на вашем компьютере! Укажите его вручную, в настройках.";
		public const string UnableToFindJavaExe = "Неудалось найти '{0}'!";
		public const string ClientDamagedText = "Запуск игры невозможен. Клиент поврежден. Произведите повторную установку!";
		public const string ClientDamagedTitle = "Клиент повреджен";
	}
}
