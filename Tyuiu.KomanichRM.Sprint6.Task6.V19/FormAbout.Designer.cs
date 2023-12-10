
namespace Tyuiu.KomanichRM.Sprint6.Task6.V19
{
    partial class FormAbout_KRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KRM));
            this.labelInfo_KRM = new System.Windows.Forms.Label();
            this.pictureBoxInfo_KRM = new System.Windows.Forms.PictureBox();
            this.buttonOk_KRM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KRM)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KRM
            // 
            this.labelInfo_KRM.AutoSize = true;
            this.labelInfo_KRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_KRM.Location = new System.Drawing.Point(343, 39);
            this.labelInfo_KRM.Name = "labelInfo_KRM";
            this.labelInfo_KRM.Size = new System.Drawing.Size(384, 162);
            this.labelInfo_KRM.TabIndex = 1;
            this.labelInfo_KRM.Text = resources.GetString("labelInfo_KRM.Text");
            // 
            // pictureBoxInfo_KRM
            // 
            this.pictureBoxInfo_KRM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo_KRM.Image")));
            this.pictureBoxInfo_KRM.Location = new System.Drawing.Point(26, 39);
            this.pictureBoxInfo_KRM.Name = "pictureBoxInfo_KRM";
            this.pictureBoxInfo_KRM.Size = new System.Drawing.Size(294, 332);
            this.pictureBoxInfo_KRM.TabIndex = 2;
            this.pictureBoxInfo_KRM.TabStop = false;
            // 
            // buttonOk_KRM
            // 
            this.buttonOk_KRM.Location = new System.Drawing.Point(602, 324);
            this.buttonOk_KRM.Name = "buttonOk_KRM";
            this.buttonOk_KRM.Size = new System.Drawing.Size(125, 47);
            this.buttonOk_KRM.TabIndex = 3;
            this.buttonOk_KRM.Text = "OK";
            this.buttonOk_KRM.UseVisualStyleBackColor = true;
            this.buttonOk_KRM.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAbout_KRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.buttonOk_KRM);
            this.Controls.Add(this.pictureBoxInfo_KRM);
            this.Controls.Add(this.labelInfo_KRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_KRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KRM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo_KRM;
        private System.Windows.Forms.PictureBox pictureBoxInfo_KRM;
        private System.Windows.Forms.Button buttonOk_KRM;
    }
}