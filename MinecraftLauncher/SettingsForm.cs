using System;
using System.Drawing;
using System.Windows.Forms;
using MinecraftLauncher.Core;

namespace MinecraftLauncher
{
    partial class SettingsForm : Form
    {
        public LaunchContext Context { get; private set; }

        public SettingsForm(LaunchContext context)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            Context = context;

            Load += (sender, args) =>
            {
                javaHomePath.Text = context.JavaHomePath;

                if (context.InitialJavaHeapSize < 256)
                    context.InitialJavaHeapSize = 256;

                if (context.InitialJavaHeapSize > 4096)
                    context.InitialJavaHeapSize = 4096;

                if (context.MaximumJavaHeapSize < 256)
                    context.MaximumJavaHeapSize = 256;

                if (context.MaximumJavaHeapSize > 4096)
                    context.MaximumJavaHeapSize = 4096;

                initialSize.Value = context.InitialJavaHeapSize;
                maximumSize.Value = context.MaximumJavaHeapSize;

                labelInitialSize.Text = initialSize.Value + Strings.MegaBytes;
				labelMaximumSize.Text = maximumSize.Value + Strings.MegaBytes;
            };

            initialSize.ValueChanged += (sender, args) =>
            {
                context.InitialJavaHeapSize = (initialSize.Value / 32) * 32;
                initialSize.Value = context.InitialJavaHeapSize;

                if (context.InitialJavaHeapSize > context.MaximumJavaHeapSize)
                    maximumSize.Value = context.InitialJavaHeapSize;

				labelInitialSize.Text = initialSize.Value + Strings.MegaBytes;
            };

            maximumSize.ValueChanged += (sender, args) =>
            {
                context.MaximumJavaHeapSize = (maximumSize.Value / 32) * 32;
                maximumSize.Value = context.MaximumJavaHeapSize;

                if (context.MaximumJavaHeapSize < context.InitialJavaHeapSize)
                    initialSize.Value = context.MaximumJavaHeapSize;

				labelMaximumSize.Text = maximumSize.Value + Strings.MegaBytes;
            };
        }

        private void JavaHomeSelectClick(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog { Description = "Укажите путь к JavaHome", SelectedPath = javaHomePath.Text })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    Context.JavaHomePath = fd.SelectedPath;
                    javaHomePath.Text = Context.JavaHomePath;
                }
            }
        }

        private void MinecraftSelectClick(object sender, EventArgs e)
        {
            /*using (FolderBrowserDialog fd = new FolderBrowserDialog() { Description = "Укажите путь к .minecraft", SelectedPath = minecraftPath.Text })
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    Context.MinecraftPath = fd.SelectedPath;
                    minecraftPath.Text = Context.MinecraftPath;
                }
            }*/
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            Context.JavaHomePath = javaHomePath.Text;
            //Context.MinecraftPath = minecraftPath.Text;
        }
    }
}
