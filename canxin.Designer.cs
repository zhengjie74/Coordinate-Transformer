namespace LocationTransform
{
    partial class canxin
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
            groupBox1 = new GroupBox();
            Trans_H = new TextBox();
            Trans_B = new TextBox();
            Trans_L = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TransZ = new TextBox();
            TransY = new TextBox();
            TransX = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Cal_X = new Label();
            button_f = new Button();
            button2 = new Button();
            button_i = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Trans_H);
            groupBox1.Controls.Add(Trans_B);
            groupBox1.Controls.Add(Trans_L);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "参心大地坐标系";
            // 
            // Trans_H
            // 
            Trans_H.Location = new Point(102, 212);
            Trans_H.Name = "Trans_H";
            Trans_H.Size = new Size(100, 23);
            Trans_H.TabIndex = 5;
            // 
            // Trans_B
            // 
            Trans_B.Location = new Point(102, 136);
            Trans_B.Name = "Trans_B";
            Trans_B.Size = new Size(100, 23);
            Trans_B.TabIndex = 4;
            // 
            // Trans_L
            // 
            Trans_L.Location = new Point(102, 69);
            Trans_L.Name = "Trans_L";
            Trans_L.Size = new Size(100, 23);
            Trans_L.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 218);
            label3.Name = "label3";
            label3.Size = new Size(17, 17);
            label3.TabIndex = 2;
            label3.Text = "H";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "B(十进制度)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "L(十进制度)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TransZ);
            groupBox2.Controls.Add(TransY);
            groupBox2.Controls.Add(TransX);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Cal_X);
            groupBox2.Location = new Point(351, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(261, 282);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "参心空间直角坐标系";
            // 
            // TransZ
            // 
            TransZ.Location = new Point(96, 212);
            TransZ.Name = "TransZ";
            TransZ.Size = new Size(100, 23);
            TransZ.TabIndex = 5;
            // 
            // TransY
            // 
            TransY.Location = new Point(96, 136);
            TransY.Name = "TransY";
            TransY.Size = new Size(100, 23);
            TransY.TabIndex = 4;
            // 
            // TransX
            // 
            TransX.Location = new Point(96, 69);
            TransX.Name = "TransX";
            TransX.Size = new Size(100, 23);
            TransX.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 218);
            label6.Name = "label6";
            label6.Size = new Size(15, 17);
            label6.TabIndex = 2;
            label6.Text = "Z";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 139);
            label5.Name = "label5";
            label5.Size = new Size(15, 17);
            label5.TabIndex = 1;
            label5.Text = "Y";
            // 
            // Cal_X
            // 
            Cal_X.AutoSize = true;
            Cal_X.Location = new Point(50, 69);
            Cal_X.Name = "Cal_X";
            Cal_X.Size = new Size(16, 17);
            Cal_X.TabIndex = 0;
            Cal_X.Text = "X";
            // 
            // button_f
            // 
            button_f.Location = new Point(162, 383);
            button_f.Name = "button_f";
            button_f.Size = new Size(75, 23);
            button_f.TabIndex = 2;
            button_f.Text = "正算";
            button_f.UseVisualStyleBackColor = true;
            button_f.Click += button_f_Click;
            // 
            // button2
            // 
            button2.Location = new Point(402, 383);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "退出";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_i
            // 
            button_i.Location = new Point(278, 383);
            button_i.Name = "button_i";
            button_i.Size = new Size(75, 23);
            button_i.TabIndex = 4;
            button_i.Text = "反算";
            button_i.UseVisualStyleBackColor = true;
            button_i.Click += button_i_Click;
            // 
            // canxin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(button_i);
            Controls.Add(button2);
            Controls.Add(button_f);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "canxin";
            Text = "canxin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Trans_H;
        private TextBox Trans_B;
        private TextBox Trans_L;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TransZ;
        private TextBox TransY;
        private TextBox TransX;
        private Label label6;
        private Label label5;
        private Label Cal_X;
        private Button button_f;
        private Button button2;
        private Button button_i;
    }
}