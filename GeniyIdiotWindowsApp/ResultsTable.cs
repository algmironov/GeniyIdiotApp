using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeniyIdiotApp.Common;

namespace GeniyIdiotWindowsApp
{
    public partial class resultsTable1 : Form
    {
        List<List<string>> results = ResultStorage.GetAllResults();
        List<Result> allResults = ResultStorage.GetListOfResults();
        public resultsTable1()
        {
            InitializeComponent();
            CreateTable();

        }

        private void CreateTable()
        {
            string[][] stringsrows = new string[results.Count][];
            int i = 0;
            if (results.Count > 0)
            {
                foreach (List<string> s in results)
                {
                    dataGridView1.Rows.Add(new string[] { s[0], s[1], s[2] });
                }

            }


            dataGridView1.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить все результаты?", "Все результаты будут удалены", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                ResultStorage.ClearResults();
                results = ResultStorage.GetAllResults();
                CreateTable();
            }


        }

        private void removeLine_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление записи", MessageBoxButtons.OKCancel);
            int index = 0;
            if (dialogResult == DialogResult.OK)
            {
                index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
            }
            Result resultToRemove = allResults[index];
            ResultStorage.RemoveChoosenResult(resultToRemove);
            allResults = ResultStorage.GetListOfResults();
            dataGridView1.Update();

        }

        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
