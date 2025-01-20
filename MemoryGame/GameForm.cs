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

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        private int time = 0;
        private int rows = 0;
        private int cols = 0;
        private Button[,] buttonGrid;
        private PictureBox[,] pictureGrid;
        private int[][] matrix;
        /*
        [DllImport("MemoryDll.dll", CallingConvention = CallingConvention.Cdecl)]
        private static unsafe extern void fillMatrix(IntPtr[] matrix, int n, int m);

        [DllImport("MemoryDll.dll", CallingConvention = CallingConvention.Cdecl)]
        private static unsafe extern void matrixEnd(IntPtr[] matrix, int n, int m, int lvl);

        private unsafe int[][] fillMatrixSharp(int n, int m)
        {
            int[][] matrix = new int[n][];

            IntPtr[] ptrArray = new IntPtr[n];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[m];
                ptrArray[i] = Marshal.AllocHGlobal(m * sizeof(int));
            }

            fillMatrix(ptrArray, n, m);
            matrixEnd(ptrArray, n, m, 3);

            for (int i = 0; i < n; i++)
            {
                Marshal.Copy(ptrArray[i], matrix[i], 0, m);
                Marshal.FreeHGlobal(ptrArray[i]); // Освобождаем память
            }

            return matrix;
        }*/

        public GameForm(int time, int rows, int cols)
        {
            InitializeComponent();
            this.time = time;
            this.rows = rows;
            this.cols = cols;

            label1.Text = time.ToString();
            label2.Text = rows.ToString();
            label3.Text = cols.ToString();

            int buttonSize = 50; // Размер кнопок
            int spacing = 5;     // Отступы между кнопками

            // Устанавливаем размер формы в зависимости от количества кнопок
            this.ClientSize = new Size(cols * (buttonSize + spacing) + 20, rows * (buttonSize + spacing) + 50);
            TableLayoutPanel.Size = new Size(cols * (buttonSize + spacing), rows * (buttonSize + spacing));
            TablePicturePanel.Size = new Size(cols * (buttonSize + spacing), rows * (buttonSize + spacing));

            TableLayoutPanel.ColumnCount = cols;
            TableLayoutPanel.RowCount = rows;

            TablePicturePanel.ColumnCount = cols;
            TablePicturePanel.RowCount = rows;

            //matrix = fillMatrixSharp(cols, rows);

            matrix = new int[cols][];
            for (int i = 0; i < cols; i++)
            {
                matrix[i] = new int[rows];
            }
            for (int i = 0; i < cols; i++) {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i][j] = 1;
                }
            }

            GeneratePictureTable(cols, rows);

            GenerateButtonTable(cols, rows);

            TableLayoutPanel.Hide();

            TablePicturePanel.Visible = false;

        }

        private void GeneratePictureTable(int rows, int cols)
        {
            int buttonSize = 50;
            int spacing = 5;

            pictureGrid = new PictureBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    pictureGrid[i, j] = new PictureBox();
                    //pictureGrid[i, j].FlatStyle = FlatStyle.Flat;
                    pictureGrid[i, j].Size = new Size(buttonSize, buttonSize);
                    pictureGrid[i, j].Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));

                    if (matrix[i][j] == -1)
                    {
                        //pictureGrid[i, j].Image = global::MemoryGame.Properties.Resources.circle;
                    }
                    else
                    {
                        //pictureGrid[i, j].Text = $"{matrix[i][j]}";
                    }
                    pictureGrid[i, j].Tag = new Tuple<int, int>(i, j);
                    pictureGrid[i, j].Click += Button_Click;

                    TablePicturePanel.Controls.Add(pictureGrid[i, j]);
                }
            }
        }

        private void GenerateButtonTable(int rows, int cols)
        {
            int buttonSize = 50;
            int spacing = 5;

            buttonGrid = new Button[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    buttonGrid[i, j] = new Button();
                    buttonGrid[i, j].FlatStyle = FlatStyle.Flat;
                    buttonGrid[i, j].Size = new Size(buttonSize, buttonSize);
                    buttonGrid[i, j].Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));

                    if (matrix[i][j] == -1)
                    {
                        //buttonGrid[i, j].Image = global::MemoryGame.Properties.Resources.circle;
                    }
                    else
                    {
                        buttonGrid[i, j].Text = $"{matrix[i][j]}";
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
                MessageBox.Show($"{matrix[row][col]}");
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
            TablePicturePanel.Visible = true;

            await Task.Delay(time * 1000);
            TablePicturePanel.Visible = false;
            TableLayoutPanel.Show();
        }
    }
}
