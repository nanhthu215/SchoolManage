namespace GUI
{
    partial class frmConfig
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtServer = new TextBox();
            txtUID = new TextBox();
            txtPW = new TextBox();
            txtDB = new TextBox();
            ckW = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 231);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 172);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "UID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 115);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Database";
            // 
            // txtServer
            // 
            txtServer.Location = new Point(146, 58);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(304, 27);
            txtServer.TabIndex = 4;
            // 
            // txtUID
            // 
            txtUID.Location = new Point(146, 169);
            txtUID.Name = "txtUID";
            txtUID.Size = new Size(304, 27);
            txtUID.TabIndex = 5;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(146, 228);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(304, 27);
            txtPW.TabIndex = 6;
            // 
            // txtDB
            // 
            txtDB.Location = new Point(146, 112);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(304, 27);
            txtDB.TabIndex = 7;
            // 
            // ckW
            // 
            ckW.AutoSize = true;
            ckW.Location = new Point(146, 292);
            ckW.Name = "ckW";
            ckW.Size = new Size(187, 24);
            ckW.TabIndex = 8;
            ckW.Text = "Window Authentication";
            ckW.UseVisualStyleBackColor = true;
            ckW.CheckedChanged += ckW_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(82, 347);
            button1.Name = "button1";
            button1.Size = new Size(147, 38);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(303, 347);
            button2.Name = "button2";
            button2.Size = new Size(147, 38);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ckW);
            Controls.Add(txtDB);
            Controls.Add(txtPW);
            Controls.Add(txtUID);
            Controls.Add(txtServer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConfig";
            Text = "frmConfig";
            Load += frmConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServer;
        private TextBox txtUID;
        private TextBox txtPW;
        private TextBox txtDB;
        private CheckBox ckW;
        private Button button1;
        private Button button2;
    }
}