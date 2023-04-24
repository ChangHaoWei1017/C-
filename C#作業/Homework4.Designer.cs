namespace C_作業
{
    partial class Homework4
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
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labchinese = new System.Windows.Forms.Label();
            this.lab姓名 = new System.Windows.Forms.Label();
            this.btn儲存 = new System.Windows.Forms.Button();
            this.btn顯示 = new System.Windows.Forms.Button();
            this.btnMaxMini = new System.Windows.Forms.Button();
            this.gb成績 = new System.Windows.Forms.GroupBox();
            this.txtshow2 = new System.Windows.Forms.TextBox();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.gb成績.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(94, 285);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(74, 31);
            this.labMath.TabIndex = 7;
            this.labMath.Text = "數學 :";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(94, 213);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(74, 31);
            this.labEnglish.TabIndex = 6;
            this.labEnglish.Text = "英文 :";
            // 
            // labchinese
            // 
            this.labchinese.AutoSize = true;
            this.labchinese.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labchinese.Location = new System.Drawing.Point(94, 139);
            this.labchinese.Name = "labchinese";
            this.labchinese.Size = new System.Drawing.Size(80, 31);
            this.labchinese.TabIndex = 5;
            this.labchinese.Text = "國文 : ";
            // 
            // lab姓名
            // 
            this.lab姓名.AutoSize = true;
            this.lab姓名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab姓名.Location = new System.Drawing.Point(94, 67);
            this.lab姓名.Name = "lab姓名";
            this.lab姓名.Size = new System.Drawing.Size(80, 31);
            this.lab姓名.TabIndex = 4;
            this.lab姓名.Text = "姓名 : ";
            // 
            // btn儲存
            // 
            this.btn儲存.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn儲存.Location = new System.Drawing.Point(32, 400);
            this.btn儲存.Name = "btn儲存";
            this.btn儲存.Size = new System.Drawing.Size(136, 69);
            this.btn儲存.TabIndex = 8;
            this.btn儲存.Text = "儲存";
            this.btn儲存.UseVisualStyleBackColor = true;
            this.btn儲存.Click += new System.EventHandler(this.btn儲存_Click);
            // 
            // btn顯示
            // 
            this.btn顯示.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示.Location = new System.Drawing.Point(206, 400);
            this.btn顯示.Name = "btn顯示";
            this.btn顯示.Size = new System.Drawing.Size(180, 69);
            this.btn顯示.TabIndex = 9;
            this.btn顯示.Text = "顯示儲存內容";
            this.btn顯示.UseVisualStyleBackColor = true;
            this.btn顯示.Click += new System.EventHandler(this.btn顯示_Click);
            // 
            // btnMaxMini
            // 
            this.btnMaxMini.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMini.Location = new System.Drawing.Point(608, 539);
            this.btnMaxMini.Name = "btnMaxMini";
            this.btnMaxMini.Size = new System.Drawing.Size(259, 78);
            this.btnMaxMini.TabIndex = 10;
            this.btnMaxMini.Text = "最高分/最低分科目";
            this.btnMaxMini.UseVisualStyleBackColor = true;
            this.btnMaxMini.Click += new System.EventHandler(this.btnMaxMini_Click);
            // 
            // gb成績
            // 
            this.gb成績.Controls.Add(this.txtshow2);
            this.gb成績.Controls.Add(this.txtshow);
            this.gb成績.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb成績.Location = new System.Drawing.Point(430, 67);
            this.gb成績.Name = "gb成績";
            this.gb成績.Size = new System.Drawing.Size(471, 436);
            this.gb成績.TabIndex = 11;
            this.gb成績.TabStop = false;
            this.gb成績.Text = "成績";
            // 
            // txtshow2
            // 
            this.txtshow2.Location = new System.Drawing.Point(23, 301);
            this.txtshow2.Multiline = true;
            this.txtshow2.Name = "txtshow2";
            this.txtshow2.ReadOnly = true;
            this.txtshow2.Size = new System.Drawing.Size(429, 119);
            this.txtshow2.TabIndex = 1;
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(23, 38);
            this.txtshow.Multiline = true;
            this.txtshow.Name = "txtshow";
            this.txtshow.ReadOnly = true;
            this.txtshow.Size = new System.Drawing.Size(429, 244);
            this.txtshow.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(244, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 35);
            this.txtName.TabIndex = 12;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtchi
            // 
            this.txtchi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtchi.Location = new System.Drawing.Point(244, 139);
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(120, 35);
            this.txtchi.TabIndex = 13;
            this.txtchi.Text = "0";
            this.txtchi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txteng
            // 
            this.txteng.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txteng.Location = new System.Drawing.Point(244, 213);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(120, 35);
            this.txteng.TabIndex = 14;
            this.txteng.Text = "0";
            this.txteng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmath.Location = new System.Drawing.Point(244, 285);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(120, 35);
            this.txtmath.TabIndex = 15;
            this.txtmath.Text = "0";
            this.txtmath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Homework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 667);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.txtchi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gb成績);
            this.Controls.Add(this.btnMaxMini);
            this.Controls.Add(this.btn顯示);
            this.Controls.Add(this.btn儲存);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labchinese);
            this.Controls.Add(this.lab姓名);
            this.Name = "Homework4";
            this.Text = "Homework4";
            this.gb成績.ResumeLayout(false);
            this.gb成績.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labchinese;
        private System.Windows.Forms.Label lab姓名;
        private System.Windows.Forms.Button btn儲存;
        private System.Windows.Forms.Button btn顯示;
        private System.Windows.Forms.Button btnMaxMini;
        private System.Windows.Forms.GroupBox gb成績;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtchi;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.TextBox txtshow2;
        private System.Windows.Forms.TextBox txtshow;
    }
}