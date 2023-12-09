namespace Tyuiu.ElmurzaevIH.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_EIH = new System.Windows.Forms.Panel();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.buttonSave_EIH = new System.Windows.Forms.Button();
            this.buttonDone_EIH = new System.Windows.Forms.Button();
            this.groupBoxInPutData_EIH = new System.Windows.Forms.GroupBox();
            this.labelVarStopStep_EIH = new System.Windows.Forms.Label();
            this.labelVarStartStep_EIH = new System.Windows.Forms.Label();
            this.textBoxVarStop_EIH = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_EIH = new System.Windows.Forms.TextBox();
            this.groupBoxTask_EIH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EIH = new System.Windows.Forms.TextBox();
            this.panelLeft_EIH = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_EIH = new System.Windows.Forms.GroupBox();
            this.textBoxResult_EIH = new System.Windows.Forms.TextBox();
            this.panelRight_EIH = new System.Windows.Forms.Panel();
            this.chartFunction_EIH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterPanel_EIH = new System.Windows.Forms.Splitter();
            this.panelTop_EIH.SuspendLayout();
            this.groupBoxInPutData_EIH.SuspendLayout();
            this.groupBoxTask_EIH.SuspendLayout();
            this.panelLeft_EIH.SuspendLayout();
            this.groupBoxOutPutData_EIH.SuspendLayout();
            this.panelRight_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_EIH
            // 
            this.panelTop_EIH.Controls.Add(this.buttonHelp_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonSave_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonDone_EIH);
            this.panelTop_EIH.Controls.Add(this.groupBoxInPutData_EIH);
            this.panelTop_EIH.Controls.Add(this.groupBoxTask_EIH);
            this.panelTop_EIH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EIH.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EIH.Name = "panelTop_EIH";
            this.panelTop_EIH.Size = new System.Drawing.Size(1182, 112);
            this.panelTop_EIH.TabIndex = 0;
            this.panelTop_EIH.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_EIH_Paint);
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EIH.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_EIH.Location = new System.Drawing.Point(1039, 21);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(123, 81);
            this.buttonHelp_EIH.TabIndex = 1;
            this.buttonHelp_EIH.Text = "Справка";
            this.buttonHelp_EIH.UseVisualStyleBackColor = false;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            // 
            // buttonSave_EIH
            // 
            this.buttonSave_EIH.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSave_EIH.Location = new System.Drawing.Point(910, 21);
            this.buttonSave_EIH.Name = "buttonSave_EIH";
            this.buttonSave_EIH.Size = new System.Drawing.Size(123, 81);
            this.buttonSave_EIH.TabIndex = 1;
            this.buttonSave_EIH.Text = "Сохранить";
            this.buttonSave_EIH.UseVisualStyleBackColor = false;
            this.buttonSave_EIH.Click += new System.EventHandler(this.buttonSave_EIH_Click);
            // 
            // buttonDone_EIH
            // 
            this.buttonDone_EIH.BackColor = System.Drawing.Color.Green;
            this.buttonDone_EIH.Location = new System.Drawing.Point(781, 21);
            this.buttonDone_EIH.Name = "buttonDone_EIH";
            this.buttonDone_EIH.Size = new System.Drawing.Size(123, 81);
            this.buttonDone_EIH.TabIndex = 1;
            this.buttonDone_EIH.Text = "Выполнить";
            this.buttonDone_EIH.UseVisualStyleBackColor = false;
            this.buttonDone_EIH.Click += new System.EventHandler(this.buttonDone_EIH_Click);
            // 
            // groupBoxInPutData_EIH
            // 
            this.groupBoxInPutData_EIH.Controls.Add(this.labelVarStopStep_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.labelVarStartStep_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.textBoxVarStop_EIH);
            this.groupBoxInPutData_EIH.Controls.Add(this.textBoxVarStart_EIH);
            this.groupBoxInPutData_EIH.Location = new System.Drawing.Point(452, 12);
            this.groupBoxInPutData_EIH.Name = "groupBoxInPutData_EIH";
            this.groupBoxInPutData_EIH.Size = new System.Drawing.Size(323, 90);
            this.groupBoxInPutData_EIH.TabIndex = 0;
            this.groupBoxInPutData_EIH.TabStop = false;
            this.groupBoxInPutData_EIH.Text = "Ввод данных:";
            // 
            // labelVarStopStep_EIH
            // 
            this.labelVarStopStep_EIH.AutoSize = true;
            this.labelVarStopStep_EIH.Location = new System.Drawing.Point(168, 24);
            this.labelVarStopStep_EIH.Name = "labelVarStopStep_EIH";
            this.labelVarStopStep_EIH.Size = new System.Drawing.Size(84, 16);
            this.labelVarStopStep_EIH.TabIndex = 1;
            this.labelVarStopStep_EIH.Text = "Конец шага:";
            // 
            // labelVarStartStep_EIH
            // 
            this.labelVarStartStep_EIH.AutoSize = true;
            this.labelVarStartStep_EIH.Location = new System.Drawing.Point(7, 24);
            this.labelVarStartStep_EIH.Name = "labelVarStartStep_EIH";
            this.labelVarStartStep_EIH.Size = new System.Drawing.Size(83, 16);
            this.labelVarStartStep_EIH.TabIndex = 1;
            this.labelVarStartStep_EIH.Text = "Старт шага:";
            // 
            // textBoxVarStop_EIH
            // 
            this.textBoxVarStop_EIH.Location = new System.Drawing.Point(169, 46);
            this.textBoxVarStop_EIH.Name = "textBoxVarStop_EIH";
            this.textBoxVarStop_EIH.Size = new System.Drawing.Size(148, 22);
            this.textBoxVarStop_EIH.TabIndex = 0;
            // 
            // textBoxVarStart_EIH
            // 
            this.textBoxVarStart_EIH.Location = new System.Drawing.Point(6, 46);
            this.textBoxVarStart_EIH.Name = "textBoxVarStart_EIH";
            this.textBoxVarStart_EIH.Size = new System.Drawing.Size(148, 22);
            this.textBoxVarStart_EIH.TabIndex = 0;
            // 
            // groupBoxTask_EIH
            // 
            this.groupBoxTask_EIH.Controls.Add(this.textBoxTask_EIH);
            this.groupBoxTask_EIH.Location = new System.Drawing.Point(13, 3);
            this.groupBoxTask_EIH.Name = "groupBoxTask_EIH";
            this.groupBoxTask_EIH.Size = new System.Drawing.Size(433, 99);
            this.groupBoxTask_EIH.TabIndex = 0;
            this.groupBoxTask_EIH.TabStop = false;
            this.groupBoxTask_EIH.Text = "Условие:";
            // 
            // textBoxTask_EIH
            // 
            this.textBoxTask_EIH.Location = new System.Drawing.Point(6, 18);
            this.textBoxTask_EIH.Multiline = true;
            this.textBoxTask_EIH.Name = "textBoxTask_EIH";
            this.textBoxTask_EIH.ReadOnly = true;
            this.textBoxTask_EIH.Size = new System.Drawing.Size(421, 75);
            this.textBoxTask_EIH.TabIndex = 0;
            this.textBoxTask_EIH.Text = resources.GetString("textBoxTask_EIH.Text");
            // 
            // panelLeft_EIH
            // 
            this.panelLeft_EIH.Controls.Add(this.groupBoxOutPutData_EIH);
            this.panelLeft_EIH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EIH.Location = new System.Drawing.Point(0, 112);
            this.panelLeft_EIH.Name = "panelLeft_EIH";
            this.panelLeft_EIH.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_EIH.Size = new System.Drawing.Size(332, 541);
            this.panelLeft_EIH.TabIndex = 0;
            // 
            // groupBoxOutPutData_EIH
            // 
            this.groupBoxOutPutData_EIH.Controls.Add(this.textBoxResult_EIH);
            this.groupBoxOutPutData_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_EIH.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPutData_EIH.Name = "groupBoxOutPutData_EIH";
            this.groupBoxOutPutData_EIH.Size = new System.Drawing.Size(322, 531);
            this.groupBoxOutPutData_EIH.TabIndex = 0;
            this.groupBoxOutPutData_EIH.TabStop = false;
            this.groupBoxOutPutData_EIH.Text = "Вывод данных:";
            // 
            // textBoxResult_EIH
            // 
            this.textBoxResult_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_EIH.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_EIH.Multiline = true;
            this.textBoxResult_EIH.Name = "textBoxResult_EIH";
            this.textBoxResult_EIH.ReadOnly = true;
            this.textBoxResult_EIH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_EIH.Size = new System.Drawing.Size(316, 510);
            this.textBoxResult_EIH.TabIndex = 0;
            // 
            // panelRight_EIH
            // 
            this.panelRight_EIH.Controls.Add(this.chartFunction_EIH);
            this.panelRight_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EIH.Location = new System.Drawing.Point(332, 112);
            this.panelRight_EIH.Name = "panelRight_EIH";
            this.panelRight_EIH.Size = new System.Drawing.Size(850, 541);
            this.panelRight_EIH.TabIndex = 0;
            // 
            // chartFunction_EIH
            // 
            chartArea8.Name = "ChartArea1";
            this.chartFunction_EIH.ChartAreas.Add(chartArea8);
            this.chartFunction_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chartFunction_EIH.Legends.Add(legend8);
            this.chartFunction_EIH.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_EIH.Name = "chartFunction_EIH";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartFunction_EIH.Series.Add(series8);
            this.chartFunction_EIH.Size = new System.Drawing.Size(850, 541);
            this.chartFunction_EIH.TabIndex = 1;
            this.chartFunction_EIH.Text = "График функции";
            // 
            // splitterPanel_EIH
            // 
            this.splitterPanel_EIH.Location = new System.Drawing.Point(332, 112);
            this.splitterPanel_EIH.Name = "splitterPanel_EIH";
            this.splitterPanel_EIH.Size = new System.Drawing.Size(3, 541);
            this.splitterPanel_EIH.TabIndex = 1;
            this.splitterPanel_EIH.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.splitterPanel_EIH);
            this.Controls.Add(this.panelRight_EIH);
            this.Controls.Add(this.panelLeft_EIH);
            this.Controls.Add(this.panelTop_EIH);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 3 | Ельмурзаев И.Х.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_EIH.ResumeLayout(false);
            this.groupBoxInPutData_EIH.ResumeLayout(false);
            this.groupBoxInPutData_EIH.PerformLayout();
            this.groupBoxTask_EIH.ResumeLayout(false);
            this.groupBoxTask_EIH.PerformLayout();
            this.panelLeft_EIH.ResumeLayout(false);
            this.groupBoxOutPutData_EIH.ResumeLayout(false);
            this.groupBoxOutPutData_EIH.PerformLayout();
            this.panelRight_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_EIH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EIH;
        private System.Windows.Forms.Panel panelLeft_EIH;
        private System.Windows.Forms.Panel panelRight_EIH;
        private System.Windows.Forms.Splitter splitterPanel_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_EIH;
        private System.Windows.Forms.TextBox textBoxResult_EIH;
        private System.Windows.Forms.GroupBox groupBoxInPutData_EIH;
        private System.Windows.Forms.GroupBox groupBoxTask_EIH;
        private System.Windows.Forms.TextBox textBoxTask_EIH;
        private System.Windows.Forms.Button buttonDone_EIH;
        private System.Windows.Forms.Label labelVarStopStep_EIH;
        private System.Windows.Forms.Label labelVarStartStep_EIH;
        private System.Windows.Forms.TextBox textBoxVarStop_EIH;
        private System.Windows.Forms.TextBox textBoxVarStart_EIH;
        private System.Windows.Forms.Button buttonHelp_EIH;
        private System.Windows.Forms.Button buttonSave_EIH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_EIH;
    }
}

