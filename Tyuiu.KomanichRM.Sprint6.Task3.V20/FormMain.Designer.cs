
namespace Tyuiu.KomanichRM.Sprint6.Task3.V20
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
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_KRM = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_KRM = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixResult_KRM = new System.Windows.Forms.DataGridView();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.groupBoxTask_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRM)).BeginInit();
            this.groupBoxResult_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.dataGridViewMatrix_KRM);
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(667, 406);
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
            this.textBoxTask_KRM.Size = new System.Drawing.Size(223, 144);
            this.textBoxTask_KRM.TabIndex = 0;
            this.textBoxTask_KRM.Text = resources.GetString("textBoxTask_KRM.Text");
            // 
            // dataGridViewMatrix_KRM
            // 
            this.dataGridViewMatrix_KRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KRM.Location = new System.Drawing.Point(269, 21);
            this.dataGridViewMatrix_KRM.Name = "dataGridViewMatrix_KRM";
            this.dataGridViewMatrix_KRM.RowHeadersWidth = 51;
            this.dataGridViewMatrix_KRM.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KRM.Size = new System.Drawing.Size(392, 202);
            this.dataGridViewMatrix_KRM.TabIndex = 1;
            this.dataGridViewMatrix_KRM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMatrix_CellContentClick);
            // 
            // groupBoxResult_KRM
            // 
            this.groupBoxResult_KRM.Controls.Add(this.dataGridViewMatrixResult_KRM);
            this.groupBoxResult_KRM.Location = new System.Drawing.Point(703, 12);
            this.groupBoxResult_KRM.Name = "groupBoxResult_KRM";
            this.groupBoxResult_KRM.Size = new System.Drawing.Size(520, 406);
            this.groupBoxResult_KRM.TabIndex = 1;
            this.groupBoxResult_KRM.TabStop = false;
            this.groupBoxResult_KRM.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_KRM
            // 
            this.dataGridViewMatrixResult_KRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_KRM.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewMatrixResult_KRM.Name = "dataGridViewMatrixResult_KRM";
            this.dataGridViewMatrixResult_KRM.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_KRM.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_KRM.Size = new System.Drawing.Size(392, 202);
            this.dataGridViewMatrixResult_KRM.TabIndex = 0;
            this.dataGridViewMatrixResult_KRM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMatrixResult_CellContentClick);
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.Location = new System.Drawing.Point(594, 448);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(85, 79);
            this.buttonHelp_KRM.TabIndex = 2;
            this.buttonHelp_KRM.Text = "?";
            this.buttonHelp_KRM.UseVisualStyleBackColor = true;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.Location = new System.Drawing.Point(703, 448);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(214, 79);
            this.buttonDone_KRM.TabIndex = 2;
            this.buttonDone_KRM.Text = "Выполнить";
            this.buttonDone_KRM.UseVisualStyleBackColor = true;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain_KRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 605);
            this.Controls.Add(this.buttonDone_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.groupBoxResult_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.Name = "FormMain_KRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Команич Р. М.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRM)).EndInit();
            this.groupBoxResult_KRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
        private System.Windows.Forms.GroupBox groupBoxResult_KRM;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
    }
}

