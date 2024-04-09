using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace asm2_database
{
    public partial class Form3 : Form
    {
        public Form3(int studentid)
        {
            this.studentid = studentid;
            InitializeComponent();
            LoadAssignment();
        }

        private int studentid;

        private string oldpath = "";
        private string newpath = "D:/FODER cam ly/assignmentDDD/";
        private string assigmentname = "";
        private bool isSubmit = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadAssignment()
        {
            SqlConnection connection = ConnectSQL();
            connection.Open();
            string query = "SELECT a.course_id, a.assignment_name, a.assignment_content FROM assignment a INNER JOIN student st ON a.id = st.course_id WHERE st.id = " + studentid;
            DataTable datatTable = new DataTable();
            try
            {

                // Create a new SqlDataAdapter with the SQL query and connection
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                // Fill the DataSet with data from the SQL query
                adapter.Fill(datatTable);
                int rs = datatTable.Rows.Count;
                if (datatTable.Rows.Count > 0)
                {
                    lblcoursename.Text = datatTable.Rows[0][0].ToString();
                    txtassignmentname.Text = datatTable.Rows[0][1].ToString();
                    txtassignmentcontent.Text = datatTable.Rows[0][2].ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            connection.Close();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    oldpath = fileName;
                    assigmentname = Path.GetFileName(fileName);
                    newpath += assigmentname;
                    txtfile.Text = fileName;
                }
                isSubmit = true;
            }
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

        private void btnsubmitfile_Click(object sender, EventArgs e)
        {
            if (isSubmit)
            {
                DialogResult result = MessageBox.Show("Do you want to submit " + assigmentname, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    File.Copy(oldpath, newpath, true);
                    SqlConnection connection = ConnectSQL();
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT MAX(id) FROM submit", connection);
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
                    string query = "INSERT INTO submit VALUES (" + maxid + ", " + studentid + ", '" + assigmentname + "', 'Not graded', CURRENT_TIMESTAMP, '" + newpath + "', 0)";
                    cmd = new SqlCommand(query, connection);
                    int rs = cmd.ExecuteNonQuery();
                    if (rs > 0)
                    
                        MessageBox.Show("Submit file success"); 
                    else
                    {
                        MessageBox.Show("An error occurs");
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("No file uploaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsearchgrade_Click(object sender, EventArgs e)
        {
            string searchValue = txtsearchgrade.Text;
            dtggrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dtggrade.Rows)
                {
                    if (row.Cells[2].Value.ToString().Contains(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index == 1)
            {
                SqlConnection connection = ConnectSQL();
                String query = "SELECT sm.*, sc.score  FROM submit sm LEFT JOIN score sc ON sm.id = sc.submit_id WHERE sm.student_id = " + studentid;
                DataSet dataSet = new DataSet();
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                    dtggrade.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                
            }
        }

    }
}
