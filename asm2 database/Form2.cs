using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace asm2_database
{
    public partial class Form2 : Form
    {
        private int teacherId;
        private int courseId;
        private int studentId;
        public Form2(int teacherId)
        {
            this.teacherId = teacherId;
            this.courseId = getCourse();
            InitializeComponent();
            cbstatus.Items.Add("Active");
            cbstatus.Items.Add("Inactive");
            LoadData();
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDetele.Enabled = false;
            cbstatus.SelectedIndex = 0;

            cbstgender.Items.Add("Male");
            cbstgender.Items.Add("Female");

            cbststatus.Items.Add("Active");
            cbststatus.Items.Add("Inactive");

            txtassignmentcontent2.ReadOnly = false;
            txtassignmentname.ReadOnly = true;
            txtassignmentstname.ReadOnly = true;
            LoadAssignmentList();
            txtassignmentid.Visible = false;
            btnsubmitmark.Enabled = false;

            dtgcourse.AllowDrop = false;
            dtgcourse.CancelEdit();
            dtgcourse.AllowUserToAddRows = false;

            dataGridView1.AllowDrop = false;
            dataGridView1.CancelEdit();
            dataGridView1.AllowUserToAddRows = false;

            dtgassignmentlist.AllowDrop = false;
            dtgassignmentlist.CancelEdit();
            dtgassignmentlist.AllowUserToAddRows = false;

            txtstudentname.ReadOnly = true;
            dtgstudent.AllowDrop = false;
            dtgstudent.CancelEdit();
            dtgstudent.AllowUserToAddRows = false;
            LoadStudentInCourse();
            cbassignmentstatus.Items.Add("Active");
            cbassignmentstatus.Items.Add("Inactive");
        }

        private int getCourse()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "SELECT id FROM course where teacher_id = " + teacherId;
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            var result = sqlCommand.ExecuteScalar();
            if (result != null)  
            {
                return Convert.ToInt32(result);
            }
            return 0;
        }

        private void LoadStudentInCourse()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            String query = "SELECT id, fullname, code FROM student WHERE course_id = " + courseId;
            DataSet dataSet = new DataSet();
            try
            {

                // Create a new SqlDataAdapter with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataSet with data from the SQL query
                adapter.Fill(dataSet);

                // Bind the DataSet to a DataGridView (assuming you have one named dataGridView1 on your form)
                dtgstudent.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        private void LoadAssignmentList()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            String query = "SELECT a.id, a.assignment_name, a.assignment_content, st.fullname, a.grade FROM assignment a INNER JOIN student st ON a.student_id = st.id";
            DataSet dataSet = new DataSet();
            try
            {

                // Create a new SqlDataAdapter with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataSet with data from the SQL query
                adapter.Fill(dataSet);

                // Bind the DataSet to a DataGridView (assuming you have one named dataGridView1 on your form)
                dtgassignmentlist.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        private void LoadData()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            String query = "SELECT * FROM course WHERE teacher_id = " + teacherId;
            DataSet dataSet = new DataSet();
            try
            {

                // Create a new SqlDataAdapter with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataSet with data from the SQL query
                adapter.Fill(dataSet);

                // Bind the DataSet to a DataGridView (assuming you have one named dataGridView1 on your form)
                dtgcourse.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        private void LoadStudentData()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "SELECT * FROM student";
            DataSet dataSet = new DataSet();
            try
            {

                // Create a new SqlDataAdapter with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataSet with data from the SQL query
                adapter.Fill(dataSet);

                // Bind the DataSet to a DataGridView (assuming you have one named dataGridView1 on your form)
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();

        }

        private SqlConnection ConnectSQL()
        {
            string connectionStr = "Server=LAPTOP-J4MFSTC9;Database=BTEC_CMS;Integrated Security=True;";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionStr);

            }
            catch (Exception e)
            {
                MessageBox.Show("Connetion error");
            }
            return connection;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            int status = cbstatus.SelectedIndex;

            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "SELECT * from course where id = '" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Course with ID: " + id + " already exist.");
                txtid.Text = "";
                txtid.Focus();
            }
            else
            {
                query = "INSERT INTO course VALUES (" + id + ", " + teacherId + ", '" + name + "', " + status + ")";
                command = new SqlCommand(query, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Add course success");
                    dtgcourse.DataSource = null;
                    LoadData();
                    txtid.Text = "";
                    txtname.Text = "";
                    cbstatus.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("An error occurs");
                }
            }
            connection.Close();
        }

        private void dtgcourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnDetele.Enabled = true;
            btnEdit.Enabled = true;
            int index = dtgcourse.CurrentCell.RowIndex;
            txtid.Text = dtgcourse.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dtgcourse.CurrentRow.Cells[2].Value.ToString();
            cbstatus.SelectedIndex = Convert.ToInt32(dtgcourse.CurrentRow.Cells[3].Value);
            txtid.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            int status = cbstatus.SelectedIndex;

            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "UPDATE course SET courses_name = '" + name + "', status = " + status + " WHERE id = " + id;
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Update course success");
                dtgcourse.DataSource = null;
                LoadData();
                txtid.Text = "";
                txtid.ReadOnly = false;
                txtname.Text = "";
                cbstatus.SelectedIndex = 0;
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDetele.Enabled = false;
            }
            else
            {
                MessageBox.Show("An error occurs");
            }
            connection.Close();
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "DELETE FROM course WHERE id = " + id;
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Delete course success");
                dtgcourse.DataSource = null;
                LoadData();
                txtid.Text = "";
                txtid.ReadOnly = false;
                txtname.Text = "";
                cbstatus.SelectedIndex = 0;
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDetele.Enabled = false;
            }
            else
            {
                MessageBox.Show("An error occurs");
            }
            connection.Close();
        }

        private void btnstadd_Click(object sender, EventArgs e)
        {
            string stid = txtstid.Text;
            SqlConnection connection = ConnectSQL();
            connection.Open();
            String query = "SELECT * FROM student WHERE id = " + stid;
            SqlCommand command = new SqlCommand(query, connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                long courseid = Convert.ToInt64(cbstcourse.SelectedValue);
                string stcode = txtstcode.Text;
                string stemail = txtstemail.Text;
                string stpass = txtstpass.Text;
                string stphone = txtstphone.Text;
                string staddress = txtstadd.Text;
                string stfullname = txtstfullname.Text;
                string stbirthday = txtstbirthday.Text;
                int stgender = cbstgender.SelectedIndex;
                int ststatus = cbststatus.SelectedIndex;
                command = new SqlCommand("INSERT INTO student VALUES(@id, @courseid, 1, @stcode, @stemail, @stpass, @stphone, @staddress, @stfullname, @stbirthday, @stgender, @ststatus)", connection);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(stid));
                command.Parameters.AddWithValue("@courseid", courseid);
                command.Parameters.AddWithValue("@stcode", stcode);
                command.Parameters.AddWithValue("@stemail", stemail);
                command.Parameters.AddWithValue("@stpass", stpass);
                command.Parameters.AddWithValue("@stphone", stphone);
                command.Parameters.AddWithValue("@staddress", staddress);
                command.Parameters.AddWithValue("@stfullname", stfullname);
                command.Parameters.AddWithValue("@stbirthday", stbirthday);
                command.Parameters.AddWithValue("@stgender", stgender);
                command.Parameters.AddWithValue("@ststatus", ststatus);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Add student success");
                    LoadStudentData();
                    txtstid.Text = "";
                    cbstcourse.SelectedIndex = 0;
                    txtstcode.Text = "";
                    txtstemail.Text = "";
                    txtstpass.Text = "";
                    txtstphone.Text = "";
                    txtstadd.Text = "";
                    txtstfullname.Text = "";
                    txtstbirthday.Text = "";
                    cbstgender.SelectedIndex = 0;
                    cbststatus.SelectedIndex = 0;
                    txtstid.Focus();
                }
                else
                {
                    MessageBox.Show("An error occurs");
                }
            }
            else
            {
                MessageBox.Show("Student with id: " + stid + " already exist");
                txtid.Text = "";
                txtid.Focus();
            }
        }

        private void tpStudent_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index == 1)
            {
                SqlConnection connection = ConnectSQL();
                String query = "SELECT id, courses_name FROM course";
                DataSet dataSet = new DataSet();
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                    cbstcourse.DataSource = dataTable;
                    cbstcourse.DisplayMember = "courses_name";
                    cbstcourse.ValueMember = "id";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
                LoadStudentData();
            }
        }

        private void btnstedit_Click(object sender, EventArgs e)
        {
            string stid = txtstid.Text;
            long courseid = Convert.ToInt64(cbstcourse.SelectedValue);
            string stcode = txtstcode.Text;
            string stemail = txtstemail.Text;
            string stpass = txtstpass.Text;
            string stphone = txtstphone.Text;
            string staddress = txtstadd.Text;
            string stfullname = txtstfullname.Text;
            string stbirthday = txtstbirthday.Text;
            int stgender = cbstgender.SelectedIndex;
            int ststatus = cbststatus.SelectedIndex;

            SqlConnection connection = ConnectSQL();
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE student set course_id = @courseid, " +
                "code = @stcode, " +
                "email = @stemail, " +
                "password = @stpass, " +
                "phone = @stphone, " +
                "address = @staddress, " +
                "fullname = @stfullname, " +
                "birthday = @stbirthday, " +
                "gender = @stgender, " +
                "status = @ststatus where id = @id", connection);
            command.Parameters.AddWithValue("@id", Convert.ToInt32(stid));
            command.Parameters.AddWithValue("@courseid", courseid);
            command.Parameters.AddWithValue("@stcode", stcode);
            command.Parameters.AddWithValue("@stemail", stemail);
            command.Parameters.AddWithValue("@stpass", stpass);
            command.Parameters.AddWithValue("@stphone", stphone);
            command.Parameters.AddWithValue("@staddress", staddress);
            command.Parameters.AddWithValue("@stfullname", stfullname);
            command.Parameters.AddWithValue("@stbirthday", stbirthday);
            command.Parameters.AddWithValue("@stgender", stgender);
            command.Parameters.AddWithValue("@ststatus", ststatus);
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Update student success");
                LoadStudentData();
                txtstid.Text = "";
                cbstcourse.SelectedIndex = 0;
                txtstcode.Text = "";
                txtstemail.Text = "";
                txtstpass.Text = "";
                txtstphone.Text = "";
                txtstadd.Text = "";
                txtstfullname.Text = "";
                txtstbirthday.Text = "";
                cbstgender.SelectedIndex = 0;
                cbststatus.SelectedIndex = 0;
                txtstid.Focus();
            }
            else
            {
                MessageBox.Show("An error occurs");
            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string stid = txtstid.Text;
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string checkquery1 = "SELECT COUNT(*) FROM assignment WHERE student_id = " + stid;
            string checkquery2 = "SELECT COUNT(*) FROM score WHERE student_id = " + stid;
            string checkquery3 = "SELECT COUNT(*) FROM submit WHERE student_id = " + stid;
            SqlCommand checkcmd1 = new SqlCommand(checkquery1, connection);
            SqlCommand checkcmd2 = new SqlCommand(checkquery1, connection);
            SqlCommand checkcmd3 = new SqlCommand(checkquery1, connection);
            int checkrs1 = Convert.ToInt32(checkcmd1.ExecuteScalar());
            int checkrs2 = Convert.ToInt32(checkcmd2.ExecuteScalar());
            int checkrs3 = Convert.ToInt32(checkcmd3.ExecuteScalar());
            if (checkrs1 > 0 || checkrs2  > 0 || checkrs3 > 0) {
                MessageBox.Show("Cannot delete due to an existed reference");
            }
            else
            {
                string query = "DELETE FROM student WHERE id = " + stid;
                SqlCommand command = new SqlCommand(query, connection);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Delete student success");
                    LoadStudentData();
                    txtstid.Text = "";
                    cbstcourse.SelectedIndex = 0;
                    txtstcode.Text = "";
                    txtstemail.Text = "";
                    txtstpass.Text = "";
                    txtstphone.Text = "";
                    txtstadd.Text = "";
                    txtstfullname.Text = "";
                    txtstbirthday.Text = "";
                    cbstgender.SelectedIndex = 0;
                    cbststatus.SelectedIndex = 0;
                    txtstid.Focus();
                }
                else
                {
                    MessageBox.Show("An error occurs");
                }
            }            
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnstadd.Enabled = false;
            btnstedit.Enabled = true;
            btnstdelete.Enabled = true;
            int index = dataGridView1.CurrentCell.RowIndex;
            txtstid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbstcourse.SelectedValue = Convert.ToInt64(dataGridView1.CurrentRow.Cells[1].Value);
            txtstcode.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtstemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtstpass.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtstphone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtstadd.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtstfullname.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtstbirthday.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cbstgender.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[10].Value);
            cbststatus.SelectedIndex = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
            txtstid.ReadOnly = true;
        }

        private void dtgassignmentlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnsubmitmark.Enabled = true;
            int index = dtgassignmentlist.CurrentCell.RowIndex;
            txtassignmentid.Text = dtgassignmentlist.CurrentRow.Cells[0].Value.ToString();
            txtassignmentname.Text = dtgassignmentlist.CurrentRow.Cells[1].Value.ToString();
            txtassignmentcontent.Text = dtgassignmentlist.CurrentRow.Cells[2].Value.ToString();
            txtassignmentstname.Text = dtgassignmentlist.CurrentRow.Cells[3].Value.ToString();
            txtassignmentmark.Text = dtgassignmentlist.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnsubmitmark_Click(object sender, EventArgs e)
        {
            int assignmentid = Convert.ToInt32(txtassignmentid.Text);
            string assignmentscore = txtassignmentmark.Text;
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "UPDATE assignment set grade = '" + assignmentscore + "' WHERE id = " + assignmentid;
            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Give mark success");
                txtassignmentid.Text = "";
                txtassignmentname.Text = "";
                txtassignmentcontent2.Text = "";
                txtassignmentstname.Text = "";
                txtassignmentmark.Text = "";
                btnsubmitmark.Enabled = false;
                dtgassignmentlist.DataSource = null;
                LoadAssignmentList();
            }
            else
            {
                MessageBox.Show("An error occurs");
            }
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dtgstudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgstudent.CurrentCell.RowIndex;
            txtstudentname.Text = dtgstudent.CurrentRow.Cells[1].Value.ToString();
            studentId = Convert.ToInt32(dtgstudent.CurrentRow.Cells[0].Value.ToString());
            btnassign.Enabled = true;
        }

        private void btnassign_Click(object sender, EventArgs e)
        {
            string assignmentname = txtassignmentname2.Text;
            string assignmentcontent = txtassignmentcontent2.Text;
            string duedate = txtduedate.Value.Date.ToString();
            string status_w = cbassignmentstatus.SelectedItem.ToString();
            int status = 0;
            if (status_w.Equals("Active"))
            {
                status = 0;
            }
            else
            {
                status = 1;
            }
            SqlConnection connection = ConnectSQL();
            connection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT MAX(id) FROM assignment", connection);
            int maxid;
            var getMaxId = cmd.ExecuteScalar();
            if (getMaxId != DBNull.Value)
            {
                maxid = Convert.ToInt32(getMaxId) + 1;
            }
            else
            {
                maxid = 1;
            }
            String query = "INSERT INTO assignment VALUES (" + maxid + ", " + courseId + ", '" + assignmentname + "', '" + assignmentcontent + "', " + studentId + ", '" + duedate + "', NULL, " + status + ")";
            cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Assign homework success");
                txtstudentname.Text = "";
                txtassignmentname2.Text = "";
                txtassignmentcontent2.Text = "";
                txtduedate.Text = "";
                cbassignmentstatus.SelectedIndex = 0;
                btnassign.Enabled = false;
            }
            else
            {
                MessageBox.Show("An error occurs");
            }
        }
    }
}
