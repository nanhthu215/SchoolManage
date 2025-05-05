namespace GUI
{
    partial class HealthCare
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
            groupBox1 = new GroupBox();
            cbSID = new ComboBox();
            txtCN = new TextBox();
            txtCC = new TextBox();
            dt = new DateTimePicker();
            txtS = new TextBox();
            label2 = new Label();
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
            groupBox3.Location = new Point(106, 308);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1356, 478);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách ";
            // 
            // grd
            // 
            grd.BackgroundColor = SystemColors.ActiveBorder;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 24);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(1343, 448);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bCal);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Location = new Point(106, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1356, 84);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bCal
            // 
            bCal.Location = new Point(1146, 26);
            bCal.Name = "bCal";
            bCal.Size = new Size(136, 43);
            bCal.TabIndex = 8;
            bCal.Text = "Hủy";
            bCal.UseVisualStyleBackColor = true;
            bCal.Click += bCal_Click;
            // 
            // bSave
            // 
            bSave.Location = new Point(807, 26);
            bSave.Name = "bSave";
            bSave.Size = new Size(136, 43);
            bSave.TabIndex = 7;
            bSave.Text = "Lưu";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // bDel
            // 
            bDel.Location = new Point(445, 26);
            bDel.Name = "bDel";
            bDel.Size = new Size(136, 43);
            bDel.TabIndex = 6;
            bDel.Text = "Xóa";
            bDel.UseVisualStyleBackColor = true;
            bDel.Click += bDel_Click;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(107, 26);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(136, 43);
            bEdit.TabIndex = 5;
            bEdit.Text = "Sửa";
            bEdit.UseVisualStyleBackColor = true;
            bEdit.Click += bEdit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSID);
            groupBox1.Controls.Add(txtCN);
            groupBox1.Controls.Add(txtCC);
            groupBox1.Controls.Add(dt);
            groupBox1.Controls.Add(txtS);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(105, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1357, 165);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cbSID
            // 
            cbSID.FormattingEnabled = true;
            cbSID.Location = new Point(153, 27);
            cbSID.Name = "cbSID";
            cbSID.Size = new Size(466, 28);
            cbSID.TabIndex = 0;
            cbSID.SelectedIndexChanged += cbSID_SelectedIndexChanged;
            // 
            // txtCN
            // 
            txtCN.Location = new Point(817, 27);
            txtCN.Name = "txtCN";
            txtCN.Size = new Size(466, 27);
            txtCN.TabIndex = 1;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(153, 73);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(466, 27);
            txtCC.TabIndex = 2;
            // 
            // dt
            // 
            dt.Location = new Point(153, 121);
            dt.Name = "dt";
            dt.Size = new Size(468, 27);
            dt.TabIndex = 4;
            // 
            // txtS
            // 
            txtS.Location = new Point(817, 73);
            txtS.Name = "txtS";
            txtS.Size = new Size(466, 27);
            txtS.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(718, 76);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 10;
            label2.Text = "Tình trạng ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(718, 35);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 8;
            label9.Text = "Cân nặng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 76);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 7;
            label8.Text = "Chiều cao";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 126);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày kiểm tra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Học sinh";
            // 
            // HealthCare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HealthCare";
            Text = "Quản lý sức khỏe học sinh";
            Load += HealthCare_Load;
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
        private GroupBox groupBox1;
        private Button bShow;
        private TextBox txtYear;
        private TextBox txtName;
        private ComboBox cbGVCN;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label1;
        private DateTimePicker dt;
        private TextBox txtS;
        private Label label2;
        private TextBox txtCN;
        private TextBox txtCC;
        private ComboBox cbSID;
    }
}