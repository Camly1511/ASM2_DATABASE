namespace asm2_database
{
    partial class Form2
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
            toolStrip1 = new ToolStrip();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tpCourse = new TabPage();
            dtgcourse = new DataGridView();
            txtsearch = new TextBox();
            btnSearch = new Button();
            btnDetele = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            cbstatus = new ComboBox();
            txtname = new TextBox();
            txtid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tpStudent = new TabPage();
            label14 = new Label();
            btnstdelete = new Button();
            btnstedit = new Button();
            btnstadd = new Button();
            dataGridView1 = new DataGridView();
            cbststatus = new ComboBox();
            label12 = new Label();
            cbstgender = new ComboBox();
            cbstcourse = new ComboBox();
            txtstadd = new TextBox();
            txtstphone = new TextBox();
            txtstpass = new TextBox();
            txtstbirthday = new TextBox();
            txtstemail = new TextBox();
            txtstfullname = new TextBox();
            txtstcode = new TextBox();
            txtstid = new TextBox();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbMark = new TabPage();
            txtassignmentcontent = new RichTextBox();
            txtassignmentid = new Label();
            txtassignmentmark = new TextBox();
            txtassignmentstname = new TextBox();
            txtassignmentname = new TextBox();
            btnsubmitmark = new Button();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            dtgassignmentlist = new DataGridView();
            tpassignment = new TabPage();
            txtduedate = new DateTimePicker();
            btnassign = new Button();
            cbassignmentstatus = new ComboBox();
            txtassignmentname2 = new TextBox();
            txtstudentname = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            lblstudentname = new Label();
            dtgstudent = new DataGridView();
            btnExit = new Button();
            txtassignmentcontent2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tpCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcourse).BeginInit();
            tpStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbMark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgassignmentlist).BeginInit();
            tpassignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgstudent).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.spcMHA7eH1INBQFvqh6Wkj266e8IzRkY_1644922155____da2e99d299b5f54dd5123fba1e415d3e;
            pictureBox1.Location = new Point(5, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpCourse);
            tabControl1.Controls.Add(tpStudent);
            tabControl1.Controls.Add(tbMark);
            tabControl1.Controls.Add(tpassignment);
            tabControl1.Location = new Point(5, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(795, 338);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tpCourse
            // 
            tpCourse.Controls.Add(dtgcourse);
            tpCourse.Controls.Add(txtsearch);
            tpCourse.Controls.Add(btnSearch);
            tpCourse.Controls.Add(btnDetele);
            tpCourse.Controls.Add(btnEdit);
            tpCourse.Controls.Add(btnAdd);
            tpCourse.Controls.Add(cbstatus);
            tpCourse.Controls.Add(txtname);
            tpCourse.Controls.Add(txtid);
            tpCourse.Controls.Add(label3);
            tpCourse.Controls.Add(label2);
            tpCourse.Controls.Add(label1);
            tpCourse.Location = new Point(4, 29);
            tpCourse.Name = "tpCourse";
            tpCourse.Padding = new Padding(3);
            tpCourse.Size = new Size(787, 305);
            tpCourse.TabIndex = 0;
            tpCourse.Text = "Courses";
            tpCourse.UseVisualStyleBackColor = true;
            // 
            // dtgcourse
            // 
            dtgcourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgcourse.Location = new Point(379, 59);
            dtgcourse.Name = "dtgcourse";
            dtgcourse.RowHeadersWidth = 51;
            dtgcourse.RowTemplate.Height = 29;
            dtgcourse.Size = new Size(400, 188);
            dtgcourse.TabIndex = 8;
            dtgcourse.CellClick += dtgcourse_CellClick;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(379, 17);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(300, 27);
            txtsearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(685, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDetele
            // 
            btnDetele.Location = new Point(224, 218);
            btnDetele.Name = "btnDetele";
            btnDetele.Size = new Size(94, 29);
            btnDetele.TabIndex = 5;
            btnDetele.Text = "Detele";
            btnDetele.UseVisualStyleBackColor = true;
            btnDetele.Click += btnDetele_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(124, 218);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbstatus
            // 
            cbstatus.FormattingEnabled = true;
            cbstatus.Location = new Point(86, 166);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(232, 28);
            cbstatus.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Location = new Point(86, 113);
            txtname.Name = "txtname";
            txtname.Size = new Size(232, 27);
            txtname.TabIndex = 1;
            // 
            // txtid
            // 
            txtid.Location = new Point(86, 59);
            txtid.Name = "txtid";
            txtid.Size = new Size(232, 27);
            txtid.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 174);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 120);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // tpStudent
            // 
            tpStudent.Controls.Add(label14);
            tpStudent.Controls.Add(btnstdelete);
            tpStudent.Controls.Add(btnstedit);
            tpStudent.Controls.Add(btnstadd);
            tpStudent.Controls.Add(dataGridView1);
            tpStudent.Controls.Add(cbststatus);
            tpStudent.Controls.Add(label12);
            tpStudent.Controls.Add(cbstgender);
            tpStudent.Controls.Add(cbstcourse);
            tpStudent.Controls.Add(txtstadd);
            tpStudent.Controls.Add(txtstphone);
            tpStudent.Controls.Add(txtstpass);
            tpStudent.Controls.Add(txtstbirthday);
            tpStudent.Controls.Add(txtstemail);
            tpStudent.Controls.Add(txtstfullname);
            tpStudent.Controls.Add(txtstcode);
            tpStudent.Controls.Add(txtstid);
            tpStudent.Controls.Add(label15);
            tpStudent.Controls.Add(label13);
            tpStudent.Controls.Add(label11);
            tpStudent.Controls.Add(label10);
            tpStudent.Controls.Add(label9);
            tpStudent.Controls.Add(label8);
            tpStudent.Controls.Add(label7);
            tpStudent.Controls.Add(label6);
            tpStudent.Controls.Add(label5);
            tpStudent.Controls.Add(label4);
            tpStudent.Location = new Point(4, 29);
            tpStudent.Name = "tpStudent";
            tpStudent.Padding = new Padding(3);
            tpStudent.Size = new Size(787, 305);
            tpStudent.TabIndex = 1;
            tpStudent.Text = "Students";
            tpStudent.UseVisualStyleBackColor = true;
            tpStudent.Click += tpStudent_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 99);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 19;
            label14.Text = "Email";
            // 
            // btnstdelete
            // 
            btnstdelete.Location = new Point(295, 270);
            btnstdelete.Name = "btnstdelete";
            btnstdelete.Size = new Size(94, 29);
            btnstdelete.TabIndex = 18;
            btnstdelete.Text = "Delete";
            btnstdelete.UseVisualStyleBackColor = true;
            btnstdelete.Click += btnDelete_Click;
            // 
            // btnstedit
            // 
            btnstedit.Location = new Point(153, 270);
            btnstedit.Name = "btnstedit";
            btnstedit.Size = new Size(94, 29);
            btnstedit.TabIndex = 17;
            btnstedit.Text = "Edit";
            btnstedit.UseVisualStyleBackColor = true;
            btnstedit.Click += btnstedit_Click;
            // 
            // btnstadd
            // 
            btnstadd.Location = new Point(15, 270);
            btnstadd.Name = "btnstadd";
            btnstadd.Size = new Size(94, 29);
            btnstadd.TabIndex = 16;
            btnstadd.Text = "Add";
            btnstadd.UseVisualStyleBackColor = true;
            btnstadd.Click += btnstadd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(370, 289);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cbststatus
            // 
            cbststatus.FormattingEnabled = true;
            cbststatus.Location = new Point(77, 229);
            cbststatus.Name = "cbststatus";
            cbststatus.Size = new Size(125, 28);
            cbststatus.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 237);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 13;
            label12.Text = "Status";
            // 
            // cbstgender
            // 
            cbstgender.FormattingEnabled = true;
            cbstgender.Location = new Point(276, 184);
            cbstgender.Name = "cbstgender";
            cbstgender.Size = new Size(125, 28);
            cbstgender.TabIndex = 12;
            // 
            // cbstcourse
            // 
            cbstcourse.FormattingEnabled = true;
            cbstcourse.Location = new Point(276, 10);
            cbstcourse.Name = "cbstcourse";
            cbstcourse.Size = new Size(125, 28);
            cbstcourse.TabIndex = 11;
            // 
            // txtstadd
            // 
            txtstadd.Location = new Point(77, 185);
            txtstadd.Name = "txtstadd";
            txtstadd.Size = new Size(125, 27);
            txtstadd.TabIndex = 9;
            // 
            // txtstphone
            // 
            txtstphone.Location = new Point(276, 139);
            txtstphone.Name = "txtstphone";
            txtstphone.Size = new Size(125, 27);
            txtstphone.TabIndex = 8;
            // 
            // txtstpass
            // 
            txtstpass.Location = new Point(77, 139);
            txtstpass.Name = "txtstpass";
            txtstpass.Size = new Size(125, 27);
            txtstpass.TabIndex = 7;
            // 
            // txtstbirthday
            // 
            txtstbirthday.Location = new Point(276, 99);
            txtstbirthday.Name = "txtstbirthday";
            txtstbirthday.Size = new Size(125, 27);
            txtstbirthday.TabIndex = 6;
            // 
            // txtstemail
            // 
            txtstemail.Location = new Point(77, 95);
            txtstemail.Name = "txtstemail";
            txtstemail.Size = new Size(125, 27);
            txtstemail.TabIndex = 5;
            // 
            // txtstfullname
            // 
            txtstfullname.Location = new Point(276, 52);
            txtstfullname.Name = "txtstfullname";
            txtstfullname.Size = new Size(125, 27);
            txtstfullname.TabIndex = 4;
            // 
            // txtstcode
            // 
            txtstcode.Location = new Point(77, 48);
            txtstcode.Name = "txtstcode";
            txtstcode.Size = new Size(125, 27);
            txtstcode.TabIndex = 3;
            // 
            // txtstid
            // 
            txtstid.Location = new Point(77, 6);
            txtstid.Name = "txtstid";
            txtstid.Size = new Size(125, 27);
            txtstid.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(205, 192);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 0;
            label15.Text = "Gender";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 192);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 0;
            label13.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(205, 146);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 0;
            label11.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 146);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 0;
            label10.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(205, 102);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 0;
            label9.Text = "Birthday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 102);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(205, 55);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 0;
            label7.Text = "Fullname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 55);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 0;
            label6.Text = "Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 13);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 0;
            label5.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 13);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 0;
            label4.Text = "Id";
            // 
            // tbMark
            // 
            tbMark.Controls.Add(txtassignmentcontent);
            tbMark.Controls.Add(txtassignmentid);
            tbMark.Controls.Add(txtassignmentmark);
            tbMark.Controls.Add(txtassignmentstname);
            tbMark.Controls.Add(txtassignmentname);
            tbMark.Controls.Add(btnsubmitmark);
            tbMark.Controls.Add(label20);
            tbMark.Controls.Add(label19);
            tbMark.Controls.Add(label18);
            tbMark.Controls.Add(label17);
            tbMark.Controls.Add(label16);
            tbMark.Controls.Add(dtgassignmentlist);
            tbMark.Location = new Point(4, 29);
            tbMark.Name = "tbMark";
            tbMark.Padding = new Padding(3);
            tbMark.Size = new Size(787, 305);
            tbMark.TabIndex = 2;
            tbMark.Text = "Mark";
            tbMark.UseVisualStyleBackColor = true;
            // 
            // txtassignmentcontent
            // 
            txtassignmentcontent.Location = new Point(105, 72);
            txtassignmentcontent.Name = "txtassignmentcontent";
            txtassignmentcontent.Size = new Size(204, 83);
            txtassignmentcontent.TabIndex = 12;
            txtassignmentcontent.Text = "";
            // 
            // txtassignmentid
            // 
            txtassignmentid.AutoSize = true;
            txtassignmentid.Location = new Point(105, 6);
            txtassignmentid.Name = "txtassignmentid";
            txtassignmentid.Size = new Size(0, 20);
            txtassignmentid.TabIndex = 11;
            // 
            // txtassignmentmark
            // 
            txtassignmentmark.Location = new Point(105, 202);
            txtassignmentmark.Name = "txtassignmentmark";
            txtassignmentmark.Size = new Size(204, 27);
            txtassignmentmark.TabIndex = 10;
            // 
            // txtassignmentstname
            // 
            txtassignmentstname.Location = new Point(103, 161);
            txtassignmentstname.Name = "txtassignmentstname";
            txtassignmentstname.Size = new Size(206, 27);
            txtassignmentstname.TabIndex = 9;
            // 
            // txtassignmentname
            // 
            txtassignmentname.Location = new Point(105, 39);
            txtassignmentname.Name = "txtassignmentname";
            txtassignmentname.Size = new Size(204, 27);
            txtassignmentname.TabIndex = 7;
            // 
            // btnsubmitmark
            // 
            btnsubmitmark.Location = new Point(105, 255);
            btnsubmitmark.Name = "btnsubmitmark";
            btnsubmitmark.Size = new Size(94, 29);
            btnsubmitmark.TabIndex = 6;
            btnsubmitmark.Text = "Submit";
            btnsubmitmark.UseVisualStyleBackColor = true;
            btnsubmitmark.Click += btnsubmitmark_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(37, 209);
            label20.Name = "label20";
            label20.Size = new Size(42, 20);
            label20.TabIndex = 5;
            label20.Text = "Mark";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(37, 168);
            label19.Name = "label19";
            label19.Size = new Size(60, 20);
            label19.TabIndex = 4;
            label19.Text = "Student";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(34, 72);
            label18.Name = "label18";
            label18.Size = new Size(61, 20);
            label18.TabIndex = 3;
            label18.Text = "Content";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(34, 42);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 2;
            label17.Text = "Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 6);
            label16.Name = "label16";
            label16.Size = new Size(86, 20);
            label16.TabIndex = 1;
            label16.Text = "Assignment";
            // 
            // dtgassignmentlist
            // 
            dtgassignmentlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgassignmentlist.Location = new Point(330, 6);
            dtgassignmentlist.Name = "dtgassignmentlist";
            dtgassignmentlist.RowHeadersWidth = 51;
            dtgassignmentlist.RowTemplate.Height = 29;
            dtgassignmentlist.Size = new Size(449, 293);
            dtgassignmentlist.TabIndex = 0;
            dtgassignmentlist.CellClick += dtgassignmentlist_CellClick;
            // 
            // tpassignment
            // 
            tpassignment.Controls.Add(txtassignmentcontent2);
            tpassignment.Controls.Add(txtduedate);
            tpassignment.Controls.Add(btnassign);
            tpassignment.Controls.Add(cbassignmentstatus);
            tpassignment.Controls.Add(txtassignmentname2);
            tpassignment.Controls.Add(txtstudentname);
            tpassignment.Controls.Add(label25);
            tpassignment.Controls.Add(label24);
            tpassignment.Controls.Add(label23);
            tpassignment.Controls.Add(label22);
            tpassignment.Controls.Add(lblstudentname);
            tpassignment.Controls.Add(dtgstudent);
            tpassignment.Location = new Point(4, 29);
            tpassignment.Name = "tpassignment";
            tpassignment.Padding = new Padding(3);
            tpassignment.Size = new Size(787, 305);
            tpassignment.TabIndex = 3;
            tpassignment.Text = "Assignment";
            tpassignment.UseVisualStyleBackColor = true;
            // 
            // txtduedate
            // 
            txtduedate.Location = new Point(165, 164);
            txtduedate.Name = "txtduedate";
            txtduedate.Size = new Size(272, 27);
            txtduedate.TabIndex = 6;
            // 
            // btnassign
            // 
            btnassign.Location = new Point(194, 251);
            btnassign.Name = "btnassign";
            btnassign.Size = new Size(94, 29);
            btnassign.TabIndex = 5;
            btnassign.Text = "Assign";
            btnassign.UseVisualStyleBackColor = true;
            btnassign.Click += btnassign_Click;
            // 
            // cbassignmentstatus
            // 
            cbassignmentstatus.FormattingEnabled = true;
            cbassignmentstatus.Location = new Point(165, 204);
            cbassignmentstatus.Name = "cbassignmentstatus";
            cbassignmentstatus.Size = new Size(272, 28);
            cbassignmentstatus.TabIndex = 3;
            // 
            // txtassignmentname2
            // 
            txtassignmentname2.Location = new Point(170, 53);
            txtassignmentname2.Name = "txtassignmentname2";
            txtassignmentname2.Size = new Size(267, 27);
            txtassignmentname2.TabIndex = 2;
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(170, 12);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(267, 27);
            txtstudentname.TabIndex = 2;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(19, 207);
            label25.Name = "label25";
            label25.Size = new Size(49, 20);
            label25.TabIndex = 1;
            label25.Text = "Status";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(19, 169);
            label24.Name = "label24";
            label24.Size = new Size(70, 20);
            label24.TabIndex = 1;
            label24.Text = "Due date";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(19, 98);
            label23.Name = "label23";
            label23.Size = new Size(140, 20);
            label23.TabIndex = 1;
            label23.Text = "Assignment content";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(19, 53);
            label22.Name = "label22";
            label22.Size = new Size(127, 20);
            label22.TabIndex = 1;
            label22.Text = "Assignment name";
            // 
            // lblstudentname
            // 
            lblstudentname.AutoSize = true;
            lblstudentname.Location = new Point(19, 15);
            lblstudentname.Name = "lblstudentname";
            lblstudentname.Size = new Size(101, 20);
            lblstudentname.TabIndex = 1;
            lblstudentname.Text = "Student name";
            // 
            // dtgstudent
            // 
            dtgstudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgstudent.Location = new Point(453, 15);
            dtgstudent.Name = "dtgstudent";
            dtgstudent.RowHeadersWidth = 51;
            dtgstudent.RowTemplate.Height = 29;
            dtgstudent.Size = new Size(326, 284);
            dtgstudent.TabIndex = 0;
            dtgstudent.CellClick += dtgstudent_CellClick;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 43);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 75);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtassignmentcontent2
            // 
            txtassignmentcontent2.Location = new Point(165, 95);
            txtassignmentcontent2.Name = "txtassignmentcontent2";
            txtassignmentcontent2.Size = new Size(272, 61);
            txtassignmentcontent2.TabIndex = 7;
            txtassignmentcontent2.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tpCourse.ResumeLayout(false);
            tpCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgcourse).EndInit();
            tpStudent.ResumeLayout(false);
            tpStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbMark.ResumeLayout(false);
            tbMark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgassignmentlist).EndInit();
            tpassignment.ResumeLayout(false);
            tpassignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgstudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tpCourse;
        private TextBox txtname;
        private TextBox txtid;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tpStudent;
        private DataGridView dtgcourse;
        private TextBox txtsearch;
        private Button btnSearch;
        private Button btnDetele;
        private Button btnEdit;
        private Button btnAdd;
        private ComboBox cbstatus;
        private TextBox txtstid;
        private Label label15;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbstcourse;
        private TextBox txtstadd;
        private TextBox txtstphone;
        private TextBox txtstpass;
        private TextBox txtstbirthday;
        private TextBox txtstemail;
        private TextBox txtstfullname;
        private TextBox txtstcode;
        private Label label14;
        private Button btnstdelete;
        private Button btnstedit;
        private Button btnstadd;
        private DataGridView dataGridView1;
        private ComboBox cbststatus;
        private Label label12;
        private ComboBox cbstgender;
        private TabPage tbMark;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private DataGridView dtgassignmentlist;
        private TextBox txtassignmentmark;
        private TextBox txtassignmentstname;
        private TextBox txtassignmentname;
        private Button btnsubmitmark;
        private Label txtassignmentid;
        private Button btnExit;
        private TabPage tpassignment;
        private DataGridView dtgstudent;
        private RichTextBox richTextBox1;
        private ComboBox cbassignmentstatus;
        private TextBox textBox3;
        private TextBox txtassignmentname2;
        private TextBox txtstudentname;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button btnassign;
        private Label lblstudentname;
        private DateTimePicker txtduedate;
        private RichTextBox txtassignmentcontent;
        private RichTextBox txtassignmentcontent2;
    }
}