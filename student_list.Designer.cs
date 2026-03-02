namespace dess
{
    partial class student_list
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
            lblTITLE = new Label();
            txtSEARCH = new TextBox();
            btnSEARCH = new Button();
            dataGridView1 = new DataGridView();
            btnREFRESH = new Button();
            lblTIT = new Label();
            txtID = new TextBox();
            txtFIRSTNAME = new TextBox();
            txtLASTNAME = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAGE = new TextBox();
            cbCOURSE = new ComboBox();
            cbSECTION = new ComboBox();
            btnSAVERECORD = new Button();
            btnRECORD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Location = new Point(62, 36);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(175, 20);
            lblTITLE.TabIndex = 0;
            lblTITLE.Text = "STUDENT MASTER LIST";
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(47, 88);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(252, 27);
            txtSEARCH.TabIndex = 1;
            // 
            // btnSEARCH
            // 
            btnSEARCH.Location = new Point(402, 85);
            btnSEARCH.Name = "btnSEARCH";
            btnSEARCH.Size = new Size(141, 33);
            btnSEARCH.TabIndex = 2;
            btnSEARCH.Text = "SEARCH";
            btnSEARCH.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(347, 308);
            dataGridView1.TabIndex = 3;
            // 
            // btnREFRESH
            // 
            btnREFRESH.Location = new Point(587, 36);
            btnREFRESH.Name = "btnREFRESH";
            btnREFRESH.Size = new Size(104, 31);
            btnREFRESH.TabIndex = 4;
            btnREFRESH.Text = "REFRESH";
            btnREFRESH.UseVisualStyleBackColor = true;
            // 
            // lblTIT
            // 
            lblTIT.AutoSize = true;
            lblTIT.Location = new Point(723, 85);
            lblTIT.Name = "lblTIT";
            lblTIT.Size = new Size(250, 20);
            lblTIT.TabIndex = 5;
            lblTIT.Text = "UPDATE STUDENT INFORMATION";
            // 
            // txtID
            // 
            txtID.Location = new Point(761, 140);
            txtID.Name = "txtID";
            txtID.Size = new Size(212, 27);
            txtID.TabIndex = 6;
            // 
            // txtFIRSTNAME
            // 
            txtFIRSTNAME.Location = new Point(761, 194);
            txtFIRSTNAME.Name = "txtFIRSTNAME";
            txtFIRSTNAME.Size = new Size(212, 27);
            txtFIRSTNAME.TabIndex = 7;
            // 
            // txtLASTNAME
            // 
            txtLASTNAME.Location = new Point(761, 248);
            txtLASTNAME.Name = "txtLASTNAME";
            txtLASTNAME.Size = new Size(220, 27);
            txtLASTNAME.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(662, 154);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 209);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 10;
            label2.Text = "FIRST NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 251);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 11;
            label3.Text = "LAST NAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 286);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "COURSE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 334);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 13;
            label5.Text = "SECTION:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(661, 391);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 14;
            label6.Text = "AGE:";
            // 
            // txtAGE
            // 
            txtAGE.Location = new Point(761, 404);
            txtAGE.Name = "txtAGE";
            txtAGE.Size = new Size(212, 27);
            txtAGE.TabIndex = 15;
            // 
            // cbCOURSE
            // 
            cbCOURSE.FormattingEnabled = true;
            cbCOURSE.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cbCOURSE.Location = new Point(765, 291);
            cbCOURSE.Name = "cbCOURSE";
            cbCOURSE.Size = new Size(216, 28);
            cbCOURSE.TabIndex = 16;
            // 
            // cbSECTION
            // 
            cbSECTION.FormattingEnabled = true;
            cbSECTION.Location = new Point(769, 342);
            cbSECTION.Name = "cbSECTION";
            cbSECTION.Size = new Size(204, 28);
            cbSECTION.TabIndex = 17;
            // 
            // btnSAVERECORD
            // 
            btnSAVERECORD.Location = new Point(776, 449);
            btnSAVERECORD.Name = "btnSAVERECORD";
            btnSAVERECORD.Size = new Size(176, 41);
            btnSAVERECORD.TabIndex = 18;
            btnSAVERECORD.Text = "SAVE RECORD";
            btnSAVERECORD.UseVisualStyleBackColor = true;
            // 
            // btnRECORD
            // 
            btnRECORD.Location = new Point(776, 505);
            btnRECORD.Name = "btnRECORD";
            btnRECORD.Size = new Size(176, 36);
            btnRECORD.TabIndex = 19;
            btnRECORD.Text = "DELETE RECORD";
            btnRECORD.UseVisualStyleBackColor = true;
            // 
            // student_list
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 600);
            Controls.Add(btnRECORD);
            Controls.Add(btnSAVERECORD);
            Controls.Add(cbSECTION);
            Controls.Add(cbCOURSE);
            Controls.Add(txtAGE);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLASTNAME);
            Controls.Add(txtFIRSTNAME);
            Controls.Add(txtID);
            Controls.Add(lblTIT);
            Controls.Add(btnREFRESH);
            Controls.Add(dataGridView1);
            Controls.Add(btnSEARCH);
            Controls.Add(txtSEARCH);
            Controls.Add(lblTITLE);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "student_list";
            Text = "student_list";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTITLE;
        private TextBox txtSEARCH;
        private Button btnSEARCH;
        private DataGridView dataGridView1;
        private Button btnREFRESH;
        private Label lblTIT;
        private TextBox txtID;
        private TextBox txtFIRSTNAME;
        private TextBox txtLASTNAME;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAGE;
        private ComboBox cbCOURSE;
        private ComboBox cbSECTION;
        private Button btnSAVERECORD;
        private Button btnRECORD;
    }
}