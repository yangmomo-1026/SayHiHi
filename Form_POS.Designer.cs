namespace SayHiHi
{
    partial class Form_POS
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Wine = new System.Windows.Forms.Button();
            this.but_Whisky = new System.Windows.Forms.Button();
            this.but_Tequila = new System.Windows.Forms.Button();
            this.but_Beer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_sum = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_credit = new System.Windows.Forms.Button();
            this.but_Cash = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_list_box = new System.Windows.Forms.Label();
            this.but_delete = new System.Windows.Forms.Button();
            this.lab_list = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.but_Wine);
            this.panel_menu.Controls.Add(this.but_Whisky);
            this.panel_menu.Controls.Add(this.but_Tequila);
            this.panel_menu.Controls.Add(this.but_Beer);
            this.panel_menu.Location = new System.Drawing.Point(24, 88);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(187, 273);
            this.panel_menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "菜單 Menu：";
            // 
            // but_Wine
            // 
            this.but_Wine.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Wine.Location = new System.Drawing.Point(94, 153);
            this.but_Wine.Name = "but_Wine";
            this.but_Wine.Size = new System.Drawing.Size(85, 112);
            this.but_Wine.TabIndex = 3;
            this.but_Wine.Text = "Wine\r\n紅酒\r\nNT320";
            this.but_Wine.UseVisualStyleBackColor = true;
            this.but_Wine.Click += new System.EventHandler(this.but_Wine_Click);
            // 
            // but_Whisky
            // 
            this.but_Whisky.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Whisky.Location = new System.Drawing.Point(7, 153);
            this.but_Whisky.Name = "but_Whisky";
            this.but_Whisky.Size = new System.Drawing.Size(85, 112);
            this.but_Whisky.TabIndex = 2;
            this.but_Whisky.Text = "Whisky\r\n威士忌\r\nNT350";
            this.but_Whisky.UseVisualStyleBackColor = true;
            this.but_Whisky.Click += new System.EventHandler(this.but_Whisky_Click);
            // 
            // but_Tequila
            // 
            this.but_Tequila.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Tequila.Location = new System.Drawing.Point(94, 35);
            this.but_Tequila.Name = "but_Tequila";
            this.but_Tequila.Size = new System.Drawing.Size(85, 112);
            this.but_Tequila.TabIndex = 1;
            this.but_Tequila.Text = "Tequila\r\n龍舌蘭\r\nNT180";
            this.but_Tequila.UseVisualStyleBackColor = true;
            this.but_Tequila.Click += new System.EventHandler(this.but_Tequila_Click);
            // 
            // but_Beer
            // 
            this.but_Beer.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Beer.Location = new System.Drawing.Point(7, 35);
            this.but_Beer.Name = "but_Beer";
            this.but_Beer.Size = new System.Drawing.Size(85, 112);
            this.but_Beer.TabIndex = 0;
            this.but_Beer.Text = "Beer \r\n啤酒\r\nNT300";
            this.but_Beer.UseVisualStyleBackColor = true;
            this.but_Beer.Click += new System.EventHandler(this.but_Beer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lab_sum);
            this.panel1.Controls.Add(this.textBox_sum);
            this.panel1.Location = new System.Drawing.Point(217, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 95);
            this.panel1.TabIndex = 1;
            // 
            // lab_sum
            // 
            this.lab_sum.AutoSize = true;
            this.lab_sum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_sum.Location = new System.Drawing.Point(8, 9);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(157, 21);
            this.lab_sum.TabIndex = 1;
            this.lab_sum.Text = "總金額 Total Price：";
            // 
            // textBox_sum
            // 
            this.textBox_sum.BackColor = System.Drawing.Color.Black;
            this.textBox_sum.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_sum.ForeColor = System.Drawing.Color.White;
            this.textBox_sum.Location = new System.Drawing.Point(8, 38);
            this.textBox_sum.Multiline = true;
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.ReadOnly = true;
            this.textBox_sum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_sum.Size = new System.Drawing.Size(214, 38);
            this.textBox_sum.TabIndex = 0;
            this.textBox_sum.Text = "NT$ 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.but_credit);
            this.panel2.Controls.Add(this.but_Cash);
            this.panel2.Location = new System.Drawing.Point(217, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 171);
            this.panel2.TabIndex = 2;
            // 
            // but_credit
            // 
            this.but_credit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_credit.Location = new System.Drawing.Point(119, 9);
            this.but_credit.Name = "but_credit";
            this.but_credit.Size = new System.Drawing.Size(103, 153);
            this.but_credit.TabIndex = 5;
            this.but_credit.Text = "信用卡結帳\r\n享九折優惠";
            this.but_credit.UseVisualStyleBackColor = true;
            this.but_credit.Click += new System.EventHandler(this.but_credit_Click);
            // 
            // but_Cash
            // 
            this.but_Cash.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Cash.Location = new System.Drawing.Point(8, 9);
            this.but_Cash.Name = "but_Cash";
            this.but_Cash.Size = new System.Drawing.Size(103, 153);
            this.but_Cash.TabIndex = 4;
            this.but_Cash.Text = "現金結帳";
            this.but_Cash.UseVisualStyleBackColor = true;
            this.but_Cash.Click += new System.EventHandler(this.but_Cash_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lab_list_box);
            this.panel3.Controls.Add(this.but_delete);
            this.panel3.Controls.Add(this.lab_list);
            this.panel3.Location = new System.Drawing.Point(457, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 273);
            this.panel3.TabIndex = 3;
            // 
            // lab_list_box
            // 
            this.lab_list_box.BackColor = System.Drawing.Color.White;
            this.lab_list_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_list_box.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_list_box.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_list_box.Location = new System.Drawing.Point(10, 48);
            this.lab_list_box.Name = "lab_list_box";
            this.lab_list_box.Size = new System.Drawing.Size(222, 171);
            this.lab_list_box.TabIndex = 7;
            this.lab_list_box.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // but_delete
            // 
            this.but_delete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_delete.Location = new System.Drawing.Point(129, 238);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(103, 26);
            this.but_delete.TabIndex = 6;
            this.but_delete.Text = "清除清單";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // lab_list
            // 
            this.lab_list.AutoSize = true;
            this.lab_list.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_list.Location = new System.Drawing.Point(6, 13);
            this.lab_list.Name = "lab_list";
            this.lab_list.Size = new System.Drawing.Size(122, 21);
            this.lab_list.TabIndex = 2;
            this.lab_list.Text = "我的購物清單：";
            // 
            // Form_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.Name = "Form_POS";
            this.Text = "Form2";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button but_Wine;
        private System.Windows.Forms.Button but_Whisky;
        private System.Windows.Forms.Button but_Tequila;
        private System.Windows.Forms.Button but_Beer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button but_credit;
        private System.Windows.Forms.Button but_Cash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_sum;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Label lab_list;
        private System.Windows.Forms.Label lab_list_box;
    }
}