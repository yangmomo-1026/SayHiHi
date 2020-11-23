namespace SayHiHi
{
    partial class Form_MyClac
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
            this.tb_num_one = new System.Windows.Forms.TextBox();
            this.tb_num_two = new System.Windows.Forms.TextBox();
            this.but_addition = new System.Windows.Forms.Button();
            this.but_subtraction = new System.Windows.Forms.Button();
            this.but_mul = new System.Windows.Forms.Button();
            this.but_div = new System.Windows.Forms.Button();
            this.lab_ans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_num1 = new System.Windows.Forms.Label();
            this.lab_num2 = new System.Windows.Forms.Label();
            this.lab_answer_only = new System.Windows.Forms.Label();
            this.gb_MyClac = new System.Windows.Forms.GroupBox();
            this.gb_MyClac.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_num_one
            // 
            this.tb_num_one.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_num_one.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_num_one.Location = new System.Drawing.Point(83, 22);
            this.tb_num_one.Multiline = true;
            this.tb_num_one.Name = "tb_num_one";
            this.tb_num_one.Size = new System.Drawing.Size(107, 25);
            this.tb_num_one.TabIndex = 0;
            this.tb_num_one.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_num_two
            // 
            this.tb_num_two.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_num_two.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_num_two.Location = new System.Drawing.Point(83, 61);
            this.tb_num_two.Multiline = true;
            this.tb_num_two.Name = "tb_num_two";
            this.tb_num_two.Size = new System.Drawing.Size(107, 25);
            this.tb_num_two.TabIndex = 1;
            this.tb_num_two.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // but_addition
            // 
            this.but_addition.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_addition.Location = new System.Drawing.Point(218, 22);
            this.but_addition.Name = "but_addition";
            this.but_addition.Size = new System.Drawing.Size(60, 25);
            this.but_addition.TabIndex = 2;
            this.but_addition.Text = "+";
            this.but_addition.UseVisualStyleBackColor = true;
            this.but_addition.Click += new System.EventHandler(this.but_addition_Click);
            // 
            // but_subtraction
            // 
            this.but_subtraction.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_subtraction.Location = new System.Drawing.Point(218, 53);
            this.but_subtraction.Name = "but_subtraction";
            this.but_subtraction.Size = new System.Drawing.Size(60, 25);
            this.but_subtraction.TabIndex = 3;
            this.but_subtraction.Text = "-";
            this.but_subtraction.UseVisualStyleBackColor = true;
            this.but_subtraction.Click += new System.EventHandler(this.but_subtraction_Click);
            // 
            // but_mul
            // 
            this.but_mul.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_mul.Location = new System.Drawing.Point(218, 84);
            this.but_mul.Name = "but_mul";
            this.but_mul.Size = new System.Drawing.Size(60, 25);
            this.but_mul.TabIndex = 4;
            this.but_mul.Text = "*";
            this.but_mul.UseVisualStyleBackColor = true;
            this.but_mul.Click += new System.EventHandler(this.but_mul_Click);
            // 
            // but_div
            // 
            this.but_div.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_div.Location = new System.Drawing.Point(218, 115);
            this.but_div.Name = "but_div";
            this.but_div.Size = new System.Drawing.Size(60, 25);
            this.but_div.TabIndex = 5;
            this.but_div.Text = "/";
            this.but_div.UseVisualStyleBackColor = true;
            this.but_div.Click += new System.EventHandler(this.but_div_Click);
            // 
            // lab_ans
            // 
            this.lab_ans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_ans.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_ans.Location = new System.Drawing.Point(84, 111);
            this.lab_ans.Name = "lab_ans";
            this.lab_ans.Size = new System.Drawing.Size(106, 28);
            this.lab_ans.TabIndex = 6;
            this.lab_ans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------";
            // 
            // lab_num1
            // 
            this.lab_num1.AutoSize = true;
            this.lab_num1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_num1.Location = new System.Drawing.Point(15, 24);
            this.lab_num1.Name = "lab_num1";
            this.lab_num1.Size = new System.Drawing.Size(58, 21);
            this.lab_num1.TabIndex = 8;
            this.lab_num1.Text = "Num1";
            // 
            // lab_num2
            // 
            this.lab_num2.AutoSize = true;
            this.lab_num2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_num2.Location = new System.Drawing.Point(15, 64);
            this.lab_num2.Name = "lab_num2";
            this.lab_num2.Size = new System.Drawing.Size(58, 21);
            this.lab_num2.TabIndex = 9;
            this.lab_num2.Text = "Num2";
            // 
            // lab_answer_only
            // 
            this.lab_answer_only.AutoSize = true;
            this.lab_answer_only.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_answer_only.Location = new System.Drawing.Point(12, 116);
            this.lab_answer_only.Name = "lab_answer_only";
            this.lab_answer_only.Size = new System.Drawing.Size(68, 21);
            this.lab_answer_only.TabIndex = 10;
            this.lab_answer_only.Text = "Answer";
            // 
            // gb_MyClac
            // 
            this.gb_MyClac.Controls.Add(this.lab_answer_only);
            this.gb_MyClac.Controls.Add(this.lab_num2);
            this.gb_MyClac.Controls.Add(this.lab_num1);
            this.gb_MyClac.Controls.Add(this.label1);
            this.gb_MyClac.Controls.Add(this.lab_ans);
            this.gb_MyClac.Controls.Add(this.but_div);
            this.gb_MyClac.Controls.Add(this.but_mul);
            this.gb_MyClac.Controls.Add(this.but_subtraction);
            this.gb_MyClac.Controls.Add(this.but_addition);
            this.gb_MyClac.Controls.Add(this.tb_num_two);
            this.gb_MyClac.Controls.Add(this.tb_num_one);
            this.gb_MyClac.Location = new System.Drawing.Point(12, 12);
            this.gb_MyClac.Name = "gb_MyClac";
            this.gb_MyClac.Size = new System.Drawing.Size(290, 160);
            this.gb_MyClac.TabIndex = 11;
            this.gb_MyClac.TabStop = false;
            this.gb_MyClac.Text = "MyClac";
            // 
            // Form_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 456);
            this.Controls.Add(this.gb_MyClac);
            this.Name = "Form_MyClac";
            this.Text = "Form_MyClac";
            this.gb_MyClac.ResumeLayout(false);
            this.gb_MyClac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num_one;
        private System.Windows.Forms.TextBox tb_num_two;
        private System.Windows.Forms.Button but_addition;
        private System.Windows.Forms.Button but_subtraction;
        private System.Windows.Forms.Button but_mul;
        private System.Windows.Forms.Button but_div;
        private System.Windows.Forms.Label lab_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_num1;
        private System.Windows.Forms.Label lab_num2;
        private System.Windows.Forms.Label lab_answer_only;
        private System.Windows.Forms.GroupBox gb_MyClac;
    }
}