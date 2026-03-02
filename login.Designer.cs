namespace dess
{
    partial class login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLOGIN = new Button();
            lblUSERNAME = new Label();
            lblPASSWORD = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(256, 52);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(257, 96);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLOGIN
            // 
            btnLOGIN.Location = new Point(256, 147);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(295, 68);
            btnLOGIN.TabIndex = 2;
            btnLOGIN.Text = "LOGIN";
            btnLOGIN.UseVisualStyleBackColor = true;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // lblUSERNAME
            // 
            lblUSERNAME.AutoSize = true;
            lblUSERNAME.Location = new Point(160, 60);
            lblUSERNAME.Name = "lblUSERNAME";
            lblUSERNAME.Size = new Size(63, 15);
            lblUSERNAME.TabIndex = 3;
            lblUSERNAME.Text = "Username:";
            // 
            // lblPASSWORD
            // 
            lblPASSWORD.AutoSize = true;
            lblPASSWORD.Location = new Point(160, 104);
            lblPASSWORD.Name = "lblPASSWORD";
            lblPASSWORD.Size = new Size(60, 15);
            lblPASSWORD.TabIndex = 4;
            lblPASSWORD.Text = "Password:";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPASSWORD);
            Controls.Add(lblUSERNAME);
            Controls.Add(btnLOGIN);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLOGIN;
        private Label lblUSERNAME;
        private Label lblPASSWORD;
    }
}