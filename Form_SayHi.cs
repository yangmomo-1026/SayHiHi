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
    public partial class Form_SayHi : Form
    {
        public Form_SayHi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ChName = tb_ch.Text;
            string EnName = tb_en.Text;
            string Sex;
            string Birth = dateTimePicker1.Value.ToString();
            if (rb_girl.Checked)
            {
                Sex = "女生";
            } 
            else if (rb_boy.Checked)
            {
                Sex = "男生";
            }
            else
            {
                Sex = "未選取";
            }

            MessageBox.Show($"中文名字 : {ChName}\n\r英文名字 : {EnName} \n\r性別是 : {Sex} \n\r生日是 : {Birth}");

        }
    }
}
