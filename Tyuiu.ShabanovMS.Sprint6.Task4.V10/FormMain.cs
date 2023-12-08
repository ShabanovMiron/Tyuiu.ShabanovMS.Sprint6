using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShabanovMS.Sprint6.Task4.V10.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task4.V10
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

                int len = stopValue - startValue + 1;
                double[] resArray;
                resArray = new double[len];

                resArray = ds.GetMassFunction(startValue, stopValue);

                chartFx_SMS.ChartAreas[0].AxisX.Title = "Ось X";
                chartFx_SMS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SMS.Text = "";

                chartFx_SMS.Series[0].Points.Clear();


                for (int i = 0; i <= len - 1; i++)
                {
                    chartFx_SMS.Series[0].Points.AddXY(startValue, resArray[i]);
                    textBoxResult_SMS.AppendText(resArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Введены неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-1 Шабанов Мирон Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SMS_Click(object sender, EventArgs e)
        {
            try
            {


                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SMS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
