using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void NewTestButton_Click(object sender, EventArgs e)
        {
            NewGameForm newForm = new NewGameForm();
            newForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm newForm = new StatisticsForm();
            newForm.Show();
            this.Hide();
        }
    }
}
