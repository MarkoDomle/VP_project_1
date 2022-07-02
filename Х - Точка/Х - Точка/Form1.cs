using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Х___Точка
{
     public partial class Form1 : Form
    {
        internal Form1()
        {
            InitializeComponent();
        }
        Boolean isX = true;

        void disable_when_over() { 
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
        }
        void game_winner()
        {
            if (btn0.Text == "X" && btn1.Text == "X" && btn2.Text == "X"||
                btn3.Text == "X" && btn4.Text == "X" && btn5.Text == "X"||
                btn6.Text == "X" && btn7.Text == "X" && btn8.Text == "X"||
                btn0.Text == "X" && btn4.Text == "X" && btn8.Text == "X"||
                btn2.Text == "X" && btn4.Text == "X" && btn6.Text == "X")
            {
                pobeda pobeda = new pobeda();
                pobeda.Show();
                updateX();
                disable_when_over();

            }
            if (btn0.Text == "O" && btn1.Text == "O" && btn2.Text == "O" ||
               btn3.Text == "O" && btn4.Text == "O" && btn5.Text == "O" ||
               btn6.Text == "O" && btn7.Text == "O" && btn8.Text == "O" ||
               btn0.Text == "O" && btn4.Text == "O" && btn8.Text == "O" ||
               btn2.Text == "O" && btn4.Text == "O" && btn6.Text == "O") {
                pobedaZaO pobeda = new pobedaZaO();
                pobeda.Show();
                updateO();
                disable_when_over();
            }       
        }
        int x;
        private void updateO()
        {
            x = int.Parse(player_x_score.Text);
            x++;
            player_x_score.Text = x.ToString();
        }

        private void updateX()
        {
            int x;
            x = int.Parse(player_x_score.Text.ToString());
            x++;
            player_x_score.Text = Convert.ToString(x);
        }

        private void btn0_Click(object sender, EventArgs e) {
            if (isX)
            {
                isX = false;
                btn0.Text = "X";
                btn0.Enabled = false;
                game_winner();
            }
            else {
                isX = true;
                btn0.Text = "O";
                btn0.Enabled = false;
                game_winner();
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn1.Text = "X";
                btn1.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn1.Text = "О";
                btn1.Enabled = false;
                game_winner();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn2.Text = "X";
                btn2.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn2.Text = "O";
                btn2.Enabled = false;
                game_winner();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn3.Text = "X";
                btn3.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn3.Text = "O";
                btn3.Enabled = false;
                game_winner();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn4.Text = "X";
                btn4.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn4.Text = "O";
                btn4.Enabled = false;
                game_winner();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn5.Text = "X";
                btn5.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn5.Text = "O";
                btn5.Enabled = false;
                game_winner();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn6.Text = "X";
                btn6.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn6.Text = "O";
                btn6.Enabled = false;
                game_winner();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn7.Text = "X";
                btn7.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn7.Text = "O";
                btn7.Enabled = false;
                game_winner();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isX)
            {
                isX = false;
                btn8.Text = "X";
                btn8.Enabled = false;
                game_winner();
            }
            else
            {
                isX = true;
                btn8.Text = "O";
                btn8.Enabled = false;
                game_winner();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;

            btn0.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";

            player_x_score.Text = "0";
            player_O_score.Text = "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show( "Дали сакате да излезите?", "Излез", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void btn_new_game_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;

            btn0.Text = "";
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";

        }
    }
}
