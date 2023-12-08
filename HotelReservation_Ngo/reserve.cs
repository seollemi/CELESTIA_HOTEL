using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelReservation_Ngo
{
    public partial class reserve : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");

        public reserve()
        {
            InitializeComponent();
            DisplayReservations();
        }
        private void reserve_Load(object sender, EventArgs e)
        {
            DisplayReservations();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addReserve addReserve = new addReserve(this);
            addReserve.Show();
        }

        public void DisplayReservations()
        {
            string query = @"SELECT reserve.id, CONCAT(client.c_lname, ', ', client.c_fname) AS ClientName, rdetails.rname AS RoomName, 
            reserve.chIn AS CheckInDate, reserve.chOut AS CheckOutDate, reserve.Confirmation
                             FROM reserve
                             INNER JOIN client ON reserve.clientID = client.cid
                             INNER JOIN rdetails ON reserve.roomID = rdetails.rid";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function still not available. Sorry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Check for null values before conversion
                int id;
                if (selectedRow.Cells["ID"].Value != null && int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out id))
                {
                    string clientname = selectedRow.Cells["ClientName"].Value?.ToString();
                    string rm = selectedRow.Cells["RoomName"].Value?.ToString();

                    DateTime chIn;
                    if (selectedRow.Cells["CheckInDate"].Value != null && DateTime.TryParse(selectedRow.Cells["CheckInDate"].Value.ToString(), out chIn))
                    {
                        DateTime chOut;
                        if (selectedRow.Cells["CheckOutDate"].Value != null && DateTime.TryParse(selectedRow.Cells["CheckOutDate"].Value.ToString(), out chOut))
                        {
                            TimeSpan duration = chOut - chIn;
                            int numberOfDays = duration.Days;

                            // Retrieve room details for the selected room name (rm)
                            string query = @"SELECT rid, rname, price
                                     FROM rdetails
                                     WHERE rname = @RoomName";

                            try
                            {
                                connection.Open();
                                MySqlCommand command = new MySqlCommand(query, connection);
                                command.Parameters.AddWithValue("@RoomName", rm);
                                MySqlDataReader reader = command.ExecuteReader();

                                if (reader.Read())
                                {
                                    int roomID = reader.GetInt32("rid");
                                    string roomName = reader.GetString("rname");
                                    decimal roomPrice = reader.GetDecimal("price");

                                    decimal total = roomPrice * numberOfDays;

                                    MessageBox.Show("Client name: " + clientname + "\nRoom name: " + rm +
                                                    "\nRoom number: " + roomID +
                                                    "\nRoom price: ₱" + roomPrice + // Formats price as currency
                                                    "\nNumber of days for the reservation: " + numberOfDays +
                                                    "\nTotal Price to pay: " + total, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Room details not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                if (connection.State == System.Data.ConnectionState.Open)
                                    connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid CheckOutDate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid CheckInDate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
