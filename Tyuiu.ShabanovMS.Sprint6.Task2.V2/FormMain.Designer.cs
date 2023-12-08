
namespace Tyuiu.ShabanovMS.Sprint6.Task2.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.labelForm_SMS = new System.Windows.Forms.Label();
            this.pictureBoxForm_SMS = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.groupBoxInpun_SMS = new System.Windows.Forms.GroupBox();
            this.labelStop_SMS = new System.Windows.Forms.Label();
            this.labelStart_SMS = new System.Windows.Forms.Label();
            this.textBoxStop_SMS = new System.Windows.Forms.TextBox();
            this.textBoxStart_SMS = new System.Windows.Forms.TextBox();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_SMS = new System.Windows.Forms.DataGridView();
            this.ColumnX_SMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx_SMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFx_SMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SMS)).BeginInit();
            this.groupBoxInpun_SMS.SuspendLayout();
            this.groupBoxOutput_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx_SMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.labelForm_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.pictureBoxForm_SMS);
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(592, 249);
            this.groupBoxTask_SMS.TabIndex = 0;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // labelForm_SMS
            // 
            this.labelForm_SMS.AutoSize = true;
            this.labelForm_SMS.Location = new System.Drawing.Point(7, 180);
            this.labelForm_SMS.Name = "labelForm_SMS";
            this.labelForm_SMS.Size = new System.Drawing.Size(58, 13);
            this.labelForm_SMS.TabIndex = 2;
            this.labelForm_SMS.Text = "Формула:";
            // 
            // pictureBoxForm_SMS
            // 
            this.pictureBoxForm_SMS.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxForm_SMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm_SMS.Image")));
            this.pictureBoxForm_SMS.Location = new System.Drawing.Point(6, 199);
            this.pictureBoxForm_SMS.Name = "pictureBoxForm_SMS";
            this.pictureBoxForm_SMS.Size = new System.Drawing.Size(367, 44);
            this.pictureBoxForm_SMS.TabIndex = 1;
            this.pictureBoxForm_SMS.TabStop = false;
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(581, 65);
            this.textBoxTask_SMS.TabIndex = 1;
            this.textBoxTask_SMS.TabStop = false;
            this.textBoxTask_SMS.Text = "Произвести табулирование фунции F(x) на заданном диапазоне [-5;5] с шагом 1. При " +
    "делении на ноль вернуть значение 0 и занести значения в DataGridView. Значения о" +
    "круглить до двух знаков после запятой.";
            // 
            // groupBoxInpun_SMS
            // 
            this.groupBoxInpun_SMS.Controls.Add(this.labelStop_SMS);
            this.groupBoxInpun_SMS.Controls.Add(this.labelStart_SMS);
            this.groupBoxInpun_SMS.Controls.Add(this.textBoxStop_SMS);
            this.groupBoxInpun_SMS.Controls.Add(this.textBoxStart_SMS);
            this.groupBoxInpun_SMS.Location = new System.Drawing.Point(23, 315);
            this.groupBoxInpun_SMS.Name = "groupBoxInpun_SMS";
            this.groupBoxInpun_SMS.Size = new System.Drawing.Size(326, 122);
            this.groupBoxInpun_SMS.TabIndex = 1;
            this.groupBoxInpun_SMS.TabStop = false;
            this.groupBoxInpun_SMS.Text = "Ввод данных";
            // 
            // labelStop_SMS
            // 
            this.labelStop_SMS.AutoSize = true;
            this.labelStop_SMS.Location = new System.Drawing.Point(195, 80);
            this.labelStop_SMS.Name = "labelStop_SMS";
            this.labelStop_SMS.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SMS.TabIndex = 1;
            this.labelStop_SMS.Text = "Конец шага:";
            // 
            // labelStart_SMS
            // 
            this.labelStart_SMS.AutoSize = true;
            this.labelStart_SMS.Location = new System.Drawing.Point(19, 80);
            this.labelStart_SMS.Name = "labelStart_SMS";
            this.labelStart_SMS.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SMS.TabIndex = 1;
            this.labelStart_SMS.Text = "Старт шага:";
            // 
            // textBoxStop_SMS
            // 
            this.textBoxStop_SMS.Location = new System.Drawing.Point(198, 96);
            this.textBoxStop_SMS.Name = "textBoxStop_SMS";
            this.textBoxStop_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SMS.TabIndex = 0;
            this.textBoxStop_SMS.TabStop = false;
            this.textBoxStop_SMS.Text = "5";
            // 
            // textBoxStart_SMS
            // 
            this.textBoxStart_SMS.Location = new System.Drawing.Point(22, 96);
            this.textBoxStart_SMS.Name = "textBoxStart_SMS";
            this.textBoxStart_SMS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SMS.TabIndex = 1;
            this.textBoxStart_SMS.Text = "-5";
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SMS.Location = new System.Drawing.Point(355, 352);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(119, 56);
            this.buttonHelp_SMS.TabIndex = 2;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonDone_SMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SMS.Location = new System.Drawing.Point(480, 352);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(120, 56);
            this.buttonDone_SMS.TabIndex = 3;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.chartFx_SMS);
            this.groupBoxOutput_SMS.Controls.Add(this.dataGridViewFunction_SMS);
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(611, 13);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(636, 424);
            this.groupBoxOutput_SMS.TabIndex = 4;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод данных";
            // 
            // dataGridViewFunction_SMS
            // 
            this.dataGridViewFunction_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_SMS,
            this.ColumnFx_SMS});
            this.dataGridViewFunction_SMS.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewFunction_SMS.Name = "dataGridViewFunction_SMS";
            this.dataGridViewFunction_SMS.RowHeadersVisible = false;
            this.dataGridViewFunction_SMS.Size = new System.Drawing.Size(203, 398);
            this.dataGridViewFunction_SMS.TabIndex = 0;
            // 
            // ColumnX_SMS
            // 
            this.ColumnX_SMS.HeaderText = "X";
            this.ColumnX_SMS.Name = "ColumnX_SMS";
            this.ColumnX_SMS.ReadOnly = true;
            // 
            // ColumnFx_SMS
            // 
            this.ColumnFx_SMS.HeaderText = "F(x)";
            this.ColumnFx_SMS.Name = "ColumnFx_SMS";
            this.ColumnFx_SMS.ReadOnly = true;
            // 
            // chartFx_SMS
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFx_SMS.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFx_SMS.Legends.Add(legend5);
            this.chartFx_SMS.Location = new System.Drawing.Point(215, 82);
            this.chartFx_SMS.Name = "chartFx_SMS";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFx_SMS.Series.Add(series5);
            this.chartFx_SMS.Size = new System.Drawing.Size(415, 300);
            this.chartFx_SMS.TabIndex = 1;
            this.chartFx_SMS.Text = "chartF(x)";
            // 
            // FormMain_SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 450);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.buttonDone_SMS);
            this.Controls.Add(this.buttonHelp_SMS);
            this.Controls.Add(this.groupBoxInpun_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.Name = "FormMain_SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 2 | Шабанов М.С.";
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SMS)).EndInit();
            this.groupBoxInpun_SMS.ResumeLayout(false);
            this.groupBoxInpun_SMS.PerformLayout();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx_SMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.Label labelForm_SMS;
        private System.Windows.Forms.PictureBox pictureBoxForm_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.GroupBox groupBoxInpun_SMS;
        private System.Windows.Forms.Label labelStart_SMS;
        private System.Windows.Forms.TextBox textBoxStop_SMS;
        private System.Windows.Forms.TextBox textBoxStart_SMS;
        private System.Windows.Forms.Label labelStop_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx_SMS;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_SMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_SMS;
    }
}

