using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        string[,] puzzle = new string[9, 9];

        public Form1()
        {
            InitializeComponent();
            int puzzleToPlay = new Random().Next(1, 2 + 1);
            if (puzzleToPlay == 1)
            {
                createPuzzle1();
            }
            else {
                createPuzzle2();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            line.DrawLine(pen, 151, 123, 339, 123);
            line.DrawLine(pen, 151, 186, 339, 186);
            line.DrawLine(pen, 213, 61, 213, 249);
            line.DrawLine(pen, 276, 61, 276, 249);
            line.Dispose();
        }

        private void position22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPuzzle1() {
            m0Position01.Text = "2";
            m0Position01.Enabled = false;

            m0Position10.Text = "4";
            m0Position10.Enabled = false;

            m0Position21.Text = "7";
            m0Position21.Enabled = false;

            m1Position20.Text = "4";
            m1Position20.Enabled = false;

            m1Position21.Text = "6";
            m1Position21.Enabled = false;

            m1Position22.Text = "8";
            m1Position22.Enabled = false;

            m2Position00.Text = "6";
            m2Position00.Enabled = false;

            m2Position22.Text = "3";
            m2Position22.Enabled = false;

            m3Position00.Text = "6";
            m3Position00.Enabled = false;

            m3Position10.Text = "2";
            m3Position10.Enabled = false;

            m3Position21.Text = "4";
            m3Position21.Enabled = false;

            m3Position22.Text = "8";
            m3Position22.Enabled = false;

            m4Position01.Text = "8";
            m4Position01.Enabled = false;

            m4Position12.Text = "6";
            m4Position12.Enabled = false;

            m4Position22.Text = "5";
            m4Position22.Enabled = false;

            m5Position01.Text = "9";
            m5Position01.Enabled = false;

            m5Position10.Text = "3";
            m5Position10.Enabled = false;

            m5Position12.Text = "5";
            m5Position12.Enabled = false;

            m5Position20.Text = "7";
            m5Position20.Enabled = false;

            m6Position00.Text = "8";
            m6Position00.Enabled = false;

            m6Position01.Text = "5";
            m6Position01.Enabled = false;

            m7Position01.Text = "9";
            m7Position01.Enabled = false;

            m7Position02.Text = "7";
            m7Position02.Enabled = false;

            m7Position11.Text = "5";
            m7Position11.Enabled = false;

            m7Position12.Text = "4";
            m7Position12.Enabled = false;

            m7Position20.Text = "8";
            m7Position20.Enabled = false;

            m7Position21.Text = "1";
            m7Position21.Enabled = false;

            m8Position02.Text = "6";
            m8Position02.Enabled = false;

            m8Position12.Text = "2";
            m8Position12.Enabled = false;

            m8Position21.Text = "5";
            m8Position21.Enabled = false;

            m8Position22.Text = "9";
            m8Position22.Enabled = false;
        }

        private void createPuzzle2() {
            m0Position01.Text = "7";
            m0Position01.Enabled = false;

            m0Position10.Text = "6";
            m0Position10.Enabled = false;

            m1Position00.Text = "6";
            m1Position00.Enabled = false;

            m1Position11.Text = "9";
            m1Position11.Enabled = false;

            m1Position20.Text = "8";
            m1Position20.Enabled = false;

            m1Position21.Text = "4";
            m1Position21.Enabled = false;

            m2Position01.Text = "9";
            m2Position01.Enabled = false;

            m2Position10.Text = "7";
            m2Position10.Enabled = false;

            m2Position12.Text = "2";
            m2Position12.Enabled = false;

            m2Position21.Text = "3";
            m2Position21.Enabled = false;

            m2Position22.Text = "5";
            m2Position22.Enabled = false;

            m3Position02.Text = "5";
            m3Position02.Enabled = false;

            m3Position21.Text = "9";
            m3Position21.Enabled = false;

            m4Position01.Text = "3";
            m4Position01.Enabled = false;

            m4Position10.Text = "7";
            m4Position10.Enabled = false;

            m4Position22.Text = "2";
            m4Position22.Enabled = false;

            m5Position00.Text = "1";
            m5Position00.Enabled = false;

            m5Position01.Text = "7";
            m5Position01.Enabled = false;

            m5Position20.Text = "4";
            m5Position20.Enabled = false;

            m5Position22.Text = "3";
            m5Position22.Enabled = false;

            m6Position10.Text = "4";
            m6Position10.Enabled = false;

            m6Position12.Text = "8";
            m6Position12.Enabled = false;

            m6Position21.Text = "6";
            m6Position21.Enabled = false;

            m6Position22.Text = "7";
            m6Position22.Enabled = false;

            m7Position00.Text = "3";
            m7Position00.Enabled = false;

            m7Position10.Text = "2";
            m7Position10.Enabled = false;

            m7Position22.Text = "8";
            m7Position22.Enabled = false;

            m8Position01.Text = "8";
            m8Position01.Enabled = false;

            m8Position02.Text = "7";
            m8Position02.Enabled = false;

            m8Position11.Text = "5";
            m8Position11.Enabled = false;

            m8Position20.Text = "3";
            m8Position20.Enabled = false;

            SudokuService.ECCI_SudokuPortClient sudokuWeb = new SudokuService.ECCI_SudokuPortClient();
            bool prueba = sudokuWeb.checkRow(1);
            playerLabel.Text = prueba.ToString();

        }

        private void createPuzzle3() {
            m0Position01.Text = "8";
            m0Position01.Enabled = false;
        }
    }
}
