namespace SayHiHi
{
    partial class Form_guess
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
            this.lab_guess = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_guess
            // 
            this.lab_guess.AutoSize = true;
            this.lab_guess.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_guess.Location = new System.Drawing.Point(82, 25);
            this.lab_guess.Name = "lab_guess";
            this.lab_guess.Size = new System.Drawing.Size(67, 24);
            this.lab_guess.TabIndex = 0;
            this.lab_guess.Text = "猜數字";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(7, 78);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(95, 31);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "輸入";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_answer
            // 
            this.btn_answer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_answer.Location = new System.Drawing.Point(127, 78);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(95, 31);
            this.btn_answer.TabIndex = 2;
            this.btn_answer.Text = "答案";
            this.btn_answer.UseVisualStyleBackColor = true;
            // 
            // Form_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 123);
            this.Controls.Add(this.btn_answer);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.lab_guess);
            this.Name = "Form_guess";
            this.Text = "Form_guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_guess;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_answer;
    }
}