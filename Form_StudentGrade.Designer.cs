namespace SayHiHi
{
    partial class Form_StudentGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_ch = new System.Windows.Forms.TextBox();
            this.tb_en = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_random20 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "學生：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(67, 22);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(73, 22);
            this.tb_name.TabIndex = 4;
            // 
            // tb_ch
            // 
            this.tb_ch.Location = new System.Drawing.Point(67, 56);
            this.tb_ch.Name = "tb_ch";
            this.tb_ch.Size = new System.Drawing.Size(73, 22);
            this.tb_ch.TabIndex = 5;
            // 
            // tb_en
            // 
            this.tb_en.Location = new System.Drawing.Point(67, 90);
            this.tb_en.Name = "tb_en";
            this.tb_en.Size = new System.Drawing.Size(73, 22);
            this.tb_en.TabIndex = 6;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(67, 124);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(73, 22);
            this.tb_ma.TabIndex = 7;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(16, 167);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(123, 26);
            this.btn_enter.TabIndex = 8;
            this.btn_enter.Text = "輸入學生資料";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_random.Location = new System.Drawing.Point(17, 199);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(123, 26);
            this.btn_random.TabIndex = 9;
            this.btn_random.Text = "隨機存入資料";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Enabled = false;
            this.btn_sum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_sum.Location = new System.Drawing.Point(17, 231);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(123, 26);
            this.btn_sum.TabIndex = 10;
            this.btn_sum.Text = "各科統計";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_random20
            // 
            this.btn_random20.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_random20.Location = new System.Drawing.Point(17, 396);
            this.btn_random20.Name = "btn_random20";
            this.btn_random20.Size = new System.Drawing.Size(123, 26);
            this.btn_random20.TabIndex = 15;
            this.btn_random20.Text = "隨機加入20筆資料";
            this.btn_random20.UseVisualStyleBackColor = true;
            this.btn_random20.Click += new System.EventHandler(this.btn_random20_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.Location = new System.Drawing.Point(17, 364);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(123, 26);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "重設所有資料";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "姓名   國文   英文   數學   總和   平均     最高     最低\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 18);
            this.label8.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(167, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 234);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel2.Location = new System.Drawing.Point(167, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 147);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 100);
            this.label5.TabIndex = 0;
            // 
            // Form_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(692, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_random20);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.tb_en);
            this.Controls.Add(this.tb_ch);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_StudentGrade";
            this.Text = "Form_StudentGrade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_ch;
        private System.Windows.Forms.TextBox tb_en;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_random20;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}