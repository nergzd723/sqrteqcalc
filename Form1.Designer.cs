namespace sqrteqcalc
{
    partial class sqrteqsolver
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.aarg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcbttn = new System.Windows.Forms.Button();
            this.barg = new System.Windows.Forms.TextBox();
            this.carg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.answ = new System.Windows.Forms.Label();
            this.previewlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aarg
            // 
            this.aarg.Location = new System.Drawing.Point(32, 66);
            this.aarg.Name = "aarg";
            this.aarg.Size = new System.Drawing.Size(28, 20);
            this.aarg.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Print your x, y and z argument at the proper windows.\r\nProgram will calculate you" +
    "r equation and solve it! ";
            // 
            // calcbttn
            // 
            this.calcbttn.Location = new System.Drawing.Point(98, 117);
            this.calcbttn.Name = "calcbttn";
            this.calcbttn.Size = new System.Drawing.Size(103, 27);
            this.calcbttn.TabIndex = 2;
            this.calcbttn.Text = "Calculate";
            this.calcbttn.UseVisualStyleBackColor = true;
            this.calcbttn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // barg
            // 
            this.barg.Location = new System.Drawing.Point(132, 66);
            this.barg.Name = "barg";
            this.barg.Size = new System.Drawing.Size(32, 20);
            this.barg.TabIndex = 3;
            // 
            // carg
            // 
            this.carg.Location = new System.Drawing.Point(243, 65);
            this.carg.Name = "carg";
            this.carg.Size = new System.Drawing.Size(29, 20);
            this.carg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // answ
            // 
            this.answ.AutoSize = true;
            this.answ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.answ.Location = new System.Drawing.Point(123, 147);
            this.answ.Name = "answ";
            this.answ.Size = new System.Drawing.Size(0, 18);
            this.answ.TabIndex = 9;
            // 
            // previewlabel
            // 
            this.previewlabel.AutoSize = true;
            this.previewlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.previewlabel.Location = new System.Drawing.Point(82, 93);
            this.previewlabel.Name = "previewlabel";
            this.previewlabel.Size = new System.Drawing.Size(0, 20);
            this.previewlabel.TabIndex = 10;
            // 
            // sqrteqsolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 214);
            this.Controls.Add(this.previewlabel);
            this.Controls.Add(this.answ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carg);
            this.Controls.Add(this.barg);
            this.Controls.Add(this.calcbttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aarg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "sqrteqsolver";
            this.Text = "sqrtoseqsolver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aarg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcbttn;
        private System.Windows.Forms.TextBox barg;
        private System.Windows.Forms.TextBox carg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label answ;
        private System.Windows.Forms.Label previewlabel;
    }
}

