namespace MODIS数据下载地址生成
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nud_year = new System.Windows.Forms.NumericUpDown();
            this.nud_month = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "月";
            // 
            // cb_year
            // 
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cb_year.Location = new System.Drawing.Point(117, 22);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(63, 29);
            this.cb_year.TabIndex = 3;
            this.cb_year.SelectedIndexChanged += new System.EventHandler(this.cb_year_SelectedIndexChanged);
            // 
            // cb_month
            // 
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_month.Location = new System.Drawing.Point(222, 22);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(48, 29);
            this.cb_month.TabIndex = 3;
            this.cb_month.SelectedIndexChanged += new System.EventHandler(this.cb_month_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(330, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "生成代码 + 下载地址";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(630, 333);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "清空内容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "复制内容";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nud_year
            // 
            this.nud_year.Location = new System.Drawing.Point(117, 58);
            this.nud_year.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nud_year.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nud_year.Name = "nud_year";
            this.nud_year.Size = new System.Drawing.Size(63, 29);
            this.nud_year.TabIndex = 6;
            this.nud_year.Value = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.nud_year.ValueChanged += new System.EventHandler(this.nud_year_ValueChanged);
            // 
            // nud_month
            // 
            this.nud_month.Location = new System.Drawing.Point(222, 58);
            this.nud_month.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nud_month.Name = "nud_month";
            this.nud_month.Size = new System.Drawing.Size(48, 29);
            this.nud_month.TabIndex = 6;
            this.nud_month.ValueChanged += new System.EventHandler(this.nud_month_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(568, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 62);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 36);
            this.textBox1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "A_SST";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 28);
            this.button5.TabIndex = 8;
            this.button5.Text = "A_CHL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 28);
            this.button6.TabIndex = 8;
            this.button6.Text = "A_PAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(23, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "A_RRS_488";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 174);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 28);
            this.button8.TabIndex = 8;
            this.button8.Text = "A_RRS_531";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 208);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = "A_RRS_547";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 242);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 28);
            this.button10.TabIndex = 8;
            this.button10.Text = "A_RRS_645";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 28);
            this.button11.TabIndex = 8;
            this.button11.Text = "A_RRS_667";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(144, 38);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 28);
            this.button12.TabIndex = 8;
            this.button12.Text = "T_SST";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(143, 72);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(103, 28);
            this.button13.TabIndex = 8;
            this.button13.Text = "T_CHL";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(143, 106);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(103, 28);
            this.button14.TabIndex = 8;
            this.button14.Text = "T_PAR";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(143, 140);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(103, 28);
            this.button15.TabIndex = 8;
            this.button15.Text = "T_RRS_488";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(143, 174);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(103, 28);
            this.button16.TabIndex = 8;
            this.button16.Text = "T_RRS_531";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(143, 208);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(103, 28);
            this.button17.TabIndex = 8;
            this.button17.Text = "T_RRS_547";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(144, 242);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(103, 28);
            this.button18.TabIndex = 8;
            this.button18.Text = "T_RRS_645";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(144, 276);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(103, 28);
            this.button19.TabIndex = 8;
            this.button19.Text = "T_RRS_667";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(659, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 333);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单个地址复制";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nud_month);
            this.Controls.Add(this.nud_year);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIS数据下载地址生成";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_month)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_year;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nud_year;
        private System.Windows.Forms.NumericUpDown nud_month;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

