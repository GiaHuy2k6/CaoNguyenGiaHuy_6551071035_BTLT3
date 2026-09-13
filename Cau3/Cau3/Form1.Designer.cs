namespace Cau3
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
            txtHo = new Label();
            txtTen = new Label();
            lblHoTen = new Label();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnThoat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtHo
            // 
            txtHo.AutoSize = true;
            txtHo.Location = new Point(174, 117);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(51, 20);
            txtHo.TabIndex = 0;
            txtHo.Text = "Họ lót";
            txtHo.Click += txtHo_Click;
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Location = new Point(184, 164);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(32, 20);
            txtTen.TabIndex = 1;
            txtTen.Text = "Tên";
            // 
            // lblHoTen
            // 
            lblHoTen.BorderStyle = BorderStyle.Fixed3D;
            lblHoTen.Location = new Point(277, 117);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(223, 25);
            lblHoTen.TabIndex = 2;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(184, 240);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(94, 29);
            btnHo.TabIndex = 3;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += btnHo_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(335, 240);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(94, 29);
            btnTen.TabIndex = 4;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(476, 240);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(94, 29);
            btnHoTen.TabIndex = 5;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(320, 318);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(180, 51);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(277, 164);
            label1.Name = "label1";
            label1.Size = new Size(223, 25);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(lblHoTen);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHo;
        private Label txtTen;
        private Label lblHoTen;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnThoat;
        private Label label1;
    }
}
