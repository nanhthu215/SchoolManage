namespace GUI
{
    partial class ClassManage
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
            bPDF = new Button();
            bCal = new Button();
            bSave = new Button();
            bDel = new Button();
            bEdit = new Button();
            bAdd = new Button();
            groupBox1 = new GroupBox();
            bShow = new Button();
            txtYear = new TextBox();
            txtName = new TextBox();
            txtCID = new TextBox();
            cbGVCN = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label1 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(103, 306);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1342, 478);
            groupBox3.TabIndex = 5;
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
            grd.Size = new Size(1330, 448);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bPDF);
            groupBox2.Controls.Add(bCal);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(103, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1342, 84);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bPDF
            // 
            bPDF.Location = new Point(1120, 26);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(136, 43);
            bPDF.TabIndex = 10;
            bPDF.Text = "In";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bCal
            // 
            bCal.Location = new Point(912, 26);
            bCal.Name = "bCal";
            bCal.Size = new Size(136, 43);
            bCal.TabIndex = 9;
            bCal.Text = "Hủy";
            bCal.UseVisualStyleBackColor = true;
            bCal.Click += bCal_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(702, 26);
            bSave.Name = "bSave";
            bSave.Size = new Size(136, 43);
            bSave.TabIndex = 8;
            bSave.Text = "Lưu";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bDel
            // 
            bDel.Location = new Point(292, 26);
            bDel.Name = "bDel";
            bDel.Size = new Size(136, 43);
            bDel.TabIndex = 6;
            bDel.Text = "Xóa";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bDel_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(499, 26);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(136, 43);
            bEdit.TabIndex = 7;
            bEdit.Text = "Sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(89, 26);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(136, 43);
            bAdd.TabIndex = 5;
            bAdd.Text = "Thêm";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bShow);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCID);
            groupBox1.Controls.Add(cbGVCN);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(102, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1343, 165);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp học";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bShow
            // 
            bShow.Location = new Point(801, 86);
            bShow.Name = "bShow";
            bShow.Size = new Size(468, 43);
            bShow.TabIndex = 4;
            bShow.Text = "Hiển thị danh sách học sinh";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += bShow_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(139, 124);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(466, 27);
            txtYear.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(468, 27);
            txtName.TabIndex = 1;
            // 
            // txtCID
            // 
            txtCID.Location = new Point(139, 28);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(468, 27);
            txtCID.TabIndex = 0;
            txtCID.KeyUp += txtCID_KeyUp;
            // 
            // cbGVCN
            // 
            cbGVCN.FormattingEnabled = true;
            cbGVCN.Location = new Point(801, 27);
            cbGVCN.Name = "cbGVCN";
            cbGVCN.Size = new Size(468, 28);
            cbGVCN.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(718, 35);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 8;
            label9.Text = "GVCN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 76);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 7;
            label8.Text = "Tên lớp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 127);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Niên khóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp";
            // 
            // ClassManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ClassManage";
            Text = "ClassManage";
            Load += ClassManage_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView grd;
        private GroupBox groupBox2;
        private Button bCal;
        private Button bSave;
        private Button bDel;
        private Button bEdit;
        private Button bAdd;
        private GroupBox groupBox1;
        private TextBox txtYear;
        private TextBox txtName;
        private TextBox txtCID;
        private ComboBox cbGVCN;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label1;
        private Button bPDF;
        private Button bShow;
    }
}