
namespace Tyuiu.ShabanovMS.Sprint6.Task3.V18
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
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_SMS = new System.Windows.Forms.DataGridView();
            this.labelInput_SMS = new System.Windows.Forms.Label();
            this.groupBoxResult_SMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SMS = new System.Windows.Forms.DataGridView();
            this.labelResult_SMS = new System.Windows.Forms.Label();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SMS)).BeginInit();
            this.groupBoxResult_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonDone_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SMS.Location = new System.Drawing.Point(18, 258);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(90, 41);
            this.buttonDone_SMS.TabIndex = 0;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(12, 30);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(234, 214);
            this.groupBoxTask_SMS.TabIndex = 1;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(222, 188);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.\r\n\r" +
    "\n-19 -19   1  18   7\r\n   5   3  -4  -6 -12\r\n -15   6   2   2 -14\r\n  -9 -10  15  " +
    "-5  -6\r\n -13 -15  -9   7   1\r\n";
            // 
            // dataGridViewInput_SMS
            // 
            this.dataGridViewInput_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_SMS.ColumnHeadersVisible = false;
            this.dataGridViewInput_SMS.Location = new System.Drawing.Point(274, 46);
            this.dataGridViewInput_SMS.Name = "dataGridViewInput_SMS";
            this.dataGridViewInput_SMS.ReadOnly = true;
            this.dataGridViewInput_SMS.RowHeadersVisible = false;
            this.dataGridViewInput_SMS.Size = new System.Drawing.Size(240, 221);
            this.dataGridViewInput_SMS.TabIndex = 2;
            // 
            // labelInput_SMS
            // 
            this.labelInput_SMS.AutoSize = true;
            this.labelInput_SMS.Location = new System.Drawing.Point(271, 30);
            this.labelInput_SMS.Name = "labelInput_SMS";
            this.labelInput_SMS.Size = new System.Drawing.Size(102, 13);
            this.labelInput_SMS.TabIndex = 3;
            this.labelInput_SMS.Text = "Исходная матрица";
            // 
            // groupBoxResult_SMS
            // 
            this.groupBoxResult_SMS.Controls.Add(this.labelResult_SMS);
            this.groupBoxResult_SMS.Controls.Add(this.dataGridViewResult_SMS);
            this.groupBoxResult_SMS.Location = new System.Drawing.Point(546, 12);
            this.groupBoxResult_SMS.Name = "groupBoxResult_SMS";
            this.groupBoxResult_SMS.Size = new System.Drawing.Size(314, 269);
            this.groupBoxResult_SMS.TabIndex = 4;
            this.groupBoxResult_SMS.TabStop = false;
            this.groupBoxResult_SMS.Text = "Вывод данных";
            // 
            // dataGridViewResult_SMS
            // 
            this.dataGridViewResult_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMS.ColumnHeadersVisible = false;
            this.dataGridViewResult_SMS.Location = new System.Drawing.Point(37, 34);
            this.dataGridViewResult_SMS.Name = "dataGridViewResult_SMS";
            this.dataGridViewResult_SMS.ReadOnly = true;
            this.dataGridViewResult_SMS.RowHeadersVisible = false;
            this.dataGridViewResult_SMS.Size = new System.Drawing.Size(240, 221);
            this.dataGridViewResult_SMS.TabIndex = 0;
            // 
            // labelResult_SMS
            // 
            this.labelResult_SMS.AutoSize = true;
            this.labelResult_SMS.Location = new System.Drawing.Point(37, 17);
            this.labelResult_SMS.Name = "labelResult_SMS";
            this.labelResult_SMS.Size = new System.Drawing.Size(59, 13);
            this.labelResult_SMS.TabIndex = 1;
            this.labelResult_SMS.Text = "Результат";
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_SMS.Location = new System.Drawing.Point(150, 258);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(90, 41);
            this.buttonHelp_SMS.TabIndex = 5;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 312);
            this.Controls.Add(this.buttonHelp_SMS);
            this.Controls.Add(this.groupBoxResult_SMS);
            this.Controls.Add(this.labelInput_SMS);
            this.Controls.Add(this.dataGridViewInput_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.Controls.Add(this.buttonDone_SMS);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 4 | Шабанов М.С.";
            this.Load += new System.EventHandler(this.FormMain_SMS_Load);
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SMS)).EndInit();
            this.groupBoxResult_SMS.ResumeLayout(false);
            this.groupBoxResult_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.DataGridView dataGridViewInput_SMS;
        private System.Windows.Forms.Label labelInput_SMS;
        private System.Windows.Forms.GroupBox groupBoxResult_SMS;
        private System.Windows.Forms.Label labelResult_SMS;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
    }
}

