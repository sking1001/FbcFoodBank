namespace About
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dcaLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.appIconPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dcaLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dcaLogoPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 50);
            this.panel1.TabIndex = 0;
            // 
            // dcaLogoPictureBox
            // 
            this.dcaLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dcaLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dcaLogoPictureBox.Image")));
            this.dcaLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.dcaLogoPictureBox.Name = "dcaLogoPictureBox";
            this.dcaLogoPictureBox.Size = new System.Drawing.Size(394, 50);
            this.dcaLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dcaLogoPictureBox.TabIndex = 0;
            this.dcaLogoPictureBox.TabStop = false;
            // 
            // AppLabel
            // 
            this.AppLabel.AutoSize = true;
            this.AppLabel.Location = new System.Drawing.Point(135, 110);
            this.AppLabel.Name = "AppLabel";
            this.AppLabel.Size = new System.Drawing.Size(52, 13);
            this.AppLabel.TabIndex = 1;
            this.AppLabel.Text = "[AppTitle]";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(135, 127);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(48, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "[Version]";
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(135, 144);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(178, 13);
            this.CopyrightLabel.TabIndex = 3;
            this.CopyrightLabel.Text = "© 2007 First Baptist Church Cushing";
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(160, 218);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // appIconPictureBox
            // 
            this.appIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appIconPictureBox.Image")));
            this.appIconPictureBox.Location = new System.Drawing.Point(81, 110);
            this.appIconPictureBox.Name = "appIconPictureBox";
            this.appIconPictureBox.Size = new System.Drawing.Size(48, 48);
            this.appIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.appIconPictureBox.TabIndex = 5;
            this.appIconPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.appIconPictureBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.AppLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About [AppTitle]";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dcaLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox dcaLogoPictureBox;
        private System.Windows.Forms.Label AppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox appIconPictureBox;
    }
}