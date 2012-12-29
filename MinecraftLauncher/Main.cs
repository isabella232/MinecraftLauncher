using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MinecraftLauncher.Core;

namespace MinecraftLauncher
{
	public sealed partial class Main : Form
	{
		private LaunchContext context;
		private bool checkForUpdatesOnStart = true;

		public Main()
		{
			InitializeComponent();
			Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			LoginButton.State = UI.ImageButton.ImageButtonState.Disabled;
			CabinetButton.State = UI.ImageButton.ImageButtonState.Disabled;

			UpdateLocalizer.Localize(updaterControl);

			updaterControl.UpdateSuccessful += (s, e) =>
			{
				checkForUpdatesOnStart = false;
				LoginButton.State = UI.ImageButton.ImageButtonState.Normal;
			};

			updaterControl.ReadyToBeInstalled += (s, e) => updaterControl.InstallNow();

			updaterControl.UpToDate += (s, e) =>
			{
				LoginButton.State = UI.ImageButton.ImageButtonState.Normal;
				CabinetButton.State = UI.ImageButton.ImageButtonState.Normal;
			};

			updaterControl.CheckingFailed += (s, e) =>
			{
				LoginButton.State = UI.ImageButton.ImageButtonState.Normal;
				CabinetButton.State = UI.ImageButton.ImageButtonState.Normal;
			};

			Load += FormLoad;
			KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Enter && LoginButton.Enabled)
					LoginButtonClick(this, new EventArgs());
			};
		}

		private void FormLoad(object sender, EventArgs e)
		{
			try
			{
				context = SettingsManager.Load();
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(Errors.SettingsLoadError + ex.Message);
			}

			if (context == null || String.IsNullOrEmpty(context.JavaHomePath))
			{
				context = new LaunchContext
				{
					InitialJavaHeapSize = 512,
					MaximumJavaHeapSize = 1024
				};

				try
				{
					FileManager.LocateJava(context);
				}
				catch (Exception ex)
				{
					Tools.InfoBoxShow(ex.Message);
				}
			}

			if (checkForUpdatesOnStart)
				updaterControl.ForceCheckForUpdate(true);

			context.Password = Tools.DecodePassword(context.Password);

			LoginTextBox.Text = context.Login;
			PasswordTextBox.Text = context.Password;
		}

		private void SettingsButtonClick(object sender, EventArgs e)
		{
			using (var sf = new SettingsForm(context.Copy()))
			{
				if (sf.ShowDialog() != DialogResult.OK)
					return;

				context = sf.Context;
				SettingsManager.Save(context);
			}
		}

		private void RegisterLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (var reg = new RegisterForm())
			{
				reg.ShowDialog();
			}
		}

		private bool Login()
		{
			try
			{
				ValidationUnit.ValidateLogin(LoginTextBox.Text);
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
				return false;
			}

			try
			{
				FileManager.LocateMinecraft();
			}
			catch
			{
				Tools.InfoBoxShow(Errors.ClientDamagedText, Errors.ClientDamagedTitle);
				LoginButton.State = UI.ImageButton.ImageButtonState.Disabled;
				return false;
			}

			Application.DoEvents();

			try
			{
				Cursor = Cursors.WaitCursor;
				context.SessionID = AuthManager.Authentificate(LoginTextBox.Text, PasswordTextBox.Text);
			}
			catch (Exception ex)
			{
				File.AppendAllText(Path.Combine(FileManager.StartupDirectory, "log.txt"), ex.StackTrace);
				Tools.InfoBoxShow(ex.Message);
				Cursor = Cursors.Arrow;
				return false;
			}
			finally
			{
				Cursor = Cursors.Arrow;
			}

			context.Login = LoginTextBox.Text;
			context.Password = Tools.EncodePassword(PasswordTextBox.Text);

			try
			{
				SettingsManager.Save(context);
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(Errors.SettingsSaveError + ex.Message);
			}

			return true;
		}

		public void Run()
		{
			try
			{
				Launcher.Run(context);
			}
			catch (Exception ex)
			{
				File.AppendAllText(Path.Combine(FileManager.StartupDirectory, "log.txt"), ex.StackTrace + Environment.NewLine + Environment.NewLine);
				Tools.InfoBoxShow(ex.Message);
			}
		}

		private void LoginButtonClick(object sender, EventArgs e)
		{
			if (Login())
				Run();
		}

		private void CabinetButtonClick(object sender, EventArgs e)
		{
			if (!Login())
				return;

			using (var cabinet = new CabinetForm(context))
			{
				if (cabinet.ShowDialog() == DialogResult.OK)
				{
					Run();
				}
			}
		}

		private void CheckForUpdatesButtonClick(object sender, EventArgs e)
		{
			updaterControl.ForceCheckForUpdate(true);
		}
	}
}
