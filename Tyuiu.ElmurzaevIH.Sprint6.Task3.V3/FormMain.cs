using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6.Task3.V3.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5,5] { { -18, 21, 10, -2, 12 }, { -18, -10, 33, -20, 32 }, { 14, -15, -14, 12, -18 }, { -19, 5, -3, 28, -17 }, { -14, -9, 23, -13, 11 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridViewMatrix_EIH.ColumnCount = cols;
            dataGridViewMatrix_EIH.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_EIH.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows ; i++)
            {
                for (int j = 0; j < cols ; j++)
                {
                    dataGridViewMatrix_EIH.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            int[,] resMtrx = ds.Calculate(mtrx);

            int rows = resMtrx.GetUpperBound(0) + 1;
            int cols = resMtrx.Length / rows;

            dataGridViewResultMatrix_EIH.ColumnCount = cols;
            dataGridViewResultMatrix_EIH.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewResultMatrix_EIH.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResultMatrix_EIH.Rows[i].Cells[j].Value = Convert.ToString(resMtrx[i, j]);
                }
            }
        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение");
        }
    }
}
