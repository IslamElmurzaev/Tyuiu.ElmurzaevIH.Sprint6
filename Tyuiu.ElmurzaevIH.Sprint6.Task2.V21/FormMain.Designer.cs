namespace Tyuiu.ElmurzaevIH.Sprint6.Task2.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_EIH = new System.Windows.Forms.Button();
            this.chartFunction_EIH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPutData_EIH = new System.Windows.Forms.GroupBox();
            this.labelResult_EIH = new System.Windows.Forms.Label();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_EIH = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_EIH = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_EIH = new System.Windows.Forms.TextBox();
            this.labelStartStep_EIH = new System.Windows.Forms.Label();
            this.labelStopStep_EIH = new System.Windows.Forms.Label();
            this.dataGridViewFunction_EIH = new System.Windows.Forms.DataGridView();
            this.valueX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.textBoxCondition_EIH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EIH)).BeginInit();
            this.groupBoxOutPutData_EIH.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInPutData_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_EIH
            // 
            this.buttonDone_EIH.BackColor = System.Drawing.Color.Green;
            this.buttonDone_EIH.Location = new System.Drawing.Point(401, 364);
            this.buttonDone_EIH.Name = "buttonDone_EIH";
            this.buttonDone_EIH.Size = new System.Drawing.Size(131, 74);
            this.buttonDone_EIH.TabIndex = 0;
            this.buttonDone_EIH.Text = "Выполнить";
            this.buttonDone_EIH.UseVisualStyleBackColor = false;
            this.buttonDone_EIH.Click += new System.EventHandler(this.buttonDone_EIH_Click);
            this.buttonDone_EIH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_EIH_MouseDown);
            this.buttonDone_EIH.MouseEnter += new System.EventHandler(this.buttonDone_EIH_MouseEnter);
            this.buttonDone_EIH.MouseLeave += new System.EventHandler(this.buttonDone_EIH_MouseLeave);
            // 
            // chartFunction_EIH
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_EIH.ChartAreas.Add(chartArea1);
            this.chartFunction_EIH.Location = new System.Drawing.Point(215, 37);
            this.chartFunction_EIH.Name = "chartFunction_EIH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartFunction_EIH.Series.Add(series1);
            this.chartFunction_EIH.Size = new System.Drawing.Size(373, 383);
            this.chartFunction_EIH.TabIndex = 2;
            // 
            // groupBoxOutPutData_EIH
            // 
            this.groupBoxOutPutData_EIH.Controls.Add(this.dataGridViewFunction_EIH);
            this.groupBoxOutPutData_EIH.Controls.Add(this.labelResult_EIH);
            this.groupBoxOutPutData_EIH.Controls.Add(this.chartFunction_EIH);
            this.groupBoxOutPutData_EIH.Location = new System.Drawing.Point(538, 12);
            this.groupBoxOutPutData_EIH.Name = "groupBoxOutPutData_EIH";
            this.groupBoxOutPutData_EIH.Size = new System.Drawing.Size(588, 426);
            this.groupBoxOutPutData_EIH.TabIndex = 3;
            this.groupBoxOutPutData_EIH.TabStop = false;
            this.groupBoxOutPutData_EIH.Text = "Вывод данных:";
            // 
            // labelResult_EIH
            // 
            this.labelResult_EIH.AutoSize = true;
            this.labelResult_EIH.Location = new System.Drawing.Point(6, 18);
            this.labelResult_EIH.Name = "labelResult_EIH";
            this.labelResult_EIH.Size = new System.Drawing.Size(80, 16);
            this.labelResult_EIH.TabIndex = 3;
            this.labelResult_EIH.Text = "Результат:";
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition_EIH);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(520, 346);
            this.groupBoxCondition.TabIndex = 4;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие:";
            // 
            // groupBoxInPutData_EIH
            // 
            this.groupBoxInPutData_EIH.Controls.Add(this.labelStopStep_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.labelStartStep_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.textBoxStopStep_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.textBoxStartStep_EIH);
            this.groupBoxInPutData_EIH.Location = new System.Drawing.Point(12, 364);
            this.groupBoxInPutData_EIH.Name = "groupBoxInPutData_EIH";
            this.groupBoxInPutData_EIH.Size = new System.Drawing.Size(286, 74);
            this.groupBoxInPutData_EIH.TabIndex = 5;
            this.groupBoxInPutData_EIH.TabStop = false;
            this.groupBoxInPutData_EIH.Text = "Ввод данных:";
            // 
            // textBoxStartStep_EIH
            // 
            this.textBoxStartStep_EIH.Location = new System.Drawing.Point(6, 37);
            this.textBoxStartStep_EIH.Name = "textBoxStartStep_EIH";
            this.textBoxStartStep_EIH.Size = new System.Drawing.Size(128, 22);
            this.textBoxStartStep_EIH.TabIndex = 0;
            // 
            // textBoxStopStep_EIH
            // 
            this.textBoxStopStep_EIH.Location = new System.Drawing.Point(152, 37);
            this.textBoxStopStep_EIH.Name = "textBoxStopStep_EIH";
            this.textBoxStopStep_EIH.Size = new System.Drawing.Size(128, 22);
            this.textBoxStopStep_EIH.TabIndex = 0;
            // 
            // labelStartStep_EIH
            // 
            this.labelStartStep_EIH.AutoSize = true;
            this.labelStartStep_EIH.Location = new System.Drawing.Point(6, 18);
            this.labelStartStep_EIH.Name = "labelStartStep_EIH";
            this.labelStartStep_EIH.Size = new System.Drawing.Size(83, 16);
            this.labelStartStep_EIH.TabIndex = 1;
            this.labelStartStep_EIH.Text = "Старт шага:";
            // 
            // labelStopStep_EIH
            // 
            this.labelStopStep_EIH.AutoSize = true;
            this.labelStopStep_EIH.Location = new System.Drawing.Point(149, 18);
            this.labelStopStep_EIH.Name = "labelStopStep_EIH";
            this.labelStopStep_EIH.Size = new System.Drawing.Size(76, 16);
            this.labelStopStep_EIH.TabIndex = 1;
            this.labelStopStep_EIH.Text = "Стоп шага:";
            // 
            // dataGridViewFunction_EIH
            // 
            this.dataGridViewFunction_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_EIH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueX,
            this.F});
            this.dataGridViewFunction_EIH.Location = new System.Drawing.Point(9, 37);
            this.dataGridViewFunction_EIH.Name = "dataGridViewFunction_EIH";
            this.dataGridViewFunction_EIH.RowHeadersVisible = false;
            this.dataGridViewFunction_EIH.RowHeadersWidth = 51;
            this.dataGridViewFunction_EIH.RowTemplate.Height = 24;
            this.dataGridViewFunction_EIH.Size = new System.Drawing.Size(200, 382);
            this.dataGridViewFunction_EIH.TabIndex = 4;
            // 
            // valueX
            // 
            this.valueX.HeaderText = "X";
            this.valueX.MinimumWidth = 6;
            this.valueX.Name = "valueX";
            this.valueX.Width = 76;
            // 
            // F
            // 
            this.F.HeaderText = "F(x)";
            this.F.MinimumWidth = 6;
            this.F.Name = "F";
            this.F.Width = 76;
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_EIH.Location = new System.Drawing.Point(305, 365);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(90, 73);
            this.buttonHelp_EIH.TabIndex = 6;
            this.buttonHelp_EIH.Text = "Справка";
            this.buttonHelp_EIH.UseVisualStyleBackColor = false;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            // 
            // textBoxCondition_EIH
            // 
            this.textBoxCondition_EIH.Location = new System.Drawing.Point(9, 18);
            this.textBoxCondition_EIH.Multiline = true;
            this.textBoxCondition_EIH.Name = "textBoxCondition_EIH";
            this.textBoxCondition_EIH.ReadOnly = true;
            this.textBoxCondition_EIH.Size = new System.Drawing.Size(494, 322);
            this.textBoxCondition_EIH.TabIndex = 0;
            this.textBoxCondition_EIH.Text = "Протабулировать функцию cos(x) + (cox(x) / (x + 2)) - 3 * x на диапазоне [-5;5] с" +
    " шагом 1. Результат вывести в DataGridView и построить график функции.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.buttonHelp_EIH);
            this.Controls.Add(this.groupBoxInPutData_EIH);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.groupBoxOutPutData_EIH);
            this.Controls.Add(this.buttonDone_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 21 | Ельмурзаев И.Х.";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EIH)).EndInit();
            this.groupBoxOutPutData_EIH.ResumeLayout(false);
            this.groupBoxOutPutData_EIH.PerformLayout();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInPutData_EIH.ResumeLayout(false);
            this.groupBoxInPutData_EIH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_EIH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_EIH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EIH;
        private System.Windows.Forms.Label labelResult_EIH;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxInPutData_EIH;
        private System.Windows.Forms.TextBox textBoxStartStep_EIH;
        private System.Windows.Forms.Label labelStartStep_EIH;
        private System.Windows.Forms.TextBox textBoxStopStep_EIH;
        private System.Windows.Forms.Label labelStopStep_EIH;
        private System.Windows.Forms.DataGridView dataGridViewFunction_EIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueX;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.Button buttonHelp_EIH;
        private System.Windows.Forms.TextBox textBoxCondition_EIH;
    }
}

