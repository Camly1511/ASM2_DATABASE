using System.Data;
using System.Data.SqlClient;

namespace asm2_database
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection ConnectSQL()
        {
            string connectionStr = "Server=LAPTOP-J4MFSTC9;Database=BTEC_CMS;Integrated Security=True;";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionStr);
                
            }
            catch (Exception e) {
                    MessageBox.Show("Connetion error");
            }
            return connection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnusername_Click(object sender, EventArgs e)
        {

        }

        private void btnpassword_Click(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            string username = txtpass.Text;
            string password = txtname.Text;
            SqlConnection connection = ConnectSQL();
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string query = "SELECT id FROM teacher where email = '" + username + "' and password = '" + password + "'";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                var result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    this.Hide();
                    Form2 form2 = new Form2(Convert.ToInt32(result));
                    form2.Show();
                }
                else
                {
                    query = "SELECT id FROM student where email = '" + username + "' and password = '" + password + "'";
                    sqlCommand = new SqlCommand(query, connection);
                    result = sqlCommand.ExecuteScalar();
                    if (result != null)
                    {
                        this.Hide();
                        Form3 form3 = new Form3(Convert.ToInt32(result));
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                        txtname.Text = "";
                        txtpass.Text = "";
                        txtname.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Connect fail");
                txtname.Text = "";
                txtpass.Text = "";
                txtname.Focus();
            }
            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtname.PasswordChar = '*';
        }
    }
}