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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        //自我介紹按鈕
        private void but_SayHi_Click(object sender, EventArgs e)
        {
            Form_SayHiHi SayHi = new Form_SayHiHi();
            SayHi.Show();

        }

        //POS按鈕
        private void but_POS_Click(object sender, EventArgs e)
        {
            Form_POS POS = new Form_POS();
            POS.Show();
        }

        //學生資料登入
        private void button1_Click(object sender, EventArgs e)
        {
            Form_StudentForm studentform = new Form_StudentForm();
            studentform.Show();
        }

        private void but_MyClas_Click(object sender, EventArgs e)
        {
            Form_MyClac myClac = new Form_MyClac();
            myClac.Show();
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            Form_loan loan = new Form_loan();
            loan.Show();
        }
    }
}
