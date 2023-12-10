
namespace Tyuiu.ShabanovMS.Sprint6.Task6.V11
{
    partial class FormMain_SMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SMS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.buttonOpen_SMS = new System.Windows.Forms.Button();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxInput_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SMS = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_SMS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipAnnotation_SMS = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBoxTask_SMS.SuspendLayout();
            this.groupBoxInput_SMS.SuspendLayout();
            this.groupBoxOutput_SMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelp_SMS);
            this.groupBox1.Controls.Add(this.buttonDone_SMS);
            this.groupBox1.Controls.Add(this.buttonOpen_SMS);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы управления";
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonHelp_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SMS.Image")));
            this.buttonHelp_SMS.Location = new System.Drawing.Point(850, 21);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(67, 60);
            this.buttonHelp_SMS.TabIndex = 0;
            this.toolTipAnnotation_SMS.SetToolTip(this.buttonHelp_SMS, "Информация о разработчике\r\n\r\n");
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_SMS.Enabled = false;
            this.buttonDone_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SMS.Image")));
            this.buttonDone_SMS.Location = new System.Drawing.Point(114, 20);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(69, 62);
            this.buttonDone_SMS.TabIndex = 0;
            this.toolTipAnnotation_SMS.SetToolTip(this.buttonDone_SMS, "Вывести предпоследнее слово каждой строки\r\n");
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // buttonOpen_SMS
            // 
            this.buttonOpen_SMS.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpen_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SMS.Image")));
            this.buttonOpen_SMS.Location = new System.Drawing.Point(6, 19);
            this.buttonOpen_SMS.Name = "buttonOpen_SMS";
            this.buttonOpen_SMS.Size = new System.Drawing.Size(67, 62);
            this.buttonOpen_SMS.TabIndex = 0;
            this.toolTipAnnotation_SMS.SetToolTip(this.buttonOpen_SMS, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            this.buttonOpen_SMS.UseVisualStyleBackColor = false;
            this.buttonOpen_SMS.Click += new System.EventHandler(this.buttonOpen_SMS_Click);
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(13, 112);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(947, 76);
            this.groupBoxTask_SMS.TabIndex = 1;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Location = new System.Drawing.Point(7, 19);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(934, 46);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.Text = resources.GetString("textBoxTask_SMS.Text");
            // 
            // groupBoxInput_SMS
            // 
            this.groupBoxInput_SMS.Controls.Add(this.textBoxInput_SMS);
            this.groupBoxInput_SMS.Location = new System.Drawing.Point(13, 194);
            this.groupBoxInput_SMS.Name = "groupBoxInput_SMS";
            this.groupBoxInput_SMS.Size = new System.Drawing.Size(474, 394);
            this.groupBoxInput_SMS.TabIndex = 2;
            this.groupBoxInput_SMS.TabStop = false;
            this.groupBoxInput_SMS.Text = "Ввод";
            // 
            // textBoxInput_SMS
            // 
            this.textBoxInput_SMS.Location = new System.Drawing.Point(7, 20);
            this.textBoxInput_SMS.Multiline = true;
            this.textBoxInput_SMS.Name = "textBoxInput_SMS";
            this.textBoxInput_SMS.Size = new System.Drawing.Size(461, 368);
            this.textBoxInput_SMS.TabIndex = 0;
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.textBoxResult_SMS);
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(493, 194);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(471, 394);
            this.groupBoxOutput_SMS.TabIndex = 2;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод";
            // 
            // textBoxResult_SMS
            // 
            this.textBoxResult_SMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_SMS.Multiline = true;
            this.textBoxResult_SMS.Name = "textBoxResult_SMS";
            this.textBoxResult_SMS.Size = new System.Drawing.Size(461, 368);
            this.textBoxResult_SMS.TabIndex = 0;
            // 
            // openFileDialogTask_SMS
            // 
            this.openFileDialogTask_SMS.FileName = "openFileDialog1";
            // 
            // toolTipAnnotation_SMS
            // 
            this.toolTipAnnotation_SMS.Tag = "";
            this.toolTipAnnotation_SMS.ToolTipTitle = "Подсказка";
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 600);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.groupBoxInput_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 11 | Шабанов М.С.";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            this.groupBoxInput_SMS.ResumeLayout(false);
            this.groupBoxInput_SMS.PerformLayout();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            this.groupBoxOutput_SMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.Button buttonOpen_SMS;
        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.GroupBox groupBoxInput_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMS;
        private System.Windows.Forms.TextBox textBoxInput_SMS;
        private System.Windows.Forms.TextBox textBoxResult_SMS;
        private System.Windows.Forms.ToolTip toolTipAnnotation_SMS;
    }
}

