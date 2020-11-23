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
    public partial class Form_SayHiHi : Form
    {
        public Form_SayHiHi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button_SayHi_Click(object sender, EventArgs e)
        {
            string chName = textBox_chName.Text;
            string enName = textBox_enName.Text;
            string star = textBox_star.Text;
            string sex = textBox_sex.Text;
            string birthday_year = textBox_birthday_year.Text;
            string birthday_month = textBox_birthday_month.Text;
            string birthday_day = textBox_birthday_day.Text;
            //int Y = Age(int.Parse(s: textBox_birthday_year.Text));


            MessageBox.Show("HI ! 我是" + chName + Environment.NewLine + "英文名字是" + enName + Environment.NewLine
                + "星座是" + star + Environment.NewLine + "性別是" + sex + Environment.NewLine +
                "生日是" + birthday_year + "年" + birthday_month + "月" + birthday_day + "日" +
                Environment.NewLine /*+ "我今年" + Y.ToString() + "歲"*/);
        }
        //int Age(int Year)
        //{
        //    int x =DateTime.Now.Year - Year ;

        //        return x ;
        //}



        private void textBox_birthday_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_birthday_month_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_birthday_day_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
