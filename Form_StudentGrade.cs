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
    public partial class Form_StudentGrade : Form
    {
        public Form_StudentGrade()
        {
            InitializeComponent();
        }

        List<Student> Stu = new List<Student>();
        double sum = 0.0;
        double SumCh = 0;
        double SumEn = 0;
        double SumMa = 0;
        double ReCh = 0.0;
        double ReEn = 0.0;
        double ReMa = 0.0;
        double revarge = 0.0;
        double max = 0;
        double min = 0;
        double MaxCh = 0.0;
        double MaxEn = 0.0;
        double MaxMa = 0.0;
        double MinCh = 100.0;
        double MinEn = 100.0;
        double MinMa = 100.0;
        char pad = ' ';
        int count = 0;
        Random ran = new Random();
        string MaxWord = "";
        string MinWord = "";
        string x;
        private void input()
        {
            foreach ( Student StudentData in Stu)
            {
                sum = StudentData.ch + StudentData.en + StudentData.ma;
                revarge =sum / 3.0 ;
                max = StudentData.ma < StudentData.ch ? StudentData.ch : StudentData.ma;
                max = max < StudentData.en ? StudentData.en : max;

                if (max == StudentData.ch)
                {
                    MaxWord = "國文";
                }else if (max == StudentData.en)
                {
                    MaxWord = "英文";
                }
                else
                {
                    MaxWord ="數學";
                }

                min = StudentData.ma < StudentData.ch ? StudentData.ma : StudentData.ch;
                min = min < StudentData.en ? min : StudentData.en;

                if (min == StudentData.ch)
                {
                    MinWord = "國文";
                }
                else if (min == StudentData.en)
                {
                    MinWord = "英文";
                }
                else
                {
                    MinWord = "數學";
                }


                x = $"{StudentData.name.PadLeft(3,pad)}" +
                    $"{StudentData.ch.ToString().PadLeft(7, pad)}" +
                    $"{StudentData.en.ToString().PadLeft(7, pad)}" +
                    $"{StudentData.ma.ToString().PadLeft(7, pad)}" +
                    $"{sum.ToString().PadLeft(7, pad)}" +
                    $"{revarge.ToString("f1").PadLeft(7, pad)}" +
                    $"{(MaxWord + max.ToString()).PadLeft(7,pad)}" +
                    $"{(MinWord + min.ToString()).PadLeft(7,pad)}" +
                    $" \n";
                //label6.Text += StudentData.name.PadLeft(2);
            }
            label8.Text += x;
            tb_name.Text = "";
            tb_ch.Text = "";
            tb_en.Text = "";
            tb_ma.Text = "";
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("請輸入名字");
                tb_name.Focus();
            }
            else if(tb_ch.Text == "")
            {
                MessageBox.Show("請輸入國文成績");
                tb_ch.Focus();
            }
            else if(tb_en.Text == "")
            {
                MessageBox.Show("請輸入英文成績");
                tb_en.Focus();
            }
            else if (tb_ma.Text == "")
            {
                MessageBox.Show("請輸入數學成績");
                tb_ma.Focus();
            }
            else
            {
                Student StudentData = new Student();
                StudentData.name = tb_name.Text;
                StudentData.ch = Convert.ToInt32(tb_ch.Text);
                StudentData.en = Convert.ToInt32(tb_en.Text);
                StudentData.ma = Convert.ToInt32(tb_ma.Text);
                Stu.Add(StudentData);
                SumCh += StudentData.ch;
                SumEn += StudentData.en;
                SumMa += StudentData.ma;
                input();
                btn_sum.Enabled = true;
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = ran.Next(1, 100);
            b = ran.Next(1, 100);
            c = ran.Next(1, 100);
            count += 1;
            Student StudentData = new Student();
            StudentData.name = count.ToString();
            StudentData.ch = a;
            StudentData.en = b;
            StudentData.ma = c;
            Stu.Add(StudentData);
            SumCh += StudentData.ch;
            SumEn += StudentData.en;
            SumMa += StudentData.ma;
            input();
            btn_sum.Enabled = true;
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            ReCh = SumCh/count ;
            ReEn = SumEn / count;
            ReMa = SumMa / count;
            foreach( Student i in Stu)
            {
                if ( i.ch>MaxCh)
                {
                    MaxCh = i.ch;
                }
                if (i.en > MaxEn)
                {
                    MaxEn = i.en;
                }
                if (i.ma > MaxMa)
                {
                    MaxMa = i.ma;
                }
                if (i.ch < MinCh)
                {
                    MinCh = i.ch;
                }
                if (i.en < MinEn)
                {
                    MinEn = i.en;
                }
                if (i.ma < MinMa)
                {
                    MinMa = i.ma;
                }
            }

            //string a = $"{ReCh,6}{"orange",10}";
            label5.Text = "總分" + SumCh.ToString().PadLeft(7, pad) + SumEn.ToString().PadLeft(7, pad) + SumMa.ToString().PadLeft(7, pad) + 
                "\n平均" + ReCh.ToString("f1").PadLeft(7, pad) + ReEn.ToString("f1").PadLeft(7, pad) + ReMa.ToString("f1").PadLeft(7, pad) +
                "\n最高分" + MaxCh.ToString().PadLeft(5, pad) + MaxEn.ToString().PadLeft(7, pad) + MaxMa.ToString().PadLeft(7, pad) + 
                "\n最低分" + MinCh.ToString().PadLeft(5, pad) + MinEn.ToString().PadLeft(7, pad) + MinMa.ToString().PadLeft(7, pad);

            btn_enter.Enabled = false;
            btn_random.Enabled = false;
            btn_random20.Enabled = false;
            btn_sum.Enabled = false;
        }

        private void btn_random20_Click(object sender, EventArgs e)
        {
            for ( int i =0; i<20 ; i++)
            {
                btn_random_Click( this,  e);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach ( Student i in Stu)
            {
                i.ch = 0.0;
                i.en = 0.0;
                i.ma = 0.0;
                i.name = "";
            }
            Stu.Clear();
            sum = 0.0;
            SumCh = 0;
            SumEn = 0;
            SumMa = 0;
            ReCh = 0.0;
            ReEn = 0.0;
            ReMa = 0.0;
            revarge = 0.0;
            max = 0;
            min = 0;
            MaxCh = 0.0;
            MaxEn = 0.0;
            MaxMa = 0.0;
            MinCh = 100.0;
            MinEn = 100.0;
            MinMa = 100.0;
            count = 0;
            label8.Text = "";
            label5.Text = "";
            btn_enter.Enabled = true;
            btn_random.Enabled = true;
            btn_random20.Enabled = true;
            //btn_sum.Enabled = false;
            
        }
    }
}
