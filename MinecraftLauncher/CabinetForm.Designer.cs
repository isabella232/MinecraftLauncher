namespace MinecraftLauncher
{
	partial class CabinetForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
			this.CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.UploadSkinButton = new MinecraftLauncher.UI.ImageButton();
			this.PlayButton = new MinecraftLauncher.UI.ImageButton();
			this.ChangePasswordButton = new MinecraftLauncher.UI.ImageButton();
			this.ChooseSkinButton = new MinecraftLauncher.UI.ImageButton();
			this.skinViewer2 = new MinecraftLauncher.UI.SkinViewer();
			this.skinViewer1 = new MinecraftLauncher.UI.SkinViewer();
			this.SuspendLayout();
			// 
			// NewPasswordTextBox
			// 
			this.NewPasswordTextBox.Location = new System.Drawing.Point(89, 441);
			this.NewPasswordTextBox.Name = "NewPasswordTextBox";
			this.NewPasswordTextBox.PasswordChar = '•';
			this.NewPasswordTextBox.Size = new System.Drawing.Size(206, 21);
			this.NewPasswordTextBox.TabIndex = 8;
			// 
			// CurrentPasswordTextBox
			// 
			this.CurrentPasswordTextBox.Location = new System.Drawing.Point(91, 399);
			this.CurrentPasswordTextBox.MaxLength = 146;
			this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
			this.CurrentPasswordTextBox.PasswordChar = '•';
			this.CurrentPasswordTextBox.Size = new System.Drawing.Size(206, 21);
			this.CurrentPasswordTextBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(86, 425);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Новый пароль:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(86, 383);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Текущий пароль:";
			// 
			// UploadSkinButton
			// 
			this.UploadSkinButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.UploadSkinButton.BackColor = System.Drawing.Color.Transparent;
			this.UploadSkinButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.UploadSkinButton.ForeColor = System.Drawing.Color.White;
			this.UploadSkinButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.UploadSkinButton.Location = new System.Drawing.Point(222, 340);
			this.UploadSkinButton.Name = "UploadSkinButton";
			this.UploadSkinButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.UploadSkinButton.Size = new System.Drawing.Size(100, 25);
			this.UploadSkinButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.UploadSkinButton.TabIndex = 13;
			this.UploadSkinButton.Text = "Установить";
			this.UploadSkinButton.UseVisualStyleBackColor = false;
			this.UploadSkinButton.Click += new System.EventHandler(this.UploadSkinButtonClick);
			// 
			// PlayButton
			// 
			this.PlayButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.PlayButton.BackColor = System.Drawing.Color.Transparent;
			this.PlayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.PlayButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.PlayButton.ForeColor = System.Drawing.Color.White;
			this.PlayButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.PlayButton.Location = new System.Drawing.Point(142, 506);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.PlayButton.Size = new System.Drawing.Size(100, 35);
			this.PlayButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.PlayButton.TabIndex = 12;
			this.PlayButton.Text = "Играть";
			this.PlayButton.UseVisualStyleBackColor = false;
			// 
			// ChangePasswordButton
			// 
			this.ChangePasswordButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.ChangePasswordButton.BackColor = System.Drawing.Color.Transparent;
			this.ChangePasswordButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.ChangePasswordButton.ForeColor = System.Drawing.Color.White;
			this.ChangePasswordButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.ChangePasswordButton.Location = new System.Drawing.Point(142, 469);
			this.ChangePasswordButton.Name = "ChangePasswordButton";
			this.ChangePasswordButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.ChangePasswordButton.Size = new System.Drawing.Size(100, 25);
			this.ChangePasswordButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.ChangePasswordButton.TabIndex = 11;
			this.ChangePasswordButton.Text = "Сменить пароль";
			this.ChangePasswordButton.UseVisualStyleBackColor = false;
			this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButtonClick);
			// 
			// ChooseSkinButton
			// 
			this.ChooseSkinButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.ChooseSkinButton.BackColor = System.Drawing.Color.Transparent;
			this.ChooseSkinButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.ChooseSkinButton.ForeColor = System.Drawing.Color.White;
			this.ChooseSkinButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.ChooseSkinButton.Location = new System.Drawing.Point(62, 340);
			this.ChooseSkinButton.Name = "ChooseSkinButton";
			this.ChooseSkinButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.ChooseSkinButton.Size = new System.Drawing.Size(100, 25);
			this.ChooseSkinButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.ChooseSkinButton.TabIndex = 2;
			this.ChooseSkinButton.Text = "Выбрать скин";
			this.ChooseSkinButton.UseVisualStyleBackColor = false;
			this.ChooseSkinButton.Click += new System.EventHandler(this.ChooseSkinButtonClick);
			// 
			// skinViewer2
			// 
			this.skinViewer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(165)))), ((int)(((byte)(244)))));
			this.skinViewer2.FrontRender = false;
			this.skinViewer2.Location = new System.Drawing.Point(200, 48);
			this.skinViewer2.Name = "skinViewer2";
			this.skinViewer2.ScaleFactor = 8F;
			this.skinViewer2.Size = new System.Drawing.Size(144, 264);
			this.skinViewer2.Skin = null;
			this.skinViewer2.TabIndex = 1;
			this.skinViewer2.Text = "skinViewer2";
			// 
			// skinViewer1
			// 
			this.skinViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(165)))), ((int)(((byte)(244)))));
			this.skinViewer1.FrontRender = true;
			this.skinViewer1.Location = new System.Drawing.Point(40, 48);
			this.skinViewer1.Name = "skinViewer1";
			this.skinViewer1.ScaleFactor = 8F;
			this.skinViewer1.Size = new System.Drawing.Size(144, 264);
			this.skinViewer1.Skin = null;
			this.skinViewer1.TabIndex = 0;
			this.skinViewer1.Text = "skinViewer1";
			// 
			// CabinetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MinecraftLauncher.Properties.Resources.bg_cabinet;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(384, 560);
			this.Controls.Add(this.UploadSkinButton);
			this.Controls.Add(this.PlayButton);
			this.Controls.Add(this.ChangePasswordButton);
			this.Controls.Add(this.NewPasswordTextBox);
			this.Controls.Add(this.CurrentPasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChooseSkinButton);
			this.Controls.Add(this.skinViewer2);
			this.Controls.Add(this.skinViewer1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CabinetForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Личный кабинет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UI.SkinViewer skinViewer1;
		private UI.SkinViewer skinViewer2;
		private UI.ImageButton ChooseSkinButton;
		private System.Windows.Forms.TextBox NewPasswordTextBox;
		private System.Windows.Forms.TextBox CurrentPasswordTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private UI.ImageButton ChangePasswordButton;
		private UI.ImageButton PlayButton;
		private UI.ImageButton UploadSkinButton;
	}
}