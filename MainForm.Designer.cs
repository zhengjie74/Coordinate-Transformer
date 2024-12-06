namespace LocationTransform
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            开始ToolStripMenuItem = new ToolStripMenuItem();
            高斯投影坐标正反算ToolStripMenuItem = new ToolStripMenuItem();
            参心大地坐标转换ToolStripMenuItem = new ToolStripMenuItem();
            数据库视图ToolStripMenuItem = new ToolStripMenuItem();
            文件读入树状视图ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            tabControl1 = new KDelTabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 开始ToolStripMenuItem, 退出ToolStripMenuItem, 关于ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(653, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            开始ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 高斯投影坐标正反算ToolStripMenuItem, 参心大地坐标转换ToolStripMenuItem, 数据库视图ToolStripMenuItem, 文件读入树状视图ToolStripMenuItem });
            开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            开始ToolStripMenuItem.Size = new Size(44, 21);
            开始ToolStripMenuItem.Text = "开始";
            // 
            // 高斯投影坐标正反算ToolStripMenuItem
            // 
            高斯投影坐标正反算ToolStripMenuItem.Name = "高斯投影坐标正反算ToolStripMenuItem";
            高斯投影坐标正反算ToolStripMenuItem.Size = new Size(184, 22);
            高斯投影坐标正反算ToolStripMenuItem.Text = "高斯投影坐标正反算";
            高斯投影坐标正反算ToolStripMenuItem.Click += 高斯投影坐标正反算ToolStripMenuItem_Click;
            // 
            // 参心大地坐标转换ToolStripMenuItem
            // 
            参心大地坐标转换ToolStripMenuItem.Name = "参心大地坐标转换ToolStripMenuItem";
            参心大地坐标转换ToolStripMenuItem.Size = new Size(184, 22);
            参心大地坐标转换ToolStripMenuItem.Text = "参心/大地坐标转换";
            参心大地坐标转换ToolStripMenuItem.Click += 参心大地坐标转换ToolStripMenuItem_Click;
            // 
            // 数据库视图ToolStripMenuItem
            // 
            数据库视图ToolStripMenuItem.Name = "数据库视图ToolStripMenuItem";
            数据库视图ToolStripMenuItem.Size = new Size(184, 22);
            数据库视图ToolStripMenuItem.Text = "数据库视图";
            // 
            // 文件读入树状视图ToolStripMenuItem
            // 
            文件读入树状视图ToolStripMenuItem.Name = "文件读入树状视图ToolStripMenuItem";
            文件读入树状视图ToolStripMenuItem.Size = new Size(184, 22);
            文件读入树状视图ToolStripMenuItem.Text = "文件读入树状视图";
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(44, 21);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(44, 21);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // tabControl1
            // 
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(12, 3);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(653, 792);
            tabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(653, 818);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 开始ToolStripMenuItem;
        private ToolStripMenuItem 高斯投影坐标正反算ToolStripMenuItem;
        private ToolStripMenuItem 参心大地坐标转换ToolStripMenuItem;
        private ToolStripMenuItem 数据库视图ToolStripMenuItem;
        private ToolStripMenuItem 文件读入树状视图ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ColorDialog colorDialog1;
        private KDelTabControl tabControl1;
    }
}