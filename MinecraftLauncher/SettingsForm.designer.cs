namespace MinecraftLauncher
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.javaHomePath = new System.Windows.Forms.TextBox();
            this.javaHomeSelect = new System.Windows.Forms.Button();
            this.minecraftSelect = new System.Windows.Forms.Button();
            this.minecraftPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialSize = new System.Windows.Forms.TrackBar();
            this.maximumSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInitialSize = new System.Windows.Forms.Label();
            this.labelMaximumSize = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Java Home Path: *";
            // 
            // javaHomePath
            // 
            this.javaHomePath.Location = new System.Drawing.Point(12, 24);
            this.javaHomePath.Name = "javaHomePath";
            this.javaHomePath.Size = new System.Drawing.Size(489, 21);
            this.javaHomePath.TabIndex = 0;
            // 
            // javaHomeSelect
            // 
            this.javaHomeSelect.Location = new System.Drawing.Point(507, 23);
            this.javaHomeSelect.Name = "javaHomeSelect";
            this.javaHomeSelect.Size = new System.Drawing.Size(75, 22);
            this.javaHomeSelect.TabIndex = 1;
            this.javaHomeSelect.Text = "...";
            this.javaHomeSelect.UseVisualStyleBackColor = true;
            this.javaHomeSelect.Click += new System.EventHandler(this.JavaHomeSelectClick);
            // 
            // minecraftSelect
            // 
            this.minecraftSelect.Enabled = false;
            this.minecraftSelect.Location = new System.Drawing.Point(507, -45);
            this.minecraftSelect.Name = "minecraftSelect";
            this.minecraftSelect.Size = new System.Drawing.Size(75, 22);
            this.minecraftSelect.TabIndex = 3;
            this.minecraftSelect.Text = "...";
            this.minecraftSelect.UseVisualStyleBackColor = true;
            this.minecraftSelect.Click += new System.EventHandler(this.MinecraftSelectClick);
            // 
            // minecraftPath
            // 
            this.minecraftPath.Enabled = false;
            this.minecraftPath.Location = new System.Drawing.Point(12, -44);
            this.minecraftPath.Name = "minecraftPath";
            this.minecraftPath.Size = new System.Drawing.Size(489, 21);
            this.minecraftPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, -60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".minecraft Directory Path: *";
            // 
            // initialSize
            // 
            this.initialSize.LargeChange = 32;
            this.initialSize.Location = new System.Drawing.Point(12, 64);
            this.initialSize.Maximum = 4096;
            this.initialSize.Minimum = 256;
            this.initialSize.Name = "initialSize";
            this.initialSize.Size = new System.Drawing.Size(570, 45);
            this.initialSize.SmallChange = 32;
            this.initialSize.TabIndex = 4;
            this.initialSize.TickFrequency = 32;
            this.initialSize.Value = 256;
            // 
            // maximumSize
            // 
            this.maximumSize.LargeChange = 32;
            this.maximumSize.Location = new System.Drawing.Point(12, 115);
            this.maximumSize.Maximum = 4096;
            this.maximumSize.Minimum = 256;
            this.maximumSize.Name = "maximumSize";
            this.maximumSize.Size = new System.Drawing.Size(570, 45);
            this.maximumSize.SmallChange = 32;
            this.maximumSize.TabIndex = 5;
            this.maximumSize.TickFrequency = 32;
            this.maximumSize.Value = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Минимальный объем выделяемой памяти:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Максимальный объем выделяемой памяти:";
            // 
            // labelInitialSize
            // 
            this.labelInitialSize.Location = new System.Drawing.Point(482, 48);
            this.labelInitialSize.Name = "labelInitialSize";
            this.labelInitialSize.Size = new System.Drawing.Size(100, 23);
            this.labelInitialSize.TabIndex = 10;
            this.labelInitialSize.Text = "0M";
            this.labelInitialSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMaximumSize
            // 
            this.labelMaximumSize.Location = new System.Drawing.Point(482, 96);
            this.labelMaximumSize.Name = "labelMaximumSize";
            this.labelMaximumSize.Size = new System.Drawing.Size(100, 23);
            this.labelMaximumSize.TabIndex = 11;
            this.labelMaximumSize.Text = "0M";
            this.labelMaximumSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bOk
            // 
            this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOk.Location = new System.Drawing.Point(376, 166);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(100, 30);
            this.bOk.TabIndex = 6;
            this.bOk.Text = "Применить";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(482, 166);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(100, 30);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "* Не изменяйте значение поля, если не знаете его предназначения.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "* Java 32 Bit может выделить только 1376MB.";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 204);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.labelMaximumSize);
            this.Controls.Add(this.labelInitialSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maximumSize);
            this.Controls.Add(this.initialSize);
            this.Controls.Add(this.minecraftSelect);
            this.Controls.Add(this.minecraftPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.javaHomeSelect);
            this.Controls.Add(this.javaHomePath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.initialSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox javaHomePath;
        private System.Windows.Forms.Button javaHomeSelect;
        private System.Windows.Forms.Button minecraftSelect;
        private System.Windows.Forms.TextBox minecraftPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar initialSize;
        private System.Windows.Forms.TrackBar maximumSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInitialSize;
        private System.Windows.Forms.Label labelMaximumSize;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}