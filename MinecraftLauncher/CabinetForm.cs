using System;
using System.Drawing;
using System.Windows.Forms;
using MinecraftLauncher.Core;

namespace MinecraftLauncher
{
	public partial class CabinetForm : Form
	{
		private readonly LaunchContext context;
		private Image selectedSkin;

		public CabinetForm()
		{
			InitializeComponent();

			KeyDown += (s, e) =>
			{
				if (e.KeyCode == Keys.Escape)
					DialogResult = DialogResult.Cancel;
			};
		}

		private void ShowSkin()
		{
			try
			{
				var skin = CabinetManager.GetSkin(context.Login);
				skinViewer1.Skin = skinViewer2.Skin = skin;
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
			}
		}

		public CabinetForm(LaunchContext context) : this()
		{
			this.context = context;

			Load += (s, e) =>
			{
				Text = String.Format(Strings.CabinetTitle, context.Login);
				ShowSkin();
			};
		}

		private void ChooseSkinButtonClick(object sender, EventArgs e)
		{
			using (var op = new OpenFileDialog {Filter = "PNG|*.png"})
			{
				if (op.ShowDialog() != DialogResult.OK) 
					return;

				try
				{
					selectedSkin = FileManager.ValidateAndLoadSkinFile(op.FileName);
					skinViewer1.Skin = skinViewer2.Skin = selectedSkin;
				}
				catch(Exception ex)
				{
					Tools.InfoBoxShow(ex.Message);
				}
			}
		}

		private void UploadSkinButtonClick(object sender, EventArgs e)
		{
			if (selectedSkin == null)
			{
				Tools.InfoBoxShow(Errors.ChooseSkinFirst);
				return;
			}

			try
			{
				CabinetManager.UploadSkin(context.Login, context.SessionID, selectedSkin);
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
				return;
			}

			ShowSkin();
			Tools.InfoBoxShow(Strings.SkinUploaded);
		}

		private void ChangePasswordButtonClick(object sender, EventArgs e)
		{
			try
			{
				if (NewPasswordTextBox.Text.Length < ValidationUnit.PasswordMinLength)
					throw new InvalidOperationException(String.Format(Errors.InvalidPasswordsLength, ValidationUnit.PasswordMinLength));

				CabinetManager.ChangePassword(context.Login, CurrentPasswordTextBox.Text, context.SessionID, NewPasswordTextBox.Text);
			}
			catch (Exception ex)
			{
				Tools.InfoBoxShow(ex.Message);
				return;
			}

			Tools.InfoBoxShow(Strings.PasswordChanged);
		}
	}
}
