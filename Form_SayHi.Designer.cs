namespace SayHiHi
{
    partial class Form_SayHi
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ch = new System.Windows.Forms.TextBox();
            this.tb_en = new System.Windows.Forms.TextBox();
            this.rb_girl = new System.Windows.Forms.RadioButton();
            this.rb_boy = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(491, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "中文姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(491, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "英文姓名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(517, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "生日:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(517, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "性別:";
            // 
            // tb_ch
            // 
            this.tb_ch.Location = new System.Drawing.Point(560, 292);
            this.tb_ch.Name = "tb_ch";
            this.tb_ch.Size = new System.Drawing.Size(100, 25);
            this.tb_ch.TabIndex = 5;
            // 
            // tb_en
            // 
            this.tb_en.Location = new System.Drawing.Point(560, 334);
            this.tb_en.Name = "tb_en";
            this.tb_en.Size = new System.Drawing.Size(100, 25);
            this.tb_en.TabIndex = 6;
            // 
            // rb_girl
            // 
            this.rb_girl.AutoSize = true;
            this.rb_girl.BackColor = System.Drawing.Color.Transparent;
            this.rb_girl.Location = new System.Drawing.Point(560, 388);
            this.rb_girl.Name = "rb_girl";
            this.rb_girl.Size = new System.Drawing.Size(52, 21);
            this.rb_girl.TabIndex = 7;
            this.rb_girl.TabStop = true;
            this.rb_girl.Text = "女生";
            this.rb_girl.UseVisualStyleBackColor = false;
            // 
            // rb_boy
            // 
            this.rb_boy.AutoSize = true;
            this.rb_boy.BackColor = System.Drawing.Color.Transparent;
            this.rb_boy.Location = new System.Drawing.Point(618, 388);
            this.rb_boy.Name = "rb_boy";
            this.rb_boy.Size = new System.Drawing.Size(52, 21);
            this.rb_boy.TabIndex = 8;
            this.rb_boy.TabStop = true;
            this.rb_boy.Text = "男生";
            this.rb_boy.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 427);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 27, 0, 0, 0, 0);
            // 
            // Form_SayHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SayHiHi.Properties.Resources._5f320cead54d0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 529);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rb_boy);
            this.Controls.Add(this.rb_girl);
            this.Controls.Add(this.tb_en);
            this.Controls.Add(this.tb_ch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_SayHi";
            this.Text = "Form_SayHi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ch;
        private System.Windows.Forms.TextBox tb_en;
        private System.Windows.Forms.RadioButton rb_girl;
        private System.Windows.Forms.RadioButton rb_boy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}