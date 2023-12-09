
namespace Tyuiu.KomanichRM.Sprint6.Task4.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KRM));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KRM = new System.Windows.Forms.TextBox();
            this.textBoxStart_KRM = new System.Windows.Forms.TextBox();
            this.labelStop_KRM = new System.Windows.Forms.Label();
            this.labelStart_KRM = new System.Windows.Forms.Label();
            this.ButtonDone_KRM = new System.Windows.Forms.Button();
            this.buttonSave_KRM = new System.Windows.Forms.Button();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.groupBoxOutput_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KRM = new System.Windows.Forms.TextBox();
            this.chartFunction_KRM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KRM.SuspendLayout();
            this.groupBoxInput_KRM.SuspendLayout();
            this.groupBoxOutput_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(515, 148);
            this.groupBoxTask_KRM.TabIndex = 0;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // textBoxTask_KRM
            // 
            this.textBoxTask_KRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KRM.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_KRM.Multiline = true;
            this.textBoxTask_KRM.Name = "textBoxTask_KRM";
            this.textBoxTask_KRM.ReadOnly = true;
            this.textBoxTask_KRM.Size = new System.Drawing.Size(463, 108);
            this.textBoxTask_KRM.TabIndex = 0;
            this.textBoxTask_KRM.Text = resources.GetString("textBoxTask_KRM.Text");
            // 
            // groupBoxInput_KRM
            // 
            this.groupBoxInput_KRM.Controls.Add(this.textBoxStop_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.textBoxStart_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.labelStop_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.labelStart_KRM);
            this.groupBoxInput_KRM.Location = new System.Drawing.Point(545, 43);
            this.groupBoxInput_KRM.Name = "groupBoxInput_KRM";
            this.groupBoxInput_KRM.Size = new System.Drawing.Size(304, 100);
            this.groupBoxInput_KRM.TabIndex = 2;
            this.groupBoxInput_KRM.TabStop = false;
            this.groupBoxInput_KRM.Text = "Ввод данных";
            // 
            // textBoxStop_KRM
            // 
            this.textBoxStop_KRM.Location = new System.Drawing.Point(135, 56);
            this.textBoxStop_KRM.Name = "textBoxStop_KRM";
            this.textBoxStop_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxStop_KRM.TabIndex = 1;
            // 
            // textBoxStart_KRM
            // 
            this.textBoxStart_KRM.Location = new System.Drawing.Point(6, 56);
            this.textBoxStart_KRM.Name = "textBoxStart_KRM";
            this.textBoxStart_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_KRM.TabIndex = 1;
            // 
            // labelStop_KRM
            // 
            this.labelStop_KRM.AutoSize = true;
            this.labelStop_KRM.Location = new System.Drawing.Point(132, 36);
            this.labelStop_KRM.Name = "labelStop_KRM";
            this.labelStop_KRM.Size = new System.Drawing.Size(89, 17);
            this.labelStop_KRM.TabIndex = 0;
            this.labelStop_KRM.Text = "Конец шага:";
            // 
            // labelStart_KRM
            // 
            this.labelStart_KRM.AutoSize = true;
            this.labelStart_KRM.Location = new System.Drawing.Point(6, 36);
            this.labelStart_KRM.Name = "labelStart_KRM";
            this.labelStart_KRM.Size = new System.Drawing.Size(87, 17);
            this.labelStart_KRM.TabIndex = 0;
            this.labelStart_KRM.Text = "Старт шага:";
            // 
            // ButtonDone_KRM
            // 
            this.ButtonDone_KRM.BackColor = System.Drawing.Color.Lime;
            this.ButtonDone_KRM.Location = new System.Drawing.Point(877, 60);
            this.ButtonDone_KRM.Name = "ButtonDone_KRM";
            this.ButtonDone_KRM.Size = new System.Drawing.Size(95, 83);
            this.ButtonDone_KRM.TabIndex = 3;
            this.ButtonDone_KRM.Text = "Выполнить";
            this.ButtonDone_KRM.UseVisualStyleBackColor = false;
            this.ButtonDone_KRM.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // buttonSave_KRM
            // 
            this.buttonSave_KRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave_KRM.Location = new System.Drawing.Point(1003, 60);
            this.buttonSave_KRM.Name = "buttonSave_KRM";
            this.buttonSave_KRM.Size = new System.Drawing.Size(95, 82);
            this.buttonSave_KRM.TabIndex = 3;
            this.buttonSave_KRM.Text = "Сохранить";
            this.buttonSave_KRM.UseVisualStyleBackColor = false;
            this.buttonSave_KRM.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.BackColor = System.Drawing.Color.Red;
            this.buttonHelp_KRM.Location = new System.Drawing.Point(1125, 60);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(95, 82);
            this.buttonHelp_KRM.TabIndex = 3;
            this.buttonHelp_KRM.Text = "Справка";
            this.buttonHelp_KRM.UseVisualStyleBackColor = false;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxOutput_KRM
            // 
            this.groupBoxOutput_KRM.Controls.Add(this.textBoxResult_KRM);
            this.groupBoxOutput_KRM.Location = new System.Drawing.Point(13, 167);
            this.groupBoxOutput_KRM.Name = "groupBoxOutput_KRM";
            this.groupBoxOutput_KRM.Size = new System.Drawing.Size(324, 429);
            this.groupBoxOutput_KRM.TabIndex = 4;
            this.groupBoxOutput_KRM.TabStop = false;
            this.groupBoxOutput_KRM.Text = "Вывод";
            // 
            // textBoxResult_KRM
            // 
            this.textBoxResult_KRM.Location = new System.Drawing.Point(0, 21);
            this.textBoxResult_KRM.Multiline = true;
            this.textBoxResult_KRM.Name = "textBoxResult_KRM";
            this.textBoxResult_KRM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRM.Size = new System.Drawing.Size(318, 445);
            this.textBoxResult_KRM.TabIndex = 0;
            // 
            // chartFunction_KRM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KRM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KRM.Legends.Add(legend1);
            this.chartFunction_KRM.Location = new System.Drawing.Point(377, 167);
            this.chartFunction_KRM.Name = "chartFunction_KRM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KRM.Series.Add(series1);
            this.chartFunction_KRM.Size = new System.Drawing.Size(864, 423);
            this.chartFunction_KRM.TabIndex = 5;
            this.chartFunction_KRM.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.Blue;
            title1.Text = "График функции (sin(x)/(x+1,7)) - cos(x) * 4x - 6 ";
            this.chartFunction_KRM.Titles.Add(title1);
            this.chartFunction_KRM.Click += new System.EventHandler(this.chartFunction_Click);
            // 
            // FormMain_KRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.chartFunction_KRM);
            this.Controls.Add(this.groupBoxOutput_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.buttonSave_KRM);
            this.Controls.Add(this.ButtonDone_KRM);
            this.Controls.Add(this.groupBoxInput_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.Name = "FormMain_KRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 17 | Команич Р. М.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            this.groupBoxInput_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.PerformLayout();
            this.groupBoxOutput_KRM.ResumeLayout(false);
            this.groupBoxOutput_KRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
        private System.Windows.Forms.GroupBox groupBoxInput_KRM;
        private System.Windows.Forms.TextBox textBoxStop_KRM;
        private System.Windows.Forms.TextBox textBoxStart_KRM;
        private System.Windows.Forms.Label labelStop_KRM;
        private System.Windows.Forms.Label labelStart_KRM;
        private System.Windows.Forms.Button ButtonDone_KRM;
        private System.Windows.Forms.Button buttonSave_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRM;
        private System.Windows.Forms.TextBox textBoxResult_KRM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRM;
    }
}

