
namespace Tyuiu.KomanichRM.Sprint6.Task6.V19
{
    partial class FormMain_KRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KRM));
            this.panelTop_KRM = new System.Windows.Forms.Panel();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.buttonOpenFile_KRM = new System.Windows.Forms.Button();
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.panelLeft_KRM = new System.Windows.Forms.Panel();
            this.groupBoxInput_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxInput_KRM = new System.Windows.Forms.TextBox();
            this.panelRight_KRM = new System.Windows.Forms.Panel();
            this.groupBoxOutput_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_KRM = new System.Windows.Forms.TextBox();
            this.splitter_KRM = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_KRM = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KRM = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_KRM.SuspendLayout();
            this.groupBoxTask_KRM.SuspendLayout();
            this.panelLeft_KRM.SuspendLayout();
            this.groupBoxInput_KRM.SuspendLayout();
            this.panelRight_KRM.SuspendLayout();
            this.groupBoxOutput_KRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_KRM
            // 
            this.panelTop_KRM.Controls.Add(this.buttonHelp_KRM);
            this.panelTop_KRM.Controls.Add(this.buttonDone_KRM);
            this.panelTop_KRM.Controls.Add(this.buttonOpenFile_KRM);
            this.panelTop_KRM.Controls.Add(this.groupBoxTask_KRM);
            this.panelTop_KRM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KRM.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KRM.Name = "panelTop_KRM";
            this.panelTop_KRM.Size = new System.Drawing.Size(1258, 156);
            this.panelTop_KRM.TabIndex = 0;
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KRM.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KRM.Image")));
            this.buttonHelp_KRM.Location = new System.Drawing.Point(1045, 30);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(99, 90);
            this.buttonHelp_KRM.TabIndex = 1;
            this.buttonHelp_KRM.UseVisualStyleBackColor = false;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonDone_KRM.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KRM.Image")));
            this.buttonDone_KRM.Location = new System.Drawing.Point(874, 30);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(99, 90);
            this.buttonDone_KRM.TabIndex = 1;
            this.toolTip_KRM.SetToolTip(this.buttonDone_KRM, "Производит поиск в файле вхождений символов \"l\"\r\nи конкатенирует строки в которых" +
        " находяться \r\nэти символы\r\n");
            this.buttonDone_KRM.UseVisualStyleBackColor = false;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile_KRM
            // 
            this.buttonOpenFile_KRM.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonOpenFile_KRM.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KRM.Image")));
            this.buttonOpenFile_KRM.Location = new System.Drawing.Point(701, 30);
            this.buttonOpenFile_KRM.Name = "buttonOpenFile_KRM";
            this.buttonOpenFile_KRM.Size = new System.Drawing.Size(99, 90);
            this.buttonOpenFile_KRM.TabIndex = 1;
            this.toolTip_KRM.SetToolTip(this.buttonOpenFile_KRM, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_KRM.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KRM.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(616, 126);
            this.groupBoxTask_KRM.TabIndex = 0;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // textBoxTask_KRM
            // 
            this.textBoxTask_KRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KRM.Location = new System.Drawing.Point(6, 34);
            this.textBoxTask_KRM.Multiline = true;
            this.textBoxTask_KRM.Name = "textBoxTask_KRM";
            this.textBoxTask_KRM.ReadOnly = true;
            this.textBoxTask_KRM.Size = new System.Drawing.Size(603, 73);
            this.textBoxTask_KRM.TabIndex = 0;
            this.textBoxTask_KRM.Text = resources.GetString("textBoxTask_KRM.Text");
            // 
            // panelLeft_KRM
            // 
            this.panelLeft_KRM.Controls.Add(this.groupBoxInput_KRM);
            this.panelLeft_KRM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KRM.Location = new System.Drawing.Point(0, 156);
            this.panelLeft_KRM.Name = "panelLeft_KRM";
            this.panelLeft_KRM.Size = new System.Drawing.Size(629, 475);
            this.panelLeft_KRM.TabIndex = 0;
            // 
            // groupBoxInput_KRM
            // 
            this.groupBoxInput_KRM.Controls.Add(this.textBoxInput_KRM);
            this.groupBoxInput_KRM.Location = new System.Drawing.Point(13, 7);
            this.groupBoxInput_KRM.Name = "groupBoxInput_KRM";
            this.groupBoxInput_KRM.Size = new System.Drawing.Size(609, 456);
            this.groupBoxInput_KRM.TabIndex = 0;
            this.groupBoxInput_KRM.TabStop = false;
            this.groupBoxInput_KRM.Text = " Ввод:";
            // 
            // textBoxInput_KRM
            // 
            this.textBoxInput_KRM.Location = new System.Drawing.Point(6, 31);
            this.textBoxInput_KRM.Multiline = true;
            this.textBoxInput_KRM.Name = "textBoxInput_KRM";
            this.textBoxInput_KRM.Size = new System.Drawing.Size(597, 419);
            this.textBoxInput_KRM.TabIndex = 0;
            // 
            // panelRight_KRM
            // 
            this.panelRight_KRM.Controls.Add(this.groupBoxOutput_KRM);
            this.panelRight_KRM.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_KRM.Location = new System.Drawing.Point(635, 156);
            this.panelRight_KRM.Name = "panelRight_KRM";
            this.panelRight_KRM.Size = new System.Drawing.Size(623, 475);
            this.panelRight_KRM.TabIndex = 0;
            // 
            // groupBoxOutput_KRM
            // 
            this.groupBoxOutput_KRM.Controls.Add(this.textBoxOutput_KRM);
            this.groupBoxOutput_KRM.Location = new System.Drawing.Point(11, 7);
            this.groupBoxOutput_KRM.Name = "groupBoxOutput_KRM";
            this.groupBoxOutput_KRM.Size = new System.Drawing.Size(609, 456);
            this.groupBoxOutput_KRM.TabIndex = 0;
            this.groupBoxOutput_KRM.TabStop = false;
            this.groupBoxOutput_KRM.Text = "Вывод:";
            // 
            // textBoxOutput_KRM
            // 
            this.textBoxOutput_KRM.Location = new System.Drawing.Point(6, 31);
            this.textBoxOutput_KRM.Multiline = true;
            this.textBoxOutput_KRM.Name = "textBoxOutput_KRM";
            this.textBoxOutput_KRM.Size = new System.Drawing.Size(597, 419);
            this.textBoxOutput_KRM.TabIndex = 0;
            // 
            // splitter_KRM
            // 
            this.splitter_KRM.Location = new System.Drawing.Point(629, 156);
            this.splitter_KRM.Name = "splitter_KRM";
            this.splitter_KRM.Size = new System.Drawing.Size(3, 475);
            this.splitter_KRM.TabIndex = 1;
            this.splitter_KRM.TabStop = false;
            // 
            // openFileDialogTask_KRM
            // 
            this.openFileDialogTask_KRM.FileName = "openFileDialog1";
            // 
            // toolTip_KRM
            // 
            this.toolTip_KRM.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_KRM.ToolTipTitle = "Подсказка";
            // 
            // FormMain_KRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 631);
            this.Controls.Add(this.splitter_KRM);
            this.Controls.Add(this.panelRight_KRM);
            this.Controls.Add(this.panelLeft_KRM);
            this.Controls.Add(this.panelTop_KRM);
            this.Name = "FormMain_KRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Такс 6 | Вариант 19 | Команич Р.М.";
            this.Load += new System.EventHandler(this.FormMain_KRM_Load);
            this.panelTop_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            this.panelLeft_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.PerformLayout();
            this.panelRight_KRM.ResumeLayout(false);
            this.groupBoxOutput_KRM.ResumeLayout(false);
            this.groupBoxOutput_KRM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.Button buttonOpenFile_KRM;
        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
        private System.Windows.Forms.Panel panelLeft_KRM;
        private System.Windows.Forms.GroupBox groupBoxInput_KRM;
        private System.Windows.Forms.TextBox textBoxInput_KRM;
        private System.Windows.Forms.Panel panelRight_KRM;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRM;
        private System.Windows.Forms.TextBox textBoxOutput_KRM;
        private System.Windows.Forms.Splitter splitter_KRM;
        private System.Windows.Forms.ToolTip toolTip_KRM;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KRM;
    }
}

