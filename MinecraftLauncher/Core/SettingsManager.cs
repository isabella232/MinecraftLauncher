using System;
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
				var copy = context.Copy();
				copy.Password = Tools.EncodePassword(copy.Password);

				var s = new XmlSerializer(typeof (LaunchContext));
				s.Serialize(sw, copy);
			}
		}

		public static LaunchContext Load()
		{
			if (!File.Exists(FileManager.SettingsFilePath))
				return null;

			using (var sr = new StreamReader(File.Open(FileManager.SettingsFilePath, FileMode.Open)))
			{
				var s = new XmlSerializer(typeof (LaunchContext));
				var rtnContext = s.Deserialize(sr) as LaunchContext;

				if (rtnContext == null)
					throw new InvalidOperationException("Failed to load settings file!");

				rtnContext.Password = Tools.DecodePassword(rtnContext.Password);

				return rtnContext;
			}
		}
	}
}
