namespace MinecraftLauncher
{
	sealed partial class Main
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
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.RegisterLink = new System.Windows.Forms.LinkLabel();
			this.updaterControl = new wyDay.Controls.AutomaticUpdater();
			this.CheckForUpdatesButton = new MinecraftLauncher.UI.ImageButton();
			this.SettingsButton = new MinecraftLauncher.UI.ImageButton();
			this.LoginButton = new MinecraftLauncher.UI.ImageButton();
			this.CabinetButton = new MinecraftLauncher.UI.ImageButton();
			((System.ComponentModel.ISupportInitialize)(this.updaterControl)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.BackColor = System.Drawing.Color.Black;
			this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginTextBox.ForeColor = System.Drawing.Color.White;
			this.LoginTextBox.Location = new System.Drawing.Point(357, 218);
			this.LoginTextBox.MaxLength = 14;
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(144, 16);
			this.LoginTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(239, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(239, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.Black;
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
			this.PasswordTextBox.Location = new System.Drawing.Point(357, 250);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '•';
			this.PasswordTextBox.Size = new System.Drawing.Size(144, 16);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// RegisterLink
			// 
			this.RegisterLink.ActiveLinkColor = System.Drawing.Color.White;
			this.RegisterLink.AutoSize = true;
			this.RegisterLink.BackColor = System.Drawing.Color.Transparent;
			this.RegisterLink.LinkColor = System.Drawing.Color.LawnGreen;
			this.RegisterLink.Location = new System.Drawing.Point(354, 282);
			this.RegisterLink.Name = "RegisterLink";
			this.RegisterLink.Size = new System.Drawing.Size(47, 13);
			this.RegisterLink.TabIndex = 6;
			this.RegisterLink.TabStop = true;
			this.RegisterLink.Text = "Register";
			this.RegisterLink.VisitedLinkColor = System.Drawing.Color.LawnGreen;
			this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkClicked);
			// 
			// updaterControl
			// 
			this.updaterControl.BackColor = System.Drawing.Color.Transparent;
			this.updaterControl.ContainerForm = this;
			this.updaterControl.DaysBetweenChecks = 1;
			this.updaterControl.ForeColor = System.Drawing.Color.White;
			this.updaterControl.GUID = "0b206ba1-6366-4c6a-a47f-846e9a766c7b";
			this.updaterControl.Location = new System.Drawing.Point(6, 10);
			this.updaterControl.Name = "updaterControl";
			this.updaterControl.Size = new System.Drawing.Size(16, 16);
			this.updaterControl.TabIndex = 10;
			this.updaterControl.wyUpdateCommandline = null;
			// 
			// CheckForUpdatesButton
			// 
			this.CheckForUpdatesButton.Active = global::MinecraftLauncher.Properties.Resources.check_for_updates;
			this.CheckForUpdatesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CheckForUpdatesButton.BackColor = System.Drawing.Color.Transparent;
			this.CheckForUpdatesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CheckForUpdatesButton.Disabled = global::MinecraftLauncher.Properties.Resources.check_for_updates;
			this.CheckForUpdatesButton.Hover = global::MinecraftLauncher.Properties.Resources.check_for_updates;
			this.CheckForUpdatesButton.Location = new System.Drawing.Point(794, 6);
			this.CheckForUpdatesButton.Name = "CheckForUpdatesButton";
			this.CheckForUpdatesButton.Normal = global::MinecraftLauncher.Properties.Resources.check_for_updates;
			this.CheckForUpdatesButton.Size = new System.Drawing.Size(24, 24);
			this.CheckForUpdatesButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.CheckForUpdatesButton.TabIndex = 13;
			this.CheckForUpdatesButton.UseVisualStyleBackColor = false;
			this.CheckForUpdatesButton.Click += new System.EventHandler(this.CheckForUpdatesButtonClick);
			// 
			// SettingsButton
			// 
			this.SettingsButton.Active = global::MinecraftLauncher.Properties.Resources.settings;
			this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
			this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SettingsButton.Disabled = global::MinecraftLauncher.Properties.Resources.settings;
			this.SettingsButton.Hover = global::MinecraftLauncher.Properties.Resources.settings;
			this.SettingsButton.Location = new System.Drawing.Point(824, 6);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Normal = global::MinecraftLauncher.Properties.Resources.settings;
			this.SettingsButton.Size = new System.Drawing.Size(24, 24);
			this.SettingsButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.SettingsButton.TabIndex = 12;
			this.SettingsButton.UseVisualStyleBackColor = false;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
			// 
			// LoginButton
			// 
			this.LoginButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.LoginButton.BackColor = System.Drawing.Color.Transparent;
			this.LoginButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.LoginButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.LoginButton.ForeColor = System.Drawing.Color.White;
			this.LoginButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.LoginButton.Location = new System.Drawing.Point(408, 278);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.LoginButton.Size = new System.Drawing.Size(100, 25);
			this.LoginButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.LoginButton.TabIndex = 11;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
			// 
			// CabinetButton
			// 
			this.CabinetButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.CabinetButton.BackColor = System.Drawing.Color.Transparent;
			this.CabinetButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.CabinetButton.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.CabinetButton.ForeColor = System.Drawing.Color.White;
			this.CabinetButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.CabinetButton.Location = new System.Drawing.Point(408, 304);
			this.CabinetButton.Name = "CabinetButton";
			this.CabinetButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.CabinetButton.Size = new System.Drawing.Size(100, 25);
			this.CabinetButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.CabinetButton.TabIndex = 14;
			this.CabinetButton.Text = "Cabinet";
			this.CabinetButton.UseVisualStyleBackColor = false;
			this.CabinetButton.Click += new System.EventHandler(this.CabinetButtonClick);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MinecraftLauncher.Properties.Resources.bg;
			this.ClientSize = new System.Drawing.Size(854, 480);
			this.Controls.Add(this.CabinetButton);
			this.Controls.Add(this.CheckForUpdatesButton);
			this.Controls.Add(this.SettingsButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.updaterControl);
			this.Controls.Add(this.RegisterLink);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LoginTextBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minetrophy launcher";
			((System.ComponentModel.ISupportInitialize)(this.updaterControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.LinkLabel RegisterLink;
		private wyDay.Controls.AutomaticUpdater updaterControl;
		private UI.ImageButton LoginButton;
		private UI.ImageButton SettingsButton;
		private UI.ImageButton CheckForUpdatesButton;
		private UI.ImageButton CabinetButton;
	}
}

