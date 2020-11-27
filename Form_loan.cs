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
            double monthmoney = x / z;
            string repayment = Math.Round(x / z).ToString();     //每期攤還本金
            //string sum = Math.Round(x / z + a).ToString();

            double money;
            money = x;
            int i;
            double a;
            double b = 0;

            for ( i =1; i<=z; i++ )
            {
                //double a = x * monthrate;      //每個月利息
                a = Math.Round(x * monthrate);    //四捨五入  
                x -= (money / z);     //每個月剩下本金
                string month = i.ToString();
                //string repayment = Math.Round(x / z).ToString();     //每期攤還本金
                string loan = a.ToString();
                string sum = Math.Round(monthmoney+ a).ToString();
                ListViewItem varItem = new ListViewItem(new string[] { month , repayment , loan , sum});
                listView1.Items.Add(varItem);
                b +=a;
                textBox_sum.Text = b.ToString();
            }
            
        }
    }
}
