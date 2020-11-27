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
    public partial class Form_MyClac : Form
    {
        public Form_MyClac()
        {
            InitializeComponent();
        }

        public string num_one = "";
        public string num_two = "";
        public string num_answer = "";
        public int x = 0;
        public int y = 0;
        public int z = 0;
        

        //加法
        private void but_addition_Click(object sender, EventArgs e)
        {
            num_one = tb_num_one.Text;
            num_two = tb_num_two.Text;

            if (num_one == "" | num_two == "")
            {
                MessageBox.Show("請輸入數值","注意");
            }
            else
            {
                x = int.Parse(num_one);
                y = int.Parse(num_two);
                z = x + y;
                lab_ans.Text = z.ToString();
            }
        }

        //減法
        private void but_subtraction_Click(object sender, EventArgs e)
        {
            num_one = tb_num_one.Text;
            num_two = tb_num_two.Text;
            if (num_one == "" | num_two == "")
            {
                MessageBox.Show("請輸入數值", "注意");
            }
            else
            {
                x = int.Parse(num_one);
                y = int.Parse(num_two);
                z = x - y;
                lab_ans.Text = z.ToString();
            }
        }

        //乘法
        private void but_mul_Click(object sender, EventArgs e)
        {
            num_one = tb_num_one.Text;
            num_two = tb_num_two.Text;

            if (num_one == "" | num_two == "")
            {
                MessageBox.Show("請輸入數值", "注意");
            }
            else
            {
                x = int.Parse(num_one);
                y = int.Parse(num_two);
                z = x * y;
                lab_ans.Text = z.ToString();
            }
        }

        //除法
        private void but_div_Click(object sender, EventArgs e)
        {
            num_one = tb_num_one.Text;
            num_two = tb_num_two.Text;

            if (num_one == "" | num_two == "")
            {
                MessageBox.Show("請輸入數值", "注意");
            }
            else
            {
                x = int.Parse(num_one);
                y = int.Parse(num_two);
                z = x / y;
                lab_ans.Text = z.ToString();
            }
        }
    }
}
