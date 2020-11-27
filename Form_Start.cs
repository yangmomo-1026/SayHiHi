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
    public partial class Form_Start : Form
    {
        public Form_Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_loan loan = new Form_loan();
            loan.TopLevel =false;
            loan.Show();
            splitContainer2.Panel2.Controls.Add(loan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_StudentForm StudentForm = new Form_StudentForm();
            StudentForm.TopLevel = false;
            StudentForm.Show();
            splitContainer2.Panel2.Controls.Add(StudentForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_StudentGrade StudentGrade = new Form_StudentGrade();
            StudentGrade.TopLevel = false;
            StudentGrade.Show();
            splitContainer2.Panel2.Controls.Add(StudentGrade);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_POS POS = new Form_POS();
            POS.TopLevel = false;
            POS.Show();
            splitContainer2.Panel2.Controls.Add(POS);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_MyClac clac = new Form_MyClac();
            clac.TopLevel = false;
            clac.Show();
            splitContainer2.Panel2.Controls.Add(clac);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_guess guess = new Form_guess();
            guess.TopLevel = false;
            guess.Show();
            splitContainer2.Panel2.Controls.Add(guess);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //splitContainer2.Panel2.Controls.Clear();
            Form_ScreenSaver screensaver = new Form_ScreenSaver();
            //screensaver.TopLevel = false;
            screensaver.Show();
            //splitContainer2.Panel2.Controls.Add(screensaver);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form_oxgame OX = new Form_oxgame();
            OX.TopLevel = false;
            OX.Show();
            splitContainer2.Panel2.Controls.Add(OX);
        }
    }
}
