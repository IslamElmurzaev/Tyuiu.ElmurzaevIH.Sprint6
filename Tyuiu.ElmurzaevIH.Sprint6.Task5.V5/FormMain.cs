using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6.Task5.V5.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V5.txt";
        
        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            dataGridViewNums_EIH.ColumnCount = 2;
            dataGridViewNums_EIH.Columns[0].Width = 20;
            dataGridViewNums_EIH.Columns[1].Width = 50;

            this.chartDiag_EIH.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_EIH.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_EIH.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_EIH.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_EIH.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_EIH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewNums_EIH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
