using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation_Ngo
{
    public partial class addRoom : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=celestia;";
        private rooms roomsFormInstance;

        public addRoom(rooms RoomForm)
        {
            InitializeComponent();
            roomsFormInstance = RoomForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (rtype.SelectedIndex == -1 || btype.SelectedIndex == -1 || rtype.SelectedIndex == 0 || btype.SelectedIndex == 0)
            {
                MessageBox.Show("You must select the Room type and Bed type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(occtxt.Text) || string.IsNullOrWhiteSpace(pricetxt.Text) || string.IsNullOrWhiteSpace(nametxt.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(pricetxt.Text, out _))
            {
                MessageBox.Show("Price must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO rdetails (rtypeid, btype_id, occupancy, price, rname) VALUES (@rtypeId, @btypeId, @occupancy, @price, @rname)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rtypeId", rtype.SelectedIndex);
                        command.Parameters.AddWithValue("@btypeId", btype.SelectedIndex);
                        command.Parameters.AddWithValue("@occupancy", occtxt.Text);
                        command.Parameters.AddWithValue("@price", Convert.ToDecimal(pricetxt.Text));
                        command.Parameters.AddWithValue("@rname", nametxt.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            roomsFormInstance.displayData();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
