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
    public partial class NewGameForm : Form
    {
        int time = 5;
        int horSize = 2;
        int vertSize = 2;
        int lvl = 1;

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                lvl = Convert.ToInt32(LvlTextBox.Text);
                time = Convert.ToInt32(TimeTextBox.Text);
                horSize = Convert.ToInt32(HSizeTextBox.Text);
                vertSize = Convert.ToInt32(VSizeTextBox.Text);
                GameForm newForm = new GameForm(time, horSize, vertSize, lvl);
                newForm.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show($"Please input valid values!");
            }   
        }

        private void NewTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }
    }    
}

