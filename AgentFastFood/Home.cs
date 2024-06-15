using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgentFastFood
{
    public partial class Home : Form
    {
        // Replace with your actual connection string
        private string connectionString = "Data Source=DESKTOP-454NMGQ\\SQLEXPRESS;Initial Catalog=AgentFastFood;Integrated Security=True;TrustServerCertificate=True";

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Load initial data into DataGridView
            LoadFoodOrders();
        }

        private void LoadFoodOrders()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Food, Price, PaymentMethod, OrderDate FROM FoodOrdering";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                try
                {
                    cn.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFoodID.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderDate = dateAgent.Value.ToString("yyyy-MM-dd"); // Format the date as needed
            string paymentMethod = txtPayMed.Text;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "UPDATE FoodOrdering SET OrderDate = @OrderDate, PaymentMethod = @PaymentMethod WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@ID", orderId);

                try
                {
                    cn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh DataGridView after update
                        LoadFoodOrders();
                    }
                    else
                    {
                        MessageBox.Show("No order found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            // Assuming the ID field is txtFoodID, the payment method field is txtPayMed, and the date picker is dateAgent
            if (!int.TryParse(txtFoodID.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderDate = dateAgent.Value.ToString("yyyy-MM-dd"); // Format the date as needed
            string paymentMethod = txtPayMed.Text;

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "UPDATE FoodOrdering SET OrderDate = @OrderDate, PaymentMethod = @PaymentMethod WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@ID", orderId);

                try
                {
                    cn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh DataGridView after update
                        LoadFoodOrders();
                    }
                    else
                    {
                        MessageBox.Show("No order found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click event if needed
        }

        private void dateAgent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPayMed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
