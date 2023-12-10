using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabanovMS.Sprint6.Task6.V11.Lib;
using System.IO;
namespace Tyuiu.ShabanovMS.Sprint6.Task6.V11
{
    public partial class FormMain_SMS : Form
    {
        public FormMain_SMS()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_SMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SMS.ShowDialog();
            openFilePath = openFileDialogTask_SMS.FileName;
            textBoxInput_SMS.Text = File.ReadAllText(openFilePath);
            buttonDone_SMS.Enabled = true;
            groupBoxInput_SMS.Text = groupBoxInput_SMS.Text + " " + openFileDialogTask_SMS.FileName;
        }

        private void buttonDone_SMS_Click(object sender, EventArgs e)
        {
            //string path = @"C:\DataSprint6\InPutFileTask6V11.txt";
            textBoxResult_SMS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_SMS_Click(object sender, EventArgs e)
        {
            FormAbout_SMS formAbout = new FormAbout_SMS();
            formAbout.ShowDialog();
        }
    }
}
