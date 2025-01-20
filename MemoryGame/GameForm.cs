using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryWrapper;


namespace MemoryGame
{
    public partial class GameForm : Form
    {
        private int time = 0;
        private int rows = 0;
        private int cols = 0;
        private Button[,] buttonGrid;
        private PictureBox[,] pictureGrid;
        private int[,] matrix;
        private ManagedGame game;

        public GameForm(int time, int cols, int rows, int startlvl)
        {
            InitializeComponent();
            this.time = time;
            this.rows = rows;
            this.cols = cols;

            int buttonSize = 50; // Размер кнопок
            int spacing = 5;     // Отступы между кнопками

            // Устанавливаем размер формы в зависимости от количества кнопок
            this.ClientSize = new Size(Math.Max(cols * (buttonSize + spacing) + 20, 350), rows * (buttonSize + spacing) + 50);
            TableLayoutPanel.Size = new Size(cols * (buttonSize + spacing), rows * (buttonSize + spacing));
            TablePicturePanel.Size = new Size(cols * (buttonSize + spacing), rows * (buttonSize + spacing));
            

            TableLayoutPanel.ColumnCount = cols;
            TableLayoutPanel.RowCount = rows;

            TablePicturePanel.ColumnCount = cols;
            TablePicturePanel.RowCount = rows;

            game = new ManagedGame(rows, cols, startlvl);
            game.CreateMatrix();
            game.SetGameState(0);
            matrix = game.GetMatrix();

            label1.Text = $"Time: {time}";
            label2.Text = $"Size: {rows}x{cols}";
            label3.Text = $"Lvl: {game.GetLvl()}";
            label4.Text = $"Remains: {game.GetCurrent()}";

            TableLayoutPanel.Hide();

            TablePicturePanel.Hide();
        }

        void StartGame()
        {
            game.StartGame();
            matrix = game.GetMatrix();

            label3.Text = $"Lvl: {game.GetLvl()}";
            label4.Text = $"Remains: {game.GetCurrent()}";

            GeneratePictureTable(rows, cols);
            GenerateButtonTable(rows, cols);

            TableLayoutPanel.Hide();

            StartButton.Visible = false;
            TablePicturePanel.Visible = true;
            printMatrix();
        }

        void printMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }   
        }

        void WinGame()
        {
            TablePicturePanel.Controls.Clear();
            TableLayoutPanel.Controls.Clear();
            StartButton.Visible = true;
        }

        void LoseGame()
        {
            TablePicturePanel.Controls.Clear();
            TableLayoutPanel.Controls.Clear();
            StartButton.Visible = true;
        }

        private void GeneratePictureTable(int rows, int cols)
        {
            int buttonSize = 50;
            int spacing = 5;

            TablePicturePanel.Controls.Clear();
            pictureGrid = new PictureBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    pictureGrid[i, j] = new PictureBox();
                    //pictureGrid[i, j].FlatStyle = FlatStyle.Flat;
                    pictureGrid[i, j].Size = new Size(buttonSize, buttonSize);
                    pictureGrid[i, j].Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));

                    if (matrix[i,j] == -1)
                    {
                        pictureGrid[i, j].Image = global::MemoryGame.Properties.Resources.circle;
                    }
                    else
                    {
                        //pictureGrid[i, j].Text = $"{matrix[i][j]}";
                    }
                    pictureGrid[i, j].Tag = new Tuple<int, int>(i, j);
                    //pictureGrid[i, j].Click += Button_Click;

                    TablePicturePanel.Controls.Add(pictureGrid[i, j]);
                }
            }
        }

        private void GenerateButtonTable(int rows, int cols)
        {
            int buttonSize = 50;
            int spacing = 5;

            TableLayoutPanel.Controls.Clear();
            buttonGrid = new Button[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    buttonGrid[i, j] = new Button();
                    buttonGrid[i, j].FlatStyle = FlatStyle.Flat;
                    buttonGrid[i, j].Size = new Size(buttonSize, buttonSize);
                    buttonGrid[i, j].Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));

                    if (matrix[i,j] == -1)
                    {
                        //buttonGrid[i, j].Image = global::MemoryGame.Properties.Resources.circle;
                    }
                    else
                    {
                        //buttonGrid[i, j].Text = $"{matrix[i,j]}";
                    }
                    buttonGrid[i, j].Tag = new Tuple<int, int>(i, j);
                    buttonGrid[i, j].Click += Button_Click;

                    TableLayoutPanel.Controls.Add(buttonGrid[i, j]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag is Tuple<int, int> position)
            {
                int row = position.Item1;
                int col = position.Item2;
                bool res = game.CheckCell(row, col);


                if (res) {
                    btn.Image = global::MemoryGame.Properties.Resources.circle;
                    matrix[row, col] = -2;
                    game.SetValue(row, col, -2);
                    label4.Text = $"Remains: {game.GetCurrent()}";
                }

                if (game.GetGameState() == 2)
                {
                    WinGame();
                    MessageBox.Show($"Win!");
                }

                if (game.GetGameState() == 3)
                {
                    WinGame();
                    MessageBox.Show($"Absolute Win!");
                }

                if (game.GetGameState() == -1)
                {
                    LoseGame();
                    MessageBox.Show($"Lose :(");
                }

                if (game.GetGameState() == -2)
                {
                    LoseGame();
                    MessageBox.Show($"Absolute lose :((");
                }

                //MessageBox.Show($"{matrix[row, col]}  {res} {game.GetValue(row, col)}");
            }
        }

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual;
            ifrm.Left = this.Left;
            ifrm.Top = this.Top;
            ifrm.Show();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void TestForm_Shown(object sender, EventArgs e)
        {

        }

        private void TestForm_Activated(object sender, EventArgs e)
        {

        }

        async private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
            
            await Task.Delay(time * 1000);

            TablePicturePanel.Visible = false;
            TableLayoutPanel.Show();
        }
    }
}
