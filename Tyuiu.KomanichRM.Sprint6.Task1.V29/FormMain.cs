using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint6.Task1.V29.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task1.V29
{
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
        {
            InitializeComponent();
        }
        private void textBoxCondition1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int startStep = Convert.ToInt32(textBoxInputA_KRM.Text);
                int stopStep = Convert.ToInt32(textBoxInputB_KRM.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KRM.Text = "";
                textBoxResult_KRM.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_KRM.AppendText("|    X       |   f(x)     |" + Environment.NewLine);
                textBoxResult_KRM.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}       |   {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_KRM.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KRM.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Выполнил студент группы АСОиУб-23-3 Команич Роман Маркович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
