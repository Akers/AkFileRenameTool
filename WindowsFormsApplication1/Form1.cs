/*文件更名工具
 * 作者：Akers_Liang 梁文栩
 * 当前版本2.2
 * 最后修改日期：20110303
 * 最后修改人：Akers
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CB_nums.SelectedIndex = 0;
        }
        private void BTN_selectFile_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2D;
            DialogResult dr = OFD_selectFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                String[] s = OFD_selectFile.FileNames;
                foreach (String name in s)
                    LB_files.Items.Add(name);
                label6.Text = "已添加文件数目：" + LB_files.Items.Count;
            }
            this.Opacity = 1.000D;
        }

        //更名按钮
        private void BTN_change_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show
                (
                    "请确认是否要执行更名操作，按确定开始更名，按取消中止操作",
                    "操作确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk
                );
            if (dr == System.Windows.Forms.DialogResult.No)
                return;
            oldpaths = new List<string>();//更名前的原始路径
            bakpaths = new List<string>();//路径列表备份
            List<String> files = new List<String>();//文件列表
            #region =======判断列表是否为空===================
            
            if (LB_files.Items.Count == 0)
            {
                MessageBox.Show("请点击\"打开文件\"按钮打开需要更名的文件！！！", "错误提示");
                BTN_selectFile.Focus();
                return;
            }
            #endregion

            #region =======备份原始路径===================
            
            foreach (String s in LB_files.Items)
                files.Add(s);
            bakpaths = files;//保存旧路径到bakpaths中以备还原
            #endregion

            #region =======判断自动编号类型===================
            int idMode = 0;
            try
            {
                switch (CB_nums.SelectedItem.ToString())
                {
                    case "1-9": idMode = 1; break;
                    case "01-99": idMode = 2; break;
                    case "001-999": idMode = 3; break;
                    case "0001-9999": idMode = 4; break;
                    case "A-Z": idMode = 5; break;
                    case "不添加编号": idMode = 0; break;
                    default: MessageBox.Show("请选择自动编号类型！！！", "错误提示"); return;
                }
            }
            catch
            {
                MessageBox.Show("请选择自动编号类型！！！", "错误提示");
                return;
            }
            #endregion


            //#region =======判断列表是否为空===================
            string num = null; //已添加文件数目
            if (idMode == 0)
               num = "";
            else if (files.Count / System.Math.Pow(10, idMode) > 1 || (idMode==5 && files.Count>26))
            {
                MessageBox.Show("所选文件数量超出自动编号类型范围，将自动选择下一个编号类型！！", "错误提示");
                CB_nums.Focus();
                if(CB_nums.SelectedIndex<4)
                    CB_nums.SelectedIndex++;
                else
                    MessageBox.Show("所选文件数量超出软件处理范围，本工具一次处理文件数最大为10000个！！", "错误提示");
                return;
            }
            LB_files.Items.Clear();
            label6.Text = "已添加文件数目：0";
            
            for (int i = 0; i < files.Count;i++ )
            {
                String s = files[i];
                String path = s.Substring(0, s.LastIndexOf("\\") + 1);
                String last = null;
                if (TXT_last.Text.Trim().Length <= 1)
                    last = s.Substring(s.LastIndexOf("."), s.Length - s.LastIndexOf("."));
                else
                    last = "."+TXT_last.Text.Trim();
                
                if (idMode == 5 && i < 26)
                {
                    char a = (char)(65 + i);
                    num = "" + a;
                }
                if (idMode == 1 && i < 9)
                    num = "" + (i + 1);
                if (idMode == 2 && i < 99)
                {
                    if (i < 9)
                        num = "0" + (i + 1);
                    else
                        num = (i + 1).ToString();
                }
                if (idMode == 3 && i < 999)
                {
                    if (i < 9)
                        num = "00" + (i + 1);
                    else if (i < 99)
                        num = "0" + (i + 1);
                    else
                        num = (i + 1).ToString();
                }
                if (idMode == 4 && i < 9999)
                {
                    if (i < 9)
                        num = "000" + (i + 1);
                    else if (i < 99)
                        num = "00" + (i + 1);
                    else if (i < 999)
                        num = "0" + (i + 1);
                    else
                        num = (i + 1).ToString();
                }
                String newpath = null;
                String oldname = TXT_oldname.Text.Trim();
                if (oldname.Equals(""))
                {
                    if (s.Contains("."))
                        oldname = s.Substring(s.LastIndexOf("\\") + 1, s.LastIndexOf(".") - s.LastIndexOf("\\") - 1);
                    else
                        oldname = s;
                }
                String[] remove = null;
                if (TXT_remove.Text.Length > 1)
                {
                    remove = TXT_remove.Text.Split('/');
                    for (int j = 0; j < remove.Length; j++)
                    {
                        while (oldname.Contains(remove[j]))
                        {
                            oldname = oldname.Remove(oldname.IndexOf(remove[j]), remove[j].Length);
                        }
                    }
                }
                if (RB_front.Checked)
                {
                    //路径+编号+分割符+旧文件名+后缀
                    newpath = path + num + TXT_div.Text.Trim() + oldname + last;
                }
                else if (RB_back.Checked)
                {
                    newpath = path + oldname + TXT_div.Text.Trim() + num + last;
                }
                oldpaths.Add(newpath);//保存路径到旧路径链表中
                try
                {
                    File.Move(s, newpath);
                }
                catch
                {
                    LB_files.Items.Add("文件：" + s + "更名失败，可能是文件重名");
                }
            }
            LB_files.Items.Clear();
            TXT_div.Text = null;
            TXT_remove.Text = null;
            TXT_oldname.Text = null;
            MessageBox.Show
                (
                    "更名操作已完成^-^",
                    "操作完成",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OFD_selectFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        //拖拽的文件进入Frame事件
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None; 
        }

        //拖拽物放下时
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            bool flag = false;
            try
            {
                for (int i = 0; i < ((System.Array)e.Data.GetData(DataFormats.FileDrop)).Length; i++)
                {
                    if (File.Exists(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(i).ToString()))//判断该路径是否文件
                        LB_files.Items.Add(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(i).ToString());
                    else
                        flag = true;
                }
                if(flag)
                    MessageBox.Show("对不起，本工具暂不支持添加文件夹，所添加文件夹已经被自动技术性无视！！","出错啦～～～");
            }
            catch { }
            label6.Text = "已添加文件数量："+LB_files.Items.Count;
        }

        private void LL_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("本软件使用方法：\n点击“选择文件”按钮在弹出对话框中选择需要更名的文件（支持多选）\n或者直接把要更名的文件拖入程序窗口内\n然后在更名模式中选择相应的更名设置（文件名一栏为空则在原文件名上加上前、后缀以及编号）\n例如：\n原文件名为“D:\\a.txt”\n前缀模式更名后：01_a.txt\n后缀模式更名后：a_01.txt\n最后点击“更名”按钮进行更名操作。","帮助");
        }

        private void LL_about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Akers文件批量更名工具\n当前版本：ver2.2\n作者：Akers\n版权所有：Akers_Liang", "关于");
        }

        private void BTN_clar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show
                (
                    "请确认是否要清除所有已添加文件，按确定执行删除，按取消中止操作",
                    "操作确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk
                );
            if (dr == System.Windows.Forms.DialogResult.No)
                return;
            LB_files.Items.Clear();
            label6.Text = "已添加文件数量：" + LB_files.Items.Count;

        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            LB_files.Items.Remove(LB_files.SelectedItem);
            label6.Text = "已添加文件数量："+LB_files.Items.Count;
        }

        private void BTN_rollback_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show
                (
                    "你确定要回滚上一次更名操作？所有已更名文件将恢复到更名前状态",
                    "请确认",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    for (int i = 0; i < oldpaths.Count; i++)
                        File.Move(oldpaths[i], bakpaths[i]);
                }
                catch
                {
                    MessageBox.Show
                        (
                            "上一次更名操作不存在！！！",
                            "出错啦",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    return;
                }
            else if (dr == System.Windows.Forms.DialogResult.No)
                return;
            DialogResult dr2 =  MessageBox.Show
                        (
                            "上一次更名操作已成功撤销，是否重新添加最近一次添加的文件？",
                            "撤销成功",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Asterisk
                        );
            if (dr2 == System.Windows.Forms.DialogResult.No)
                return;
            else if (dr2 == System.Windows.Forms.DialogResult.Yes)
            {
                LB_files.Items.Clear();
                for (int i = 0; i < bakpaths.Count; i++)
                {
                    LB_files.Items.Add(bakpaths[i]);
                    label6.Text = "已添加文件数量：" + LB_files.Items.Count;
                }
            }
            TXT_div.Text = "";
            TXT_remove.Text = "";
            TXT_oldname.Text = "";
        }

        private List<string> oldpaths;
        private List<string> bakpaths;

    }
}
