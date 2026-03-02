namespace dess
{
    partial class register_student
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
            lblFIRST_NAME = new Label();
            lblLAST_NAME = new Label();
            lblCOURSE = new Label();
            lblSECTION = new Label();
            lblAGE = new Label();
            txtFIRSTNAME = new TextBox();
            txtLASTNAME = new TextBox();
            txtAGE = new TextBox();
            btnSAVERECORD = new Button();
            cbCOURSE = new ComboBox();
            cbSECTION = new ComboBox();
            SuspendLayout();
            // 
            // lblTITLE
            // 
            lblTITLE.AutoSize = true;
            lblTITLE.Location = new Point(345, 41);
            lblTITLE.Name = "lblTITLE";
            lblTITLE.Size = new Size(261, 20);
            lblTITLE.TabIndex = 0;
            lblTITLE.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblFIRST_NAME
            // 
            lblFIRST_NAME.AutoSize = true;
            lblFIRST_NAME.Location = new Point(259, 134);
            lblFIRST_NAME.Name = "lblFIRST_NAME";
            lblFIRST_NAME.Size = new Size(90, 20);
            lblFIRST_NAME.TabIndex = 1;
            lblFIRST_NAME.Text = "First Name:";
            // 
            // lblLAST_NAME
            // 
            lblLAST_NAME.AutoSize = true;
            lblLAST_NAME.Location = new Point(267, 185);
            lblLAST_NAME.Name = "lblLAST_NAME";
            lblLAST_NAME.Size = new Size(88, 20);
            lblLAST_NAME.TabIndex = 2;
            lblLAST_NAME.Text = "Last Name:";
            // 
            // lblCOURSE
            // 
            lblCOURSE.AutoSize = true;
            lblCOURSE.Location = new Point(269, 243);
            lblCOURSE.Name = "lblCOURSE";
            lblCOURSE.Size = new Size(61, 20);
            lblCOURSE.TabIndex = 3;
            lblCOURSE.Text = "Course:";
            // 
            // lblSECTION
            // 
            lblSECTION.AutoSize = true;
            lblSECTION.Location = new Point(263, 297);
            lblSECTION.Name = "lblSECTION";
            lblSECTION.Size = new Size(64, 20);
            lblSECTION.TabIndex = 4;
            lblSECTION.Text = "Section:";
            // 
            // lblAGE
            // 
            lblAGE.AutoSize = true;
            lblAGE.Location = new Point(263, 359);
            lblAGE.Name = "lblAGE";
            lblAGE.Size = new Size(41, 20);
            lblAGE.TabIndex = 5;
            lblAGE.Text = "Age:";
            // 
            // txtFIRSTNAME
            // 
            txtFIRSTNAME.Location = new Point(366, 134);
            txtFIRSTNAME.Name = "txtFIRSTNAME";
            txtFIRSTNAME.Size = new Size(240, 27);
            txtFIRSTNAME.TabIndex = 6;
            // 
            // txtLASTNAME
            // 
            txtLASTNAME.Location = new Point(366, 185);
            txtLASTNAME.Name = "txtLASTNAME";
            txtLASTNAME.Size = new Size(240, 27);
            txtLASTNAME.TabIndex = 7;
            // 
            // txtAGE
            // 
            txtAGE.Location = new Point(366, 359);
            txtAGE.Name = "txtAGE";
            txtAGE.Size = new Size(240, 27);
            txtAGE.TabIndex = 10;
            // 
            // btnSAVERECORD
            // 
            btnSAVERECORD.Location = new Point(385, 419);
            btnSAVERECORD.Name = "btnSAVERECORD";
            btnSAVERECORD.Size = new Size(199, 63);
            btnSAVERECORD.TabIndex = 11;
            btnSAVERECORD.Text = "Save Record";
            btnSAVERECORD.UseVisualStyleBackColor = true;
            // 
            // cbCOURSE
            // 
            cbCOURSE.FormattingEnabled = true;
            cbCOURSE.Items.AddRange(new object[] { "ACT", "BSOA", "HM" });
            cbCOURSE.Location = new Point(366, 243);
            cbCOURSE.Name = "cbCOURSE";
            cbCOURSE.Size = new Size(240, 28);
            cbCOURSE.TabIndex = 12;
            // 
            // cbSECTION
            // 
            cbSECTION.FormattingEnabled = true;
            cbSECTION.Location = new Point(366, 297);
            cbSECTION.Name = "cbSECTION";
            cbSECTION.Size = new Size(240, 28);
            cbSECTION.TabIndex = 13;
            // 
            // register_student
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 600);
            Controls.Add(cbSECTION);
            Controls.Add(cbCOURSE);
            Controls.Add(btnSAVERECORD);
            Controls.Add(txtAGE);
            Controls.Add(txtLASTNAME);
            Controls.Add(txtFIRSTNAME);
            Controls.Add(lblAGE);
            Controls.Add(lblSECTION);
            Controls.Add(lblCOURSE);
            Controls.Add(lblLAST_NAME);
            Controls.Add(lblFIRST_NAME);
            Controls.Add(lblTITLE);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "register_student";
            Text = "register_student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTITLE;
        private Label lblFIRST_NAME;
        private Label lblLAST_NAME;
        private Label lblCOURSE;
        private Label lblSECTION;
        private Label lblAGE;
        private TextBox txtFIRSTNAME;
        private TextBox txtLASTNAME;
        private TextBox txtAGE;
        private Button btnSAVERECORD;
        private ComboBox cbCOURSE;
        private ComboBox cbSECTION;
    }
}