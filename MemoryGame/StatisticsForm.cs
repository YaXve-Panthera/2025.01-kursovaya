using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            CreateTable();
        }

        private void CreateTable()
        {
            StatisticsDataGridView.Dock = DockStyle.Fill; 
            StatisticsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            StatisticsDataGridView.Columns.Add("col1", "Date and time");
            StatisticsDataGridView.Columns.Add("col2", "Field size");
            StatisticsDataGridView.Columns.Add("col3", "Games");
            StatisticsDataGridView.Columns.Add("col4", "Wins");
            StatisticsDataGridView.Columns.Add("col5", "Loses");
            StatisticsDataGridView.Columns.Add("col6", "Record");

            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\data\\");
            foreach (string s in files)
            {
                string[] fileText = File.ReadAllLines(s);
                StatisticsDataGridView.Rows.Add(fileText[0], fileText[1] + "x" + fileText[2],
                    fileText[3], fileText[4], fileText[5], fileText[6]);
            }
        }

        private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }
}
