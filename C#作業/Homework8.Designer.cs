namespace C_作業
{
    partial class Homework8
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
            this.labNum2 = new System.Windows.Forms.Label();
            this.labNum1 = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnreduce = new System.Windows.Forms.Button();
            this.btntake = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(86, 154);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(98, 31);
            this.labNum2.TabIndex = 3;
            this.labNum2.Text = "Num2: ";
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(86, 79);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(98, 31);
            this.labNum1.TabIndex = 2;
            this.labNum1.Text = "Num1: ";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnswer.Location = new System.Drawing.Point(86, 289);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(111, 31);
            this.labAnswer.TabIndex = 4;
            this.labAnswer.Text = "Answer: ";
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum1.Location = new System.Drawing.Point(219, 76);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(139, 39);
            this.txtnum1.TabIndex = 6;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum2.Location = new System.Drawing.Point(219, 151);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(139, 39);
            this.txtnum2.TabIndex = 7;
            // 
            // txtanswer
            // 
            this.txtanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtanswer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtanswer.Location = new System.Drawing.Point(219, 287);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.ReadOnly = true;
            this.txtanswer.Size = new System.Drawing.Size(139, 39);
            this.txtanswer.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnadd.Location = new System.Drawing.Point(414, 38);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 61);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnreduce
            // 
            this.btnreduce.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreduce.Location = new System.Drawing.Point(414, 105);
            this.btnreduce.Name = "btnreduce";
            this.btnreduce.Size = new System.Drawing.Size(93, 61);
            this.btnreduce.TabIndex = 10;
            this.btnreduce.Text = "-";
            this.btnreduce.UseVisualStyleBackColor = true;
            this.btnreduce.Click += new System.EventHandler(this.btnreduce_Click);
            // 
            // btntake
            // 
            this.btntake.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntake.Location = new System.Drawing.Point(414, 172);
            this.btntake.Name = "btntake";
            this.btntake.Size = new System.Drawing.Size(93, 61);
            this.btntake.TabIndex = 11;
            this.btntake.Text = "*";
            this.btntake.UseVisualStyleBackColor = true;
            this.btntake.Click += new System.EventHandler(this.btntake_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnremove.Location = new System.Drawing.Point(414, 278);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(93, 61);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "/";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(92, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(381, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "= = = = = = = = = = = = = = = = = = = = ";
            // 
            // Homework8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btntake);
            this.Controls.Add(this.btnreduce);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Name = "Homework8";
            this.Text = "Homework8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreduce;
        private System.Windows.Forms.Button btntake;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox textBox1;
    }
}