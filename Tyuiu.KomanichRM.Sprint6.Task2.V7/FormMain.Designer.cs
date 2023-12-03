
namespace Tyuiu.KomanichRM.Sprint6.Task2.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_KRM = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KRM = new System.Windows.Forms.TextBox();
            this.labelStop_KRM = new System.Windows.Forms.Label();
            this.labelStart_KRM = new System.Windows.Forms.Label();
            this.groupBoxOutput_KRM = new System.Windows.Forms.GroupBox();
            this.chartFunction_KRM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_KRM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFunction_KRM = new System.Windows.Forms.Label();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.groupBoxTask_KRM.SuspendLayout();
            this.groupBoxInput_KRM.SuspendLayout();
            this.groupBoxOutput_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(599, 373);
            this.groupBoxTask_KRM.TabIndex = 0;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // textBoxTask_KRM
            // 
            this.textBoxTask_KRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KRM.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_KRM.Multiline = true;
            this.textBoxTask_KRM.Name = "textBoxTask_KRM";
            this.textBoxTask_KRM.ReadOnly = true;
            this.textBoxTask_KRM.Size = new System.Drawing.Size(440, 44);
            this.textBoxTask_KRM.TabIndex = 0;
            this.textBoxTask_KRM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n";
            // 
            // groupBoxInput_KRM
            // 
            this.groupBoxInput_KRM.Controls.Add(this.textBoxStopStep_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.textBoxStartStep_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.labelStop_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.labelStart_KRM);
            this.groupBoxInput_KRM.Location = new System.Drawing.Point(18, 421);
            this.groupBoxInput_KRM.Name = "groupBoxInput_KRM";
            this.groupBoxInput_KRM.Size = new System.Drawing.Size(341, 109);
            this.groupBoxInput_KRM.TabIndex = 1;
            this.groupBoxInput_KRM.TabStop = false;
            this.groupBoxInput_KRM.Text = "Ввод данных";
            // 
            // textBoxStopStep_KRM
            // 
            this.textBoxStopStep_KRM.Location = new System.Drawing.Point(183, 60);
            this.textBoxStopStep_KRM.Name = "textBoxStopStep_KRM";
            this.textBoxStopStep_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxStopStep_KRM.TabIndex = 1;
            // 
            // textBoxStartStep_KRM
            // 
            this.textBoxStartStep_KRM.Location = new System.Drawing.Point(12, 60);
            this.textBoxStartStep_KRM.Name = "textBoxStartStep_KRM";
            this.textBoxStartStep_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_KRM.TabIndex = 1;
            // 
            // labelStop_KRM
            // 
            this.labelStop_KRM.AutoSize = true;
            this.labelStop_KRM.Location = new System.Drawing.Point(180, 40);
            this.labelStop_KRM.Name = "labelStop_KRM";
            this.labelStop_KRM.Size = new System.Drawing.Size(89, 17);
            this.labelStop_KRM.TabIndex = 0;
            this.labelStop_KRM.Text = "Конец шага:";
            // 
            // labelStart_KRM
            // 
            this.labelStart_KRM.AutoSize = true;
            this.labelStart_KRM.Location = new System.Drawing.Point(9, 40);
            this.labelStart_KRM.Name = "labelStart_KRM";
            this.labelStart_KRM.Size = new System.Drawing.Size(87, 17);
            this.labelStart_KRM.TabIndex = 0;
            this.labelStart_KRM.Text = "Старт шага:";
            // 
            // groupBoxOutput_KRM
            // 
            this.groupBoxOutput_KRM.Controls.Add(this.chartFunction_KRM);
            this.groupBoxOutput_KRM.Controls.Add(this.dataGridViewFunction_KRM);
            this.groupBoxOutput_KRM.Controls.Add(this.labelFunction_KRM);
            this.groupBoxOutput_KRM.Location = new System.Drawing.Point(644, 12);
            this.groupBoxOutput_KRM.Name = "groupBoxOutput_KRM";
            this.groupBoxOutput_KRM.Size = new System.Drawing.Size(625, 518);
            this.groupBoxOutput_KRM.TabIndex = 2;
            this.groupBoxOutput_KRM.TabStop = false;
            this.groupBoxOutput_KRM.Text = "Вывод данных";
            // 
            // chartFunction_KRM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KRM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KRM.Legends.Add(legend1);
            this.chartFunction_KRM.Location = new System.Drawing.Point(141, 72);
            this.chartFunction_KRM.Name = "chartFunction_KRM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KRM.Series.Add(series1);
            this.chartFunction_KRM.Size = new System.Drawing.Size(457, 419);
            this.chartFunction_KRM.TabIndex = 3;
            // 
            // dataGridViewFunction_KRM
            // 
            this.dataGridViewFunction_KRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewFunction_KRM.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewFunction_KRM.Name = "dataGridViewFunction_KRM";
            this.dataGridViewFunction_KRM.RowHeadersVisible = false;
            this.dataGridViewFunction_KRM.RowHeadersWidth = 51;
            this.dataGridViewFunction_KRM.RowTemplate.Height = 24;
            this.dataGridViewFunction_KRM.Size = new System.Drawing.Size(127, 430);
            this.dataGridViewFunction_KRM.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(Х)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // labelFunction_KRM
            // 
            this.labelFunction_KRM.AutoSize = true;
            this.labelFunction_KRM.Location = new System.Drawing.Point(7, 40);
            this.labelFunction_KRM.Name = "labelFunction_KRM";
            this.labelFunction_KRM.Size = new System.Drawing.Size(80, 17);
            this.labelFunction_KRM.TabIndex = 1;
            this.labelFunction_KRM.Text = "Результат:";
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KRM.Location = new System.Drawing.Point(383, 437);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(91, 77);
            this.buttonHelp_KRM.TabIndex = 3;
            this.buttonHelp_KRM.Text = "Справка";
            this.buttonHelp_KRM.UseVisualStyleBackColor = false;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_KRM_Click);
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_KRM.Location = new System.Drawing.Point(492, 437);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(136, 77);
            this.buttonDone_KRM.TabIndex = 3;
            this.buttonDone_KRM.Text = "Выполнить";
            this.buttonDone_KRM.UseVisualStyleBackColor = false;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone_KRM.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // FormMain_KRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 610);
            this.Controls.Add(this.buttonDone_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.groupBoxOutput_KRM);
            this.Controls.Add(this.groupBoxInput_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.Name = "FormMain_KRM";
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | Команич Р. М.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            this.groupBoxInput_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.PerformLayout();
            this.groupBoxOutput_KRM.ResumeLayout(false);
            this.groupBoxOutput_KRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
        private System.Windows.Forms.GroupBox groupBoxInput_KRM;
        private System.Windows.Forms.TextBox textBoxStopStep_KRM;
        private System.Windows.Forms.TextBox textBoxStartStep_KRM;
        private System.Windows.Forms.Label labelStop_KRM;
        private System.Windows.Forms.Label labelStart_KRM;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.Label labelFunction_KRM;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KRM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

