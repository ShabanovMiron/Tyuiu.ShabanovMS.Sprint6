
namespace Tyuiu.ShabanovMS.Sprint6.Task1.V4
{
    partial class FormTask1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask1));
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.labelFormula_SMS = new System.Windows.Forms.Label();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SMS = new System.Windows.Forms.GroupBox();
            this.labelStop_SMS = new System.Windows.Forms.Label();
            this.labelStart_SMS = new System.Windows.Forms.Label();
            this.textBoxStop_SMS = new System.Windows.Forms.TextBox();
            this.textBoxStart_SMS = new System.Windows.Forms.TextBox();
            this.buttonInfo_SMS = new System.Windows.Forms.Button();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SMS = new System.Windows.Forms.TextBox();
            this.labelResult_SMS = new System.Windows.Forms.Label();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInput_SMS.SuspendLayout();
            this.groupBoxOutput_SMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.labelFormula_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(540, 267);
            this.groupBoxTask_SMS.TabIndex = 0;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // labelFormula_SMS
            // 
            this.labelFormula_SMS.AutoSize = true;
            this.labelFormula_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormula_SMS.Location = new System.Drawing.Point(6, 90);
            this.labelFormula_SMS.Name = "labelFormula_SMS";
            this.labelFormula_SMS.Size = new System.Drawing.Size(71, 16);
            this.labelFormula_SMS.TabIndex = 2;
            this.labelFormula_SMS.Text = "Формула:";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(6, 106);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(247, 43);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SMS.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(528, 52);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.TabStop = false;
            this.textBoxTask_SMS.Text = "Произвести табулирование данной функции на отрезки [-5;5] с шагом 1. При делении " +
    "на 0 вернуть значение 0. Результат округлить до двух знаков после запятой и выве" +
    "сти в TextBox";
            // 
            // groupBoxInput_SMS
            // 
            this.groupBoxInput_SMS.Controls.Add(this.labelStop_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.labelStart_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.textBoxStop_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.textBoxStart_SMS);
            this.groupBoxInput_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_SMS.Location = new System.Drawing.Point(18, 285);
            this.groupBoxInput_SMS.Name = "groupBoxInput_SMS";
            this.groupBoxInput_SMS.Size = new System.Drawing.Size(228, 123);
            this.groupBoxInput_SMS.TabIndex = 3;
            this.groupBoxInput_SMS.TabStop = false;
            this.groupBoxInput_SMS.Text = "Ввод данных";
            // 
            // labelStop_SMS
            // 
            this.labelStop_SMS.AutoSize = true;
            this.labelStop_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStop_SMS.Location = new System.Drawing.Point(119, 74);
            this.labelStop_SMS.Name = "labelStop_SMS";
            this.labelStop_SMS.Size = new System.Drawing.Size(85, 16);
            this.labelStop_SMS.TabIndex = 2;
            this.labelStop_SMS.Text = "Конец шага:";
            // 
            // labelStart_SMS
            // 
            this.labelStart_SMS.AutoSize = true;
            this.labelStart_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart_SMS.Location = new System.Drawing.Point(7, 74);
            this.labelStart_SMS.Name = "labelStart_SMS";
            this.labelStart_SMS.Size = new System.Drawing.Size(84, 16);
            this.labelStart_SMS.TabIndex = 2;
            this.labelStart_SMS.Text = "Старт шага:";
            // 
            // textBoxStop_SMS
            // 
            this.textBoxStop_SMS.Location = new System.Drawing.Point(122, 93);
            this.textBoxStop_SMS.Name = "textBoxStop_SMS";
            this.textBoxStop_SMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_SMS.TabIndex = 1;
            // 
            // textBoxStart_SMS
            // 
            this.textBoxStart_SMS.Location = new System.Drawing.Point(0, 93);
            this.textBoxStart_SMS.Name = "textBoxStart_SMS";
            this.textBoxStart_SMS.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_SMS.TabIndex = 0;
            // 
            // buttonInfo_SMS
            // 
            this.buttonInfo_SMS.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonInfo_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_SMS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInfo_SMS.Location = new System.Drawing.Point(281, 356);
            this.buttonInfo_SMS.Name = "buttonInfo_SMS";
            this.buttonInfo_SMS.Size = new System.Drawing.Size(112, 52);
            this.buttonInfo_SMS.TabIndex = 4;
            this.buttonInfo_SMS.Text = "Справка";
            this.buttonInfo_SMS.UseVisualStyleBackColor = false;
            this.buttonInfo_SMS.Click += new System.EventHandler(this.buttonInfo_SMS_Click);
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDone_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SMS.Location = new System.Drawing.Point(434, 356);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(112, 52);
            this.buttonDone_SMS.TabIndex = 5;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.labelResult_SMS);
            this.groupBoxOutput_SMS.Controls.Add(this.textBoxResult_SMS);
            this.groupBoxOutput_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(558, 12);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(230, 426);
            this.groupBoxOutput_SMS.TabIndex = 6;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод данных";
            // 
            // textBoxResult_SMS
            // 
            this.textBoxResult_SMS.Font = new System.Drawing.Font("Consolas", 11.5F);
            this.textBoxResult_SMS.Location = new System.Drawing.Point(7, 45);
            this.textBoxResult_SMS.Multiline = true;
            this.textBoxResult_SMS.Name = "textBoxResult_SMS";
            this.textBoxResult_SMS.ReadOnly = true;
            this.textBoxResult_SMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SMS.Size = new System.Drawing.Size(217, 375);
            this.textBoxResult_SMS.TabIndex = 0;
            // 
            // labelResult_SMS
            // 
            this.labelResult_SMS.AutoSize = true;
            this.labelResult_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_SMS.Location = new System.Drawing.Point(7, 26);
            this.labelResult_SMS.Name = "labelResult_SMS";
            this.labelResult_SMS.Size = new System.Drawing.Size(91, 16);
            this.labelResult_SMS.TabIndex = 1;
            this.labelResult_SMS.Text = "Результат:";
            // 
            // FormTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.buttonDone_SMS);
            this.Controls.Add(this.buttonInfo_SMS);
            this.Controls.Add(this.groupBoxInput_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.Name = "FormTask1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 4 | Шабанов М.С.";
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInput_SMS.ResumeLayout(false);
            this.groupBoxInput_SMS.PerformLayout();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            this.groupBoxOutput_SMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label labelFormula_SMS;
        private System.Windows.Forms.GroupBox groupBoxInput_SMS;
        private System.Windows.Forms.Label labelStop_SMS;
        private System.Windows.Forms.Label labelStart_SMS;
        private System.Windows.Forms.TextBox textBoxStop_SMS;
        private System.Windows.Forms.TextBox textBoxStart_SMS;
        private System.Windows.Forms.Button buttonInfo_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.TextBox textBoxResult_SMS;
        private System.Windows.Forms.Label labelResult_SMS;
    }
}

