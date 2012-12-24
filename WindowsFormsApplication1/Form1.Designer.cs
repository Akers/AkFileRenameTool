namespace WindowsFormsApplication1
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
            this.BTN_change = new System.Windows.Forms.Button();
            this.TXT_oldname = new System.Windows.Forms.TextBox();
            this.BTN_selectFile = new System.Windows.Forms.Button();
            this.OFD_selectFile = new System.Windows.Forms.OpenFileDialog();
            this.LB_files = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_last = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_remove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RB_back = new System.Windows.Forms.RadioButton();
            this.RB_front = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_div = new System.Windows.Forms.TextBox();
            this.CB_nums = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LL_help = new System.Windows.Forms.LinkLabel();
            this.LL_about = new System.Windows.Forms.LinkLabel();
            this.BTN_rollback = new System.Windows.Forms.Button();
            this.BTN_clar = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_change
            // 
            this.BTN_change.Location = new System.Drawing.Point(12, 444);
            this.BTN_change.Name = "BTN_change";
            this.BTN_change.Size = new System.Drawing.Size(205, 22);
            this.BTN_change.TabIndex = 0;
            this.BTN_change.Text = "更名";
            this.BTN_change.UseVisualStyleBackColor = true;
            this.BTN_change.Click += new System.EventHandler(this.BTN_change_Click);
            // 
            // TXT_oldname
            // 
            this.TXT_oldname.Location = new System.Drawing.Point(50, 22);
            this.TXT_oldname.Name = "TXT_oldname";
            this.TXT_oldname.Size = new System.Drawing.Size(100, 21);
            this.TXT_oldname.TabIndex = 2;
            // 
            // BTN_selectFile
            // 
            this.BTN_selectFile.Location = new System.Drawing.Point(24, 227);
            this.BTN_selectFile.Name = "BTN_selectFile";
            this.BTN_selectFile.Size = new System.Drawing.Size(105, 23);
            this.BTN_selectFile.TabIndex = 3;
            this.BTN_selectFile.Text = "添加文件";
            this.BTN_selectFile.UseVisualStyleBackColor = true;
            this.BTN_selectFile.Click += new System.EventHandler(this.BTN_selectFile_Click);
            // 
            // OFD_selectFile
            // 
            this.OFD_selectFile.Multiselect = true;
            this.OFD_selectFile.Tag = "*.*";
            this.OFD_selectFile.Title = "请选择需要更名的文件";
            // 
            // LB_files
            // 
            this.LB_files.AllowDrop = true;
            this.LB_files.FormattingEnabled = true;
            this.LB_files.HorizontalScrollbar = true;
            this.LB_files.ItemHeight = 12;
            this.LB_files.Location = new System.Drawing.Point(2, 2);
            this.LB_files.Name = "LB_files";
            this.LB_files.Size = new System.Drawing.Size(455, 208);
            this.LB_files.Sorted = true;
            this.LB_files.TabIndex = 4;
            this.LB_files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.LB_files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_last);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_remove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_oldname);
            this.groupBox1.Location = new System.Drawing.Point(6, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件名更改（不更改项请留空）";
            // 
            // TXT_last
            // 
            this.TXT_last.Location = new System.Drawing.Point(297, 18);
            this.TXT_last.Name = "TXT_last";
            this.TXT_last.Size = new System.Drawing.Size(75, 21);
            this.TXT_last.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "后缀名（不包括\".\"）";
            // 
            // TXT_remove
            // 
            this.TXT_remove.Location = new System.Drawing.Point(213, 48);
            this.TXT_remove.Name = "TXT_remove";
            this.TXT_remove.Size = new System.Drawing.Size(216, 21);
            this.TXT_remove.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "在文件名中移除(多个关键字用/隔开)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件名";
            // 
            // RB_back
            // 
            this.RB_back.AutoSize = true;
            this.RB_back.Location = new System.Drawing.Point(221, 56);
            this.RB_back.Name = "RB_back";
            this.RB_back.Size = new System.Drawing.Size(71, 16);
            this.RB_back.TabIndex = 11;
            this.RB_back.Text = "后缀模式";
            this.RB_back.UseVisualStyleBackColor = true;
            // 
            // RB_front
            // 
            this.RB_front.AutoSize = true;
            this.RB_front.Checked = true;
            this.RB_front.Location = new System.Drawing.Point(111, 57);
            this.RB_front.Name = "RB_front";
            this.RB_front.Size = new System.Drawing.Size(71, 16);
            this.RB_front.TabIndex = 10;
            this.RB_front.TabStop = true;
            this.RB_front.Text = "前缀模式";
            this.RB_front.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "自动编号模式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "自动编号类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "分隔符";
            // 
            // TXT_div
            // 
            this.TXT_div.Location = new System.Drawing.Point(266, 23);
            this.TXT_div.Name = "TXT_div";
            this.TXT_div.Size = new System.Drawing.Size(34, 21);
            this.TXT_div.TabIndex = 6;
            // 
            // CB_nums
            // 
            this.CB_nums.FormattingEnabled = true;
            this.CB_nums.Items.AddRange(new object[] {
            "不添加编号",
            "1-9",
            "A-Z",
            "01-99",
            "001-999",
            "0001-9999"});
            this.CB_nums.Location = new System.Drawing.Point(87, 25);
            this.CB_nums.Name = "CB_nums";
            this.CB_nums.Size = new System.Drawing.Size(121, 20);
            this.CB_nums.TabIndex = 4;
            this.CB_nums.Text = "选择自动编号类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "已添加文件数目：0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(-1, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "Copy Right @ Akers 2011";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "|";
            // 
            // LL_help
            // 
            this.LL_help.AutoSize = true;
            this.LL_help.Location = new System.Drawing.Point(375, 473);
            this.LL_help.Name = "LL_help";
            this.LL_help.Size = new System.Drawing.Size(29, 12);
            this.LL_help.TabIndex = 12;
            this.LL_help.TabStop = true;
            this.LL_help.Text = "帮助";
            this.LL_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_help_LinkClicked);
            // 
            // LL_about
            // 
            this.LL_about.AutoSize = true;
            this.LL_about.Location = new System.Drawing.Point(412, 473);
            this.LL_about.Name = "LL_about";
            this.LL_about.Size = new System.Drawing.Size(29, 12);
            this.LL_about.TabIndex = 13;
            this.LL_about.TabStop = true;
            this.LL_about.Text = "关于";
            this.LL_about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_about_LinkClicked);
            // 
            // BTN_rollback
            // 
            this.BTN_rollback.Location = new System.Drawing.Point(257, 444);
            this.BTN_rollback.Name = "BTN_rollback";
            this.BTN_rollback.Size = new System.Drawing.Size(184, 23);
            this.BTN_rollback.TabIndex = 14;
            this.BTN_rollback.Text = "撤销更名";
            this.BTN_rollback.UseVisualStyleBackColor = true;
            this.BTN_rollback.Click += new System.EventHandler(this.BTN_rollback_Click);
            // 
            // BTN_clar
            // 
            this.BTN_clar.Location = new System.Drawing.Point(178, 227);
            this.BTN_clar.Name = "BTN_clar";
            this.BTN_clar.Size = new System.Drawing.Size(101, 23);
            this.BTN_clar.TabIndex = 15;
            this.BTN_clar.Text = "移除所有文件";
            this.BTN_clar.UseVisualStyleBackColor = true;
            this.BTN_clar.Click += new System.EventHandler(this.BTN_clar_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(325, 227);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(103, 23);
            this.BTN_del.TabIndex = 16;
            this.BTN_del.Text = "移除选中文件";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_back);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RB_front);
            this.groupBox2.Controls.Add(this.CB_nums);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_div);
            this.groupBox2.Location = new System.Drawing.Point(6, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 88);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动编号（不进行编号请选择“不进行编号”）";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_clar);
            this.Controls.Add(this.BTN_rollback);
            this.Controls.Add(this.LL_about);
            this.Controls.Add(this.LL_help);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_files);
            this.Controls.Add(this.BTN_selectFile);
            this.Controls.Add(this.BTN_change);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akers文件批量更名工具 Ver2.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_change;
        private System.Windows.Forms.TextBox TXT_oldname;
        private System.Windows.Forms.Button BTN_selectFile;
        private System.Windows.Forms.OpenFileDialog OFD_selectFile;
        private System.Windows.Forms.ListBox LB_files;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_nums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_div;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RB_back;
        private System.Windows.Forms.RadioButton RB_front;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel LL_help;
        private System.Windows.Forms.LinkLabel LL_about;
        private System.Windows.Forms.Button BTN_rollback;
        private System.Windows.Forms.Button BTN_clar;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.TextBox TXT_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_last;
        private System.Windows.Forms.Label label5;
    }
}

