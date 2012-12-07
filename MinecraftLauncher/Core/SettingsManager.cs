using System.IO;
using System.Xml.Serialization;

namespace MinecraftLauncher.Core
{
	static class SettingsManager
	{
		public static void Save(LaunchContext context)
		{
			using (var sw = new StreamWriter(File.Open(FileManager.SettingsFilePath, FileMode.Create)))
			{
				var s = new XmlSerializer(typeof (LaunchContext));
				s.Serialize(sw, context);
			}
		}

		public static LaunchContext Load()
		{
			if (!File.Exists(FileManager.SettingsFilePath))
				return null;

			using (var sr = new StreamReader(File.Open(FileManager.SettingsFilePath, FileMode.Open)))
			{
				var s = new XmlSerializer(typeof (LaunchContext));
				return s.Deserialize(sr) as LaunchContext;
			}
		}
	}
}
