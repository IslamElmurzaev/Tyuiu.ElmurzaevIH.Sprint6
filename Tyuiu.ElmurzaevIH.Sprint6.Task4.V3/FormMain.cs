using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ElmurzaevIH.Sprint6.Task4.V3.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_EIH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_EIH.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_EIH.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_EIH.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_EIH.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_EIH.Text = "";

                chartFunction_EIH.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_EIH.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_EIH.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_EIH_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";
                File.WriteAllText(path, textBoxResult_EIH.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение");
        }
    }
}
