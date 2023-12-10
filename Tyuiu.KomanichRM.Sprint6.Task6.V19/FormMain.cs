using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint6.Task6.V19.Lib;
using System.IO;

namespace Tyuiu.KomanichRM.Sprint6.Task6.V19
{
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRM.ShowDialog();
            openFilePath = openFileDialogTask_KRM.FileName;
            textBoxInput_KRM.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_KRM.Text = groupBoxOutput_KRM.Text + " " + openFileDialogTask_KRM.FileName;
            buttonDone_KRM.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_KRM.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout_KRM formAbout = new FormAbout_KRM();
            formAbout.ShowDialog();
        }
    }
}
