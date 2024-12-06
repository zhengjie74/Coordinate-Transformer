namespace LocationTransform
{
    partial class dbManage
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
            listView1 = new ListView();
            refreshview = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(613, 606);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // refreshview
            // 
            refreshview.Location = new Point(12, 635);
            refreshview.Name = "refreshview";
            refreshview.Size = new Size(75, 23);
            refreshview.TabIndex = 1;
            refreshview.Text = "刷新视图";
            refreshview.UseVisualStyleBackColor = true;
            refreshview.Click += refreshview_Click;
            // 
            // dbManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 753);
            Controls.Add(refreshview);
            Controls.Add(listView1);
            Name = "dbManage";
            Text = "dbManage";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button refreshview;
    }
}