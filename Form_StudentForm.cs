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
    public partial class Form_StudentForm : Form
    {

        public Form_StudentForm()
        {
            InitializeComponent();
        }


        struct data
        {
            public string sdname;
            public int Ch;
            public int Ma;
            public int En;
            public data(string name,int chinese,int math,int english)
            {
                sdname = name;
                Ch = chinese;
                Ma = math;
                En = english;
            }
        }
        string x;

        //資料儲存鍵
        public void but_sve_Click(object sender, EventArgs e)
        {
            data da = new data(tb_name.Text, int.Parse(tb_ch.Text), int.Parse(tb_ma.Text), int.Parse(tb_en.Text));
            x = "姓名: " + da.sdname + "\n" + "國文成績: " + da.Ch + "分" + "\n" + "數學成績: " + da.Ma + "分" + "\n" + "英文成績: " + da.En + "分";
        }

        //成績顯示控制
        private void but_show_Click(object sender, EventArgs e)
        {
            lab_score.Text =x;
        }

        //成績比大小鍵
        private void but_highest_Click(object sender, EventArgs e)
        {
            data da = new data(tb_name.Text, int.Parse(tb_ch.Text), int.Parse(tb_ma.Text), int.Parse(tb_en.Text));
            int x = da.Ch;
            int y = da.Ma;
            int z = da.En;
            int max;
            int min;
            string max_item = "";
            string min_item = "";
            if (x > y & x > z)
            {
                max = x;
                max_item = "國文";
            }
            else if (y > x & y > z)
            {
                max = y;
                max_item = "數學";
            }
            else {  max = z;
                max_item = "英文";
            }

            if (x < y & x < z)
            {
                 min = x;
                 min_item = "國文";
            }
            else if (y < x & y < z)
            {
                 min = y;
                 min_item = "數學";
            }
            else {  min = z; 
                 min_item = "英文"; }

            lab_sum.Text = "最高分科目: " + max_item + " " + max + " 分 "
                + "\n" + "最低分科目: " + min_item + " " + min + " 分 ";
        }

        //清除資料
        private void but_clear_Click(object sender, EventArgs e)
        {
            data da = new data(tb_name.Text, int.Parse(tb_ch.Text), int.Parse(tb_ma.Text), int.Parse(tb_en.Text));
            lab_score.Text = "";
            lab_sum.Text = "";
            tb_name.Text = "";
            tb_ch.Text = "0";
            tb_ma.Text = "0";
            tb_en.Text = "0";
            x = "";
        }

    }
}
