
namespace Tyuiu.ShabanovMS.Sprint6.Task5.V25
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SMS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SMS = new System.Windows.Forms.TextBox();
            this.buttonDone_SMS = new System.Windows.Forms.Button();
            this.buttonOpen_SMS = new System.Windows.Forms.Button();
            this.buttonHelp_SMS = new System.Windows.Forms.Button();
            this.groupBoxOutput_SMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SMS = new System.Windows.Forms.DataGridView();
            this.chartResult_SMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxButtons_SMS = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SMS.SuspendLayout();
            this.groupBoxOutput_SMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SMS)).BeginInit();
            this.groupBoxButtons_SMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SMS
            // 
            this.groupBoxTask_SMS.Controls.Add(this.textBoxTask_SMS);
            this.groupBoxTask_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_SMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SMS.Name = "groupBoxTask_SMS";
            this.groupBoxTask_SMS.Size = new System.Drawing.Size(837, 589);
            this.groupBoxTask_SMS.TabIndex = 0;
            this.groupBoxTask_SMS.TabStop = false;
            this.groupBoxTask_SMS.Text = "Условие";
            // 
            // textBoxTask_SMS
            // 
            this.textBoxTask_SMS.Location = new System.Drawing.Point(0, 19);
            this.textBoxTask_SMS.Multiline = true;
            this.textBoxTask_SMS.Name = "textBoxTask_SMS";
            this.textBoxTask_SMS.ReadOnly = true;
            this.textBoxTask_SMS.Size = new System.Drawing.Size(541, 86);
            this.textBoxTask_SMS.TabIndex = 0;
            this.textBoxTask_SMS.TabStop = false;
            this.textBoxTask_SMS.Text = resources.GetString("textBoxTask_SMS.Text");
            // 
            // buttonDone_SMS
            // 
            this.buttonDone_SMS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDone_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_SMS.Location = new System.Drawing.Point(203, 34);
            this.buttonDone_SMS.Name = "buttonDone_SMS";
            this.buttonDone_SMS.Size = new System.Drawing.Size(75, 38);
            this.buttonDone_SMS.TabIndex = 0;
            this.buttonDone_SMS.Text = "Выполнить";
            this.buttonDone_SMS.UseVisualStyleBackColor = false;
            this.buttonDone_SMS.Click += new System.EventHandler(this.buttonDone_SMS_Click);
            // 
            // buttonOpen_SMS
            // 
            this.buttonOpen_SMS.BackColor = System.Drawing.Color.IndianRed;
            this.buttonOpen_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_SMS.Location = new System.Drawing.Point(107, 34);
            this.buttonOpen_SMS.Name = "buttonOpen_SMS";
            this.buttonOpen_SMS.Size = new System.Drawing.Size(76, 38);
            this.buttonOpen_SMS.TabIndex = 1;
            this.buttonOpen_SMS.TabStop = false;
            this.buttonOpen_SMS.Text = "Открыть файл";
            this.buttonOpen_SMS.UseVisualStyleBackColor = false;
            this.buttonOpen_SMS.Click += new System.EventHandler(this.buttonOpen_SMS_Click);
            // 
            // buttonHelp_SMS
            // 
            this.buttonHelp_SMS.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonHelp_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SMS.Location = new System.Drawing.Point(15, 34);
            this.buttonHelp_SMS.Name = "buttonHelp_SMS";
            this.buttonHelp_SMS.Size = new System.Drawing.Size(75, 38);
            this.buttonHelp_SMS.TabIndex = 1;
            this.buttonHelp_SMS.TabStop = false;
            this.buttonHelp_SMS.Text = "Справка";
            this.buttonHelp_SMS.UseVisualStyleBackColor = false;
            this.buttonHelp_SMS.Click += new System.EventHandler(this.buttonHelp_SMS_Click);
            // 
            // groupBoxOutput_SMS
            // 
            this.groupBoxOutput_SMS.Controls.Add(this.chartResult_SMS);
            this.groupBoxOutput_SMS.Controls.Add(this.dataGridViewResult_SMS);
            this.groupBoxOutput_SMS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOutput_SMS.Location = new System.Drawing.Point(0, 111);
            this.groupBoxOutput_SMS.Name = "groupBoxOutput_SMS";
            this.groupBoxOutput_SMS.Size = new System.Drawing.Size(837, 478);
            this.groupBoxOutput_SMS.TabIndex = 1;
            this.groupBoxOutput_SMS.TabStop = false;
            this.groupBoxOutput_SMS.Text = "Вывод данных";
            // 
            // dataGridViewResult_SMS
            // 
            this.dataGridViewResult_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SMS.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewResult_SMS.Name = "dataGridViewResult_SMS";
            this.dataGridViewResult_SMS.Size = new System.Drawing.Size(179, 460);
            this.dataGridViewResult_SMS.TabIndex = 0;
            // 
            // chartResult_SMS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_SMS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResult_SMS.Legends.Add(legend1);
            this.chartResult_SMS.Location = new System.Drawing.Point(209, 19);
            this.chartResult_SMS.Name = "chartResult_SMS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_SMS.Series.Add(series1);
            this.chartResult_SMS.Size = new System.Drawing.Size(590, 460);
            this.chartResult_SMS.TabIndex = 1;
            this.chartResult_SMS.Text = "chart1";
            // 
            // groupBoxButtons_SMS
            // 
            this.groupBoxButtons_SMS.Controls.Add(this.buttonDone_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonOpen_SMS);
            this.groupBoxButtons_SMS.Controls.Add(this.buttonHelp_SMS);
            this.groupBoxButtons_SMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxButtons_SMS.Location = new System.Drawing.Point(547, 0);
            this.groupBoxButtons_SMS.Name = "groupBoxButtons_SMS";
            this.groupBoxButtons_SMS.Size = new System.Drawing.Size(290, 111);
            this.groupBoxButtons_SMS.TabIndex = 2;
            this.groupBoxButtons_SMS.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 589);
            this.Controls.Add(this.groupBoxButtons_SMS);
            this.Controls.Add(this.groupBoxOutput_SMS);
            this.Controls.Add(this.groupBoxTask_SMS);
            this.MinimumSize = new System.Drawing.Size(832, 628);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Шабанов М.С.";
            this.groupBoxTask_SMS.ResumeLayout(false);
            this.groupBoxTask_SMS.PerformLayout();
            this.groupBoxOutput_SMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SMS)).EndInit();
            this.groupBoxButtons_SMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SMS;
        private System.Windows.Forms.Button buttonHelp_SMS;
        private System.Windows.Forms.Button buttonOpen_SMS;
        private System.Windows.Forms.Button buttonDone_SMS;
        private System.Windows.Forms.TextBox textBoxTask_SMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_SMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SMS;
        private System.Windows.Forms.DataGridView dataGridViewResult_SMS;
        private System.Windows.Forms.GroupBox groupBoxButtons_SMS;
    }
}

