namespace GUI
{
    partial class Student
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
            cbFilter = new ComboBox();
            label4 = new Label();
            cbGT = new ComboBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtSDT = new TextBox();
            txtSID = new TextBox();
            cbClass = new ComboBox();
            dt = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            bCal = new Button();
            bSave = new Button();
            bDel = new Button();
            bEdit = new Button();
            bAdd = new Button();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbFilter);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbGT);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtSID);
            groupBox1.Controls.Add(cbClass);
            groupBox1.Controls.Add(dt);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(60, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1420, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học sinh";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(853, 146);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(468, 28);
            cbFilter.TabIndex = 9;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(770, 149);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Trạng thái";
            // 
            // cbGT
            // 
            cbGT.FormattingEnabled = true;
            cbGT.Location = new Point(856, 66);
            cbGT.Name = "cbGT";
            cbGT.Size = new Size(465, 28);
            cbGT.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(853, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(468, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(185, 109);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(468, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(853, 108);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(468, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtSID
            // 
            txtSID.Location = new Point(185, 31);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(468, 27);
            txtSID.TabIndex = 0;
            txtSID.KeyUp += txtSID_KeyUp;
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(185, 147);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(468, 28);
            cbClass.TabIndex = 6;
            // 
            // dt
            // 
            dt.Location = new Point(185, 70);
            dt.Name = "dt";
            dt.Size = new Size(468, 27);
            dt.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 150);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 8;
            label9.Text = "Lớp học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(770, 31);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 7;
            label8.Text = "Họ tên ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(770, 69);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(770, 109);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 5;
            label6.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 112);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 72);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã số học sinh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bCal);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(60, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1420, 84);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bCal
            // 
            bCal.Location = new Point(1110, 26);
            bCal.Name = "bCal";
            bCal.Size = new Size(136, 43);
            bCal.TabIndex = 11;
            bCal.Text = "Hủy";
            bCal.UseVisualStyleBackColor = true;
            bCal.Click += bCal_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(881, 26);
            bSave.Name = "bSave";
            bSave.Size = new Size(136, 43);
            bSave.TabIndex = 10;
            bSave.Text = "Lưu";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bDel
            // 
            bDel.Location = new Point(377, 26);
            bDel.Name = "bDel";
            bDel.Size = new Size(136, 43);
            bDel.TabIndex = 8;
            bDel.Text = "Xóa";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bDel_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(636, 26);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(136, 43);
            bEdit.TabIndex = 9;
            bEdit.Text = "Sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(119, 26);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(136, 43);
            bAdd.TabIndex = 7;
            bAdd.Text = "Thêm";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(60, 327);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1420, 498);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách học sinh";
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ActiveBorder;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 24);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(1408, 468);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Student";
            Text = "Quản lý học sinh";
            Load += Student_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox cbClass;
        private DateTimePicker dt;
        private Button bSave;
        private Button bDel;
        private Button bEdit;
        private Button bAdd;
        private DataGridView grd;
        private TextBox txtAddress;
        private TextBox txtSDT;
        private TextBox txtName;
        private TextBox txtSID;
        private ComboBox cbGT;
        private Button bCal;
        private ComboBox cbFilter;
        private Label label4;
    }
}