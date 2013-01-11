using System;
using System.Xml.Serialization;

namespace MinecraftLauncher.Core
{
	/// <summary>
	/// Контекст запуска.
	/// </summary>
	public class LaunchContext
	{
		/// <summary>Домашняя директория Java</summary>
		public String JavaHomePath { get; set; }

		/// <summary>Минимальный объем выделяемой памяти</summary>
		public Int32 InitialJavaHeapSize { get; set; }

		/// <summary>Максимальный объем выделяемой памяти</summary>
		public Int32 MaximumJavaHeapSize { get; set; }

		/// <summary>Логин</summary>
		public String Login { get; set; }

		/// <summary>Пароль</summary>
		public String Password { get; set; }

		[XmlIgnore]
		public String SessionID { get; set; }

		public LaunchContext Copy()
		{
			return new LaunchContext
			{
				JavaHomePath = JavaHomePath,
				InitialJavaHeapSize = InitialJavaHeapSize,
				MaximumJavaHeapSize = MaximumJavaHeapSize,
				Login = Login,
				Password = Password,
				SessionID = SessionID
			};
		}
	}
}
