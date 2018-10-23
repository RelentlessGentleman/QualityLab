using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        public string player1;
        public string player1Markers = "X";
        public string player2;
        public string player2Markets = "O";
        public int playerCounter = 1;
        public int boardCount = 0;
        public string[] ticTacToeBoard = new string[9];
        //public string[,] ticTacToeBoardSize = new string [2,2];

        public frmMain()
        {
            InitializeComponent();
        }

        private void btn22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1 = txtPlayerName.Text;
            txtPlayerName.Clear();
            if (!string.IsNullOrEmpty(player1) && (!string.IsNullOrEmpty(player2)))
            {
                btnMakeP1.Visible = false;
                btnMakeP2.Visible = false;
                txtPlayerName.Visible = false;
                btn00.Visible = true;
                btn01.Visible = true;
                btn02.Visible = true;
                btn10.Visible = true;
                btn20.Visible = true;
                btn11.Visible = true;
                btn12.Visible = true;
                btn22.Visible = true;
                btn21.Visible = true;
                
            }
        }

        private void btnMakeP2_Click(object sender, EventArgs e)
        {
            player2 = txtPlayerName.Text;
            txtPlayerName.Clear();
            if (!string.IsNullOrEmpty(player1) && (!string.IsNullOrEmpty(player2)))
            {
                btnMakeP1.Visible = false;
                btnMakeP2.Visible = false;
                txtPlayerName.Visible = false;
                btn00.Visible = true;
                btn01.Visible = true;
                btn02.Visible = true;
                btn10.Visible = true;
                btn20.Visible = true;
                btn11.Visible = true;
                btn12.Visible = true;
                btn22.Visible = true;
                btn21.Visible = true;
            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            playerCounter++;
        }
    }
}
