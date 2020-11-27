using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayHiHi
{
    public partial class Form_oxgame : Form
    {
        public Form_oxgame()
        {
            InitializeComponent();
        }
        private void CloseBtn()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = ""; button2.Text = ""; button3.Text = ""; button4.Text = ""; button5.Text = ""; button6.Text = ""; button7.Text = ""; button8.Text = ""; button9.Text = "";
            time = 0;
        }
        int time;
        private void button1_Click(object sender, EventArgs e)
        {
            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button1.Text = "O";
            }
            else
            {
                button1.Text = "X";
            }
            button1.Enabled = false;
            win();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button2.Text = "O";
            }
            else
            {
                button2.Text = "X";
            }
            button2.Enabled = false;
            win();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button3.Text = "O";
            }
            else
            {
                button3.Text = "X";
            }
            button3.Enabled = false;
            win();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button4.Text = "O";
            }
            else
            {
                button4.Text = "X";
            }
            button4.Enabled = false;
            win();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button5.Text = "O";
            }
            else
            {
                button5.Text = "X";
            }
            button5.Enabled = false;
            win();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button6.Text = "O";
            }
            else
            {
                button6.Text = "X";
            }
            button6.Enabled = false;
            win();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button7.Text = "O";
            }
            else
            {
                button7.Text = "X";
            }
            button7.Enabled = false;
            win();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button8.Text = "O";
            }
            else
            {
                button8.Text = "X";
            }
            button8.Enabled = false;
            win();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            time += 1;
            double x = time % 2;
            if (x == 0)
            {
                button9.Text = "O";
            }
            else
            {
                button9.Text = "X";
            }
            button9.Enabled = false;
            win();
        }

        //判斷輸贏
        private void win()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
                (button1.Text == "X" && button5.Text =="X" && button9.Text == "X") ||
                (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
                (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
                (button3.Text == "X" && button5.Text == "X" && button7.Text == "X") ||
                (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X"))
            {
                MessageBox.Show(" X 贏了 ! ");
                CloseBtn();
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O"))
            {
                MessageBox.Show(" O 贏了 ! ");
                CloseBtn();

            }
            else if ( time == 9 )
            {
                MessageBox.Show(" 平手 ! ");
                CloseBtn();

            }
        }

        //再來一次
        private void but_again_Click(object sender, EventArgs e)
        {
            CloseBtn();
        }

        //關掉頁面
        private void but_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_oxgame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}