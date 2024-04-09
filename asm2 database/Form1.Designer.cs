namespace asm2_database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblusername = new Label();
            lblpassword = new Label();
            lbllogin = new Label();
            lblexit = new Label();
            txtname = new TextBox();
            txtpass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(390, 24);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            label1.Click += label1_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(203, 110);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(78, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(203, 201);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(73, 20);
            lblpassword.TabIndex = 0;
            lblpassword.Text = "Password:";
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(365, 290);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(51, 20);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "LOGIN";
            lbllogin.Click += lbllogin_Click;
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Location = new Point(578, 290);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(38, 20);
            lblexit.TabIndex = 0;
            lblexit.Text = "EXIT";
            // 
            // txtname
            // 
            txtname.Location = new Point(365, 194);
            txtname.Name = "txtname";
            txtname.Size = new Size(251, 27);
            txtname.TabIndex = 1;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(365, 110);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(251, 27);
            txtpass.TabIndex = 1;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = Properties.Resources.z5225660630506_f728f2ec0e5bd33a941fe2a528eb8298;
            ClientSize = new Size(886, 450);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(lblpassword);
            Controls.Add(lblexit);
            Controls.Add(lbllogin);
            Controls.Add(lblusername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblusername;
        private Label lblpassword;
        private Label lbllogin;
        private Label lblexit;
        private TextBox txtname;
        private TextBox txtpass;
    }
}