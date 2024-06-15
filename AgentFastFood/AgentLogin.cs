using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentFastFood
{
    public partial class AgentLogin : Form
    {
        public AgentLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Establish connection
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-454NMGQ\\SQLEXPRESS;Initial Catalog=AgentFastFood;Integrated Security=True;TrustServerCertificate=True"))
            {
                cn.Open();

                // Query to check credentials
                string query = "SELECT COUNT(*) FROM AgentLogin WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // Login successful
                    MessageBox.Show("Login success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the login form
                    this.Hide();

                    // Open the home form
                    Home homeForm = new Home();
                    homeForm.ShowDialog(); // ShowDialog() to show it as a modal dialog
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Login failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPass.PasswordChar = ckbShowPass.Checked ? '\0' : '*';
        }

        private void AgentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
