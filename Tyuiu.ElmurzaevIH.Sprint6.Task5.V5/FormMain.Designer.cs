namespace Tyuiu.ElmurzaevIH.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_EIH = new System.Windows.Forms.Panel();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.buttonOpen_EIH = new System.Windows.Forms.Button();
            this.buttonDone_EIH = new System.Windows.Forms.Button();
            this.groupBoxTask_EIH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EIH = new System.Windows.Forms.TextBox();
            this.panelLeft_EIH = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_EIH = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_EIH = new System.Windows.Forms.DataGridView();
            this.panelRight_EIH = new System.Windows.Forms.Panel();
            this.chartDiag_EIH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterPanels_EIH = new System.Windows.Forms.Splitter();
            this.panelTop_EIH.SuspendLayout();
            this.groupBoxTask_EIH.SuspendLayout();
            this.panelLeft_EIH.SuspendLayout();
            this.groupBoxOutPut_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_EIH)).BeginInit();
            this.panelRight_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_EIH
            // 
            this.panelTop_EIH.Controls.Add(this.buttonHelp_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonOpen_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonDone_EIH);
            this.panelTop_EIH.Controls.Add(this.groupBoxTask_EIH);
            this.panelTop_EIH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EIH.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EIH.Name = "panelTop_EIH";
            this.panelTop_EIH.Size = new System.Drawing.Size(882, 122);
            this.panelTop_EIH.TabIndex = 0;
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EIH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_EIH.Location = new System.Drawing.Point(771, 11);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(98, 97);
            this.buttonHelp_EIH.TabIndex = 1;
            this.buttonHelp_EIH.Text = "Справка";
            this.buttonHelp_EIH.UseVisualStyleBackColor = false;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            // 
            // buttonOpen_EIH
            // 
            this.buttonOpen_EIH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpen_EIH.Location = new System.Drawing.Point(667, 12);
            this.buttonOpen_EIH.Name = "buttonOpen_EIH";
            this.buttonOpen_EIH.Size = new System.Drawing.Size(98, 97);
            this.buttonOpen_EIH.TabIndex = 1;
            this.buttonOpen_EIH.Text = "Открыть файл";
            this.buttonOpen_EIH.UseVisualStyleBackColor = false;
            this.buttonOpen_EIH.Click += new System.EventHandler(this.buttonOpen_EIH_Click);
            // 
            // buttonDone_EIH
            // 
            this.buttonDone_EIH.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_EIH.Location = new System.Drawing.Point(563, 12);
            this.buttonDone_EIH.Name = "buttonDone_EIH";
            this.buttonDone_EIH.Size = new System.Drawing.Size(98, 97);
            this.buttonDone_EIH.TabIndex = 1;
            this.buttonDone_EIH.Text = "Выполнить";
            this.buttonDone_EIH.UseVisualStyleBackColor = false;
            this.buttonDone_EIH.Click += new System.EventHandler(this.buttonDone_EIH_Click);
            // 
            // groupBoxTask_EIH
            // 
            this.groupBoxTask_EIH.Controls.Add(this.textBoxTask_EIH);
            this.groupBoxTask_EIH.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_EIH.Name = "groupBoxTask_EIH";
            this.groupBoxTask_EIH.Size = new System.Drawing.Size(553, 104);
            this.groupBoxTask_EIH.TabIndex = 0;
            this.groupBoxTask_EIH.TabStop = false;
            this.groupBoxTask_EIH.Text = "Условие:";
            // 
            // textBoxTask_EIH
            // 
            this.textBoxTask_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_EIH.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_EIH.Multiline = true;
            this.textBoxTask_EIH.Name = "textBoxTask_EIH";
            this.textBoxTask_EIH.ReadOnly = true;
            this.textBoxTask_EIH.Size = new System.Drawing.Size(547, 83);
            this.textBoxTask_EIH.TabIndex = 0;
            this.textBoxTask_EIH.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView. Вывести в" +
    "се числа, кратные 2. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_EIH
            // 
            this.panelLeft_EIH.Controls.Add(this.groupBoxOutPut_EIH);
            this.panelLeft_EIH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EIH.Location = new System.Drawing.Point(0, 122);
            this.panelLeft_EIH.Name = "panelLeft_EIH";
            this.panelLeft_EIH.Size = new System.Drawing.Size(207, 431);
            this.panelLeft_EIH.TabIndex = 0;
            // 
            // groupBoxOutPut_EIH
            // 
            this.groupBoxOutPut_EIH.Controls.Add(this.dataGridViewNums_EIH);
            this.groupBoxOutPut_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_EIH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_EIH.Name = "groupBoxOutPut_EIH";
            this.groupBoxOutPut_EIH.Size = new System.Drawing.Size(207, 431);
            this.groupBoxOutPut_EIH.TabIndex = 0;
            this.groupBoxOutPut_EIH.TabStop = false;
            this.groupBoxOutPut_EIH.Text = "Вывод данных:";
            // 
            // dataGridViewNums_EIH
            // 
            this.dataGridViewNums_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_EIH.ColumnHeadersVisible = false;
            this.dataGridViewNums_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_EIH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewNums_EIH.Name = "dataGridViewNums_EIH";
            this.dataGridViewNums_EIH.RowHeadersVisible = false;
            this.dataGridViewNums_EIH.RowHeadersWidth = 51;
            this.dataGridViewNums_EIH.RowTemplate.Height = 24;
            this.dataGridViewNums_EIH.Size = new System.Drawing.Size(201, 410);
            this.dataGridViewNums_EIH.TabIndex = 0;
            this.dataGridViewNums_EIH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNums_EIH_CellContentClick);
            // 
            // panelRight_EIH
            // 
            this.panelRight_EIH.Controls.Add(this.chartDiag_EIH);
            this.panelRight_EIH.Controls.Add(this.splitterPanels_EIH);
            this.panelRight_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_EIH.Location = new System.Drawing.Point(207, 122);
            this.panelRight_EIH.Name = "panelRight_EIH";
            this.panelRight_EIH.Size = new System.Drawing.Size(675, 431);
            this.panelRight_EIH.TabIndex = 0;
            // 
            // chartDiag_EIH
            // 
            chartArea6.Name = "ChartArea1";
            this.chartDiag_EIH.ChartAreas.Add(chartArea6);
            this.chartDiag_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDiag_EIH.Location = new System.Drawing.Point(3, 0);
            this.chartDiag_EIH.Name = "chartDiag_EIH";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.LimeGreen;
            series6.IsVisibleInLegend = false;
            series6.Name = "Series1";
            this.chartDiag_EIH.Series.Add(series6);
            this.chartDiag_EIH.Size = new System.Drawing.Size(672, 431);
            this.chartDiag_EIH.TabIndex = 1;
            this.chartDiag_EIH.Text = "chart1";
            // 
            // splitterPanels_EIH
            // 
            this.splitterPanels_EIH.Location = new System.Drawing.Point(0, 0);
            this.splitterPanels_EIH.Name = "splitterPanels_EIH";
            this.splitterPanels_EIH.Size = new System.Drawing.Size(3, 431);
            this.splitterPanels_EIH.TabIndex = 0;
            this.splitterPanels_EIH.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelRight_EIH);
            this.Controls.Add(this.panelLeft_EIH);
            this.Controls.Add(this.panelTop_EIH);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 5 | Ельмурзаев И.Х.";
            this.panelTop_EIH.ResumeLayout(false);
            this.groupBoxTask_EIH.ResumeLayout(false);
            this.groupBoxTask_EIH.PerformLayout();
            this.panelLeft_EIH.ResumeLayout(false);
            this.groupBoxOutPut_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_EIH)).EndInit();
            this.panelRight_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_EIH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EIH;
        private System.Windows.Forms.Panel panelLeft_EIH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_EIH;
        private System.Windows.Forms.Panel panelRight_EIH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_EIH;
        private System.Windows.Forms.Splitter splitterPanels_EIH;
        private System.Windows.Forms.GroupBox groupBoxTask_EIH;
        private System.Windows.Forms.TextBox textBoxTask_EIH;
        private System.Windows.Forms.DataGridView dataGridViewNums_EIH;
        private System.Windows.Forms.Button buttonDone_EIH;
        private System.Windows.Forms.Button buttonHelp_EIH;
        private System.Windows.Forms.Button buttonOpen_EIH;
    }
}

