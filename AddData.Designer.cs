namespace LocationTransform
{
    partial class AddData
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Ipt_Name = new TextBox();
            Ipt_x = new TextBox();
            Ipt_y = new TextBox();
            Ipt_Add = new Button();
            label5 = new Label();
            Ipt_h = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GPS经纬度坐标", "GPS高斯平面坐标" });
            comboBox1.Location = new Point(119, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 1;
            label1.Text = "添加坐标类型: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "名称";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 3;
            label3.Text = "经度L/坐标X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 150);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 4;
            label4.Text = "纬度B/坐标Y";
            // 
            // Ipt_Name
            // 
            Ipt_Name.Location = new Point(119, 80);
            Ipt_Name.Name = "Ipt_Name";
            Ipt_Name.Size = new Size(121, 23);
            Ipt_Name.TabIndex = 5;
            // 
            // Ipt_x
            // 
            Ipt_x.Location = new Point(119, 116);
            Ipt_x.Name = "Ipt_x";
            Ipt_x.Size = new Size(121, 23);
            Ipt_x.TabIndex = 6;
            // 
            // Ipt_y
            // 
            Ipt_y.Location = new Point(119, 150);
            Ipt_y.Name = "Ipt_y";
            Ipt_y.Size = new Size(121, 23);
            Ipt_y.TabIndex = 7;
            // 
            // Ipt_Add
            // 
            Ipt_Add.Location = new Point(87, 222);
            Ipt_Add.Name = "Ipt_Add";
            Ipt_Add.Size = new Size(75, 23);
            Ipt_Add.TabIndex = 8;
            Ipt_Add.Text = "添加";
            Ipt_Add.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 187);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 9;
            label5.Text = "高程H";
            // 
            // Ipt_h
            // 
            Ipt_h.Location = new Point(119, 184);
            Ipt_h.Name = "Ipt_h";
            Ipt_h.Size = new Size(121, 23);
            Ipt_h.TabIndex = 10;
            // 
            // AddData
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 278);
            Controls.Add(Ipt_h);
            Controls.Add(label5);
            Controls.Add(Ipt_Add);
            Controls.Add(Ipt_y);
            Controls.Add(Ipt_x);
            Controls.Add(Ipt_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "AddData";
            Text = "AddData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Ipt_Name;
        private TextBox Ipt_x;
        private TextBox Ipt_y;
        private Button Ipt_Add;
        private Label label5;
        private TextBox Ipt_h;
    }
}