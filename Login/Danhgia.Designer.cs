namespace GUI
{
    partial class Danhgia
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
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            groupBox1 = new GroupBox();
            bAdd = new Button();
            txtDanhGia = new TextBox();
            bSave = new Button();
            n1 = new NumericUpDown();
            label8 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)n1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(106, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1342, 512);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách đánh giá";
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ActiveBorder;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(15, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(1321, 472);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bAdd);
            groupBox1.Controls.Add(txtDanhGia);
            groupBox1.Controls.Add(bSave);
            groupBox1.Controls.Add(n1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(105, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1343, 197);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đánh giá chất lượng của phụ huynh";
            // 
            // bAdd
            // 
            bAdd.Location = new Point(804, 120);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(168, 43);
            bAdd.TabIndex = 14;
            bAdd.Text = "Tạo Đánh Giá";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click_1;
            // 
            // txtDanhGia
            // 
            txtDanhGia.Location = new Point(272, 51);
            txtDanhGia.Name = "txtDanhGia";
            txtDanhGia.Size = new Size(922, 27);
            txtDanhGia.TabIndex = 13;
            // 
            // bSave
            // 
            bSave.Location = new Point(1026, 120);
            bSave.Name = "bSave";
            bSave.Size = new Size(168, 43);
            bSave.TabIndex = 7;
            bSave.Text = "Gửi Đánh Giá";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bAdd_Click;
            // 
            // n1
            // 
            n1.Location = new Point(272, 131);
            n1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            n1.Name = "n1";
            n1.Size = new Size(475, 27);
            n1.TabIndex = 12;
            n1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 131);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 7;
            label8.Text = "Thang Điểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Viết Đánh Giá";
            // 
            // Danhgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Danhgia";
            Text = "Đánh giá chất lượng giảng dạy";
            Load += Danhgia_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)n1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView grd;
        private GroupBox groupBox1;
        private ComboBox cbGT;
        private TextBox txtAddress;
        private TextBox txtSDT;
        private TextBox txtName;
        private TextBox txtSID;
        private ComboBox cbClass;
        private DateTimePicker dt;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown n1;
        private Button bSave;
        private TextBox txtDanhGia;
        private Button bAdd;
    }
}