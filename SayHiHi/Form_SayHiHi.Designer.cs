namespace SayHiHi
{
    partial class Form_SayHiHi
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SayHiHi));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label_chName = new System.Windows.Forms.Label();
            this.label_enName = new System.Windows.Forms.Label();
            this.label_star = new System.Windows.Forms.Label();
            this.label_birthday = new System.Windows.Forms.Label();
            this.label_sex = new System.Windows.Forms.Label();
            this.textBox_chName = new System.Windows.Forms.TextBox();
            this.textBox_enName = new System.Windows.Forms.TextBox();
            this.textBox_star = new System.Windows.Forms.TextBox();
            this.textBox_sex = new System.Windows.Forms.TextBox();
            this.textBox_birthday_year = new System.Windows.Forms.TextBox();
            this.button_SayHi = new System.Windows.Forms.Button();
            this.textBox_birthday_month = new System.Windows.Forms.TextBox();
            this.textBox_birthday_day = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 509);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label_chName
            // 
            this.label_chName.AutoSize = true;
            this.label_chName.BackColor = System.Drawing.Color.Transparent;
            this.label_chName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_chName.Location = new System.Drawing.Point(477, 185);
            this.label_chName.Name = "label_chName";
            this.label_chName.Size = new System.Drawing.Size(78, 21);
            this.label_chName.TabIndex = 1;
            this.label_chName.Text = "中文姓名:";
            // 
            // label_enName
            // 
            this.label_enName.AutoSize = true;
            this.label_enName.BackColor = System.Drawing.Color.Transparent;
            this.label_enName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_enName.Location = new System.Drawing.Point(477, 223);
            this.label_enName.Name = "label_enName";
            this.label_enName.Size = new System.Drawing.Size(78, 21);
            this.label_enName.TabIndex = 2;
            this.label_enName.Text = "英文姓名:";
            // 
            // label_star
            // 
            this.label_star.AutoSize = true;
            this.label_star.BackColor = System.Drawing.Color.Transparent;
            this.label_star.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_star.Location = new System.Drawing.Point(477, 253);
            this.label_star.Name = "label_star";
            this.label_star.Size = new System.Drawing.Size(46, 21);
            this.label_star.TabIndex = 3;
            this.label_star.Text = "星座:";
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.BackColor = System.Drawing.Color.Transparent;
            this.label_birthday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_birthday.Location = new System.Drawing.Point(476, 323);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(78, 21);
            this.label_birthday.TabIndex = 4;
            this.label_birthday.Text = "西元生日:";
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.BackColor = System.Drawing.Color.Transparent;
            this.label_sex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_sex.Location = new System.Drawing.Point(477, 288);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(46, 21);
            this.label_sex.TabIndex = 5;
            this.label_sex.Text = "性別:";
            // 
            // textBox_chName
            // 
            this.textBox_chName.Location = new System.Drawing.Point(561, 184);
            this.textBox_chName.Name = "textBox_chName";
            this.textBox_chName.Size = new System.Drawing.Size(100, 22);
            this.textBox_chName.TabIndex = 6;
            // 
            // textBox_enName
            // 
            this.textBox_enName.Location = new System.Drawing.Point(561, 222);
            this.textBox_enName.Name = "textBox_enName";
            this.textBox_enName.Size = new System.Drawing.Size(100, 22);
            this.textBox_enName.TabIndex = 7;
            // 
            // textBox_star
            // 
            this.textBox_star.Location = new System.Drawing.Point(561, 252);
            this.textBox_star.Name = "textBox_star";
            this.textBox_star.Size = new System.Drawing.Size(100, 22);
            this.textBox_star.TabIndex = 8;
            // 
            // textBox_sex
            // 
            this.textBox_sex.Location = new System.Drawing.Point(561, 287);
            this.textBox_sex.Name = "textBox_sex";
            this.textBox_sex.Size = new System.Drawing.Size(100, 22);
            this.textBox_sex.TabIndex = 9;
            // 
            // textBox_birthday_year
            // 
            this.textBox_birthday_year.Location = new System.Drawing.Point(480, 352);
            this.textBox_birthday_year.Name = "textBox_birthday_year";
            this.textBox_birthday_year.Size = new System.Drawing.Size(58, 22);
            this.textBox_birthday_year.TabIndex = 10;
            this.textBox_birthday_year.TextChanged += new System.EventHandler(this.textBox_birthday_year_TextChanged);
            // 
            // button_SayHi
            // 
            this.button_SayHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SayHi.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_SayHi.Location = new System.Drawing.Point(550, 413);
            this.button_SayHi.Name = "button_SayHi";
            this.button_SayHi.Size = new System.Drawing.Size(75, 23);
            this.button_SayHi.TabIndex = 11;
            this.button_SayHi.Text = "Say Hi";
            this.button_SayHi.UseVisualStyleBackColor = true;
            this.button_SayHi.Click += new System.EventHandler(this.button_SayHi_Click);
            // 
            // textBox_birthday_month
            // 
            this.textBox_birthday_month.Location = new System.Drawing.Point(573, 352);
            this.textBox_birthday_month.Name = "textBox_birthday_month";
            this.textBox_birthday_month.Size = new System.Drawing.Size(25, 22);
            this.textBox_birthday_month.TabIndex = 12;
            this.textBox_birthday_month.TextChanged += new System.EventHandler(this.textBox_birthday_month_TextChanged);
            // 
            // textBox_birthday_day
            // 
            this.textBox_birthday_day.Location = new System.Drawing.Point(636, 352);
            this.textBox_birthday_day.Name = "textBox_birthday_day";
            this.textBox_birthday_day.Size = new System.Drawing.Size(25, 22);
            this.textBox_birthday_day.TabIndex = 13;
            this.textBox_birthday_day.TextChanged += new System.EventHandler(this.textBox_birthday_day_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(542, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "年";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(604, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "月";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(667, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "日";
            // 
            // Form_SayHiHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_birthday_day);
            this.Controls.Add(this.textBox_birthday_month);
            this.Controls.Add(this.button_SayHi);
            this.Controls.Add(this.textBox_birthday_year);
            this.Controls.Add(this.textBox_sex);
            this.Controls.Add(this.textBox_star);
            this.Controls.Add(this.textBox_enName);
            this.Controls.Add(this.textBox_chName);
            this.Controls.Add(this.label_sex);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_star);
            this.Controls.Add(this.label_enName);
            this.Controls.Add(this.label_chName);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_SayHiHi";
            this.Text = "SayHiHi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label_chName;
        private System.Windows.Forms.Label label_enName;
        private System.Windows.Forms.Label label_star;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.Label label_sex;
        private System.Windows.Forms.TextBox textBox_chName;
        private System.Windows.Forms.TextBox textBox_enName;
        private System.Windows.Forms.TextBox textBox_star;
        private System.Windows.Forms.TextBox textBox_sex;
        private System.Windows.Forms.TextBox textBox_birthday_year;
        private System.Windows.Forms.Button button_SayHi;
        private System.Windows.Forms.TextBox textBox_birthday_month;
        private System.Windows.Forms.TextBox textBox_birthday_day;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

