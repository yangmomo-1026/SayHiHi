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
    public partial class Form_guess : Form
    {
        public Form_guess()
        {
            InitializeComponent();
        }

        int input;
        int guess;
        int max = 100;
        int min = 0;

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int empty;
            Random r = new Random();    //建立亂數物件
            guess = r.Next(1, 100);    //設定亂數範圍

            lab_guess.Text = min + "~" + max;
            bool a = int.TryParse(tb_guess.Text , out empty);
            if (a == true)
            {
                do
                {
                    input = empty;
                    if (input == guess)
                    {
                        lab_guess.Text = "恭喜你猜對了 ! 答案是" + guess;
                        break;
                    }
                    else if (input > guess)
                    {
                        max = input;
                        lab_guess.Text = min + "~" + max;
                    }
                    else if (input < guess)
                    {
                        min = input;
                        lab_guess.Text = min + "~" + max;
                    }
                } while (input == guess);
            }
            else
            {
                lab_guess.Text = "請輸入數值";
                tb_guess.Focus();
            }

        }

        private void btn_answer_Click(object sender, EventArgs e)
        {

        }
    }
}
