using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint6.Task2.V7.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task2.V7
{
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KRM.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KRM.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KRM.Titles.Add("График функции (sin(x)/x+1,2) - sin(x) * 2 - 2x");

                this.chartFunction_KRM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KRM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KRM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KRM.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KRM.BackColor = Color.Blue;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KRM.BackColor = Color.DarkGreen;
        }

        private void buttonDone_RKM_Click(object sender, EventArgs e)
        {

        }
    }
}
