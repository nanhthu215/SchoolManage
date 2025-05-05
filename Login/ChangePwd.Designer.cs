namespace GUI
{
    partial class ChangePwd
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bChange = new Button();
            bExit = new Button();
            txtXN = new TextBox();
            txtMKM = new TextBox();
            txtMKC = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(441, 433);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(366, 492);
            label3.Name = "label3";
            label3.Size = new Size(210, 28);
            label3.TabIndex = 2;
            label3.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(455, 378);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 3;
            label4.Text = "Mật Khẩu cũ";
            // 
            // bChange
            // 
            bChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bChange.Location = new Point(587, 572);
            bChange.Name = "bChange";
            bChange.Size = new Size(190, 48);
            bChange.TabIndex = 4;
            bChange.Text = "Xác Nhận";
            bChange.UseVisualStyleBackColor = true;
            bChange.Click += bChange_Click;
            // 
            // bExit
            // 
            bExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bExit.Location = new Point(854, 572);
            bExit.Name = "bExit";
            bExit.Size = new Size(190, 48);
            bExit.TabIndex = 5;
            bExit.Text = "Trở về";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // txtXN
            // 
            txtXN.Font = new Font("Segoe UI", 12F);
            txtXN.Location = new Point(587, 489);
            txtXN.Name = "txtXN";
            txtXN.PasswordChar = '*';
            txtXN.Size = new Size(457, 34);
            txtXN.TabIndex = 3;
            txtXN.UseSystemPasswordChar = true;
            // 
            // txtMKM
            // 
            txtMKM.Font = new Font("Segoe UI", 12F);
            txtMKM.Location = new Point(587, 430);
            txtMKM.Name = "txtMKM";
            txtMKM.PasswordChar = '*';
            txtMKM.Size = new Size(457, 34);
            txtMKM.TabIndex = 2;
            txtMKM.UseSystemPasswordChar = true;
            // 
            // txtMKC
            // 
            txtMKC.Font = new Font("Segoe UI", 12F);
            txtMKC.Location = new Point(587, 372);
            txtMKC.Name = "txtMKC";
            txtMKC.PasswordChar = '*';
            txtMKC.Size = new Size(457, 34);
            txtMKC.TabIndex = 1;
            txtMKC.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._6aac76d0250dd92ce6a297f128d12376;
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1529, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(636, 280);
            label5.Name = "label5";
            label5.Size = new Size(297, 50);
            label5.TabIndex = 11;
            label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // ChangePwd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtMKC);
            Controls.Add(txtMKM);
            Controls.Add(txtXN);
            Controls.Add(bExit);
            Controls.Add(bChange);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ChangePwd";
            Text = "Đổi mật khẩu";
            Load += ChangePwd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bChange;
        private Button bExit;
        private TextBox txtXN;
        private TextBox txtMKM;
        private TextBox txtMKC;
        private PictureBox pictureBox1;
        private Label label5;
    }
}