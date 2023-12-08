using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task5.V25.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task5.V25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V25.txt";

        private void buttonDone_SMS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SMS.ColumnCount = 2;
            dataGridViewResult_SMS.Columns[0].Width = 20;
            dataGridViewResult_SMS.Columns[0].Width = 50;

            chartResult_SMS.ChartAreas[0].AxisX.Title = "Ось X";
            chartResult_SMS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_SMS.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];

            numArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numArray.Length; i++)
            {
                dataGridViewResult_SMS.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                chartResult_SMS.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void buttonOpen_SMS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1: Шабанов Мирон Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
