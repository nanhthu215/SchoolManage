namespace Login
{
    partial class Login
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
            Button bLogin;
            Button button1;
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lblMS = new Label();
            txtMK = new TextBox();
            txtDN = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            bLogin = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.SteelBlue;
            bLogin.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            bLogin.ForeColor = Color.Snow;
            bLogin.Location = new Point(51, 193);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(139, 43);
            bLogin.TabIndex = 2;
            bLogin.Text = "Đăng Nhập";
            bLogin.UseVisualStyleBackColor = false;
            bLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(249, 193);
            button1.Name = "button1";
            button1.Size = new Size(133, 43);
            button1.TabIndex = 3;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI.Properties.Resources.Screenshot_2025_04_14_231715;
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 535);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lblMS);
            groupBox1.Controls.Add(bLogin);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtDN);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(428, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đăng nhập";
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.Font = new Font("Arial", 7.8F);
            lblMS.ForeColor = SystemColors.ButtonHighlight;
            lblMS.Location = new Point(102, 174);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(41, 16);
            lblMS.TabIndex = 5;
            lblMS.Text = "label3";
            // 
            // txtMK
            // 
            txtMK.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMK.Location = new Point(102, 120);
            txtMK.Multiline = true;
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.PlaceholderText = "Password";
            txtMK.Size = new Size(264, 34);
            txtMK.TabIndex = 1;
            txtMK.WordWrap = false;
            // 
            // txtDN
            // 
            txtDN.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDN.Location = new Point(102, 56);
            txtDN.Multiline = true;
            txtDN.Name = "txtDN";
            txtDN.PlaceholderText = "Username";
            txtDN.Size = new Size(264, 34);
            txtDN.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = GUI.Properties.Resources.Screenshot_2025_04_14_231908;
            pictureBox3.Location = new Point(51, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GUI.Properties.Resources.Screenshot_2025_04_14_231857;
            pictureBox2.Location = new Point(51, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(419, 92);
            label1.Name = "label1";
            label1.Size = new Size(449, 33);
            label1.TabIndex = 2;
            label1.Text = "ỨNG DỤNG QUẢN LÝ GIÁO DỤC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(544, 141);
            label2.Name = "label2";
            label2.Size = new Size(181, 33);
            label2.TabIndex = 3;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(885, 563);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Đăng nhập";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txtMK;
        private TextBox txtDN;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label lblMS;
    }
}
