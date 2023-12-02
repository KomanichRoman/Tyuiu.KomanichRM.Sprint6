
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask.Location = new System.Drawing.Point(23, 29);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(1134, 397);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(718, 44);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(372, 67);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelInput);
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput.Location = new System.Drawing.Point(81, 432);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(355, 117);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод данных";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInput.Location = new System.Drawing.Point(6, 52);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(112, 18);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Переменная X:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(10, 85);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.label2);
            this.groupBoxOutput.Controls.Add(this.textBoxResult);
            this.groupBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutput.Location = new System.Drawing.Point(665, 432);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(375, 117);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 85);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(671, 583);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(64, 63);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Location = new System.Drawing.Point(779, 583);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(194, 63);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(6, 39);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(682, 335);
            this.textBoxTask.TabIndex = 2;
            this.textBoxTask.Text = "Вычислить выражение по формуле:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 658);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Команич Р. М.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

