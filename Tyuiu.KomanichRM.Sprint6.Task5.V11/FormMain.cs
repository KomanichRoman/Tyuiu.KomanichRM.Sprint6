using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint6.Task5.V11.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chartColumns.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartColumns.ChartAreas[0].AxisY.Title = "Ось Y";

            chartColumns.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartColumns.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Выполнил студент группы АСОиУб-23-3 Команич Роман Маркович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
