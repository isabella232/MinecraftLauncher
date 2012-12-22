using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinecraftLauncher
{
	public partial class CabinetForm : Form
	{
		public CabinetForm()
		{
			InitializeComponent();

			var skin = Image.FromFile(@"C:\Users\Void\Desktop\skin_2012122205573286944.png");
			skinViewer1.Skin = skin;
			skinViewer2.Skin = skin;
			skinViewer2.FrontRender = false;
		}
	}
}
