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
    public partial class Form_ScreenSaver : Form
    {
        public Form_ScreenSaver()
        {
            InitializeComponent();
        }

        bool left = true;
        bool left2 = true;
        bool Go = true;
        int MouX = 0;
        int MouY = 0;


        //private void Run( PictureBox pic , int PicX , int PicY)
        //{

        //} 

        private void Form_ScreenSaver_Click(object sender, EventArgs e)
        {
            if (Go)
                Close();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (left)
            {
                pictureBox1.Left -= 3;
                if (pictureBox1.Left <= 0)
                {
                    left = !left;
                }
            }
            else
            {
                pictureBox1.Left += 3;
                if (pictureBox1.Left + pictureBox1.Width >= this.Width)
                {
                    left = !left;
                }
            }

            if (left2)
            {
                pictureBox1.Top -= 3;
                if (pictureBox1.Top <= 0)
                {
                    left2 = !left2;
                }
            }
            else
            {
                pictureBox1.Top += 3;
                if (pictureBox1.Top + pictureBox1.Height >= this.Height)
                {
                    left2 = !left2;
                }
            }
        }


        private void Form_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {

            if ( Go )
            {
                MouX = e.X;
                MouY = e.Y;
                Go = !Go;
            }
            else if ( MouX != e.X || MouY != e.Y)
            {
                Close();
            }
        }
    }
}
