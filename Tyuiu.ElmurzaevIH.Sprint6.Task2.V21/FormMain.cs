using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6.Task2.V21.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task2.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService(); 
        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_EIH.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_EIH.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_EIH.Titles.Add("График функции cos(x) + (cox(x) / (x + 2)) - 3 * x");
                this.chartFunction_EIH.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_EIH.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_EIH.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_EIH.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_EIH_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_EIH.BackColor = Color.Red;
        }

        private void buttonDone_EIH_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_EIH.BackColor = Color.Green;
        }

        private void buttonDone_EIH_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_EIH.BackColor = Color.Blue;
        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение");
        }
    }
}
