namespace GUI
{
    partial class TeacherManage
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
            groupBox2 = new GroupBox();
            bCal = new Button();
            bSave = new Button();
            bDel = new Button();
            bEdit = new Button();
            bAdd = new Button();
            grb = new GroupBox();
            txtE = new TextBox();
            cbGT = new ComboBox();
            txtAddress = new TextBox();
            txtSDT = new TextBox();
            txtName = new TextBox();
            txtTID = new TextBox();
            dt = new DateTimePicker();
            txtEmail = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            grb.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(106, 326);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1342, 458);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách giáo viên";
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ActiveBorder;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 24);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(1330, 428);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bCal);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(106, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 84);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bCal
            // 
            bCal.Location = new Point(1100, 26);
            bCal.Name = "bCal";
            bCal.Size = new Size(136, 43);
            bCal.TabIndex = 11;
            bCal.Text = "Hủy";
            bCal.UseVisualStyleBackColor = true;
            bCal.Click += bCal_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(835, 26);
            bSave.Name = "bSave";
            bSave.Size = new Size(136, 43);
            bSave.TabIndex = 10;
            bSave.Text = "Lưu";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bDel
            // 
            bDel.Location = new Point(359, 26);
            bDel.Name = "bDel";
            bDel.Size = new Size(136, 43);
            bDel.TabIndex = 8;
            bDel.Text = "Xóa";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bDel_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(592, 26);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(136, 43);
            bEdit.TabIndex = 9;
            bEdit.Text = "Sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(136, 26);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(136, 43);
            bAdd.TabIndex = 7;
            bAdd.Text = "Thêm";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // grb
            // 
            grb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grb.Controls.Add(txtE);
            grb.Controls.Add(cbGT);
            grb.Controls.Add(txtAddress);
            grb.Controls.Add(txtSDT);
            grb.Controls.Add(txtName);
            grb.Controls.Add(txtTID);
            grb.Controls.Add(dt);
            grb.Controls.Add(txtEmail);
            grb.Controls.Add(label8);
            grb.Controls.Add(label7);
            grb.Controls.Add(label6);
            grb.Controls.Add(label3);
            grb.Controls.Add(label2);
            grb.Controls.Add(label1);
            grb.Location = new Point(105, 38);
            grb.Name = "grb";
            grb.Size = new Size(1343, 197);
            grb.TabIndex = 3;
            grb.TabStop = false;
            grb.Text = "Thông tin giáo viên";
            // 
            // txtE
            // 
            txtE.Location = new Point(137, 151);
            txtE.Name = "txtE";
            txtE.Size = new Size(468, 27);
            txtE.TabIndex = 6;
            // 
            // cbGT
            // 
            cbGT.FormattingEnabled = true;
            cbGT.Location = new Point(856, 66);
            cbGT.Name = "cbGT";
            cbGT.Size = new Size(422, 28);
            cbGT.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(137, 108);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(468, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(853, 108);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(425, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(853, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(425, 27);
            txtName.TabIndex = 1;
            // 
            // txtTID
            // 
            txtTID.Location = new Point(137, 30);
            txtTID.Name = "txtTID";
            txtTID.Size = new Size(468, 27);
            txtTID.TabIndex = 0;
            txtTID.KeyUp += txtTID_KeyUp_1;
            // 
            // dt
            // 
            dt.Location = new Point(137, 69);
            dt.Name = "dt";
            dt.Size = new Size(468, 27);
            dt.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(26, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(46, 20);
            txtEmail.TabIndex = 8;
            txtEmail.Text = "Email";
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
            label3.Location = new Point(26, 111);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã số giáo viên";
            // 
            // TeacherManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1552, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grb);
            Name = "TeacherManage";
            Text = "Quản lý giáo viên";
            Load += TeacherManage_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            grb.ResumeLayout(false);
            grb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView grd;
        private GroupBox groupBox2;
        private Button bSave;
        private Button bDel;
        private Button bEdit;
        private Button bAdd;
        private GroupBox grb;
        private TextBox txtE;
        private ComboBox cbGT;
        private TextBox txtAddress;
        private TextBox txtSDT;
        private TextBox txtName;
        private TextBox txtTID;
        private DateTimePicker dt;
        private Label txtEmail;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bCal;
    }
}