using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task0.V15.Lib;

namespace Tyuiu.ShabanovMS.Sprint6.Task0.V15
{
    public partial class FormTask0_SMS : Form
    {
        public FormTask0_SMS()
        {
            InitializeComponent();
        }

        private void buttonDone_SMS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SMS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SMS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAuthor_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-1 Шабанов Мирон Сергеевич", "Сообщение");
        }

        private void textBoxVarX_SMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

            
        }
    }
}
