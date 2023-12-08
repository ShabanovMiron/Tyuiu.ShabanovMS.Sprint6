
namespace Tyuiu.ShabanovMS.Sprint6.Task0.V15
{
    partial class FormTask0_SMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask0_SMS));
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SMS = new System.Windows.Forms.PictureBox();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInput_SMS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_SMS = new System.Windows.Forms.TextBox();
            this.textBoxResult_SMS = new System.Windows.Forms.TextBox();
            this.labelVarX_SMS = new System.Windows.Forms.Label();
            this.labelResult_SMS = new System.Windows.Forms.Label();
            this.buttonAuthor_SMS = new System.Windows.Forms.Button();
            this.labelFormula_SMS = new System.Windows.Forms.Label();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SMS)).BeginInit();
            this.groupBoxInput_SMS.SuspendLayout();
            this.groupBoxOutput_SMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.labelFormula_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.pictureBoxFormula_SMS);
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(756, 126);
            this.groupBoxTask_SMS.TabIndex = 0;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // pictureBoxFormula_SMS
            // 
            this.pictureBoxFormula_SMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SMS.Image")));
            this.pictureBoxFormula_SMS.Location = new System.Drawing.Point(472, 49);
            this.pictureBoxFormula_SMS.Name = "pictureBoxFormula_SMS";
            this.pictureBoxFormula_SMS.Size = new System.Drawing.Size(242, 35);
            this.pictureBoxFormula_SMS.TabIndex = 0;
            this.pictureBoxFormula_SMS.TabStop = false;
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.Location = new System.Drawing.Point(648, 382);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(127, 39);
            this.buttonDone_SMS.TabIndex = 2;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = true;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(343, 92);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.TabStop = false;
            this.textBoxTask_SMS.Text = "Вычислить значение выражение при x = 3. Результат округлить до трех знаков после " +
    "запятой и вывести в TextBox";
            // 
            // groupBoxInput_SMS
            // 
            this.groupBoxInput_SMS.Controls.Add(this.labelVarX_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.textBoxVarX_SMS);
            this.groupBoxInput_SMS.Location = new System.Drawing.Point(64, 225);
            this.groupBoxInput_SMS.Name = "groupBoxInput_SMS";
            this.groupBoxInput_SMS.Size = new System.Drawing.Size(200, 134);
            this.groupBoxInput_SMS.TabIndex = 6;
            this.groupBoxInput_SMS.TabStop = false;
            this.groupBoxInput_SMS.Text = "Ввод данных";
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.labelResult_SMS);
            this.groupBoxOutput_SMS.Controls.Add(this.textBoxResult_SMS);
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(575, 225);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(200, 134);
            this.groupBoxOutput_SMS.TabIndex = 7;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод данных";
            // 
            // textBoxVarX_SMS
            // 
            this.textBoxVarX_SMS.Location = new System.Drawing.Point(6, 62);
            this.textBoxVarX_SMS.Name = "textBoxVarX_SMS";
            this.textBoxVarX_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_SMS.TabIndex = 1;
            this.textBoxVarX_SMS.TabStop = false;
            this.textBoxVarX_SMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SMS_KeyPress);
            // 
            // textBoxResult_SMS
            // 
            this.textBoxResult_SMS.Location = new System.Drawing.Point(6, 62);
            this.textBoxResult_SMS.Name = "textBoxResult_SMS";
            this.textBoxResult_SMS.ReadOnly = true;
            this.textBoxResult_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_SMS.TabIndex = 0;
            // 
            // labelVarX_SMS
            // 
            this.labelVarX_SMS.AutoSize = true;
            this.labelVarX_SMS.Location = new System.Drawing.Point(7, 43);
            this.labelVarX_SMS.Name = "labelVarX_SMS";
            this.labelVarX_SMS.Size = new System.Drawing.Size(17, 13);
            this.labelVarX_SMS.TabIndex = 1;
            this.labelVarX_SMS.Text = "X:";
            // 
            // labelResult_SMS
            // 
            this.labelResult_SMS.AutoSize = true;
            this.labelResult_SMS.Location = new System.Drawing.Point(7, 43);
            this.labelResult_SMS.Name = "labelResult_SMS";
            this.labelResult_SMS.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SMS.TabIndex = 1;
            this.labelResult_SMS.Text = "Результат:";
            // 
            // buttonAuthor_SMS
            // 
            this.buttonAuthor_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthor_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthor_SMS.Location = new System.Drawing.Point(575, 382);
            this.buttonAuthor_SMS.Name = "buttonAuthor_SMS";
            this.buttonAuthor_SMS.Size = new System.Drawing.Size(46, 39);
            this.buttonAuthor_SMS.TabIndex = 8;
            this.buttonAuthor_SMS.Text = "?";
            this.buttonAuthor_SMS.UseVisualStyleBackColor = true;
            this.buttonAuthor_SMS.Click += new System.EventHandler(this.buttonAuthor_SMS_Click);
            // 
            // labelFormula_SMS
            // 
            this.labelFormula_SMS.AutoSize = true;
            this.labelFormula_SMS.Location = new System.Drawing.Point(469, 30);
            this.labelFormula_SMS.Name = "labelFormula_SMS";
            this.labelFormula_SMS.Size = new System.Drawing.Size(55, 13);
            this.labelFormula_SMS.TabIndex = 2;
            this.labelFormula_SMS.Text = "Формула";
            // 
            // FormTask0_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.buttonAuthor_SMS);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.groupBoxInput_SMS);
            this.Controls.Add(this.buttonDone_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.Name = "FormTask0_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 15 | Шабанов М.С.";
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SMS)).EndInit();
            this.groupBoxInput_SMS.ResumeLayout(false);
            this.groupBoxInput_SMS.PerformLayout();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            this.groupBoxOutput_SMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SMS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBoxInput_SMS;
        private System.Windows.Forms.Label labelVarX_SMS;
        private System.Windows.Forms.TextBox textBoxVarX_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.Label labelResult_SMS;
        private System.Windows.Forms.TextBox textBoxResult_SMS;
        private System.Windows.Forms.Button buttonAuthor_SMS;
        private System.Windows.Forms.Label labelFormula_SMS;
    }
}

