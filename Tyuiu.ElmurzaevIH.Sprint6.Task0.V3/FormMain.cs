using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ElmurzaevIH.Sprint6.Task0.V3.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonPushMe_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, мир");
        }

        private void textBoxVarX_EIH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInPutData_EIH_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_EIH.Text);
                textBoxResult_EIH.Text = Convert.ToString(ds.Calculate(x));
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void textBoxVarX_EIH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxTask_EIH_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-1 Ельмурзаев Ислам Хаважевич", "Сообщение");
        }
    }
}
