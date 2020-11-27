using Microsoft.VisualBasic;
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
        int input;
        int guess;
        int max = 100;
        int min = 0;
        string y;




        public Form_guess()
        {
            InitializeComponent();
        }

        private void Guess()
        {
            y = Interaction.InputBox("請輸入 1 ~ 99", "猜大小");
            bool x = int.TryParse(y, out input);
            do
            {
                if (x)
                {
                    if (input > 0 && input <= 100)
                    {
                        if (input == guess)
                        {
                            MessageBox.Show("猜對囉 !");
                            guess = 0;
                            lab_guess.Text = "0 ~ 100";
                            max = 0;
                            min = 0;
                            input = 0;
                            btn_answer.Enabled = false;
                            break;
                        }
                        else if (input > guess)
                        {
                            max = input;
                            lab_guess.Text = min + " ~ " + max;
                            MessageBox.Show("太大了，換小一點的數吧 ! ");
                        }
                        else
                        {
                            min = input;
                            lab_guess.Text = min + " ~ " + max;
                            MessageBox.Show("太小了，換大一點的數吧 ! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" 請輸入 1~100 內的數字");
                    }
                }
                else if (y == "")
                {
                    lab_guess.Text = "0 ~ 100";
                    max = 0;
                    min = 0;
                    input = 0;
                    break;
                }
                else
                {
                    MessageBox.Show("這是猜數字遊戲 \n請輸入數字別調皮^^");
                }
                y = Interaction.InputBox("請輸入 " + min +" ~ " + max , "猜大小");
                x = int.TryParse(y, out input);

            } while (true);
            
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Random r = new Random();    //建立亂數物件
            guess = r.Next(1, 100);    //設定亂數範圍
            btn_answer.Enabled = true;
            Guess();
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            lab_guess.Text = "0 ~ 100";
            MessageBox.Show(guess.ToString());
            guess = 0;
            btn_answer.Enabled = false;
        }
    }
    }

