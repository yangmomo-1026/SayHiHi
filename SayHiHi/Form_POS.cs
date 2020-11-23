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
    public partial class Form_POS : Form
    {
        public Form_POS()
        {
            InitializeComponent();
        }

        //初始總額
        int total = 0;

        //商品單價
        int Beer = 300;
        int Tequila = 180;
        int Whisky = 350; 
        int Wine = 320;

        //個別購買數量
        int Beer_num = 0;
        int Tequila_num = 0;
        int Whisky_num = 0;
        int Wine_num = 0;

        //購買輸出文字
        string beer_x = "";
        string te_x = "";
        string Whisky_x = "";
        string Wine_x = "";

        //個別購買總額
        int Beer_total = 0;
        int te_total = 0;
        int Whisky_total = 0;
        int Wine_total = 0;

        //啤酒按鈕
        private void but_Beer_Click(object sender, EventArgs e)
        {
            total += Beer;
            textBox_sum.Text = "NT$ "+ total.ToString();
            Beer_num += 1;
            Beer_total += 300;
            beer_x = "啤酒" + Beer_num + "瓶 , 總共 " + Beer_total + " 元"+Environment.NewLine ;
            lab_list_box.Text = beer_x + te_x + Whisky_x + Wine_x;
        }

        //龍舌蘭按鈕
        private void but_Tequila_Click(object sender, EventArgs e)
        {
            total +=Tequila;
            textBox_sum.Text = "NT$ " + total.ToString();
            Tequila_num += 1;
            te_total += 180;
            te_x = "龍舌蘭" + Tequila_num + "瓶 , 總共 " + te_total + " 元" + Environment.NewLine;
            lab_list_box.Text = beer_x + te_x + Whisky_x + Wine_x;
        }

        //威士忌按鈕
        private void but_Whisky_Click(object sender, EventArgs e)
        {
            total += Whisky;
            textBox_sum.Text = "NT$ " + total.ToString();
            Whisky_num += 1;
            Whisky_total += 350;
            Whisky_x = "威士忌" + Whisky_num + "瓶 , 總共 " + Whisky_total + " 元" + Environment.NewLine;
            lab_list_box.Text = beer_x + te_x + Whisky_x + Wine_x;
        }

        //紅酒按鈕
        private void but_Wine_Click(object sender, EventArgs e)
        {
            total += Wine;
            textBox_sum.Text = "NT$ " + total.ToString();
            Wine_num += 1;
            Wine_total += 320;
            Wine_x = "紅酒" + Wine_num + "瓶 , 總共 " + Wine_total + " 元" + Environment.NewLine;
            lab_list_box.Text = beer_x + te_x + Whisky_x + Wine_x;
        }

        //清除鍵
        private void but_delete_Click(object sender, EventArgs e)
        {
            lab_list_box.Text = "尚未點餐";
            textBox_sum.Text = "NT$ 0 ";
            total = 0;
            Beer_total = 0;
            te_total = 0;
            Whisky_total = 0;
            Wine_total = 0;
            Beer_num = 0;
            Tequila_num = 0;
            Whisky_num = 0;
            Wine_num = 0;
            beer_x = "";
            te_x = "";
            Whisky_x = "";
            Wine_x = "";
        }   
       
        //一般結帳
        private void but_Cash_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                int x = total;
                MessageBox.Show("總金額 " + x + " 元", "確認付款", MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("尚未點餐 " , "確認付款");
            }
        }

        //信用卡結帳
        private void but_credit_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                double y = total * 0.9;
                MessageBox.Show("總金額 " + total + " 元" +Environment.NewLine+ "------------"+Environment.NewLine + "折扣後金額 " + y + "元" , "確認付款", MessageBoxButtons.YesNo);
            }
            else
            {
                MessageBox.Show("尚未點餐 ", "確認付款");
            }
        }
    }
}
