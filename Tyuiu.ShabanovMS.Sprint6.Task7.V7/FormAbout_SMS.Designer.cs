
namespace Tyuiu.ShabanovMS.Sprint6.Task7.V7
{
    partial class FormAbout_SMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SMS));
            this.textBoxAbout_SMS = new System.Windows.Forms.TextBox();
            this.pictureBoxAvatar_SMS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_SMS
            // 
            this.textBoxAbout_SMS.Location = new System.Drawing.Point(148, 64);
            this.textBoxAbout_SMS.Multiline = true;
            this.textBoxAbout_SMS.Name = "textBoxAbout_SMS";
            this.textBoxAbout_SMS.ReadOnly = true;
            this.textBoxAbout_SMS.Size = new System.Drawing.Size(224, 59);
            this.textBoxAbout_SMS.TabIndex = 0;
            this.textBoxAbout_SMS.TabStop = false;
            this.textBoxAbout_SMS.Text = "Разработчик: Шабанов М.С.\r\nГруппа АСОиУб-23-1\r\nВысшая школа цифровых технологий (" +
    "c) 2023\r\n";
            // 
            // pictureBoxAvatar_SMS
            // 
            this.pictureBoxAvatar_SMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SMS.Image")));
            this.pictureBoxAvatar_SMS.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxAvatar_SMS.Name = "pictureBoxAvatar_SMS";
            this.pictureBoxAvatar_SMS.Size = new System.Drawing.Size(130, 146);
            this.pictureBoxAvatar_SMS.TabIndex = 1;
            this.pictureBoxAvatar_SMS.TabStop = false;
            // 
            // FormAbout_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 203);
            this.Controls.Add(this.pictureBoxAvatar_SMS);
            this.Controls.Add(this.textBoxAbout_SMS);
            this.Name = "FormAbout_SMS";
            this.Text = "FormAbout_SMS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_SMS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SMS;
    }
}