namespace WinFormsApp3
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
            txtNhapTen = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            lblLapTrinh = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNhapTen
            // 
            txtNhapTen.AutoSize = true;
            txtNhapTen.Location = new Point(200, 67);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(75, 20);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.Text = "Nhập Tên:";
            txtNhapTen.Click += txtNhapTen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(136, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(128, 189);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(3, 142);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(65, 24);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Black";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Blue;
            radioButton3.Location = new Point(3, 103);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Blue";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Lime;
            radioButton2.Location = new Point(3, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(3, 23);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(474, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 189);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 124);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gạch chân";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 78);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(124, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Nghiêng Italic";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Đậm Bold";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 346);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Lập Trình Bởi:";
            label1.Click += label1_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Location = new Point(304, 346);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(62, 25);
            lblLapTrinh.TabIndex = 4;
            lblLapTrinh.Text = "label2";
            lblLapTrinh.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(410, 328);
            button1.Name = "button1";
            button1.Size = new Size(92, 58);
            button1.TabIndex = 5;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblLapTrinh);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Định Dạng (Formater)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNhapTen;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radRed;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
        private Label lblLapTrinh;
        private Button button1;
    }
}
