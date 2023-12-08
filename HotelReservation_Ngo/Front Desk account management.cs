using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelReservation_Ngo
{
    public partial class Front_Desk_account_management : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");
        int id;
        string firstName, lastName, gender, username, password;
        public Front_Desk_account_management()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }
        public void displayfdam()
        {
            try
            {
                // connection.Open();
                string query = "Select * from user;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                connection.Open();

                string query = "insert into user (fname, lname, gender, username,password) " +
                    "Values(@FirstName,@LastName,@gender,@username,@password);";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", textBox2.Text); // Update with text box values
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@gender", textBox4.Text);
                    command.Parameters.AddWithValue("@username", textBox6.Text);
                    command.Parameters.AddWithValue("@password", textBox7.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Front desk added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        //displayclients();
                        connection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Front desk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    displayfdam();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Front_Desk_account_management_Load(object sender, EventArgs e)
        {
            displayfdam();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                connection.Open();

                string query = "UPDATE user SET fname=@FirstName,lname=@LastName, gender=@gender, username=@username,password=@password where id =@CID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CID", id);
                    command.Parameters.AddWithValue("@FirstName", textBox2.Text); // Update with text box values
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@gender", textBox4.Text);
                    command.Parameters.AddWithValue("@username", textBox6.Text);
                    command.Parameters.AddWithValue("@password", textBox7.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Front desk update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        connection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Failed to update Front desk", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    displayfdam();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Extract data from the selected row
                    int cidd = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    // Delete query
                    string query = "DELETE FROM user WHERE id =@CID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CID", cidd);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // If deletion is successful
                            MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayfdam(); // Refresh the DataGridView after deletion
                            Clear(); // Clear any fields or selections

                        }
                        else
                        {
                            MessageBox.Show("Failed to delete row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // Ensure the connection is closed after operations
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row
                id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                firstName = selectedRow.Cells["fname"].Value.ToString();
                lastName = selectedRow.Cells["lname"].Value.ToString();
                gender = selectedRow.Cells["gender"].Value.ToString();
                username = selectedRow.Cells["username"].Value.ToString();
                password = selectedRow.Cells["password"].Value.ToString();

                // Update the text boxes
                textBox1.Text = id.ToString();
                textBox2.Text = firstName;
                textBox3.Text = lastName;
                textBox4.Text = gender;
                textBox6.Text = username;
                textBox7.Text = password;
            }
        }
    }
}
