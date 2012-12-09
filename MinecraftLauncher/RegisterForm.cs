using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MinecraftLauncher.Core;

namespace MinecraftLauncher
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

			KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Escape)
					DialogResult = DialogResult.Cancel;
			};
		}

		private void RegisterButtonClick(object sender, EventArgs e)
		{
			try
			{
				ValidationUnit.ValidateLogin(LoginTextBox.Text);

				if (PasswordTextBox.Text.Length < ValidationUnit.PasswordMinLength)
					throw new InvalidOperationException(String.Format(Errors.InvalidPasswordsLength, ValidationUnit.PasswordMinLength));

				if (PasswordTextBox.Text != ConfirmTextBox.Text)
					throw new InvalidOperationException(Errors.PasswordsNotMatch);
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
				PasswordTextBox.Text = string.Empty;
				ConfirmTextBox.Text = string.Empty;
				return;
			}

			Application.DoEvents();

			try
			{
				Cursor = Cursors.WaitCursor;
				AuthManager.Register(LoginTextBox.Text, PasswordTextBox.Text);
			}
			catch (Exception ex)
			{
				File.AppendAllText(Path.Combine(FileManager.StartupDirectory, "log.txt"), ex.StackTrace + Environment.NewLine);
				Tools.InfoBoxShow(ex.Message);
				PasswordTextBox.Text = string.Empty;
				ConfirmTextBox.Text = string.Empty;
				Cursor = Cursors.Arrow;
				return;
			}
			finally
			{
				Cursor = Cursors.Arrow;
			}

			Tools.InfoBoxShow(Strings.RegisterCompleted);
			DialogResult = DialogResult.OK;
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
