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
        bool win;
        SudokuService.ECCI_SudokuPortClient sudokuWeb = new SudokuService.ECCI_SudokuPortClient();

        public Form1()
        {
            InitializeComponent();
            fillPuzzle();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);
            line.DrawLine(pen, 100, 126, 288, 126);
            line.DrawLine(pen, 100, 189, 288, 189);
            line.DrawLine(pen, 162, 64, 162, 249);
            line.DrawLine(pen, 225, 64, 225, 249);
            line.Dispose();
        }

        private void fillPuzzle()
        {
            string values = sudokuWeb.sendPuzzleValues();
            string[] elements = values.Split(',');
            Console.WriteLine(elements[0]);
            
            /*PRIMERA FILA DE LA MATRIZ*/
            m0Position00.Text = elements[0];
            if (m0Position00.Text != "0")
                m0Position00.Enabled = false;
            m0Position01.Text = elements[1];
            if (m0Position01.Text != "0")
                m0Position01.Enabled = false;
            m0Position02.Text = elements[2];
            if (m0Position02.Text != "0")
                m0Position02.Enabled = false;
            m1Position00.Text = elements[3];
            if (m1Position00.Text != "0")
                m1Position00.Enabled = false;
            m1Position01.Text = elements[4];
            if (m1Position01.Text != "0")
                m1Position01.Enabled = false;
            m1Position02.Text = elements[5];
            if (m1Position02.Text != "0")
                m1Position02.Enabled = false;
            m2Position00.Text = elements[6];
            if (m2Position00.Text != "0")
                m2Position00.Enabled = false;
            m2Position01.Text = elements[7];
            if (m2Position01.Text != "0")
                m2Position01.Enabled = false;
            m2Position02.Text = elements[8];
            if (m2Position02.Text != "0")
                m2Position02.Enabled = false;
            m0Position10.Text = elements[9];
            if (m0Position10.Text != "0")
                m0Position10.Enabled = false;
            m0Position11.Text = elements[10];
            if (m0Position11.Text != "0")
                m0Position11.Enabled = false;
            m0Position12.Text = elements[11];
            if (m0Position12.Text != "0")
                m0Position12.Enabled = false;
            m1Position10.Text = elements[12];
            if (m1Position10.Text != "0")
                m1Position10.Enabled = false;
            m1Position11.Text = elements[13];
            if (m1Position11.Text != "0")
                m1Position11.Enabled = false;
            m1Position12.Text = elements[14];
            if (m1Position12.Text != "0")
                m1Position12.Enabled = false;
            m2Position10.Text = elements[15];
            if (m2Position10.Text != "0")
                m2Position10.Enabled = false;
            m2Position11.Text = elements[16];
            if (m2Position11.Text != "0")
                m2Position11.Enabled = false;
            m2Position12.Text = elements[17];
            if (m2Position12.Text != "0")
                m2Position12.Enabled = false;
            m0Position20.Text = elements[18];
            if (m0Position20.Text != "0")
                m0Position20.Enabled = false;
            m0Position21.Text = elements[19];
            if (m0Position21.Text != "0")
                m0Position21.Enabled = false;
            m0Position22.Text = elements[20];
            if (m0Position22.Text != "0")
                m0Position22.Enabled = false;
            m1Position20.Text = elements[21];
            if (m1Position20.Text != "0")
                m1Position20.Enabled = false;
            m1Position21.Text = elements[22];
            if (m1Position21.Text != "0")
                m1Position21.Enabled = false;
            m1Position22.Text = elements[23];
            if (m1Position22.Text != "0")
                m1Position22.Enabled = false;
            m2Position20.Text = elements[24];
            if (m2Position20.Text != "0")
                m2Position20.Enabled = false;
            m2Position21.Text = elements[25];
            if (m2Position21.Text != "0")
                m2Position21.Enabled = false;
            m2Position22.Text = elements[26];
            if (m2Position22.Text != "0")
                m2Position22.Enabled = false;
            /*PRIMERA FILA DE LA MATRIZ*/

            /*SEGUNDA FILA DE LA MATRIZ*/
            m3Position00.Text = elements[27];
            if (m3Position00.Text != "0")
                m3Position00.Enabled = false;
            m3Position01.Text = elements[28];
            if (m3Position01.Text != "0")
                m3Position01.Enabled = false;
            m3Position02.Text = elements[29];
            if (m3Position02.Text != "0")
                m3Position02.Enabled = false;
            m4Position00.Text = elements[30];
            if (m4Position00.Text != "0")
                m4Position00.Enabled = false;
            m4Position01.Text = elements[31];
            if (m4Position01.Text != "0")
                m4Position01.Enabled = false;
            m4Position02.Text = elements[32];
            if (m4Position02.Text != "0")
                m4Position02.Enabled = false;
            m5Position00.Text = elements[33];
            if (m5Position00.Text != "0")
                m5Position00.Enabled = false;
            m5Position01.Text = elements[34];
            if (m5Position01.Text != "0")
                m5Position01.Enabled = false;
            m5Position02.Text = elements[35];
            if (m5Position02.Text != "0")
                m5Position02.Enabled = false;
            m3Position10.Text = elements[36];
            if (m3Position10.Text != "0")
                m3Position10.Enabled = false;
            m3Position11.Text = elements[37];
            if (m3Position11.Text != "0")
                m3Position11.Enabled = false;
            m3Position12.Text = elements[38];
            if (m3Position12.Text != "0")
                m3Position12.Enabled = false;
            m4Position10.Text = elements[39];
            if (m4Position10.Text != "0")
                m4Position10.Enabled = false;
            m4Position11.Text = elements[40];
            if (m4Position11.Text != "0")
                m4Position11.Enabled = false;
            m4Position12.Text = elements[41];
            if (m4Position12.Text != "0")
                m4Position12.Enabled = false;
            m5Position10.Text = elements[42];
            if (m5Position10.Text != "0")
                m5Position10.Enabled = false;
            m5Position11.Text = elements[43];
            if (m5Position11.Text != "0")
                m5Position11.Enabled = false;
            m5Position12.Text = elements[44];
            if (m5Position12.Text != "0")
                m5Position12.Enabled = false;
            m3Position20.Text = elements[45];
            if (m3Position20.Text != "0")
                m3Position20.Enabled = false;
            m3Position21.Text = elements[46];
            if (m3Position21.Text != "0")
                m3Position21.Enabled = false;
            m3Position22.Text = elements[47];
            if (m3Position22.Text != "0")
                m3Position22.Enabled = false;
            m4Position20.Text = elements[48];
            if (m4Position20.Text != "0")
                m4Position20.Enabled = false;
            m4Position21.Text = elements[49];
            if (m4Position21.Text != "0")
                m4Position21.Enabled = false;
            m4Position22.Text = elements[50];
            if (m4Position22.Text != "0")
                m4Position22.Enabled = false;
            m5Position20.Text = elements[51];
            if (m5Position20.Text != "0")
                m5Position20.Enabled = false;
            m5Position21.Text = elements[52];
            if (m5Position21.Text != "0")
                m5Position21.Enabled = false;
            m5Position22.Text = elements[53];
            if (m5Position22.Text != "0")
                m5Position22.Enabled = false;
            /*SEGUNDA FILA DE LA MATRIZ*/


            /*TERCERA FILA DE LA MATRIZ*/
            m6Position00.Text = elements[54];
            if (m6Position00.Text != "0")
                m6Position00.Enabled = false;
            m6Position01.Text = elements[55];
            if (m6Position01.Text != "0")
                m6Position01.Enabled = false;
            m6Position02.Text = elements[56];
            if (m6Position02.Text != "0")
                m6Position02.Enabled = false;
            m7Position00.Text = elements[57];
            if (m7Position00.Text != "0")
                m7Position00.Enabled = false;
            m7Position01.Text = elements[58];
            if (m7Position01.Text != "0")
                m7Position01.Enabled = false;
            m7Position02.Text = elements[59];
            if (m7Position02.Text != "0")
                m7Position02.Enabled = false;
            m8Position00.Text = elements[60];
            if (m8Position00.Text != "0")
                m8Position00.Enabled = false;
            m8Position01.Text = elements[61];
            if (m8Position01.Text != "0")
                m8Position01.Enabled = false;
            m8Position02.Text = elements[62];
            if (m8Position02.Text != "0")
                m8Position02.Enabled = false;
            m6Position10.Text = elements[63];
            if (m6Position10.Text != "0")
                m6Position10.Enabled = false;
            m6Position11.Text = elements[64];
            if (m6Position11.Text != "0")
                m6Position11.Enabled = false;
            m6Position12.Text = elements[65];
            if (m6Position12.Text != "0")
                m6Position12.Enabled = false;
            m7Position10.Text = elements[66];
            if (m7Position10.Text != "0")
                m7Position10.Enabled = false;
            m7Position11.Text = elements[67];
            if (m7Position11.Text != "0")
                m7Position11.Enabled = false;
            m7Position12.Text = elements[68];
            if (m7Position12.Text != "0")
                m7Position12.Enabled = false;
            m8Position10.Text = elements[69];
            if (m8Position10.Text != "0")
                m8Position10.Enabled = false;
            m8Position11.Text = elements[70];
            if (m8Position11.Text != "0")
                m8Position11.Enabled = false;
            m8Position12.Text = elements[71];
            if (m8Position12.Text != "0")
                m8Position12.Enabled = false;
            m6Position20.Text = elements[72];
            if (m6Position20.Text != "0")
                m6Position20.Enabled = false;
            m6Position21.Text = elements[73];
            if (m6Position21.Text != "0")
                m6Position21.Enabled = false;
            m6Position22.Text = elements[74];
            if (m6Position22.Text != "0")
                m6Position22.Enabled = false;
            m7Position20.Text = elements[75];
            if (m7Position20.Text != "0")
                m7Position20.Enabled = false;
            m7Position21.Text = elements[76];
            if (m7Position21.Text != "0")
                m7Position21.Enabled = false;
            m7Position22.Text = elements[77];
            if (m7Position22.Text != "0")
                m7Position22.Enabled = false;
            m8Position20.Text = elements[78];
            if (m8Position20.Text != "0")
                m8Position20.Enabled = false;
            m8Position21.Text = elements[79];
            if (m8Position21.Text != "0")
                m8Position21.Enabled = false;
            m8Position22.Text = elements[80];
            if (m8Position22.Text != "0")
                m8Position22.Enabled = false;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string values = "";
            values += m0Position00.Text;
            values += m0Position01.Text;
            values += m0Position02.Text;
            values += m1Position00.Text;
            values += m1Position01.Text;
            values += m1Position02.Text;
            values += m2Position00.Text;
            values += m2Position01.Text;
            values += m2Position02.Text;
            values += m0Position10.Text;
            values += m0Position11.Text;
            values += m0Position12.Text;
            values += m1Position10.Text;
            values += m1Position11.Text;
            values += m1Position12.Text;
            values += m2Position10.Text;
            values += m2Position11.Text;
            values += m2Position12.Text;
            values += m0Position20.Text;
            values += m0Position21.Text;
            values += m0Position22.Text;
            values += m1Position20.Text;
            values += m1Position21.Text;
            values += m1Position22.Text;
            values += m2Position20.Text;
            values += m2Position21.Text;
            values += m2Position22.Text;

            values += m3Position00.Text;
            values += m3Position01.Text;
            values += m3Position02.Text;
            values += m4Position00.Text;
            values += m4Position01.Text;
            values += m4Position02.Text;
            values += m5Position00.Text;
            values += m5Position01.Text;
            values += m5Position02.Text;
            values += m3Position10.Text;
            values += m3Position11.Text;
            values += m3Position12.Text;
            values += m4Position10.Text;
            values += m4Position11.Text;
            values += m4Position12.Text;
            values += m5Position10.Text;
            values += m5Position11.Text;
            values += m5Position12.Text;
            values += m3Position20.Text;
            values += m3Position21.Text;
            values += m3Position22.Text;
            values += m4Position20.Text;
            values += m4Position21.Text;
            values += m4Position22.Text;
            values += m5Position20.Text;
            values += m5Position21.Text;
            values += m5Position22.Text;

            values += m6Position00.Text;
            values += m6Position01.Text;
            values += m6Position02.Text;
            values += m7Position00.Text;
            values += m7Position01.Text;
            values += m7Position02.Text;
            values += m8Position00.Text;
            values += m8Position01.Text;
            values += m8Position02.Text;
            values += m6Position10.Text;
            values += m6Position11.Text;
            values += m6Position12.Text;
            values += m7Position10.Text;
            values += m7Position11.Text;
            values += m7Position12.Text;
            values += m8Position10.Text;
            values += m8Position11.Text;
            values += m8Position12.Text;
            values += m6Position20.Text;
            values += m6Position21.Text;
            values += m6Position22.Text;
            values += m7Position20.Text;
            values += m7Position21.Text;
            values += m7Position22.Text;
            values += m8Position20.Text;
            values += m8Position21.Text;
            values += m8Position22.Text;

            sudokuWeb.receivePuzzle(values);
            win = sudokuWeb.winGame();
            if (win) {
                MessageBox.Show("Ganaste el juego!", "Fin del juego");
            }
        }
    }
}
