namespace SayHiHi
{
    partial class start
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lab_CSharp = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.but_MyClas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.but_POS = new System.Windows.Forms.Button();
            this.but_SayHi = new System.Windows.Forms.Button();
            this.btn_loan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.lab_CSharp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // lab_CSharp
            // 
            this.lab_CSharp.AutoSize = true;
            this.lab_CSharp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_CSharp.Location = new System.Drawing.Point(38, 32);
            this.lab_CSharp.Name = "lab_CSharp";
            this.lab_CSharp.Size = new System.Drawing.Size(63, 21);
            this.lab_CSharp.TabIndex = 0;
            this.lab_CSharp.Text = "C#作業";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.btn_loan);
            this.splitContainer2.Panel1.Controls.Add(this.but_MyClas);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.but_POS);
            this.splitContainer2.Panel1.Controls.Add(this.but_SayHi);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Size = new System.Drawing.Size(800, 357);
            this.splitContainer2.SplitterDistance = 141;
            this.splitContainer2.TabIndex = 0;
            // 
            // but_MyClas
            // 
            this.but_MyClas.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_MyClas.Location = new System.Drawing.Point(23, 152);
            this.but_MyClas.Name = "but_MyClas";
            this.but_MyClas.Size = new System.Drawing.Size(105, 26);
            this.but_MyClas.TabIndex = 3;
            this.but_MyClas.Text = "My Clas";
            this.but_MyClas.UseVisualStyleBackColor = true;
            this.but_MyClas.Click += new System.EventHandler(this.but_MyClas_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(23, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Student Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_POS
            // 
            this.but_POS.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_POS.Location = new System.Drawing.Point(23, 65);
            this.but_POS.Name = "but_POS";
            this.but_POS.Size = new System.Drawing.Size(105, 26);
            this.but_POS.TabIndex = 1;
            this.but_POS.Text = "POS";
            this.but_POS.UseVisualStyleBackColor = true;
            this.but_POS.Click += new System.EventHandler(this.but_POS_Click);
            // 
            // but_SayHi
            // 
            this.but_SayHi.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_SayHi.Location = new System.Drawing.Point(23, 23);
            this.but_SayHi.Name = "but_SayHi";
            this.but_SayHi.Size = new System.Drawing.Size(105, 26);
            this.but_SayHi.TabIndex = 0;
            this.but_SayHi.Text = "Say Hi !";
            this.but_SayHi.UseVisualStyleBackColor = true;
            this.but_SayHi.Click += new System.EventHandler(this.but_SayHi_Click);
            // 
            // btn_loan
            // 
            this.btn_loan.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_loan.Location = new System.Drawing.Point(23, 198);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(105, 26);
            this.btn_loan.TabIndex = 4;
            this.btn_loan.Text = "Loan";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "start";
            this.Text = "Start";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lab_CSharp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button but_SayHi;
        private System.Windows.Forms.Button but_POS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button but_MyClas;
        private System.Windows.Forms.Button btn_loan;
    }
}