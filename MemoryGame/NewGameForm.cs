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

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameForm newForm = new GameForm(5, horSize, vertSize);
            newForm.Show();
            this.Hide();
        }

        private void NewTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void TimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void HSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void VSizeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void HSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            horSize = Convert.ToInt32(HSizeTextBox.Text);
        }

        private void VSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            vertSize = Convert.ToInt32(VSizeTextBox.Text);
        }
    }
}

