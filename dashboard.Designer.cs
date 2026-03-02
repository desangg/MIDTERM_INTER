namespace dess
{
    partial class dashboard
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
            btnREGISTER_STUDENT = new Button();
            btnSTUDENT_LIST = new Button();
            SuspendLayout();
            // 
            // btnREGISTER_STUDENT
            // 
            btnREGISTER_STUDENT.Location = new Point(126, 237);
            btnREGISTER_STUDENT.Name = "btnREGISTER_STUDENT";
            btnREGISTER_STUDENT.Size = new Size(295, 97);
            btnREGISTER_STUDENT.TabIndex = 0;
            btnREGISTER_STUDENT.Text = "REGISTER STUDENT";
            btnREGISTER_STUDENT.UseVisualStyleBackColor = true;
            // 
            // btnSTUDENT_LIST
            // 
            btnSTUDENT_LIST.Location = new Point(547, 237);
            btnSTUDENT_LIST.Name = "btnSTUDENT_LIST";
            btnSTUDENT_LIST.Size = new Size(275, 97);
            btnSTUDENT_LIST.TabIndex = 1;
            btnSTUDENT_LIST.Text = "STUDENT LIST";
            btnSTUDENT_LIST.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 674);
            Controls.Add(btnSTUDENT_LIST);
            Controls.Add(btnREGISTER_STUDENT);
            Name = "dashboard";
            Text = "dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnREGISTER_STUDENT;
        private Button btnSTUDENT_LIST;
    }
}