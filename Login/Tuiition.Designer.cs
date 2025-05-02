namespace GUI
{
    partial class Tuiition
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
            cbSID = new ComboBox();
            bPDF = new Button();
            bPayment = new Button();
            cbStatus = new ComboBox();
            txtA = new TextBox();
            txtTID = new TextBox();
            dt = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
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
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách học phí";
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
            grd.SelectionChanged += grd_SelectionChanged;
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
            groupBox2.TabIndex = 7;
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
            grb.Controls.Add(cbSID);
            grb.Controls.Add(bPDF);
            grb.Controls.Add(bPayment);
            grb.Controls.Add(cbStatus);
            grb.Controls.Add(txtA);
            grb.Controls.Add(txtTID);
            grb.Controls.Add(dt);
            grb.Controls.Add(label8);
            grb.Controls.Add(label7);
            grb.Controls.Add(label3);
            grb.Controls.Add(label2);
            grb.Controls.Add(label1);
            grb.Location = new Point(105, 38);
            grb.Name = "grb";
            grb.Size = new Size(1343, 192);
            grb.TabIndex = 6;
            grb.TabStop = false;
            grb.Text = "Thông tin học phí";
            // 
            // cbSID
            // 
            cbSID.FormattingEnabled = true;
            cbSID.Location = new Point(856, 25);
            cbSID.Name = "cbSID";
            cbSID.Size = new Size(422, 28);
            cbSID.TabIndex = 14;
            cbSID.SelectedIndexChanged += cbSID_SelectedIndexChanged;
            // 
            // bPDF
            // 
            bPDF.Location = new Point(1089, 120);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(189, 43);
            bPDF.TabIndex = 13;
            bPDF.Text = "In Hóa Đơn";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bPayment
            // 
            bPayment.Location = new Point(853, 120);
            bPayment.Name = "bPayment";
            bPayment.Size = new Size(189, 43);
            bPayment.TabIndex = 12;
            bPayment.Text = "Thanh Toán";
            bPayment.UseVisualStyleBackColor = true;
            bPayment.Click += bPayment_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(856, 66);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(422, 28);
            cbStatus.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new Point(137, 108);
            txtA.Name = "txtA";
            txtA.Size = new Size(468, 27);
            txtA.TabIndex = 4;
            // 
            // txtTID
            // 
            txtTID.Location = new Point(137, 30);
            txtTID.Name = "txtTID";
            txtTID.Size = new Size(468, 27);
            txtTID.TabIndex = 0;
            // 
            // dt
            // 
            dt.Location = new Point(137, 69);
            dt.Name = "dt";
            dt.Size = new Size(468, 27);
            dt.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(770, 33);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 7;
            label8.Text = "Học Sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(770, 69);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 6;
            label7.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 111);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Hạn học phí";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Học Phí";
            // 
            // Tuiition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 246, 255);
            ClientSize = new Size(1553, 822);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grb);
            Name = "Tuiition";
            Text = "Tuiition";
            Load += Tuiition_Load;
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
        private Button bCal;
        private Button bSave;
        private Button bDel;
        private Button bEdit;
        private Button bAdd;
        private GroupBox grb;
        private ComboBox cbStatus;
        private TextBox txtA;
        private TextBox txtTID;
        private DateTimePicker dt;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bPDF;
        private Button bPayment;
        private ComboBox cbSID;
    }
}