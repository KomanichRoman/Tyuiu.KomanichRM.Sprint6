
namespace Tyuiu.KomanichRM.Sprint6.Task0.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_KRM = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_KRM = new System.Windows.Forms.GroupBox();
            this.labelInput_KRM = new System.Windows.Forms.Label();
            this.textBoxInput_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_KRM = new System.Windows.Forms.GroupBox();
            this.labelResult_KRM = new System.Windows.Forms.Label();
            this.textBoxResult_KRM = new System.Windows.Forms.TextBox();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.groupBoxTask_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRM)).BeginInit();
            this.groupBoxInput_KRM.SuspendLayout();
            this.groupBoxOutput_KRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Controls.Add(this.pictureBoxFormula_KRM);
            this.groupBoxTask_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(23, 29);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(1134, 397);
            this.groupBoxTask_KRM.TabIndex = 0;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // textBoxTask_KRM
            // 
            this.textBoxTask_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_KRM.Location = new System.Drawing.Point(6, 39);
            this.textBoxTask_KRM.Multiline = true;
            this.textBoxTask_KRM.Name = "textBoxTask_KRM";
            this.textBoxTask_KRM.ReadOnly = true;
            this.textBoxTask_KRM.Size = new System.Drawing.Size(682, 335);
            this.textBoxTask_KRM.TabIndex = 2;
            this.textBoxTask_KRM.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxFormula_KRM
            // 
            this.pictureBoxFormula_KRM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KRM.Image")));
            this.pictureBoxFormula_KRM.Location = new System.Drawing.Point(743, 52);
            this.pictureBoxFormula_KRM.Name = "pictureBoxFormula_KRM";
            this.pictureBoxFormula_KRM.Size = new System.Drawing.Size(299, 51);
            this.pictureBoxFormula_KRM.TabIndex = 1;
            this.pictureBoxFormula_KRM.TabStop = false;
            // 
            // groupBoxInput_KRM
            // 
            this.groupBoxInput_KRM.Controls.Add(this.labelInput_KRM);
            this.groupBoxInput_KRM.Controls.Add(this.textBoxInput_KRM);
            this.groupBoxInput_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_KRM.Location = new System.Drawing.Point(29, 432);
            this.groupBoxInput_KRM.Name = "groupBoxInput_KRM";
            this.groupBoxInput_KRM.Size = new System.Drawing.Size(355, 117);
            this.groupBoxInput_KRM.TabIndex = 1;
            this.groupBoxInput_KRM.TabStop = false;
            this.groupBoxInput_KRM.Text = "Ввод данных";
            // 
            // labelInput_KRM
            // 
            this.labelInput_KRM.AutoSize = true;
            this.labelInput_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput_KRM.Location = new System.Drawing.Point(6, 52);
            this.labelInput_KRM.Name = "labelInput_KRM";
            this.labelInput_KRM.Size = new System.Drawing.Size(112, 18);
            this.labelInput_KRM.TabIndex = 1;
            this.labelInput_KRM.Text = "Переменная X:";
            // 
            // textBoxInput_KRM
            // 
            this.textBoxInput_KRM.Location = new System.Drawing.Point(10, 85);
            this.textBoxInput_KRM.Name = "textBoxInput_KRM";
            this.textBoxInput_KRM.Size = new System.Drawing.Size(100, 26);
            this.textBoxInput_KRM.TabIndex = 0;
            this.textBoxInput_KRM.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput_KRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // groupBoxOutput_KRM
            // 
            this.groupBoxOutput_KRM.Controls.Add(this.labelResult_KRM);
            this.groupBoxOutput_KRM.Controls.Add(this.textBoxResult_KRM);
            this.groupBoxOutput_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput_KRM.Location = new System.Drawing.Point(430, 432);
            this.groupBoxOutput_KRM.Name = "groupBoxOutput_KRM";
            this.groupBoxOutput_KRM.Size = new System.Drawing.Size(375, 117);
            this.groupBoxOutput_KRM.TabIndex = 2;
            this.groupBoxOutput_KRM.TabStop = false;
            this.groupBoxOutput_KRM.Text = "Вывод данных";
            // 
            // labelResult_KRM
            // 
            this.labelResult_KRM.AutoSize = true;
            this.labelResult_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_KRM.Location = new System.Drawing.Point(6, 52);
            this.labelResult_KRM.Name = "labelResult_KRM";
            this.labelResult_KRM.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KRM.TabIndex = 1;
            this.labelResult_KRM.Text = "Результат:";
            // 
            // textBoxResult_KRM
            // 
            this.textBoxResult_KRM.Location = new System.Drawing.Point(6, 85);
            this.textBoxResult_KRM.Name = "textBoxResult_KRM";
            this.textBoxResult_KRM.ReadOnly = true;
            this.textBoxResult_KRM.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult_KRM.TabIndex = 0;
            this.textBoxResult_KRM.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KRM.Location = new System.Drawing.Point(1058, 463);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(64, 63);
            this.buttonHelp_KRM.TabIndex = 3;
            this.buttonHelp_KRM.Text = "?";
            this.buttonHelp_KRM.UseVisualStyleBackColor = true;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KRM.Location = new System.Drawing.Point(823, 461);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(194, 63);
            this.buttonDone_KRM.TabIndex = 4;
            this.buttonDone_KRM.Text = "Выполнить";
            this.buttonDone_KRM.UseVisualStyleBackColor = true;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 658);
            this.Controls.Add(this.buttonDone_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.groupBoxOutput_KRM);
            this.Controls.Add(this.groupBoxInput_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Команич Р. М.";
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KRM)).EndInit();
            this.groupBoxInput_KRM.ResumeLayout(false);
            this.groupBoxInput_KRM.PerformLayout();
            this.groupBoxOutput_KRM.ResumeLayout(false);
            this.groupBoxOutput_KRM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KRM;
        private System.Windows.Forms.GroupBox groupBoxInput_KRM;
        private System.Windows.Forms.Label labelInput_KRM;
        private System.Windows.Forms.TextBox textBoxInput_KRM;
        private System.Windows.Forms.GroupBox groupBoxOutput_KRM;
        private System.Windows.Forms.Label labelResult_KRM;
        private System.Windows.Forms.TextBox textBoxResult_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
    }
}

