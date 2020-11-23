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
    public partial class Form_loan : Form
    {
        public Form_loan()
        {
            InitializeComponent();
        }

        double x;
        double y;
        double z;

        private void button_enter_Click(object sender, EventArgs e)
        {
            string credit = textBox_credit.Text;
            string rate = textBox_rate.Text;
            string stage = textBox_stage.Text;
            x = Convert.ToDouble(credit);            //貸款總額
            y = Convert.ToDouble(rate);              //年利率
            z = Convert.ToDouble(stage);           //貸款期數
            double monthrate = y / 12 * 0.01;              //月利率
            //int repayment = Convert.ToInt32( x / z );     //每期攤還本金
            double money;
            money = x;
            int i;
            for ( i =1; i<=z; i++ )
            {
                double a = x * monthrate;      //每個月利息
                x = x - (money / z);     //每個月剩下本金
                a = Math.Round(a / 1);    //四捨五入
                listView1 lv = new listView1();

                //MessageBox.Show(a.ToString());

                ListViewItem varItem = new ListViewItem(new string[] { textBox_credit.Text,
                                                                textBox_rate.Text,
                                                                textBox_stage.Text,
                                                                textBox_sum.Text
                                                               });
                listView1.Items.Add(varItem);



            }

        }
    }
}
