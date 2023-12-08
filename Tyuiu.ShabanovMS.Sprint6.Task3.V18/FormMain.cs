using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task3.V18.Lib;
namespace Tyuiu.ShabanovMS.Sprint6.Task3.V18
{
    public partial class FormMain_SMS : Form
    {
        public FormMain_SMS()
        {
            InitializeComponent();
        }

        int[,] matrix = new int[5, 5] {{ -19, -19, 1, 18, 7},
                                { 5, 3, -4, -6, -12},
                                { -15, 6, 2, 2, -14},
                                { -9, -10, 15, -5, -6},
                                { -13, -15, -9, 7, 1} };

        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] resMatrix = ds.Calculate(matrix);
            int rows = resMatrix.GetUpperBound(0) + 1;
            int columns = resMatrix.Length / rows;

            dataGridViewResult_SMS.RowCount = rows;
            dataGridViewResult_SMS.ColumnCount = columns;


            for (int i = 0; i < rows; i++)
            {
                dataGridViewResult_SMS.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SMS.Rows[i].Cells[j].Value = Convert.ToString(resMatrix[i, j]);
                }
            }

        }

        private void FormMain_SMS_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewInput_SMS.RowCount = rows;
            dataGridViewInput_SMS.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewInput_SMS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    dataGridViewInput_SMS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1: Шабанов Мирон Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
