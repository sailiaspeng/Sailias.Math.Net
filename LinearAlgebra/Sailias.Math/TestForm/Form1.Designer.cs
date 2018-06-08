namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MatrixABox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colInput1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rowInput1 = new System.Windows.Forms.TextBox();
            this.valueInput1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rowInput2 = new System.Windows.Forms.TextBox();
            this.valueInput2 = new System.Windows.Forms.TextBox();
            this.Btext = new System.Windows.Forms.RichTextBox();
            this.Atext = new System.Windows.Forms.RichTextBox();
            this.RankBtn = new System.Windows.Forms.Button();
            this.TransformBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MatrixABox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(742, 167);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(308, 166);
            this.resultText.TabIndex = 7;
            this.resultText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "运算结果";
            // 
            // MatrixABox
            // 
            this.MatrixABox.Controls.Add(this.label5);
            this.MatrixABox.Controls.Add(this.label6);
            this.MatrixABox.Controls.Add(this.colInput1);
            this.MatrixABox.Controls.Add(this.label7);
            this.MatrixABox.Controls.Add(this.rowInput1);
            this.MatrixABox.Controls.Add(this.valueInput1);
            this.MatrixABox.Location = new System.Drawing.Point(12, 21);
            this.MatrixABox.Name = "MatrixABox";
            this.MatrixABox.Size = new System.Drawing.Size(568, 45);
            this.MatrixABox.TabIndex = 9;
            this.MatrixABox.TabStop = false;
            this.MatrixABox.Text = "矩阵A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "值列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "列数";
            // 
            // colInput1
            // 
            this.colInput1.Location = new System.Drawing.Point(148, 12);
            this.colInput1.Name = "colInput1";
            this.colInput1.Size = new System.Drawing.Size(55, 21);
            this.colInput1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "行数";
            // 
            // rowInput1
            // 
            this.rowInput1.Location = new System.Drawing.Point(52, 12);
            this.rowInput1.Name = "rowInput1";
            this.rowInput1.Size = new System.Drawing.Size(55, 21);
            this.rowInput1.TabIndex = 9;
            // 
            // valueInput1
            // 
            this.valueInput1.Location = new System.Drawing.Point(264, 12);
            this.valueInput1.Name = "valueInput1";
            this.valueInput1.Size = new System.Drawing.Size(298, 21);
            this.valueInput1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.colInput2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rowInput2);
            this.groupBox2.Controls.Add(this.valueInput2);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 45);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "矩阵B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "值列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "列数";
            // 
            // colInput2
            // 
            this.colInput2.Location = new System.Drawing.Point(148, 12);
            this.colInput2.Name = "colInput2";
            this.colInput2.Size = new System.Drawing.Size(55, 21);
            this.colInput2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "行数";
            // 
            // rowInput2
            // 
            this.rowInput2.Location = new System.Drawing.Point(52, 12);
            this.rowInput2.Name = "rowInput2";
            this.rowInput2.Size = new System.Drawing.Size(55, 21);
            this.rowInput2.TabIndex = 9;
            // 
            // valueInput2
            // 
            this.valueInput2.Location = new System.Drawing.Point(264, 12);
            this.valueInput2.Name = "valueInput2";
            this.valueInput2.Size = new System.Drawing.Size(298, 21);
            this.valueInput2.TabIndex = 7;
            // 
            // Btext
            // 
            this.Btext.Location = new System.Drawing.Point(324, 165);
            this.Btext.Name = "Btext";
            this.Btext.Size = new System.Drawing.Size(293, 166);
            this.Btext.TabIndex = 15;
            this.Btext.Text = "";
            // 
            // Atext
            // 
            this.Atext.Location = new System.Drawing.Point(14, 165);
            this.Atext.Name = "Atext";
            this.Atext.Size = new System.Drawing.Size(293, 166);
            this.Atext.TabIndex = 16;
            this.Atext.Text = "";
            // 
            // RankBtn
            // 
            this.RankBtn.Location = new System.Drawing.Point(634, 297);
            this.RankBtn.Name = "RankBtn";
            this.RankBtn.Size = new System.Drawing.Size(75, 23);
            this.RankBtn.TabIndex = 20;
            this.RankBtn.Text = "求秩";
            this.RankBtn.UseVisualStyleBackColor = true;
            this.RankBtn.Click += new System.EventHandler(this.RankBtn_Click);
            // 
            // TransformBtn
            // 
            this.TransformBtn.Location = new System.Drawing.Point(634, 258);
            this.TransformBtn.Name = "TransformBtn";
            this.TransformBtn.Size = new System.Drawing.Size(75, 23);
            this.TransformBtn.TabIndex = 19;
            this.TransformBtn.Text = "转置";
            this.TransformBtn.UseVisualStyleBackColor = true;
            this.TransformBtn.Click += new System.EventHandler(this.TransformBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Location = new System.Drawing.Point(634, 219);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.MultiplyBtn.TabIndex = 18;
            this.MultiplyBtn.Text = "求积";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Location = new System.Drawing.Point(634, 180);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(75, 23);
            this.AdditionBtn.TabIndex = 17;
            this.AdditionBtn.Text = "求和";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "矩阵A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "矩阵B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 421);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RankBtn);
            this.Controls.Add(this.TransformBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.Atext);
            this.Controls.Add(this.Btext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MatrixABox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MatrixABox.ResumeLayout(false);
            this.MatrixABox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox MatrixABox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colInput1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rowInput1;
        private System.Windows.Forms.TextBox valueInput1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rowInput2;
        private System.Windows.Forms.TextBox valueInput2;
        private System.Windows.Forms.RichTextBox Btext;
        private System.Windows.Forms.RichTextBox Atext;
        private System.Windows.Forms.Button RankBtn;
        private System.Windows.Forms.Button TransformBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

