using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6Review.V29.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6Review.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        Random random = new Random();

        int rows;
        int cols;

        int[,] mtrx;

        int leftBorder;
        int rightBorder;

        int firstNum;
        int lastNum;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            
            
            int R = Convert.ToInt32(textBoxValueR_EIH.Text);

            leftBorder = Convert.ToInt32(textBoxLeftBorder_EIH.Text);
            rightBorder = Convert.ToInt32(textBoxRightBorder_EIH.Text);

            if (leftBorder < rightBorder && R < rows)
            {
                textBoxResult_EIH.Text = Convert.ToString(ds.GetMatrix(mtrx, R, leftBorder, rightBorder));
            }            
        }

        private void buttonSetMatrix_EIH_Click(object sender, EventArgs e)
        {
            try
            {
                rows = Convert.ToInt32(textBoxSetRows_EIH.Text);
                cols = Convert.ToInt32(textBoxSetCols_EIH.Text);


                firstNum = Convert.ToInt32(textBoxValueFirstNum_EIH.Text);
                lastNum = Convert.ToInt32(textBoxValueLastNum_EIH.Text);


                mtrx = new int[rows, cols];

                if (firstNum < lastNum)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = random.Next(firstNum, lastNum + 1);
                        for (int i = 0; i < rows; i++)
                        {
                            mtrx[i, j] = value;
                            value++;
                        }
                    }

                    dataGridViewMatrix_EIH.ColumnCount = cols;
                    dataGridViewMatrix_EIH.RowCount = rows;

                    for (int i = 0; i < cols; i++)
                    {
                        dataGridViewMatrix_EIH.Columns[i].Width = 25;
                    }

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewMatrix_EIH.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                        }
                    }

                }
            } catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonhelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SprintReview выполнил студент ИИПб-23-1 Ельмурзаев И.Х", "Сообщение");
        }
    }
}
