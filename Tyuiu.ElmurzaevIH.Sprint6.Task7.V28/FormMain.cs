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
using Tyuiu.ElmurzaevIH.Sprint6.Task7.V28.Lib;
namespace Tyuiu.ElmurzaevIH.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_EIH.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_EIH.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filepath)
        {
            string fileData = File.ReadAllText(filepath); // читаем данные из файла

            // Разделяем на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Определение кол-ва строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Создание массива необходимой длинны
            int[,] arrayValues = new int[rows, columns];

            // Заполнение массива
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_EIH_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_EIH.ShowDialog();
                openFilePath = openFileDialogTask_EIH.FileName;

                int[,] arrayValues = new int[rows, columns];

                arrayValues = LoadFromFileData(openFilePath);

                dataGridViewIn_EIH.ColumnCount = columns;
                dataGridViewIn_EIH.RowCount = rows;
                dataGridViewOut_EIH.ColumnCount = columns;
                dataGridViewOut_EIH.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_EIH.Columns[i].Width = 40;
                    dataGridViewOut_EIH.Columns[i].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewIn_EIH.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDo_EIH.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите файл!", "Пожалуйста!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonDo_EIH_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_EIH.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_EIH.Enabled = true;
        }

        private void buttonSaveFile_EIH_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_EIH.FileName = "OutPutFileTask7V28.csv";
            saveFileDialogTask_EIH.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_EIH.ShowDialog();

            string path = saveFileDialogTask_EIH.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_EIH.RowCount;
            int columns = dataGridViewOut_EIH.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_EIH.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_EIH.Rows[i].Cells[j].Value;
                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_EIH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_EIH.ToolTipTitle = "Открыть файл";
        }

        private void buttonDo_EIH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_EIH.ToolTipTitle = "Выполнить";

        }

        private void buttonSaveFile_EIH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_EIH.ToolTipTitle = "Сохранить в файл";

        }

        private void buttonHelp_EIH_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_EIH.ToolTipTitle = "Справка";

        }

        private void buttonHelp_EIH_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
