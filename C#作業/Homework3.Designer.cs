namespace C_作業
{
    partial class Homework3
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
            this.laboff = new System.Windows.Forms.Label();
            this.bntbeer = new System.Windows.Forms.Button();
            this.bntTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.bntCash = new System.Windows.Forms.Button();
            this.bntcreditcard = new System.Windows.Forms.Button();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtlistshow = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtmenu = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // laboff
            // 
            this.laboff.AutoSize = true;
            this.laboff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laboff.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.laboff.Location = new System.Drawing.Point(599, 349);
            this.laboff.Name = "laboff";
            this.laboff.Size = new System.Drawing.Size(150, 28);
            this.laboff.TabIndex = 8;
            this.laboff.Text = "信用卡享九折!";
            // 
            // bntbeer
            // 
            this.bntbeer.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntbeer.Location = new System.Drawing.Point(98, 123);
            this.bntbeer.Name = "bntbeer";
            this.bntbeer.Size = new System.Drawing.Size(127, 174);
            this.bntbeer.TabIndex = 10;
            this.bntbeer.Text = "啤酒 Beer NT$120";
            this.bntbeer.UseVisualStyleBackColor = true;
            this.bntbeer.Click += new System.EventHandler(this.bntbeer_Click);
            // 
            // bntTequila
            // 
            this.bntTequila.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntTequila.Location = new System.Drawing.Point(252, 123);
            this.bntTequila.Name = "bntTequila";
            this.bntTequila.Size = new System.Drawing.Size(127, 174);
            this.bntTequila.TabIndex = 11;
            this.bntTequila.Text = "龍舌蘭 Tequila NT$180";
            this.bntTequila.UseVisualStyleBackColor = true;
            this.bntTequila.Click += new System.EventHandler(this.bntTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(98, 324);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(127, 174);
            this.btnWhisky.TabIndex = 12;
            this.btnWhisky.Text = "威士忌 Whisky NT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(252, 324);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(127, 174);
            this.btnWine.TabIndex = 13;
            this.btnWine.Text = "紅酒 Wine NT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // bntCash
            // 
            this.bntCash.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntCash.Location = new System.Drawing.Point(460, 274);
            this.bntCash.Name = "bntCash";
            this.bntCash.Size = new System.Drawing.Size(113, 62);
            this.bntCash.TabIndex = 14;
            this.bntCash.Text = "現金";
            this.bntCash.UseVisualStyleBackColor = true;
            this.bntCash.Click += new System.EventHandler(this.bntCash_Click);
            // 
            // bntcreditcard
            // 
            this.bntcreditcard.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntcreditcard.Location = new System.Drawing.Point(590, 274);
            this.bntcreditcard.Name = "bntcreditcard";
            this.bntcreditcard.Size = new System.Drawing.Size(113, 62);
            this.bntcreditcard.TabIndex = 15;
            this.bntcreditcard.Text = "信用卡";
            this.bntcreditcard.UseVisualStyleBackColor = true;
            this.bntcreditcard.Click += new System.EventHandler(this.bntcreditcard_Click);
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txttotalprice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txttotalprice.ForeColor = System.Drawing.Color.Yellow;
            this.txttotalprice.Location = new System.Drawing.Point(460, 126);
            this.txttotalprice.Multiline = true;
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(256, 41);
            this.txttotalprice.TabIndex = 16;
            this.txttotalprice.Text = "NT$ 0";
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtlistshow
            // 
            this.txtlistshow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtlistshow.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtlistshow.Location = new System.Drawing.Point(806, 108);
            this.txtlistshow.Multiline = true;
            this.txtlistshow.Name = "txtlistshow";
            this.txtlistshow.ReadOnly = true;
            this.txtlistshow.Size = new System.Drawing.Size(293, 228);
            this.txtlistshow.TabIndex = 17;
            this.txtlistshow.Text = "尚未點餐";
            this.txtlistshow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtlistshow.TextChanged += new System.EventHandler(this.txtlistshow_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(970, 363);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 48);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtmenu
            // 
            this.txtmenu.BackColor = System.Drawing.SystemColors.Control;
            this.txtmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmenu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmenu.Location = new System.Drawing.Point(59, 59);
            this.txtmenu.Multiline = true;
            this.txtmenu.Name = "txtmenu";
            this.txtmenu.ReadOnly = true;
            this.txtmenu.Size = new System.Drawing.Size(358, 496);
            this.txtmenu.TabIndex = 19;
            this.txtmenu.Text = "菜單 Menu";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(435, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 140);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "總金額 Total Price";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(435, 221);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(296, 175);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "付款方式";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(774, 59);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(355, 375);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "購物清單 List";
            // 
            // Homework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 612);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtlistshow);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.bntcreditcard);
            this.Controls.Add(this.bntCash);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnWhisky);
            this.Controls.Add(this.bntTequila);
            this.Controls.Add(this.bntbeer);
            this.Controls.Add(this.laboff);
            this.Controls.Add(this.txtmenu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Name = "Homework3";
            this.Text = "Homework3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laboff;
        private System.Windows.Forms.Button bntbeer;
        private System.Windows.Forms.Button bntTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button bntCash;
        private System.Windows.Forms.Button bntcreditcard;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.TextBox txtlistshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtmenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}