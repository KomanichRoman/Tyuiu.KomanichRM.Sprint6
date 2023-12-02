
namespace Tyuiu.KomanichRM.Sprint6.Task1.V29
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
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KRM = new System.Windows.Forms.GroupBox();
            this.labelStop_KRM = new System.Windows.Forms.Label();
            this.labelStart_KRM = new System.Windows.Forms.Label();
            this.textBoxInputB_KRM = new System.Windows.Forms.TextBox();
            this.textBoxInputA_KRM = new System.Windows.Forms.TextBox();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.labelResult_KRM = new System.Windows.Forms.Label();
            this.groupBoxTask_KRM.SuspendLayout();
            this.groupBoxResult_KRM.SuspendLayout();
            this.groupBoxInput_KRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.textBoxCondition_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(788, 422);
            this.groupBoxTask_KRM.TabIndex = 0;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // textBoxCondition_KRM
            // 
            this.textBoxCondition_KRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_KRM.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_KRM.Multiline = true;
            this.textBoxCondition_KRM.Name = "textBoxCondition_KRM";
            this.textBoxCondition_KRM.ReadOnly = true;
            this.textBoxCondition_KRM.Size = new System.Drawing.Size(364, 46);
            this.textBoxCondition_KRM.TabIndex = 0;
            this.textBoxCondition_KRM.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "\r\n\r\n";
            this.textBoxCondition_KRM.TextChanged += new System.EventHandler(this.textBoxCondition1_TextChanged);
            // 
            // groupBoxResult_KRM
            // 
            this.groupBoxResult_KRM.Controls.Add(this.labelResult_KRM);
            this.groupBoxResult_KRM.Controls.Add(this.textBoxResult_KRM);
            this.groupBoxResult_KRM.Location = new System.Drawing.Point(844, 26);
            this.groupBoxResult_KRM.Name = "groupBoxResult_KRM";
            this.groupBoxResult_KRM.Size = new System.Drawing.Size(364, 462);
            this.groupBoxResult_KRM.TabIndex = 1;
            this.groupBoxResult_KRM.TabStop = false;
            this.groupBoxResult_KRM.Text = "Вывод данных";
            // 
            // textBoxResult_KRM
            // 
            this.textBoxResult_KRM.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KRM.Location = new System.Drawing.Point(6, 49);
            this.textBoxResult_KRM.Multiline = true;
            this.textBoxResult_KRM.Name = "textBoxResult_KRM";
            this.textBoxResult_KRM.ReadOnly = true;
            this.textBoxResult_KRM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KRM.Size = new System.Drawing.Size(352, 394);
            this.textBoxResult_KRM.TabIndex = 0;
            this.textBoxResult_KRM.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // groupBoxInput_KRM
            // 
            this.groupBoxInput_KRM.Controls.Add(this.labelStop_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.labelStart_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.textBoxInputB_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.textBoxInputA_KRM);
            this.groupBoxInput_KRM.Location = new System.Drawing.Point(18, 457);
            this.groupBoxInput_KRM.Name = "groupBoxInput_KRM";
            this.groupBoxInput_KRM.Size = new System.Drawing.Size(454, 100);
            this.groupBoxInput_KRM.TabIndex = 2;
            this.groupBoxInput_KRM.TabStop = false;
            this.groupBoxInput_KRM.Text = "Ввод данных";
            // 
            // labelStop_KRM
            // 
            this.labelStop_KRM.AutoSize = true;
            this.labelStop_KRM.Location = new System.Drawing.Point(145, 28);
            this.labelStop_KRM.Name = "labelStop_KRM";
            this.labelStop_KRM.Size = new System.Drawing.Size(89, 17);
            this.labelStop_KRM.TabIndex = 2;
            this.labelStop_KRM.Text = "Конец шага:";
            // 
            // labelStart_KRM
            // 
            this.labelStart_KRM.AutoSize = true;
            this.labelStart_KRM.Location = new System.Drawing.Point(21, 28);
            this.labelStart_KRM.Name = "labelStart_KRM";
            this.labelStart_KRM.Size = new System.Drawing.Size(87, 17);
            this.labelStart_KRM.TabIndex = 2;
            this.labelStart_KRM.Text = "Старт шага:";
            // 
            // textBoxInputB_KRM
            // 
            this.textBoxInputB_KRM.Location = new System.Drawing.Point(148, 48);
            this.textBoxInputB_KRM.Name = "textBoxInputB_KRM";
            this.textBoxInputB_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputB_KRM.TabIndex = 1;
            // 
            // textBoxInputA_KRM
            // 
            this.textBoxInputA_KRM.Location = new System.Drawing.Point(24, 48);
            this.textBoxInputA_KRM.Name = "textBoxInputA_KRM";
            this.textBoxInputA_KRM.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputA_KRM.TabIndex = 0;
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KRM.Location = new System.Drawing.Point(494, 457);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(101, 100);
            this.buttonHelp_KRM.TabIndex = 3;
            this.buttonHelp_KRM.Text = "Справка";
            this.buttonHelp_KRM.UseVisualStyleBackColor = false;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KRM.Location = new System.Drawing.Point(621, 457);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(190, 100);
            this.buttonDone_KRM.TabIndex = 3;
            this.buttonDone_KRM.Text = "Выполнить";
            this.buttonDone_KRM.UseVisualStyleBackColor = false;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // labelResult_KRM
            // 
            this.labelResult_KRM.AutoSize = true;
            this.labelResult_KRM.Location = new System.Drawing.Point(7, 35);
            this.labelResult_KRM.Name = "labelResult_KRM";
            this.labelResult_KRM.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KRM.TabIndex = 1;
            this.labelResult_KRM.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 648);
            this.Controls.Add(this.buttonDone_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.groupBoxInput_KRM);
            this.Controls.Add(this.groupBoxResult_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 29 | Команич Р. М.";
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            this.groupBoxResult_KRM.ResumeLayout(false);
            this.groupBoxResult_KRM.PerformLayout();
            this.groupBoxInput_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.TextBox textBoxCondition_KRM;
        private System.Windows.Forms.GroupBox groupBoxResult_KRM;
        private System.Windows.Forms.TextBox textBoxResult_KRM;
        private System.Windows.Forms.GroupBox groupBoxInput_KRM;
        private System.Windows.Forms.TextBox textBoxInputB_KRM;
        private System.Windows.Forms.TextBox textBoxInputA_KRM;
        private System.Windows.Forms.Label labelStop_KRM;
        private System.Windows.Forms.Label labelStart_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.Label labelResult_KRM;
    }
}

