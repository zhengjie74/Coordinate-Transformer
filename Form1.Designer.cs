namespace LocationTransform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            Gps_localNo = new ColumnHeader();
            Gps_localName = new ColumnHeader();
            Gps_localX = new ColumnHeader();
            Gps_localY = new ColumnHeader();
            Gps_localH = new ColumnHeader();
            Gps_localNote = new ColumnHeader();
            label1 = new Label();
            button_AddData = new Button();
            button_ImportFromFile = new Button();
            groupBox1 = new GroupBox();
            text_Spheroid_c = new TextBox();
            text_Spheroid_f = new TextBox();
            text_Spheroid_e1 = new TextBox();
            text_Spheroid_e2 = new TextBox();
            text_Spheroid_b = new TextBox();
            text_Spheroid_a = new TextBox();
            text_Spheroid_Name = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label16 = new Label();
            textBox13 = new TextBox();
            Cal_Y = new TextBox();
            Cal_X = new TextBox();
            textBox10 = new TextBox();
            Cal_B = new TextBox();
            Cal_L = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            listView2 = new ListView();
            Gps_GaussNO = new ColumnHeader();
            Gps_GaussName = new ColumnHeader();
            Gps_GaussX = new ColumnHeader();
            Gps_GaussY = new ColumnHeader();
            Gps_GaussXO = new ColumnHeader();
            Gps_GaussYO = new ColumnHeader();
            label17 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Gps_localNo, Gps_localName, Gps_localX, Gps_localY, Gps_localH, Gps_localNote });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 58);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(617, 133);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Gps_localNo
            // 
            Gps_localNo.Text = "序号";
            // 
            // Gps_localName
            // 
            Gps_localName.Text = "点名";
            Gps_localName.TextAlign = HorizontalAlignment.Center;
            Gps_localName.Width = 100;
            // 
            // Gps_localX
            // 
            Gps_localX.Text = "经度(十进制度)";
            Gps_localX.TextAlign = HorizontalAlignment.Center;
            Gps_localX.Width = 100;
            // 
            // Gps_localY
            // 
            Gps_localY.Text = "纬度(十进制度)";
            Gps_localY.TextAlign = HorizontalAlignment.Center;
            Gps_localY.Width = 100;
            // 
            // Gps_localH
            // 
            Gps_localH.Text = "高程(m)";
            Gps_localH.TextAlign = HorizontalAlignment.Center;
            Gps_localH.Width = 100;
            // 
            // Gps_localNote
            // 
            Gps_localNote.Text = "备注";
            Gps_localNote.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 1;
            label1.Text = "GPS经纬度坐标 :";
            // 
            // button_AddData
            // 
            button_AddData.Location = new Point(137, 30);
            button_AddData.Margin = new Padding(2);
            button_AddData.Name = "button_AddData";
            button_AddData.Size = new Size(71, 24);
            button_AddData.TabIndex = 2;
            button_AddData.Text = "添加坐标";
            button_AddData.UseVisualStyleBackColor = true;
            // 
            // button_ImportFromFile
            // 
            button_ImportFromFile.Location = new Point(244, 30);
            button_ImportFromFile.Margin = new Padding(2);
            button_ImportFromFile.Name = "button_ImportFromFile";
            button_ImportFromFile.Size = new Size(123, 24);
            button_ImportFromFile.TabIndex = 3;
            button_ImportFromFile.Text = "从数据文件导入";
            button_ImportFromFile.UseVisualStyleBackColor = true;
            button_ImportFromFile.Click += button_ImportFromFile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(text_Spheroid_c);
            groupBox1.Controls.Add(text_Spheroid_f);
            groupBox1.Controls.Add(text_Spheroid_e1);
            groupBox1.Controls.Add(text_Spheroid_e2);
            groupBox1.Controls.Add(text_Spheroid_b);
            groupBox1.Controls.Add(text_Spheroid_a);
            groupBox1.Controls.Add(text_Spheroid_Name);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(23, 216);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(279, 307);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "椭球参数";
            // 
            // text_Spheroid_c
            // 
            text_Spheroid_c.Location = new Point(114, 256);
            text_Spheroid_c.Name = "text_Spheroid_c";
            text_Spheroid_c.ReadOnly = true;
            text_Spheroid_c.Size = new Size(123, 23);
            text_Spheroid_c.TabIndex = 15;
            // 
            // text_Spheroid_f
            // 
            text_Spheroid_f.Location = new Point(114, 227);
            text_Spheroid_f.Name = "text_Spheroid_f";
            text_Spheroid_f.ReadOnly = true;
            text_Spheroid_f.Size = new Size(123, 23);
            text_Spheroid_f.TabIndex = 14;
            // 
            // text_Spheroid_e1
            // 
            text_Spheroid_e1.Location = new Point(114, 198);
            text_Spheroid_e1.Name = "text_Spheroid_e1";
            text_Spheroid_e1.ReadOnly = true;
            text_Spheroid_e1.Size = new Size(123, 23);
            text_Spheroid_e1.TabIndex = 13;
            // 
            // text_Spheroid_e2
            // 
            text_Spheroid_e2.Location = new Point(114, 169);
            text_Spheroid_e2.Name = "text_Spheroid_e2";
            text_Spheroid_e2.ReadOnly = true;
            text_Spheroid_e2.Size = new Size(123, 23);
            text_Spheroid_e2.TabIndex = 12;
            // 
            // text_Spheroid_b
            // 
            text_Spheroid_b.Location = new Point(114, 140);
            text_Spheroid_b.Name = "text_Spheroid_b";
            text_Spheroid_b.ReadOnly = true;
            text_Spheroid_b.Size = new Size(123, 23);
            text_Spheroid_b.TabIndex = 11;
            // 
            // text_Spheroid_a
            // 
            text_Spheroid_a.Location = new Point(114, 111);
            text_Spheroid_a.Name = "text_Spheroid_a";
            text_Spheroid_a.ReadOnly = true;
            text_Spheroid_a.Size = new Size(123, 23);
            text_Spheroid_a.TabIndex = 10;
            // 
            // text_Spheroid_Name
            // 
            text_Spheroid_Name.Location = new Point(114, 82);
            text_Spheroid_Name.Name = "text_Spheroid_Name";
            text_Spheroid_Name.ReadOnly = true;
            text_Spheroid_Name.Size = new Size(123, 23);
            text_Spheroid_Name.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 262);
            label9.Name = "label9";
            label9.Size = new Size(74, 17);
            label9.TabIndex = 8;
            label9.Text = "极曲率半径c";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 233);
            label8.Name = "label8";
            label8.Size = new Size(36, 17);
            label8.TabIndex = 7;
            label8.Text = "扁率f";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 204);
            label7.Name = "label7";
            label7.Size = new Size(82, 17);
            label7.TabIndex = 6;
            label7.Text = "第一偏心率e1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 175);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 5;
            label6.Text = "第二偏心率e2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 146);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 4;
            label5.Text = "短半径b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 117);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 3;
            label4.Text = "长半径a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 88);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 2;
            label3.Text = "椭球名称";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 33);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "选择";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "克拉索夫斯基椭球", "Bessel椭球", "西安80/1975国际椭球", "WGS-84椭球" });
            comboBox1.Location = new Point(114, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(123, 25);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(Cal_Y);
            groupBox2.Controls.Add(Cal_X);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(Cal_B);
            groupBox2.Controls.Add(Cal_L);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(333, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 307);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "高斯投影正反算";
            // 
            // button6
            // 
            button6.Location = new Point(202, 175);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 18;
            button6.Text = "存入";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(106, 175);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "反算";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(10, 175);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "正算";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(202, 276);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "LO";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(106, 276);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "XY收敛角";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(10, 276);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "BL收敛角";
            button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(133, 88);
            label16.Name = "label16";
            label16.Size = new Size(36, 17);
            label16.TabIndex = 12;
            label16.Text = "DMS";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(66, 213);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(171, 23);
            textBox13.TabIndex = 11;
            // 
            // Cal_Y
            // 
            Cal_Y.Location = new Point(66, 143);
            Cal_Y.Name = "Cal_Y";
            Cal_Y.Size = new Size(171, 23);
            Cal_Y.TabIndex = 10;
            // 
            // Cal_X
            // 
            Cal_X.Location = new Point(66, 111);
            Cal_X.Name = "Cal_X";
            Cal_X.Size = new Size(171, 23);
            Cal_X.TabIndex = 9;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(66, 242);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(171, 23);
            textBox10.TabIndex = 8;
            // 
            // Cal_B
            // 
            Cal_B.Location = new Point(66, 54);
            Cal_B.Name = "Cal_B";
            Cal_B.Size = new Size(171, 23);
            Cal_B.TabIndex = 7;
            // 
            // Cal_L
            // 
            Cal_L.Location = new Point(66, 25);
            Cal_L.Name = "Cal_L";
            Cal_L.Size = new Size(171, 23);
            Cal_L.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 219);
            label15.Name = "label15";
            label15.Size = new Size(24, 17);
            label15.TabIndex = 5;
            label15.Text = "LO";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 146);
            label14.Name = "label14";
            label14.Size = new Size(15, 17);
            label14.TabIndex = 4;
            label14.Text = "Y";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 111);
            label13.Name = "label13";
            label13.Size = new Size(16, 17);
            label13.TabIndex = 3;
            label13.Text = "X";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 248);
            label12.Name = "label12";
            label12.Size = new Size(44, 17);
            label12.TabIndex = 2;
            label12.Text = "收敛角";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 57);
            label11.Name = "label11";
            label11.Size = new Size(40, 17);
            label11.TabIndex = 1;
            label11.Text = "纬度B";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 25);
            label10.Name = "label10";
            label10.Size = new Size(38, 17);
            label10.TabIndex = 0;
            label10.Text = "经度L";
            // 
            // listView2
            // 
            listView2.CheckBoxes = true;
            listView2.Columns.AddRange(new ColumnHeader[] { Gps_GaussNO, Gps_GaussName, Gps_GaussX, Gps_GaussY, Gps_GaussXO, Gps_GaussYO });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(23, 566);
            listView2.Name = "listView2";
            listView2.Size = new Size(617, 185);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Gps_GaussNO
            // 
            Gps_GaussNO.Text = "序号";
            // 
            // Gps_GaussName
            // 
            Gps_GaussName.Text = "点名";
            Gps_GaussName.TextAlign = HorizontalAlignment.Center;
            Gps_GaussName.Width = 100;
            // 
            // Gps_GaussX
            // 
            Gps_GaussX.Text = "X(大地坐标)";
            Gps_GaussX.TextAlign = HorizontalAlignment.Center;
            Gps_GaussX.Width = 110;
            // 
            // Gps_GaussY
            // 
            Gps_GaussY.Text = "Y(大地坐标)";
            Gps_GaussY.TextAlign = HorizontalAlignment.Center;
            Gps_GaussY.Width = 110;
            // 
            // Gps_GaussXO
            // 
            Gps_GaussXO.Text = "XO(工程坐标)";
            Gps_GaussXO.TextAlign = HorizontalAlignment.Center;
            Gps_GaussXO.Width = 110;
            // 
            // Gps_GaussYO
            // 
            Gps_GaussYO.Text = "YO(工程坐标)";
            Gps_GaussYO.TextAlign = HorizontalAlignment.Center;
            Gps_GaussYO.Width = 110;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 537);
            label17.Name = "label17";
            label17.Size = new Size(110, 17);
            label17.TabIndex = 7;
            label17.Text = "GPS高斯平面坐标: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(100, 22);
            deleteToolStripMenuItem.Text = "删除";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(670, 780);
            Controls.Add(label17);
            Controls.Add(listView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button_ImportFromFile);
            Controls.Add(button_AddData);
            Controls.Add(label1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader Gps_localNo;
        private ColumnHeader Gps_localName;
        private ColumnHeader Gps_localX;
        private ColumnHeader Gps_localY;
        private ColumnHeader Gps_localH;
        private ColumnHeader Gps_localNote;
        private Label label1;
        private Button button_AddData;
        private Button button_ImportFromFile;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox text_Spheroid_c;
        private TextBox text_Spheroid_f;
        private TextBox text_Spheroid_e1;
        private TextBox text_Spheroid_e2;
        private TextBox text_Spheroid_b;
        private TextBox text_Spheroid_a;
        private TextBox text_Spheroid_Name;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private ListView listView2;
        private ColumnHeader Gps_GaussNO;
        private ColumnHeader Gps_GaussName;
        private ColumnHeader Gps_GaussX;
        private ColumnHeader Gps_GaussY;
        private ColumnHeader Gps_GaussXO;
        private ColumnHeader Gps_GaussYO;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label16;
        private TextBox textBox13;
        private TextBox Cal_Y;
        private TextBox Cal_X;
        private TextBox textBox10;
        private TextBox Cal_B;
        private TextBox Cal_L;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label17;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
