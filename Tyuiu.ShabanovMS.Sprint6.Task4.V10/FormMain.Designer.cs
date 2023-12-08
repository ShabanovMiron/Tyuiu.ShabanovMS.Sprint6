
namespace Tyuiu.ShabanovMS.Sprint6.Task4.V10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SMS));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.labelForm_SMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxForm_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SMS = new System.Windows.Forms.GroupBox();
            this.labelStop_SMS = new System.Windows.Forms.Label();
            this.labelStart_SMS = new System.Windows.Forms.Label();
            this.textBoxStop_SMS = new System.Windows.Forms.TextBox();
            this.textBoxStart_SMS = new System.Windows.Forms.TextBox();
            this.buttonSave_SMS = new System.Windows.Forms.Button();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.groupBoxResult_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SMS = new System.Windows.Forms.TextBox();
            this.chartFx_SMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput_SMS.SuspendLayout();
            this.groupBoxResult_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.labelForm_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.pictureBox1);
            this.groupBoxTask_SMS.Controls.Add(this.textBoxForm_SMS);
            this.groupBoxTask_SMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(726, 544);
            this.groupBoxTask_SMS.TabIndex = 0;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // labelForm_SMS
            // 
            this.labelForm_SMS.AutoSize = true;
            this.labelForm_SMS.Location = new System.Drawing.Point(431, 16);
            this.labelForm_SMS.Name = "labelForm_SMS";
            this.labelForm_SMS.Size = new System.Drawing.Size(56, 13);
            this.labelForm_SMS.TabIndex = 2;
            this.labelForm_SMS.Text = "Функция:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxForm_SMS
            // 
            this.textBoxForm_SMS.Location = new System.Drawing.Point(7, 16);
            this.textBoxForm_SMS.Multiline = true;
            this.textBoxForm_SMS.Name = "textBoxForm_SMS";
            this.textBoxForm_SMS.ReadOnly = true;
            this.textBoxForm_SMS.Size = new System.Drawing.Size(418, 61);
            this.textBoxForm_SMS.TabIndex = 0;
            this.textBoxForm_SMS.TabStop = false;
            this.textBoxForm_SMS.Text = resources.GetString("textBoxForm_SMS.Text");
            // 
            // groupBoxInput_SMS
            // 
            this.groupBoxInput_SMS.Controls.Add(this.labelStop_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.labelStart_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.buttonHelp_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.buttonDone_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.buttonSave_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.textBoxStop_SMS);
            this.groupBoxInput_SMS.Controls.Add(this.textBoxStart_SMS);
            this.groupBoxInput_SMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInput_SMS.Location = new System.Drawing.Point(754, 0);
            this.groupBoxInput_SMS.Name = "groupBoxInput_SMS";
            this.groupBoxInput_SMS.Size = new System.Drawing.Size(280, 544);
            this.groupBoxInput_SMS.TabIndex = 1;
            this.groupBoxInput_SMS.TabStop = false;
            this.groupBoxInput_SMS.Text = "Ввод данных";
            // 
            // labelStop_SMS
            // 
            this.labelStop_SMS.AutoSize = true;
            this.labelStop_SMS.Location = new System.Drawing.Point(155, 16);
            this.labelStop_SMS.Name = "labelStop_SMS";
            this.labelStop_SMS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SMS.TabIndex = 2;
            this.labelStop_SMS.Text = "Конец шага:";
            // 
            // labelStart_SMS
            // 
            this.labelStart_SMS.AutoSize = true;
            this.labelStart_SMS.Location = new System.Drawing.Point(6, 16);
            this.labelStart_SMS.Name = "labelStart_SMS";
            this.labelStart_SMS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SMS.TabIndex = 2;
            this.labelStart_SMS.Text = "Старт шага:";
            // 
            // textBoxStop_SMS
            // 
            this.textBoxStop_SMS.Location = new System.Drawing.Point(158, 32);
            this.textBoxStop_SMS.Name = "textBoxStop_SMS";
            this.textBoxStop_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SMS.TabIndex = 1;
            this.textBoxStop_SMS.Text = "5";
            // 
            // textBoxStart_SMS
            // 
            this.textBoxStart_SMS.Location = new System.Drawing.Point(6, 32);
            this.textBoxStart_SMS.Name = "textBoxStart_SMS";
            this.textBoxStart_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SMS.TabIndex = 0;
            this.textBoxStart_SMS.Text = "-5";
            // 
            // buttonSave_SMS
            // 
            this.buttonSave_SMS.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave_SMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SMS.Location = new System.Drawing.Point(100, 73);
            this.buttonSave_SMS.Name = "buttonSave_SMS";
            this.buttonSave_SMS.Size = new System.Drawing.Size(75, 23);
            this.buttonSave_SMS.TabIndex = 3;
            this.buttonSave_SMS.Text = "Сохранить";
            this.buttonSave_SMS.UseVisualStyleBackColor = false;
            this.buttonSave_SMS.Click += new System.EventHandler(this.buttonSave_SMS_Click);
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.Color.Pink;
            this.buttonHelp_SMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SMS.Location = new System.Drawing.Point(193, 73);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_SMS.TabIndex = 4;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDone_SMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SMS.Location = new System.Drawing.Point(6, 73);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_SMS.TabIndex = 5;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // groupBoxResult_SMS
            // 
            this.groupBoxResult_SMS.Controls.Add(this.textBoxResult_SMS);
            this.groupBoxResult_SMS.Location = new System.Drawing.Point(13, 96);
            this.groupBoxResult_SMS.Name = "groupBoxResult_SMS";
            this.groupBoxResult_SMS.Size = new System.Drawing.Size(189, 436);
            this.groupBoxResult_SMS.TabIndex = 6;
            this.groupBoxResult_SMS.TabStop = false;
            this.groupBoxResult_SMS.Text = "Результат";
            // 
            // textBoxResult_SMS
            // 
            this.textBoxResult_SMS.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_SMS.Multiline = true;
            this.textBoxResult_SMS.Name = "textBoxResult_SMS";
            this.textBoxResult_SMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SMS.Size = new System.Drawing.Size(176, 410);
            this.textBoxResult_SMS.TabIndex = 0;
            // 
            // chartFx_SMS
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFx_SMS.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFx_SMS.Legends.Add(legend4);
            this.chartFx_SMS.Location = new System.Drawing.Point(211, 116);
            this.chartFx_SMS.Name = "chartFx_SMS";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFx_SMS.Series.Add(series4);
            this.chartFx_SMS.Size = new System.Drawing.Size(814, 416);
            this.chartFx_SMS.TabIndex = 7;
            this.chartFx_SMS.Text = "chart1";
            title4.BackColor = System.Drawing.Color.White;
            title4.BorderColor = System.Drawing.Color.Transparent;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title1";
            title4.Text = "График функции F(x)";
            this.chartFx_SMS.Titles.Add(title4);
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 544);
            this.Controls.Add(this.chartFx_SMS);
            this.Controls.Add(this.groupBoxResult_SMS);
            this.Controls.Add(this.groupBoxInput_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.MinimumSize = new System.Drawing.Size(1050, 583);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 10 | Шабанов М.С.";
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput_SMS.ResumeLayout(false);
            this.groupBoxInput_SMS.PerformLayout();
            this.groupBoxResult_SMS.ResumeLayout(false);
            this.groupBoxResult_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.Label labelForm_SMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxForm_SMS;
        private System.Windows.Forms.GroupBox groupBoxInput_SMS;
        private System.Windows.Forms.Label labelStop_SMS;
        private System.Windows.Forms.Label labelStart_SMS;
        private System.Windows.Forms.TextBox textBoxStop_SMS;
        private System.Windows.Forms.TextBox textBoxStart_SMS;
        private System.Windows.Forms.Button buttonSave_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.GroupBox groupBoxResult_SMS;
        private System.Windows.Forms.TextBox textBoxResult_SMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx_SMS;
    }
}

