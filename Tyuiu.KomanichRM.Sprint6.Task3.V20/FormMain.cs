﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint6.Task3.V20.Lib;

namespace Tyuiu.KomanichRM.Sprint6.Task3.V20
{
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx =  { { -14, 17, -19, 3, 2 },
                             { -4, -14, -19, -9, -1 },
                             { 1, 0, 13, 14, 8 },
                             { 13, 7, 8, -3, -15 },
                             { 2, -20, 12, -14, 4 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;
            dataGridViewMatrix_KRM.ColumnCount = colums;
            dataGridViewMatrix_KRM.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix_KRM.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix_KRM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGridMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrixResult_KRM.ColumnCount = columns;
            dataGridViewMatrixResult_KRM.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_KRM.Columns[i].Width = 50;
                    dataGridViewMatrixResult_KRM.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void dataGridMatrixResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент группы АСОиУб-23-3 Команич Роман Маркович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
