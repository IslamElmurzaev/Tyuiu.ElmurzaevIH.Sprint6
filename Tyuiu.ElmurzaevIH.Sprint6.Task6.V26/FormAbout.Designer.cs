namespace Tyuiu.ElmurzaevIH.Sprint6.Task6.V26
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxDeveloper_EIH = new System.Windows.Forms.PictureBox();
            this.labelInfo_EIH = new System.Windows.Forms.Label();
            this.buttonOK_EIH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDeveloper_EIH
            // 
            this.pictureBoxDeveloper_EIH.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDeveloper_EIH.Image")));
            this.pictureBoxDeveloper_EIH.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxDeveloper_EIH.Name = "pictureBoxDeveloper_EIH";
            this.pictureBoxDeveloper_EIH.Size = new System.Drawing.Size(151, 163);
            this.pictureBoxDeveloper_EIH.TabIndex = 0;
            this.pictureBoxDeveloper_EIH.TabStop = false;
            // 
            // labelInfo_EIH
            // 
            this.labelInfo_EIH.AutoSize = true;
            this.labelInfo_EIH.Location = new System.Drawing.Point(199, 13);
            this.labelInfo_EIH.Name = "labelInfo_EIH";
            this.labelInfo_EIH.Size = new System.Drawing.Size(343, 144);
            this.labelInfo_EIH.TabIndex = 1;
            this.labelInfo_EIH.Text = resources.GetString("labelInfo_EIH.Text");
            this.labelInfo_EIH.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOK_EIH
            // 
            this.buttonOK_EIH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOK_EIH.Location = new System.Drawing.Point(455, 161);
            this.buttonOK_EIH.Name = "buttonOK_EIH";
            this.buttonOK_EIH.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_EIH.TabIndex = 2;
            this.buttonOK_EIH.Text = "OK";
            this.buttonOK_EIH.UseVisualStyleBackColor = false;
            this.buttonOK_EIH.Click += new System.EventHandler(this.buttonOK_EIH_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 188);
            this.Controls.Add(this.buttonOK_EIH);
            this.Controls.Add(this.labelInfo_EIH);
            this.Controls.Add(this.pictureBoxDeveloper_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(581, 235);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeveloper_EIH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDeveloper_EIH;
        private System.Windows.Forms.Label labelInfo_EIH;
        private System.Windows.Forms.Button buttonOK_EIH;
    }
}