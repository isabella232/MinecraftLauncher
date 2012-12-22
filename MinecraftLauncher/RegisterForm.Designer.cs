namespace MinecraftLauncher
{
	partial class RegisterForm
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
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.ConfirmTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.RegisterButton = new MinecraftLauncher.UI.ImageButton();
			this.CancelButton = new MinecraftLauncher.UI.ImageButton();
			this.SuspendLayout();
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(124, 88);
			this.LoginTextBox.MaxLength = 146;
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(206, 21);
			this.LoginTextBox.TabIndex = 0;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(122, 130);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '•';
			this.PasswordTextBox.Size = new System.Drawing.Size(206, 21);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// ConfirmTextBox
			// 
			this.ConfirmTextBox.Location = new System.Drawing.Point(122, 172);
			this.ConfirmTextBox.Name = "ConfirmTextBox";
			this.ConfirmTextBox.PasswordChar = '•';
			this.ConfirmTextBox.Size = new System.Drawing.Size(206, 21);
			this.ConfirmTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(119, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Логин:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(119, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Пароль:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(119, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Повтор пароля:";
			// 
			// RegisterButton
			// 
			this.RegisterButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
			this.RegisterButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.RegisterButton.ForeColor = System.Drawing.Color.White;
			this.RegisterButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.RegisterButton.Location = new System.Drawing.Point(122, 203);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.RegisterButton.Size = new System.Drawing.Size(100, 25);
			this.RegisterButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.RegisterButton.TabIndex = 8;
			this.RegisterButton.TabStop = false;
			this.RegisterButton.Text = "Регистрация";
			this.RegisterButton.UseVisualStyleBackColor = false;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButtonClick);
			// 
			// CancelButton
			// 
			this.CancelButton.Active = global::MinecraftLauncher.Properties.Resources.button_active;
			this.CancelButton.BackColor = System.Drawing.Color.Transparent;
			this.CancelButton.Disabled = global::MinecraftLauncher.Properties.Resources.button_disable;
			this.CancelButton.ForeColor = System.Drawing.Color.White;
			this.CancelButton.Hover = global::MinecraftLauncher.Properties.Resources.button_hover;
			this.CancelButton.Location = new System.Drawing.Point(228, 203);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Normal = global::MinecraftLauncher.Properties.Resources.button;
			this.CancelButton.Size = new System.Drawing.Size(100, 25);
			this.CancelButton.State = MinecraftLauncher.UI.ImageButton.ImageButtonState.Normal;
			this.CancelButton.TabIndex = 9;
			this.CancelButton.TabStop = false;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.RegisterButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MinecraftLauncher.Properties.Resources.bg_reg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(450, 300);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.ConfirmTextBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox ConfirmTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private UI.ImageButton RegisterButton;
		private UI.ImageButton CancelButton;
	}
}