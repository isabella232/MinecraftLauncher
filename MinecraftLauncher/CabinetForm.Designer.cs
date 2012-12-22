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
			this.skinViewer2 = new MinecraftLauncher.UI.SkinViewer();
			this.skinViewer1 = new MinecraftLauncher.UI.SkinViewer();
			this.SuspendLayout();
			// 
			// skinViewer2
			// 
			this.skinViewer2.BackColor = System.Drawing.Color.White;
			this.skinViewer2.FrontRender = false;
			this.skinViewer2.Location = new System.Drawing.Point(162, 12);
			this.skinViewer2.Name = "skinViewer2";
			this.skinViewer2.ScaleFactor = 8F;
			this.skinViewer2.Size = new System.Drawing.Size(144, 264);
			this.skinViewer2.Skin = global::MinecraftLauncher.Properties.Resources.grimreaper;
			this.skinViewer2.TabIndex = 1;
			this.skinViewer2.Text = "skinViewer2";
			// 
			// skinViewer1
			// 
			this.skinViewer1.BackColor = System.Drawing.Color.White;
			this.skinViewer1.FrontRender = true;
			this.skinViewer1.Location = new System.Drawing.Point(12, 12);
			this.skinViewer1.Name = "skinViewer1";
			this.skinViewer1.ScaleFactor = 8F;
			this.skinViewer1.Size = new System.Drawing.Size(144, 264);
			this.skinViewer1.Skin = global::MinecraftLauncher.Properties.Resources.grimreaper;
			this.skinViewer1.TabIndex = 0;
			this.skinViewer1.Text = "skinViewer1";
			// 
			// CabinetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 441);
			this.Controls.Add(this.skinViewer2);
			this.Controls.Add(this.skinViewer1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CabinetForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Личный кабинет";
			this.ResumeLayout(false);

		}

		#endregion

		private UI.SkinViewer skinViewer1;
		private UI.SkinViewer skinViewer2;
	}
}