using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task2.V2.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task2.V2
{
    public partial class FormMain_SMS : Form
    {
        public FormMain_SMS()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SMS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SMS.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SMS.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;


                double[] resArray;
                resArray = new double[len];
                resArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFx_SMS.Titles.Add("График функции F(x)");
                this.chartFx_SMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFx_SMS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SMS.Rows.Add(Convert.ToString(startValue), Convert.ToString(resArray[i]));

                    this.chartFx_SMS.Series[0].Points.AddXY(startValue, resArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
               
           


            
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1: Шабанов Мирон Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
