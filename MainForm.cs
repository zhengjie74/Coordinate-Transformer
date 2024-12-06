using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationTransform
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            // 在 InitializeComponent 之后获取设计器中放置的 tabControl1 控件
            pointDatas.InitializeDatabase();
            //加载数据库
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void 高斯投影坐标正反算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            TabPage tb = new TabPage();
            tb.Controls.Add(form1);
            tb.Text = form1.Text + " ";
            tb.Name = form1.Name;
            this.tabControl1.TabPages.Add(tb);
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.Dock = DockStyle.Fill;
            form1.Show();
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void 参心大地坐标转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canxin form2 = new canxin();
            form2.MdiParent = this;
            TabPage tb = new TabPage();
            tb.Controls.Add(form2);
            tb.Text = form2.Text + " ";
            tb.Name = form2.Name;
            this.tabControl1.TabPages.Add(tb);
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.Show();
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 数据库视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbManage dbManage = new dbManage();
            dbManage.MdiParent = this;
            TabPage tb = new TabPage();
            tb.Controls.Add(dbManage);
            tb.Text = dbManage.Text + " ";
            tb.Name = dbManage.Name;
            this.tabControl1.TabPages.Add(tb);
            dbManage.FormBorderStyle = FormBorderStyle.None;
            dbManage.Dock = DockStyle.Fill;
            dbManage.Show();
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void 文件读入树状视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView treeView = new treeView();
            treeView.MdiParent = this;
            TabPage tb = new TabPage();
            tb.Controls.Add(treeView);
            tb.Text = treeView.Text + " ";
            tb.Name = treeView.Name;
            this.tabControl1.TabPages.Add(tb);
            treeView.FormBorderStyle = FormBorderStyle.None;
            treeView.Dock = DockStyle.Fill;
            treeView.Show();
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }
    }
}
