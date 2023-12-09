
namespace Tyuiu.ShabanovMS.Sprint6.Task6.V11
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
            this.textBoxDeveloper_SMS = new System.Windows.Forms.TextBox();
            this.pictureBoxAvatar_SMS = new System.Windows.Forms.PictureBox();
            this.buttonOK_SMS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDeveloper_SMS
            // 
            this.textBoxDeveloper_SMS.Location = new System.Drawing.Point(187, 44);
            this.textBoxDeveloper_SMS.Multiline = true;
            this.textBoxDeveloper_SMS.Name = "textBoxDeveloper_SMS";
            this.textBoxDeveloper_SMS.ReadOnly = true;
            this.textBoxDeveloper_SMS.Size = new System.Drawing.Size(207, 69);
            this.textBoxDeveloper_SMS.TabIndex = 0;
            this.textBoxDeveloper_SMS.TabStop = false;
            this.textBoxDeveloper_SMS.Text = "Разработчик: Шабанов М.С.\r\nГруппа АСОиУб-23-1\r\nВысшая школа цифровых технологий (" +
    "c) 2023\r\n";
            // 
            // pictureBoxAvatar_SMS
            // 
            this.pictureBoxAvatar_SMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SMS.Image")));
            this.pictureBoxAvatar_SMS.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_SMS.Name = "pictureBoxAvatar_SMS";
            this.pictureBoxAvatar_SMS.Size = new System.Drawing.Size(127, 144);
            this.pictureBoxAvatar_SMS.TabIndex = 1;
            this.pictureBoxAvatar_SMS.TabStop = false;
            // 
            // buttonOK_SMS
            // 
            this.buttonOK_SMS.Location = new System.Drawing.Point(319, 134);
            this.buttonOK_SMS.Name = "buttonOK_SMS";
            this.buttonOK_SMS.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SMS.TabIndex = 2;
            this.buttonOK_SMS.Text = "OK";
            this.buttonOK_SMS.UseVisualStyleBackColor = true;
            this.buttonOK_SMS.Click += new System.EventHandler(this.buttonOK_SMS_Click);
            // 
            // FormAbout_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 169);
            this.Controls.Add(this.buttonOK_SMS);
            this.Controls.Add(this.pictureBoxAvatar_SMS);
            this.Controls.Add(this.textBoxDeveloper_SMS);
            this.MaximumSize = new System.Drawing.Size(422, 208);
            this.MinimumSize = new System.Drawing.Size(422, 208);
            this.Name = "FormAbout_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDeveloper_SMS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SMS;
        private System.Windows.Forms.Button buttonOK_SMS;
    }
}