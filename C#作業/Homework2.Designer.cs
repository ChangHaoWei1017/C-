namespace C_作業
{
    partial class Homework2
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
            this.Lab頭期款 = new System.Windows.Forms.Label();
            this.Lab利率 = new System.Windows.Forms.Label();
            this.Lab期限 = new System.Windows.Forms.Label();
            this.Lab貸款 = new System.Windows.Forms.Label();
            this.btnpmt = new System.Windows.Forms.Button();
            this.btn總付款 = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.txtloan = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtpercen = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lab頭期款
            // 
            this.Lab頭期款.AutoSize = true;
            this.Lab頭期款.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab頭期款.Location = new System.Drawing.Point(192, 303);
            this.Lab頭期款.Name = "Lab頭期款";
            this.Lab頭期款.Size = new System.Drawing.Size(104, 37);
            this.Lab頭期款.TabIndex = 7;
            this.Lab頭期款.Text = "頭期款";
            // 
            // Lab利率
            // 
            this.Lab利率.AutoSize = true;
            this.Lab利率.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab利率.Location = new System.Drawing.Point(192, 232);
            this.Lab利率.Name = "Lab利率";
            this.Lab利率.Size = new System.Drawing.Size(121, 37);
            this.Lab利率.TabIndex = 6;
            this.Lab利率.Text = "利率(%)";
            // 
            // Lab期限
            // 
            this.Lab期限.AutoSize = true;
            this.Lab期限.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab期限.Location = new System.Drawing.Point(190, 165);
            this.Lab期限.Name = "Lab期限";
            this.Lab期限.Size = new System.Drawing.Size(124, 37);
            this.Lab期限.TabIndex = 5;
            this.Lab期限.Text = "期限(年)";
            // 
            // Lab貸款
            // 
            this.Lab貸款.AutoSize = true;
            this.Lab貸款.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab貸款.Location = new System.Drawing.Point(190, 96);
            this.Lab貸款.Name = "Lab貸款";
            this.Lab貸款.Size = new System.Drawing.Size(133, 37);
            this.Lab貸款.TabIndex = 4;
            this.Lab貸款.Text = "貸款金額";
            // 
            // btnpmt
            // 
            this.btnpmt.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpmt.Location = new System.Drawing.Point(101, 445);
            this.btnpmt.Name = "btnpmt";
            this.btnpmt.Size = new System.Drawing.Size(154, 60);
            this.btnpmt.TabIndex = 8;
            this.btnpmt.Text = "PMT(月付)";
            this.btnpmt.UseVisualStyleBackColor = true;
            this.btnpmt.Click += new System.EventHandler(this.btnpmt_Click);
            // 
            // btn總付款
            // 
            this.btn總付款.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn總付款.Location = new System.Drawing.Point(279, 445);
            this.btn總付款.Name = "btn總付款";
            this.btn總付款.Size = new System.Drawing.Size(152, 60);
            this.btn總付款.TabIndex = 9;
            this.btn總付款.Text = "總付款";
            this.btn總付款.UseVisualStyleBackColor = true;
            this.btn總付款.Click += new System.EventHandler(this.btn總付款_Click);
            // 
            // btnreport
            // 
            this.btnreport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreport.Location = new System.Drawing.Point(560, 445);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(179, 60);
            this.btnreport.TabIndex = 10;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // txtloan
            // 
            this.txtloan.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtloan.Location = new System.Drawing.Point(449, 90);
            this.txtloan.Name = "txtloan";
            this.txtloan.Size = new System.Drawing.Size(159, 43);
            this.txtloan.TabIndex = 11;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtyear.Location = new System.Drawing.Point(449, 164);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(159, 43);
            this.txtyear.TabIndex = 12;
            // 
            // txtpercen
            // 
            this.txtpercen.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtpercen.Location = new System.Drawing.Point(449, 231);
            this.txtpercen.Name = "txtpercen";
            this.txtpercen.Size = new System.Drawing.Size(159, 43);
            this.txtpercen.TabIndex = 13;
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTop.Location = new System.Drawing.Point(449, 302);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(159, 43);
            this.txtTop.TabIndex = 14;
            // 
            // Homework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 605);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtpercen);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtloan);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btn總付款);
            this.Controls.Add(this.btnpmt);
            this.Controls.Add(this.Lab頭期款);
            this.Controls.Add(this.Lab利率);
            this.Controls.Add(this.Lab期限);
            this.Controls.Add(this.Lab貸款);
            this.Name = "Homework2";
            this.Text = "Homework2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab頭期款;
        private System.Windows.Forms.Label Lab利率;
        private System.Windows.Forms.Label Lab期限;
        private System.Windows.Forms.Label Lab貸款;
        private System.Windows.Forms.Button btnpmt;
        private System.Windows.Forms.Button btn總付款;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.TextBox txtloan;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtpercen;
        private System.Windows.Forms.TextBox txtTop;
    }
}