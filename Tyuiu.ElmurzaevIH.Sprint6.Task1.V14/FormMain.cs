using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6.Task1.V14.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task1.V14
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_EIH.Text = "";
                textBoxResult_EIH.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxResult_EIH.AppendText("|    X     |   f(x)      |" + Environment.NewLine);
                textBoxResult_EIH.AppendText("+-----------+------------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1, 6:f2}    | ", startStep, valueArray[i]);
                    Console.WriteLine(strLine);
                    textBoxResult_EIH.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_EIH.AppendText("+-----------+------------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMessage_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение");
        }
    }
}
