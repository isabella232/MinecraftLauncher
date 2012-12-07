using System;
using System.Xml.Serialization;

namespace MinecraftLauncher.Core
{
	public class LaunchContext
	{
		public String JavaHomePath { get; set; }
		public Int32 InitialJavaHeapSize { get; set; }
		public Int32 MaximumJavaHeapSize { get; set; }
		public String Login { get; set; }
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
