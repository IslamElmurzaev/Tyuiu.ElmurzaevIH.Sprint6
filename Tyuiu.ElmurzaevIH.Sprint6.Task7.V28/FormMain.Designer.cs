namespace Tyuiu.ElmurzaevIH.Sprint6.Task7.V28
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_EIH = new System.Windows.Forms.Panel();
            this.groupBoxTask_EIH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_EIH = new System.Windows.Forms.TextBox();
            this.buttonHelp_EIH = new System.Windows.Forms.Button();
            this.buttonSaveFile_EIH = new System.Windows.Forms.Button();
            this.buttonDo_EIH = new System.Windows.Forms.Button();
            this.buttonOpenFile_EIH = new System.Windows.Forms.Button();
            this.panelLeft_EIH = new System.Windows.Forms.Panel();
            this.groupBoxIn_EIH = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_EIH = new System.Windows.Forms.DataGridView();
            this.panelRight_EIH = new System.Windows.Forms.Panel();
            this.groupBoxOut_EIH = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_EIH = new System.Windows.Forms.DataGridView();
            this.splitterPanels_EIH = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_EIH = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_EIH = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_EIH = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_EIH.SuspendLayout();
            this.groupBoxTask_EIH.SuspendLayout();
            this.panelLeft_EIH.SuspendLayout();
            this.groupBoxIn_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_EIH)).BeginInit();
            this.panelRight_EIH.SuspendLayout();
            this.groupBoxOut_EIH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_EIH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_EIH
            // 
            this.panelTop_EIH.Controls.Add(this.groupBoxTask_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonHelp_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonSaveFile_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonDo_EIH);
            this.panelTop_EIH.Controls.Add(this.buttonOpenFile_EIH);
            this.panelTop_EIH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_EIH.Location = new System.Drawing.Point(0, 0);
            this.panelTop_EIH.Name = "panelTop_EIH";
            this.panelTop_EIH.Size = new System.Drawing.Size(882, 191);
            this.panelTop_EIH.TabIndex = 0;
            // 
            // groupBoxTask_EIH
            // 
            this.groupBoxTask_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_EIH.Controls.Add(this.textBoxTask_EIH);
            this.groupBoxTask_EIH.Location = new System.Drawing.Point(12, 76);
            this.groupBoxTask_EIH.Name = "groupBoxTask_EIH";
            this.groupBoxTask_EIH.Size = new System.Drawing.Size(858, 109);
            this.groupBoxTask_EIH.TabIndex = 1;
            this.groupBoxTask_EIH.TabStop = false;
            this.groupBoxTask_EIH.Text = "Условие:";
            // 
            // textBoxTask_EIH
            // 
            this.textBoxTask_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_EIH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTask_EIH.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_EIH.Multiline = true;
            this.textBoxTask_EIH.Name = "textBoxTask_EIH";
            this.textBoxTask_EIH.ReadOnly = true;
            this.textBoxTask_EIH.Size = new System.Drawing.Size(849, 85);
            this.textBoxTask_EIH.TabIndex = 0;
            this.textBoxTask_EIH.Text = resources.GetString("textBoxTask_EIH.Text");
            // 
            // buttonHelp_EIH
            // 
            this.buttonHelp_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_EIH.Image")));
            this.buttonHelp_EIH.Location = new System.Drawing.Point(759, 12);
            this.buttonHelp_EIH.Name = "buttonHelp_EIH";
            this.buttonHelp_EIH.Size = new System.Drawing.Size(111, 58);
            this.buttonHelp_EIH.TabIndex = 0;
            this.toolTipButton_EIH.SetToolTip(this.buttonHelp_EIH, "Сведения о программе");
            this.buttonHelp_EIH.UseVisualStyleBackColor = true;
            this.buttonHelp_EIH.Click += new System.EventHandler(this.buttonHelp_EIH_Click);
            this.buttonHelp_EIH.MouseEnter += new System.EventHandler(this.buttonHelp_EIH_MouseEnter);
            // 
            // buttonSaveFile_EIH
            // 
            this.buttonSaveFile_EIH.Enabled = false;
            this.buttonSaveFile_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_EIH.Image")));
            this.buttonSaveFile_EIH.Location = new System.Drawing.Point(246, 12);
            this.buttonSaveFile_EIH.Name = "buttonSaveFile_EIH";
            this.buttonSaveFile_EIH.Size = new System.Drawing.Size(111, 58);
            this.buttonSaveFile_EIH.TabIndex = 0;
            this.buttonSaveFile_EIH.UseVisualStyleBackColor = true;
            this.buttonSaveFile_EIH.Click += new System.EventHandler(this.buttonSaveFile_EIH_Click);
            this.buttonSaveFile_EIH.MouseEnter += new System.EventHandler(this.buttonSaveFile_EIH_MouseEnter);
            // 
            // buttonDo_EIH
            // 
            this.buttonDo_EIH.Enabled = false;
            this.buttonDo_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDo_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonDo_EIH.Image")));
            this.buttonDo_EIH.Location = new System.Drawing.Point(129, 12);
            this.buttonDo_EIH.Name = "buttonDo_EIH";
            this.buttonDo_EIH.Size = new System.Drawing.Size(111, 58);
            this.buttonDo_EIH.TabIndex = 0;
            this.toolTipButton_EIH.SetToolTip(this.buttonDo_EIH, "Выполнить обработку данных\r\n");
            this.buttonDo_EIH.UseVisualStyleBackColor = true;
            this.buttonDo_EIH.Click += new System.EventHandler(this.buttonDo_EIH_Click);
            this.buttonDo_EIH.MouseEnter += new System.EventHandler(this.buttonDo_EIH_MouseEnter);
            // 
            // buttonOpenFile_EIH
            // 
            this.buttonOpenFile_EIH.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_EIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_EIH.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_EIH.Image")));
            this.buttonOpenFile_EIH.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_EIH.Name = "buttonOpenFile_EIH";
            this.buttonOpenFile_EIH.Size = new System.Drawing.Size(111, 58);
            this.buttonOpenFile_EIH.TabIndex = 0;
            this.toolTipButton_EIH.SetToolTip(this.buttonOpenFile_EIH, "Открыть файл для обработки данных в формате CSV\r\n");
            this.buttonOpenFile_EIH.UseVisualStyleBackColor = false;
            this.buttonOpenFile_EIH.Click += new System.EventHandler(this.buttonOpenFile_EIH_Click);
            this.buttonOpenFile_EIH.MouseEnter += new System.EventHandler(this.buttonOpenFile_EIH_MouseEnter);
            // 
            // panelLeft_EIH
            // 
            this.panelLeft_EIH.Controls.Add(this.groupBoxIn_EIH);
            this.panelLeft_EIH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_EIH.Location = new System.Drawing.Point(0, 191);
            this.panelLeft_EIH.Name = "panelLeft_EIH";
            this.panelLeft_EIH.Size = new System.Drawing.Size(406, 397);
            this.panelLeft_EIH.TabIndex = 0;
            // 
            // groupBoxIn_EIH
            // 
            this.groupBoxIn_EIH.Controls.Add(this.dataGridViewIn_EIH);
            this.groupBoxIn_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_EIH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_EIH.Name = "groupBoxIn_EIH";
            this.groupBoxIn_EIH.Size = new System.Drawing.Size(406, 397);
            this.groupBoxIn_EIH.TabIndex = 1;
            this.groupBoxIn_EIH.TabStop = false;
            this.groupBoxIn_EIH.Text = "Ввод:";
            // 
            // dataGridViewIn_EIH
            // 
            this.dataGridViewIn_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_EIH.ColumnHeadersVisible = false;
            this.dataGridViewIn_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_EIH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_EIH.Name = "dataGridViewIn_EIH";
            this.dataGridViewIn_EIH.RowHeadersVisible = false;
            this.dataGridViewIn_EIH.RowHeadersWidth = 51;
            this.dataGridViewIn_EIH.RowTemplate.Height = 24;
            this.dataGridViewIn_EIH.Size = new System.Drawing.Size(400, 376);
            this.dataGridViewIn_EIH.TabIndex = 0;
            // 
            // panelRight_EIH
            // 
            this.panelRight_EIH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight_EIH.Controls.Add(this.groupBoxOut_EIH);
            this.panelRight_EIH.Location = new System.Drawing.Point(409, 191);
            this.panelRight_EIH.Name = "panelRight_EIH";
            this.panelRight_EIH.Size = new System.Drawing.Size(473, 397);
            this.panelRight_EIH.TabIndex = 1;
            // 
            // groupBoxOut_EIH
            // 
            this.groupBoxOut_EIH.Controls.Add(this.dataGridViewOut_EIH);
            this.groupBoxOut_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_EIH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_EIH.Name = "groupBoxOut_EIH";
            this.groupBoxOut_EIH.Size = new System.Drawing.Size(473, 397);
            this.groupBoxOut_EIH.TabIndex = 1;
            this.groupBoxOut_EIH.TabStop = false;
            this.groupBoxOut_EIH.Text = "Вывод:";
            // 
            // dataGridViewOut_EIH
            // 
            this.dataGridViewOut_EIH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_EIH.ColumnHeadersVisible = false;
            this.dataGridViewOut_EIH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_EIH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_EIH.Name = "dataGridViewOut_EIH";
            this.dataGridViewOut_EIH.RowHeadersVisible = false;
            this.dataGridViewOut_EIH.RowHeadersWidth = 51;
            this.dataGridViewOut_EIH.RowTemplate.Height = 24;
            this.dataGridViewOut_EIH.Size = new System.Drawing.Size(467, 376);
            this.dataGridViewOut_EIH.TabIndex = 0;
            // 
            // splitterPanels_EIH
            // 
            this.splitterPanels_EIH.Location = new System.Drawing.Point(406, 191);
            this.splitterPanels_EIH.Name = "splitterPanels_EIH";
            this.splitterPanels_EIH.Size = new System.Drawing.Size(3, 397);
            this.splitterPanels_EIH.TabIndex = 2;
            this.splitterPanels_EIH.TabStop = false;
            // 
            // openFileDialogTask_EIH
            // 
            this.openFileDialogTask_EIH.FileName = "openFileDialog1";
            // 
            // toolTipButton_EIH
            // 
            this.toolTipButton_EIH.IsBalloon = true;
            this.toolTipButton_EIH.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 588);
            this.Controls.Add(this.splitterPanels_EIH);
            this.Controls.Add(this.panelRight_EIH);
            this.Controls.Add(this.panelLeft_EIH);
            this.Controls.Add(this.panelTop_EIH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(900, 635);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Ельмурзаев И.Х.";
            this.panelTop_EIH.ResumeLayout(false);
            this.groupBoxTask_EIH.ResumeLayout(false);
            this.groupBoxTask_EIH.PerformLayout();
            this.panelLeft_EIH.ResumeLayout(false);
            this.groupBoxIn_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_EIH)).EndInit();
            this.panelRight_EIH.ResumeLayout(false);
            this.groupBoxOut_EIH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_EIH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_EIH;
        private System.Windows.Forms.Panel panelLeft_EIH;
        private System.Windows.Forms.Panel panelRight_EIH;
        private System.Windows.Forms.Splitter splitterPanels_EIH;
        private System.Windows.Forms.Button buttonHelp_EIH;
        private System.Windows.Forms.Button buttonSaveFile_EIH;
        private System.Windows.Forms.Button buttonDo_EIH;
        private System.Windows.Forms.Button buttonOpenFile_EIH;
        private System.Windows.Forms.GroupBox groupBoxIn_EIH;
        private System.Windows.Forms.GroupBox groupBoxTask_EIH;
        private System.Windows.Forms.DataGridView dataGridViewIn_EIH;
        private System.Windows.Forms.GroupBox groupBoxOut_EIH;
        private System.Windows.Forms.DataGridView dataGridViewOut_EIH;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_EIH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_EIH;
        private System.Windows.Forms.ToolTip toolTipButton_EIH;
        private System.Windows.Forms.TextBox textBoxTask_EIH;
    }
}

