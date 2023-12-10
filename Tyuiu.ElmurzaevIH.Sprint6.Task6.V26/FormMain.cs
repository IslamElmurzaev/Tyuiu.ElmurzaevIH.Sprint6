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
using Tyuiu.ElmurzaevIH.Sprint6.Task6.V26.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_EIH_Click(object sender, EventArgs e)
        {
            openFileDialogTask_EIH.ShowDialog();
            openFilePath = openFileDialogTask_EIH.FileName;
            textBoxInput_EIH.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_EIH.Text = groupBoxOutPut_EIH.Text + " " + openFileDialogTask_EIH.FileName;
            buttonDone_EIH.Enabled = true;

        }

        private void buttonDone_EIH_Click(object sender, EventArgs e)
        {
            textBoxOutPut_EIH.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
