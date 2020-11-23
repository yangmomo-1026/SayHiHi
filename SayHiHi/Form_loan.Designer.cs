namespace SayHiHi
{
    partial class Form_loan
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
            this.label_credit = new System.Windows.Forms.Label();
            this.textBox_credit = new System.Windows.Forms.TextBox();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.textBox_stage = new System.Windows.Forms.TextBox();
            this.label_stages = new System.Windows.Forms.Label();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.label_sum = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.期數 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.償還本金 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.償還利息 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.本期應繳金額 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label_credit
            // 
            this.label_credit.AutoSize = true;
            this.label_credit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_credit.Location = new System.Drawing.Point(91, 86);
            this.label_credit.Name = "label_credit";
            this.label_credit.Size = new System.Drawing.Size(74, 21);
            this.label_credit.TabIndex = 0;
            this.label_credit.Text = "貸款金額";
            // 
            // textBox_credit
            // 
            this.textBox_credit.Location = new System.Drawing.Point(199, 86);
            this.textBox_credit.Name = "textBox_credit";
            this.textBox_credit.Size = new System.Drawing.Size(100, 22);
            this.textBox_credit.TabIndex = 1;
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(199, 140);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(100, 22);
            this.textBox_rate.TabIndex = 3;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_rate.Location = new System.Drawing.Point(91, 140);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(84, 21);
            this.label_rate.TabIndex = 2;
            this.label_rate.Text = "年利率(%)";
            // 
            // textBox_stage
            // 
            this.textBox_stage.Location = new System.Drawing.Point(199, 199);
            this.textBox_stage.Name = "textBox_stage";
            this.textBox_stage.Size = new System.Drawing.Size(100, 22);
            this.textBox_stage.TabIndex = 5;
            // 
            // label_stages
            // 
            this.label_stages.AutoSize = true;
            this.label_stages.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_stages.Location = new System.Drawing.Point(91, 199);
            this.label_stages.Name = "label_stages";
            this.label_stages.Size = new System.Drawing.Size(102, 21);
            this.label_stages.TabIndex = 4;
            this.label_stages.Text = "貸款期數(月)";
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(199, 257);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(100, 22);
            this.textBox_sum.TabIndex = 7;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_sum.Location = new System.Drawing.Point(91, 257);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(58, 21);
            this.label_sum.TabIndex = 6;
            this.label_sum.Text = "總利息";
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_enter.Location = new System.Drawing.Point(159, 317);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 27);
            this.button_enter.TabIndex = 8;
            this.button_enter.Text = "輸入";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.期數,
            this.償還本金,
            this.償還利息,
            this.本期應繳金額});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(382, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(353, 348);
            this.listView1.TabIndex = 10;
            this.listView1.TileSize = new System.Drawing.Size(2, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 期數
            // 
            this.期數.Text = "期數";
            this.期數.Width = 50;
            // 
            // 償還本金
            // 
            this.償還本金.Text = "償還本金";
            this.償還本金.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.償還本金.Width = 100;
            // 
            // 償還利息
            // 
            this.償還利息.Text = "償還利息";
            this.償還利息.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.償還利息.Width = 100;
            // 
            // 本期應繳金額
            // 
            this.本期應繳金額.Text = "本期應繳金額";
            this.本期應繳金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.本期應繳金額.Width = 100;
            // 
            // Form_loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.textBox_stage);
            this.Controls.Add(this.label_stages);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.textBox_credit);
            this.Controls.Add(this.label_credit);
            this.Name = "Form_loan";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_credit;
        private System.Windows.Forms.TextBox textBox_credit;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.TextBox textBox_stage;
        private System.Windows.Forms.Label label_stages;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 期數;
        private System.Windows.Forms.ColumnHeader 償還本金;
        private System.Windows.Forms.ColumnHeader 償還利息;
        private System.Windows.Forms.ColumnHeader 本期應繳金額;
    }
}