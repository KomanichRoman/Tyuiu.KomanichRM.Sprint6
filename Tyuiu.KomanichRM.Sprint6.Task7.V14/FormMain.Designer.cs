
namespace Tyuiu.KomanichRM.Sprint6.Task7.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTopTop = new System.Windows.Forms.Panel();
            this.panelTopDown = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxOunput = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutMatrix = new System.Windows.Forms.DataGridView();
            this.panelTopTop.SuspendLayout();
            this.panelTopDown.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOunput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 626);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelTopTop
            // 
            this.panelTopTop.Controls.Add(this.buttonHelp);
            this.panelTopTop.Controls.Add(this.buttonSaveFile);
            this.panelTopTop.Controls.Add(this.buttonDone);
            this.panelTopTop.Controls.Add(this.buttonOpenFile);
            this.panelTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTop.Location = new System.Drawing.Point(3, 0);
            this.panelTopTop.Name = "panelTopTop";
            this.panelTopTop.Size = new System.Drawing.Size(1255, 101);
            this.panelTopTop.TabIndex = 2;
            // 
            // panelTopDown
            // 
            this.panelTopDown.Controls.Add(this.groupBoxTask);
            this.panelTopDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDown.Location = new System.Drawing.Point(3, 101);
            this.panelTopDown.Name = "panelTopDown";
            this.panelTopDown.Size = new System.Drawing.Size(1255, 100);
            this.panelTopDown.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxInput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 201);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(623, 425);
            this.panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxOunput);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(632, 201);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(626, 425);
            this.panelRight.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(626, 201);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 425);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(7, 7);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(1236, 87);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(1223, 59);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(40, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(106, 83);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonOpenFile, "Открыть необходимый файл");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(168, 13);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(106, 82);
            this.buttonDone.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonDone, "Выполнить операцию по заданию");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.Location = new System.Drawing.Point(296, 12);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(106, 83);
            this.buttonSaveFile.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonSaveFile, "Сохранить готовый файл");
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.Location = new System.Drawing.Point(1137, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(106, 83);
            this.buttonHelp.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonHelp, "Справка");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewInMatrix);
            this.groupBoxInput.Location = new System.Drawing.Point(7, 7);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(610, 344);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод:";
            // 
            // groupBoxOunput
            // 
            this.groupBoxOunput.Controls.Add(this.dataGridViewOutMatrix);
            this.groupBoxOunput.Location = new System.Drawing.Point(3, 7);
            this.groupBoxOunput.Name = "groupBoxOunput";
            this.groupBoxOunput.Size = new System.Drawing.Size(623, 344);
            this.groupBoxOunput.TabIndex = 0;
            this.groupBoxOunput.TabStop = false;
            this.groupBoxOunput.Text = "Вывод:";
            // 
            // dataGridViewInMatrix
            // 
            this.dataGridViewInMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewInMatrix.Name = "dataGridViewInMatrix";
            this.dataGridViewInMatrix.RowHeadersWidth = 51;
            this.dataGridViewInMatrix.RowTemplate.Height = 24;
            this.dataGridViewInMatrix.Size = new System.Drawing.Size(597, 316);
            this.dataGridViewInMatrix.TabIndex = 0;
            this.dataGridViewInMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInMatrix_CellContentClick);
            // 
            // dataGridViewOutMatrix
            // 
            this.dataGridViewOutMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewOutMatrix.Name = "dataGridViewOutMatrix";
            this.dataGridViewOutMatrix.RowHeadersWidth = 51;
            this.dataGridViewOutMatrix.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix.Size = new System.Drawing.Size(597, 316);
            this.dataGridViewOutMatrix.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 626);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopDown);
            this.Controls.Add(this.panelTopTop);
            this.Controls.Add(this.splitter1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск7 | Вариант 14 | Команич Р. М.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTopTop.ResumeLayout(false);
            this.panelTopDown.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxOunput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelTopTop;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panelTopDown;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix;
        private System.Windows.Forms.GroupBox groupBoxOunput;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix;
    }
}

