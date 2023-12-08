using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task1.V4.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task1.V4
{
    public partial class FormTask1 : Form
    {
        public FormTask1()
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

                double[] resultArray;
                resultArray = new double[len];
                resultArray = ds.GetMassFunction(startValue, stopValue);

                string strLine;

                textBoxResult_SMS.Text = "";
                textBoxResult_SMS.AppendText  ("+----------+----------+" + Environment.NewLine);
                textBoxResult_SMS.AppendText  ("|    X     |---F(x)---|" + Environment.NewLine);
                textBoxResult_SMS.AppendText  ("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}  | ", startValue, resultArray[i]);
                    textBoxResult_SMS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SMS.AppendText  ("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonInfo_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Шабанов Мирон Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
