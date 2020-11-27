namespace SayHiHi
{
    partial class Form_StudentForm
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
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_ch = new System.Windows.Forms.Label();
            this.lab_ma = new System.Windows.Forms.Label();
            this.lab_en = new System.Windows.Forms.Label();
            this.gb_keyin = new System.Windows.Forms.GroupBox();
            this.but_show = new System.Windows.Forms.Button();
            this.but_sve = new System.Windows.Forms.Button();
            this.tb_en = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_ch = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.gb_score = new System.Windows.Forms.GroupBox();
            this.but_highest = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.lab_sum = new System.Windows.Forms.Label();
            this.lab_score = new System.Windows.Forms.Label();
            this.gb_keyin.SuspendLayout();
            this.gb_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_name.Location = new System.Drawing.Point(16, 30);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(74, 21);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "學生姓名";
            // 
            // lab_ch
            // 
            this.lab_ch.AutoSize = true;
            this.lab_ch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ch.Location = new System.Drawing.Point(16, 79);
            this.lab_ch.Name = "lab_ch";
            this.lab_ch.Size = new System.Drawing.Size(74, 21);
            this.lab_ch.TabIndex = 1;
            this.lab_ch.Text = "國文成績";
            // 
            // lab_ma
            // 
            this.lab_ma.AutoSize = true;
            this.lab_ma.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ma.Location = new System.Drawing.Point(16, 129);
            this.lab_ma.Name = "lab_ma";
            this.lab_ma.Size = new System.Drawing.Size(74, 21);
            this.lab_ma.TabIndex = 2;
            this.lab_ma.Text = "數學成績";
            // 
            // lab_en
            // 
            this.lab_en.AutoSize = true;
            this.lab_en.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_en.Location = new System.Drawing.Point(16, 181);
            this.lab_en.Name = "lab_en";
            this.lab_en.Size = new System.Drawing.Size(74, 21);
            this.lab_en.TabIndex = 3;
            this.lab_en.Text = "英文成績";
            // 
            // gb_keyin
            // 
            this.gb_keyin.BackColor = System.Drawing.SystemColors.Control;
            this.gb_keyin.Controls.Add(this.but_show);
            this.gb_keyin.Controls.Add(this.but_sve);
            this.gb_keyin.Controls.Add(this.tb_en);
            this.gb_keyin.Controls.Add(this.tb_ma);
            this.gb_keyin.Controls.Add(this.tb_ch);
            this.gb_keyin.Controls.Add(this.tb_name);
            this.gb_keyin.Controls.Add(this.lab_en);
            this.gb_keyin.Controls.Add(this.lab_ma);
            this.gb_keyin.Controls.Add(this.lab_ch);
            this.gb_keyin.Controls.Add(this.lab_name);
            this.gb_keyin.Location = new System.Drawing.Point(35, 29);
            this.gb_keyin.Name = "gb_keyin";
            this.gb_keyin.Size = new System.Drawing.Size(233, 286);
            this.gb_keyin.TabIndex = 1;
            this.gb_keyin.TabStop = false;
            this.gb_keyin.Text = "輸入資料";
            // 
            // but_show
            // 
            this.but_show.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_show.Location = new System.Drawing.Point(120, 236);
            this.but_show.Name = "but_show";
            this.but_show.Size = new System.Drawing.Size(94, 31);
            this.but_show.TabIndex = 9;
            this.but_show.Text = "顯示儲存資料";
            this.but_show.UseVisualStyleBackColor = true;
            this.but_show.Click += new System.EventHandler(this.but_show_Click);
            // 
            // but_sve
            // 
            this.but_sve.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_sve.Location = new System.Drawing.Point(20, 236);
            this.but_sve.Name = "but_sve";
            this.but_sve.Size = new System.Drawing.Size(94, 31);
            this.but_sve.TabIndex = 8;
            this.but_sve.Text = "儲存資料";
            this.but_sve.UseVisualStyleBackColor = true;
            this.but_sve.Click += new System.EventHandler(this.but_sve_Click);
            // 
            // tb_en
            // 
            this.tb_en.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_en.Location = new System.Drawing.Point(104, 180);
            this.tb_en.Name = "tb_en";
            this.tb_en.Size = new System.Drawing.Size(110, 23);
            this.tb_en.TabIndex = 7;
            this.tb_en.Text = "0";
            this.tb_en.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ma
            // 
            this.tb_ma.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ma.Location = new System.Drawing.Point(104, 127);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(110, 23);
            this.tb_ma.TabIndex = 6;
            this.tb_ma.Text = "0";
            this.tb_ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ch
            // 
            this.tb_ch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_ch.Location = new System.Drawing.Point(104, 77);
            this.tb_ch.Name = "tb_ch";
            this.tb_ch.Size = new System.Drawing.Size(110, 23);
            this.tb_ch.TabIndex = 5;
            this.tb_ch.Text = "0";
            this.tb_ch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_name.Location = new System.Drawing.Point(104, 28);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(110, 23);
            this.tb_name.TabIndex = 4;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gb_score
            // 
            this.gb_score.BackColor = System.Drawing.SystemColors.Control;
            this.gb_score.Controls.Add(this.but_highest);
            this.gb_score.Controls.Add(this.but_clear);
            this.gb_score.Controls.Add(this.lab_sum);
            this.gb_score.Controls.Add(this.lab_score);
            this.gb_score.Location = new System.Drawing.Point(279, 29);
            this.gb_score.Name = "gb_score";
            this.gb_score.Size = new System.Drawing.Size(240, 286);
            this.gb_score.TabIndex = 2;
            this.gb_score.TabStop = false;
            this.gb_score.Text = "成績顯示";
            // 
            // but_highest
            // 
            this.but_highest.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_highest.Location = new System.Drawing.Point(123, 236);
            this.but_highest.Name = "but_highest";
            this.but_highest.Size = new System.Drawing.Size(94, 31);
            this.but_highest.TabIndex = 11;
            this.but_highest.Text = "最高/低分";
            this.but_highest.UseVisualStyleBackColor = true;
            this.but_highest.Click += new System.EventHandler(this.but_highest_Click);
            // 
            // but_clear
            // 
            this.but_clear.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_clear.Location = new System.Drawing.Point(23, 236);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(94, 31);
            this.but_clear.TabIndex = 10;
            this.but_clear.Text = "清除資料";
            this.but_clear.UseVisualStyleBackColor = true;
            this.but_clear.Click += new System.EventHandler(this.but_clear_Click);
            // 
            // lab_sum
            // 
            this.lab_sum.BackColor = System.Drawing.SystemColors.Control;
            this.lab_sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_sum.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_sum.Location = new System.Drawing.Point(13, 146);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(214, 74);
            this.lab_sum.TabIndex = 1;
            // 
            // lab_score
            // 
            this.lab_score.BackColor = System.Drawing.SystemColors.Control;
            this.lab_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_score.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_score.Location = new System.Drawing.Point(13, 26);
            this.lab_score.Name = "lab_score";
            this.lab_score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_score.Size = new System.Drawing.Size(215, 110);
            this.lab_score.TabIndex = 0;
            // 
            // Form_StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 351);
            this.Controls.Add(this.gb_score);
            this.Controls.Add(this.gb_keyin);
            this.Name = "Form_StudentForm";
            this.Text = "Form_StudentForm";
            this.gb_keyin.ResumeLayout(false);
            this.gb_keyin.PerformLayout();
            this.gb_score.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_ch;
        private System.Windows.Forms.Label lab_ma;
        private System.Windows.Forms.Label lab_en;
        private System.Windows.Forms.GroupBox gb_keyin;
        private System.Windows.Forms.TextBox tb_en;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_ch;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button but_show;
        private System.Windows.Forms.Button but_sve;
        private System.Windows.Forms.GroupBox gb_score;
        private System.Windows.Forms.Label lab_sum;
        private System.Windows.Forms.Label lab_score;
        private System.Windows.Forms.Button but_highest;
        private System.Windows.Forms.Button but_clear;
    }
}