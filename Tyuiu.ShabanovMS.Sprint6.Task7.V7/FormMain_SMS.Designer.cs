
namespace Tyuiu.ShabanovMS.Sprint6.Task7.V7
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
            this.groupBoxButtons_SMS = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_SMS = new System.Windows.Forms.Button();
            this.buttonSave_SMS = new System.Windows.Forms.Button();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewIntput_SMS = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_SMS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_SMS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_SMS = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_SMS = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxButtons_SMS.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntput_SMS)).BeginInit();
            this.groupBoxOutput_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxButtons_SMS
            // 
            this.groupBoxButtons_SMS.Controls.Add(this.buttonHelp_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonOpenFile_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonSave_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonDone_SMS);
            this.groupBoxButtons_SMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButtons_SMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_SMS.Name = "groupBoxButtons_SMS";
            this.groupBoxButtons_SMS.Size = new System.Drawing.Size(1185, 72);
            this.groupBoxButtons_SMS.TabIndex = 0;
            this.groupBoxButtons_SMS.TabStop = false;
            this.groupBoxButtons_SMS.Text = "Элементы управления";
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SMS.Image")));
            this.buttonHelp_SMS.Location = new System.Drawing.Point(1124, 16);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(58, 53);
            this.buttonHelp_SMS.TabIndex = 0;
            this.buttonHelp_SMS.TabStop = false;
            this.toolTipButton_SMS.SetToolTip(this.buttonHelp_SMS, "Информация о разработчкие");
            this.buttonHelp_SMS.UseVisualStyleBackColor = true;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // buttonOpenFile_SMS
            // 
            this.buttonOpenFile_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_SMS.Image")));
            this.buttonOpenFile_SMS.Location = new System.Drawing.Point(7, 14);
            this.buttonOpenFile_SMS.Name = "buttonOpenFile_SMS";
            this.buttonOpenFile_SMS.Size = new System.Drawing.Size(58, 52);
            this.buttonOpenFile_SMS.TabIndex = 0;
            this.toolTipButton_SMS.SetToolTip(this.buttonOpenFile_SMS, "Нажмите для выбора файла");
            this.buttonOpenFile_SMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SMS.Click += new System.EventHandler(this.buttonOpenFile_SMS_Click);
            this.buttonOpenFile_SMS.MouseEnter += new System.EventHandler(this.buttonOpenFile_SMS_MouseEnter);
            // 
            // buttonSave_SMS
            // 
            this.buttonSave_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SMS.Image")));
            this.buttonSave_SMS.Location = new System.Drawing.Point(176, 14);
            this.buttonSave_SMS.Name = "buttonSave_SMS";
            this.buttonSave_SMS.Size = new System.Drawing.Size(58, 52);
            this.buttonSave_SMS.TabIndex = 0;
            this.buttonSave_SMS.TabStop = false;
            this.toolTipButton_SMS.SetToolTip(this.buttonSave_SMS, "Нажмите для сохранения");
            this.buttonSave_SMS.UseVisualStyleBackColor = true;
            this.buttonSave_SMS.Click += new System.EventHandler(this.buttonSave_SMS_Click);
            this.buttonSave_SMS.MouseEnter += new System.EventHandler(this.buttonSave_SMS_MouseEnter);
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SMS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SMS.Image")));
            this.buttonDone_SMS.Location = new System.Drawing.Point(90, 14);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(58, 52);
            this.buttonDone_SMS.TabIndex = 0;
            this.buttonDone_SMS.TabStop = false;
            this.toolTipButton_SMS.SetToolTip(this.buttonDone_SMS, "Нажмите для выполнения");
            this.buttonDone_SMS.UseVisualStyleBackColor = true;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            this.buttonDone_SMS.MouseEnter += new System.EventHandler(this.buttonDone_SMS_MouseEnter);
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask.Location = new System.Drawing.Point(0, 72);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(1185, 83);
            this.groupBoxTask.TabIndex = 1;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1160, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInput_SMS
            // 
            this.groupBoxInput_SMS.Controls.Add(this.dataGridViewIntput_SMS);
            this.groupBoxInput_SMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_SMS.Location = new System.Drawing.Point(0, 155);
            this.groupBoxInput_SMS.Name = "groupBoxInput_SMS";
            this.groupBoxInput_SMS.Size = new System.Drawing.Size(585, 507);
            this.groupBoxInput_SMS.TabIndex = 2;
            this.groupBoxInput_SMS.TabStop = false;
            this.groupBoxInput_SMS.Text = "Ввод";
            // 
            // dataGridViewIntput_SMS
            // 
            this.dataGridViewIntput_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntput_SMS.ColumnHeadersVisible = false;
            this.dataGridViewIntput_SMS.Location = new System.Drawing.Point(7, 19);
            this.dataGridViewIntput_SMS.Name = "dataGridViewIntput_SMS";
            this.dataGridViewIntput_SMS.RowHeadersVisible = false;
            this.dataGridViewIntput_SMS.Size = new System.Drawing.Size(572, 455);
            this.dataGridViewIntput_SMS.TabIndex = 0;
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.dataGridViewOutput_SMS);
            this.groupBoxOutput_SMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(603, 155);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(582, 507);
            this.groupBoxOutput_SMS.TabIndex = 2;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод";
            // 
            // dataGridViewOutput_SMS
            // 
            this.dataGridViewOutput_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_SMS.ColumnHeadersVisible = false;
            this.dataGridViewOutput_SMS.Location = new System.Drawing.Point(7, 14);
            this.dataGridViewOutput_SMS.Name = "dataGridViewOutput_SMS";
            this.dataGridViewOutput_SMS.RowHeadersVisible = false;
            this.dataGridViewOutput_SMS.Size = new System.Drawing.Size(569, 456);
            this.dataGridViewOutput_SMS.TabIndex = 0;
            // 
            // openFileDialogTask_SMS
            // 
            this.openFileDialogTask_SMS.FileName = "openFileDialog1";
            // 
            // toolTipButton_SMS
            // 
            this.toolTipButton_SMS.IsBalloon = true;
            this.toolTipButton_SMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_SMS.ToolTipTitle = "Подсказка";
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 662);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.groupBoxInput_SMS);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxButtons_SMS);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 7 | Шабанов М.С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxButtons_SMS.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput_SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntput_SMS)).EndInit();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons_SMS;
        private System.Windows.Forms.Button buttonSave_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonOpenFile_SMS;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInput_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.DataGridView dataGridViewIntput_SMS;
        private System.Windows.Forms.DataGridView dataGridViewOutput_SMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SMS;
        private System.Windows.Forms.ToolTip toolTipButton_SMS;
    }
}

