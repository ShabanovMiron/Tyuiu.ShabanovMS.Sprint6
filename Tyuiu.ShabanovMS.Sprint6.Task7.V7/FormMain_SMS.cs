using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task7.V7.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint6.Task7.V7
{
    public partial class FormMain_SMS : Form
    {
        public FormMain_SMS()
        {
            InitializeComponent();

            openFileDialogTask_SMS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SMS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openPathFile;

        DataService ds = new DataService();

        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }



            private void buttonOpenFile_SMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMS.ShowDialog();
            openPathFile = openFileDialogTask_SMS.FileName;


            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openPathFile);


            dataGridViewIntput_SMS.ColumnCount = columns;
            dataGridViewIntput_SMS.RowCount = rows;
            dataGridViewOutput_SMS.ColumnCount = columns;
            dataGridViewOutput_SMS.RowCount = rows;


            for(int i = 0; i < columns; i++)
            {
                dataGridViewOutput_SMS.Columns[i].Width = 25;
                dataGridViewIntput_SMS.Columns[i].Width = 25;
            }


            for(int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIntput_SMS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openPathFile);
            buttonDone_SMS.Enabled = true;
        }

        private void buttonDone_SMS_Click(object sender, EventArgs e)
        {
            int[,] valueArray = new int[rows, columns];
            valueArray = ds.GetMatrix(openPathFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_SMS.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }

            buttonSave_SMS.Enabled = true;
        }

        private void buttonSave_SMS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SMS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SMS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SMS.ShowDialog();

            string path = saveFileDialogMatrix_SMS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_SMS.RowCount;
            int columns = dataGridViewOutput_SMS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_SMS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_SMS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            FormAbout_SMS formAbout = new FormAbout_SMS();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SMS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SMS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SMS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SMS.ToolTipTitle = "Сохранить в файл";
        }
    }
}
