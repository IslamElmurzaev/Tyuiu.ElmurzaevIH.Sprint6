namespace Tyuiu.ElmurzaevIH.Sprint6.Task3.V3
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
            this.groupBoxCondition_EIH = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_EIH = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData_EIH = new System.Windows.Forms.GroupBox();
            this.dataGridViewResultMatrix_EIH = new System.Windows.Forms.DataGridView();
            this.buttonDone_EIH = new System.Windows.Forms.Button();
            this.labelResult_EIH = new System.Windows.Forms.Label();
            this.textBoxCondition_EIH = new System.Windows.Forms.TextBox();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.groupBoxCondition_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_EIH)).BeginInit();
            this.groupBoxOutPutData_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_EIH
            // 
            this.groupBoxCondition_EIH.Controls.Add(this.textBoxCondition_EIH);
            this.groupBoxCondition_EIH.Controls.Add(this.dataGridViewMatrix_EIH);
            this.groupBoxCondition_EIH.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_EIH.Name = "groupBoxCondition_EIH";
            this.groupBoxCondition_EIH.Size = new System.Drawing.Size(614, 337);
            this.groupBoxCondition_EIH.TabIndex = 0;
            this.groupBoxCondition_EIH.TabStop = false;
            this.groupBoxCondition_EIH.Text = "Условие";
            // 
            // dataGridViewMatrix_EIH
            // 
            this.dataGridViewMatrix_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_EIH.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_EIH.Location = new System.Drawing.Point(368, 22);
            this.dataGridViewMatrix_EIH.Name = "dataGridViewMatrix_EIH";
            this.dataGridViewMatrix_EIH.RowHeadersVisible = false;
            this.dataGridViewMatrix_EIH.RowHeadersWidth = 51;
            this.dataGridViewMatrix_EIH.RowTemplate.Height = 24;
            this.dataGridViewMatrix_EIH.Size = new System.Drawing.Size(240, 258);
            this.dataGridViewMatrix_EIH.TabIndex = 0;
            // 
            // groupBoxOutPutData_EIH
            // 
            this.groupBoxOutPutData_EIH.Controls.Add(this.labelResult_EIH);
            this.groupBoxOutPutData_EIH.Controls.Add(this.dataGridViewResultMatrix_EIH);
            this.groupBoxOutPutData_EIH.Location = new System.Drawing.Point(633, 13);
            this.groupBoxOutPutData_EIH.Name = "groupBoxOutPutData_EIH";
            this.groupBoxOutPutData_EIH.Size = new System.Drawing.Size(260, 291);
            this.groupBoxOutPutData_EIH.TabIndex = 1;
            this.groupBoxOutPutData_EIH.TabStop = false;
            this.groupBoxOutPutData_EIH.Text = "Вывод данных:";
            // 
            // dataGridViewResultMatrix_EIH
            // 
            this.dataGridViewResultMatrix_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultMatrix_EIH.ColumnHeadersVisible = false;
            this.dataGridViewResultMatrix_EIH.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewResultMatrix_EIH.Name = "dataGridViewResultMatrix_EIH";
            this.dataGridViewResultMatrix_EIH.RowHeadersVisible = false;
            this.dataGridViewResultMatrix_EIH.RowHeadersWidth = 51;
            this.dataGridViewResultMatrix_EIH.RowTemplate.Height = 24;
            this.dataGridViewResultMatrix_EIH.Size = new System.Drawing.Size(240, 232);
            this.dataGridViewResultMatrix_EIH.TabIndex = 0;
            // 
            // buttonDone_EIH
            // 
            this.buttonDone_EIH.Location = new System.Drawing.Point(757, 310);
            this.buttonDone_EIH.Name = "buttonDone_EIH";
            this.buttonDone_EIH.Size = new System.Drawing.Size(136, 40);
            this.buttonDone_EIH.TabIndex = 2;
            this.buttonDone_EIH.Text = "Выполнить";
            this.buttonDone_EIH.UseVisualStyleBackColor = true;
            this.buttonDone_EIH.Click += new System.EventHandler(this.buttonDone_EIH_Click);
            // 
            // labelResult_EIH
            // 
            this.labelResult_EIH.AutoSize = true;
            this.labelResult_EIH.Location = new System.Drawing.Point(7, 22);
            this.labelResult_EIH.Name = "labelResult_EIH";
            this.labelResult_EIH.Size = new System.Drawing.Size(80, 16);
            this.labelResult_EIH.TabIndex = 1;
            this.labelResult_EIH.Text = "Результат:";
            // 
            // textBoxCondition_EIH
            // 
            this.textBoxCondition_EIH.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_EIH.Multiline = true;
            this.textBoxCondition_EIH.Name = "textBoxCondition_EIH";
            this.textBoxCondition_EIH.ReadOnly = true;
            this.textBoxCondition_EIH.Size = new System.Drawing.Size(345, 310);
            this.textBoxCondition_EIH.TabIndex = 1;
            this.textBoxCondition_EIH.Text = resources.GetString("textBoxCondition_EIH.Text");
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.Location = new System.Drawing.Point(634, 310);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(86, 40);
            this.buttonHelp_EIH.TabIndex = 3;
            this.buttonHelp_EIH.Text = "?";
            this.buttonHelp_EIH.UseVisualStyleBackColor = true;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 362);
            this.Controls.Add(this.buttonHelp_EIH);
            this.Controls.Add(this.buttonDone_EIH);
            this.Controls.Add(this.groupBoxOutPutData_EIH);
            this.Controls.Add(this.groupBoxCondition_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 3 | Ельмурзаев И.Х.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_EIH.ResumeLayout(false);
            this.groupBoxCondition_EIH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_EIH)).EndInit();
            this.groupBoxOutPutData_EIH.ResumeLayout(false);
            this.groupBoxOutPutData_EIH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_EIH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_EIH;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EIH;
        private System.Windows.Forms.Label labelResult_EIH;
        private System.Windows.Forms.DataGridView dataGridViewResultMatrix_EIH;
        private System.Windows.Forms.Button buttonDone_EIH;
        private System.Windows.Forms.TextBox textBoxCondition_EIH;
        private System.Windows.Forms.Button buttonHelp_EIH;
    }
}

