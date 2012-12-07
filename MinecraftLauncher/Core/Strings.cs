namespace MinecraftLauncher.Core
{
	static class Strings
	{
		public const string InvalidLoginLength = "Имя должно быть длиной от {0} до {1} символов.";
		public const string InvalidLoginFormat = "Имя может состоять только из малых/заглавных букв английского алфавита, цифр и знаков '-', '_'.";
		public const string MinecraftFolderMissing = "Клиент поврежден!\n\nДиректория '{0}' не обнаружена!";
		public const string MinecraftBinFolderMissing = "Клиент поврежден!\n\nДиректория '{0}\\{1}' не обнаружена!";
		public const string MinecraftJarMissing = "Клиент поврежден!\n\nФайл '{0}\\{1}\\{2}' не найден!";
		public const string UnableToFindJava = "Неудалось определить местоположение Java на вашем компьютере! Укажите его вручную, в настройках.";
		public const string UnableToFindJavaExe = "Неудалось найти '{0}'!";

		public const string MegaBytes = "M";

		public const string ClientDamagedText = "Запуск игры невозможен. Клиент поврежден. Произведите повторную установку!";
		public const string ClientDamagedTitle = "Клиент повреджен";

		public const string InformationTitle = "Информация";
	}
}
