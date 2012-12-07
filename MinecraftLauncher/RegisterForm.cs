using System;
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
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
				return;
			}

			Application.DoEvents();
			var regResponse = string.Empty;

			try
			{
				Cursor = Cursors.WaitCursor;
				regResponse = AuthManager.Register(LoginTextBox.Text, PasswordTextBox.Text);
			}
			catch (Exception ex)
			{
				File.WriteAllText(Path.Combine(FileManager.StartupDirectory, "log.txt"), ex.StackTrace);
				Tools.InfoBoxShow(ex.Message);
			}
			finally
			{
				Cursor = Cursors.Arrow;
			}

			if (String.IsNullOrEmpty(regResponse))
				return;

			if (regResponse.Equals("Bad login", StringComparison.OrdinalIgnoreCase))
			{
				Tools.InfoBoxShow("Имя может состоять только из малых/заглавных букв английского алфавита, цифр и знаков '-' и '_'.");
				return;
			}

			if (regResponse.Equals("Use", StringComparison.OrdinalIgnoreCase))
			{
				Tools.InfoBoxShow("Данное имя уже занято!");
				return;
			}

			if (regResponse.Equals("Fail", StringComparison.OrdinalIgnoreCase))
			{
				Tools.InfoBoxShow("Ошибка регистрации!");
				return;
			}

			Tools.InfoBoxShow("Регистрация завершена!");
			DialogResult = DialogResult.OK;
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
