namespace Tyuiu.ElmurzaevIH.Sprint6.Task0.V3
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
            this.groupBoxInPutData_EIH = new System.Windows.Forms.GroupBox();
            this.labelVarX = new System.Windows.Forms.Label();
            this.textBoxVarX_EIH = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_EIH = new System.Windows.Forms.GroupBox();
            this.labelResult_EIH = new System.Windows.Forms.Label();
            this.textBoxResult_EIH = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDone_EIH = new System.Windows.Forms.Button();
            this.groupBoxCondition_EIH = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_EIH = new System.Windows.Forms.TextBox();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.groupBoxInPutData_EIH.SuspendLayout();
            this.groupBoxOutPutData_EIH.SuspendLayout();
            this.groupBoxCondition_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInPutData_EIH
            // 
            this.groupBoxInPutData_EIH.Controls.Add(this.labelVarX);
            this.groupBoxInPutData_EIH.Controls.Add(this.textBoxVarX_EIH);
            this.groupBoxInPutData_EIH.Location = new System.Drawing.Point(15, 319);
            this.groupBoxInPutData_EIH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_EIH.Name = "groupBoxInPutData_EIH";
            this.groupBoxInPutData_EIH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInPutData_EIH.Size = new System.Drawing.Size(449, 148);
            this.groupBoxInPutData_EIH.TabIndex = 1;
            this.groupBoxInPutData_EIH.TabStop = false;
            this.groupBoxInPutData_EIH.Text = "Ввод данных:";
            this.groupBoxInPutData_EIH.Enter += new System.EventHandler(this.groupBoxInPutData_EIH_Enter);
            // 
            // labelVarX
            // 
            this.labelVarX.AutoSize = true;
            this.labelVarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarX.Location = new System.Drawing.Point(147, 46);
            this.labelVarX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVarX.Name = "labelVarX";
            this.labelVarX.Size = new System.Drawing.Size(112, 18);
            this.labelVarX.TabIndex = 1;
            this.labelVarX.Text = "Переменная X:";
            // 
            // textBoxVarX_EIH
            // 
            this.textBoxVarX_EIH.Location = new System.Drawing.Point(128, 65);
            this.textBoxVarX_EIH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVarX_EIH.Name = "textBoxVarX_EIH";
            this.textBoxVarX_EIH.Size = new System.Drawing.Size(161, 22);
            this.textBoxVarX_EIH.TabIndex = 0;
            this.textBoxVarX_EIH.TextChanged += new System.EventHandler(this.textBoxVarX_EIH_TextChanged);
            this.textBoxVarX_EIH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_EIH_KeyPress);
            // 
            // groupBoxOutPutData_EIH
            // 
            this.groupBoxOutPutData_EIH.Controls.Add(this.labelResult_EIH);
            this.groupBoxOutPutData_EIH.Controls.Add(this.textBoxResult_EIH);
            this.groupBoxOutPutData_EIH.Location = new System.Drawing.Point(471, 319);
            this.groupBoxOutPutData_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPutData_EIH.Name = "groupBoxOutPutData_EIH";
            this.groupBoxOutPutData_EIH.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOutPutData_EIH.Size = new System.Drawing.Size(243, 148);
            this.groupBoxOutPutData_EIH.TabIndex = 2;
            this.groupBoxOutPutData_EIH.TabStop = false;
            this.groupBoxOutPutData_EIH.Text = "Вывод данных:";
            // 
            // labelResult_EIH
            // 
            this.labelResult_EIH.AutoSize = true;
            this.labelResult_EIH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult_EIH.Location = new System.Drawing.Point(53, 43);
            this.labelResult_EIH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult_EIH.Name = "labelResult_EIH";
            this.labelResult_EIH.Size = new System.Drawing.Size(84, 18);
            this.labelResult_EIH.TabIndex = 1;
            this.labelResult_EIH.Text = "Результат:";
            this.labelResult_EIH.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResult_EIH
            // 
            this.textBoxResult_EIH.Location = new System.Drawing.Point(35, 65);
            this.textBoxResult_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResult_EIH.Name = "textBoxResult_EIH";
            this.textBoxResult_EIH.ReadOnly = true;
            this.textBoxResult_EIH.Size = new System.Drawing.Size(132, 22);
            this.textBoxResult_EIH.TabIndex = 0;
            // 
            // buttonDone_EIH
            // 
            this.buttonDone_EIH.Location = new System.Drawing.Point(528, 474);
            this.buttonDone_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDone_EIH.Name = "buttonDone_EIH";
            this.buttonDone_EIH.Size = new System.Drawing.Size(173, 47);
            this.buttonDone_EIH.TabIndex = 3;
            this.buttonDone_EIH.Text = "Выполнить";
            this.buttonDone_EIH.UseVisualStyleBackColor = true;
            this.buttonDone_EIH.Click += new System.EventHandler(this.buttonDone_EIH_Click);
            // 
            // groupBoxCondition_EIH
            // 
            this.groupBoxCondition_EIH.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_EIH.Controls.Add(this.textBoxTask_EIH);
            this.groupBoxCondition_EIH.Location = new System.Drawing.Point(17, 16);
            this.groupBoxCondition_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCondition_EIH.Name = "groupBoxCondition_EIH";
            this.groupBoxCondition_EIH.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCondition_EIH.Size = new System.Drawing.Size(696, 297);
            this.groupBoxCondition_EIH.TabIndex = 4;
            this.groupBoxCondition_EIH.TabStop = false;
            this.groupBoxCondition_EIH.Text = "Условие:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_EIH
            // 
            this.textBoxTask_EIH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_EIH.Location = new System.Drawing.Point(9, 25);
            this.textBoxTask_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTask_EIH.Multiline = true;
            this.textBoxTask_EIH.Name = "textBoxTask_EIH";
            this.textBoxTask_EIH.ReadOnly = true;
            this.textBoxTask_EIH.Size = new System.Drawing.Size(685, 249);
            this.textBoxTask_EIH.TabIndex = 0;
            this.textBoxTask_EIH.Text = "Дано выражение вычислить его значение при x = 3, \r\nрезультат вывести в TextBox. \r" +
    "\nОкруглить до трёх знаков после запятой.\r\nГрафический интерфейс оформить по шабл" +
    "ону из лекции.";
            this.textBoxTask_EIH.TextChanged += new System.EventHandler(this.textBoxTask_EIH_TextChanged);
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_EIH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_EIH.Location = new System.Drawing.Point(471, 475);
            this.buttonHelp_EIH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(49, 46);
            this.buttonHelp_EIH.TabIndex = 5;
            this.buttonHelp_EIH.Text = "?";
            this.buttonHelp_EIH.UseVisualStyleBackColor = true;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 535);
            this.Controls.Add(this.buttonHelp_EIH);
            this.Controls.Add(this.groupBoxCondition_EIH);
            this.Controls.Add(this.buttonDone_EIH);
            this.Controls.Add(this.groupBoxOutPutData_EIH);
            this.Controls.Add(this.groupBoxInPutData_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Ельмурзаев И.Х.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInPutData_EIH.ResumeLayout(false);
            this.groupBoxInPutData_EIH.PerformLayout();
            this.groupBoxOutPutData_EIH.ResumeLayout(false);
            this.groupBoxOutPutData_EIH.PerformLayout();
            this.groupBoxCondition_EIH.ResumeLayout(false);
            this.groupBoxCondition_EIH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInPutData_EIH;
        private System.Windows.Forms.TextBox textBoxVarX_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EIH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelVarX;
        private System.Windows.Forms.Label labelResult_EIH;
        private System.Windows.Forms.TextBox textBoxResult_EIH;
        private System.Windows.Forms.Button buttonDone_EIH;
        private System.Windows.Forms.GroupBox groupBoxCondition_EIH;
        private System.Windows.Forms.TextBox textBoxTask_EIH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHelp_EIH;
    }
}

