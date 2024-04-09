namespace asm2_database
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tpcourses = new TabPage();
            txtfile = new TextBox();
            txtassignmentcontent = new RichTextBox();
            lblcoursename = new Label();
            label1 = new Label();
            txtassignmentname = new TextBox();
            btnpreview = new Button();
            btnreset = new Button();
            btnsubmitfile = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tpgrade = new TabPage();
            btnsearchgrade = new Button();
            txtsearchgrade = new TextBox();
            dtggrade = new DataGridView();
            btnExit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tpcourses.SuspendLayout();
            tpgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtggrade).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spcMHA7eH1INBQFvqh6Wkj266e8IzRkY_1644922155____da2e99d299b5f54dd5123fba1e415d3e;
            pictureBox1.Location = new Point(28, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpcourses);
            tabControl1.Controls.Add(tpgrade);
            tabControl1.Location = new Point(6, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 342);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tpcourses
            // 
            tpcourses.Controls.Add(txtfile);
            tpcourses.Controls.Add(txtassignmentcontent);
            tpcourses.Controls.Add(lblcoursename);
            tpcourses.Controls.Add(label1);
            tpcourses.Controls.Add(txtassignmentname);
            tpcourses.Controls.Add(btnpreview);
            tpcourses.Controls.Add(btnreset);
            tpcourses.Controls.Add(btnsubmitfile);
            tpcourses.Controls.Add(label4);
            tpcourses.Controls.Add(label3);
            tpcourses.Controls.Add(label2);
            tpcourses.Location = new Point(4, 29);
            tpcourses.Name = "tpcourses";
            tpcourses.Padding = new Padding(3);
            tpcourses.Size = new Size(793, 309);
            tpcourses.TabIndex = 0;
            tpcourses.Text = "Courses";
            tpcourses.UseVisualStyleBackColor = true;
            // 
            // txtfile
            // 
            txtfile.Location = new Point(169, 181);
            txtfile.Name = "txtfile";
            txtfile.Size = new Size(409, 27);
            txtfile.TabIndex = 10;
            // 
            // txtassignmentcontent
            // 
            txtassignmentcontent.Location = new Point(169, 104);
            txtassignmentcontent.Name = "txtassignmentcontent";
            txtassignmentcontent.Size = new Size(524, 51);
            txtassignmentcontent.TabIndex = 9;
            txtassignmentcontent.Text = "";
            // 
            // lblcoursename
            // 
            lblcoursename.AutoSize = true;
            lblcoursename.Location = new Point(92, 18);
            lblcoursename.Name = "lblcoursename";
            lblcoursename.Size = new Size(0, 20);
            lblcoursename.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Course";
            // 
            // txtassignmentname
            // 
            txtassignmentname.Location = new Point(169, 54);
            txtassignmentname.Name = "txtassignmentname";
            txtassignmentname.Size = new Size(524, 27);
            txtassignmentname.TabIndex = 2;
            
            // 
            // btnpreview
            // 
            btnpreview.Location = new Point(599, 181);
            btnpreview.Name = "btnpreview";
            btnpreview.Size = new Size(94, 29);
            btnpreview.TabIndex = 1;
            btnpreview.Text = "Browse";
            btnpreview.UseVisualStyleBackColor = true;
            btnpreview.Click += btnpreview_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(484, 231);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(94, 29);
            btnreset.TabIndex = 1;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            // 
            // btnsubmitfile
            // 
            btnsubmitfile.Location = new Point(169, 231);
            btnsubmitfile.Name = "btnsubmitfile";
            btnsubmitfile.Size = new Size(94, 29);
            btnsubmitfile.TabIndex = 1;
            btnsubmitfile.Text = "Submit";
            btnsubmitfile.UseVisualStyleBackColor = true;
            btnsubmitfile.Click += btnsubmitfile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 188);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 0;
            label4.Text = "File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 107);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 0;
            label3.Text = "Assignment content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 0;
            label2.Text = "Asssignment name";
         
            // 
            // tpgrade
            // 
            tpgrade.Controls.Add(btnsearchgrade);
            tpgrade.Controls.Add(txtsearchgrade);
            tpgrade.Controls.Add(dtggrade);
            tpgrade.Location = new Point(4, 29);
            tpgrade.Name = "tpgrade";
            tpgrade.Padding = new Padding(3);
            tpgrade.Size = new Size(793, 309);
            tpgrade.TabIndex = 1;
            tpgrade.Text = "Grade";
            tpgrade.UseVisualStyleBackColor = true;
            // 
            // btnsearchgrade
            // 
            btnsearchgrade.Location = new Point(524, 15);
            btnsearchgrade.Name = "btnsearchgrade";
            btnsearchgrade.Size = new Size(94, 29);
            btnsearchgrade.TabIndex = 2;
            btnsearchgrade.Text = "Search";
            btnsearchgrade.UseMnemonic = false;
            btnsearchgrade.UseVisualStyleBackColor = true;
            btnsearchgrade.Click += btnsearchgrade_Click;
            // 
            // txtsearchgrade
            // 
            txtsearchgrade.Location = new Point(141, 15);
            txtsearchgrade.Name = "txtsearchgrade";
            txtsearchgrade.Size = new Size(359, 27);
            txtsearchgrade.TabIndex = 1;
            // 
            // dtggrade
            // 
            dtggrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtggrade.Location = new Point(18, 54);
            dtggrade.Name = "dtggrade";
            dtggrade.RowHeadersWidth = 51;
            dtggrade.RowTemplate.Height = 29;
            dtggrade.Size = new Size(760, 245);
            dtggrade.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(680, 31);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 73);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tpcourses.ResumeLayout(false);
            tpcourses.PerformLayout();
            tpgrade.ResumeLayout(false);
            tpgrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtggrade).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tpcourses;
        private TabPage tpgrade;
        private Button btnExit;
        private TextBox txtassignmentname;
        private Button btnpreview;
        private Button btnreset;
        private Button btnsubmitfile;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblcoursename;
        private Label label1;
        private RichTextBox txtassignmentcontent;
        private TextBox txtfile;
        private OpenFileDialog openFileDialog1;
        private DataGridView dtggrade;
        private Button btnsearchgrade;
        private TextBox txtsearchgrade;
    }
}