namespace Secure_Folder
{
    partial class SecureFolderForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecureFolderForm));
			this.HideBtn = new System.Windows.Forms.Button();
			this.ShowBtn = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HideBtn
			// 
			this.HideBtn.Enabled = false;
			this.HideBtn.Location = new System.Drawing.Point(12, 111);
			this.HideBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new System.Drawing.Size(88, 28);
			this.HideBtn.TabIndex = 1;
			this.HideBtn.Text = "Hide";
			this.HideBtn.UseVisualStyleBackColor = true;
			this.HideBtn.Click += new System.EventHandler(this.ClickFolderHide);
			// 
			// ShowBtn
			// 
			this.ShowBtn.Enabled = false;
			this.ShowBtn.Location = new System.Drawing.Point(106, 111);
			this.ShowBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ShowBtn.Name = "ShowBtn";
			this.ShowBtn.Size = new System.Drawing.Size(88, 28);
			this.ShowBtn.TabIndex = 2;
			this.ShowBtn.Text = "Show";
			this.ShowBtn.UseVisualStyleBackColor = true;
			this.ShowBtn.Click += new System.EventHandler(this.ClickFolderShow);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(12, 40);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(182, 22);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ButtonKeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Please enter password for Secure Folder";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Secure Folder Commands";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 37);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 28);
			this.button1.TabIndex = 7;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.ClickPasswordCheck);
			// 
			// SecureFolderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 164);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.ShowBtn);
			this.Controls.Add(this.HideBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "SecureFolderForm";
			this.Text = "Secure Folder";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.Button HideBtn;
		private System.Windows.Forms.Button ShowBtn;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}

