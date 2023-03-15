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
        public resultsTable1()
        {
            InitializeComponent();
            CreateTable();

        }

        private void CreateTable()
        {
            //ListView listView1 = new ListView();
            //listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.Columns.Add("Имя", -2, HorizontalAlignment.Center).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView1.Columns.Add("Результат", -2, HorizontalAlignment.Center).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView1.Columns.Add("Диагноз", -2, HorizontalAlignment.Center).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            //foreach (var item in results)
            //{
            //    listView1.Items.Add(new ListViewItem(new string[] { item[0], item[1], item[2] }));
            //}

            //this.Controls.Add(listView1);

            List<string[]> data = new List<string[]>();
            foreach (var item in results)
            {
                data.Add(new string[] { item[0], item[1], item[2] });

            }
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
