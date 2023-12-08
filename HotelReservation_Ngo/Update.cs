using MySql.Data.MySqlClient;

namespace HotelReservation_Ngo
{
    public partial class Update : Form
    {
        private int selectedID;
        private reserve ReserveInstance;
        public Update(int id, reserve Reserv)
        {
            InitializeComponent();
            selectedID = id;
            ReserveInstance = Reserv;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;"))
                {
                    string query = $@"SELECT reserve.id, CONCAT(client.c_lname, ', ', client.c_fname) AS ClientName, 
                                rdetails.rname AS RoomName, reserve.chIn AS CheckInDate, 
                                reserve.chOut AS CheckOutDate, reserve.Confirmation
                          FROM reserve
                          INNER JOIN client ON reserve.clientID = client.cid
                          INNER JOIN rdetails ON reserve.roomID = rdetails.rid
                          WHERE reserve.id = {selectedID}";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                rtype.Text = reader["ClientName"].ToString();
                                btype.Text = reader["RoomName"].ToString();
                                dateTimePicker1.Value = Convert.ToDateTime(reader["CheckInDate"]);
                                dateTimePicker2.Value = Convert.ToDateTime(reader["CheckOutDate"]);
                                if (reader["Confirmation"].ToString() == "Yes" || reader["Confirmation"].ToString() == "yes")
                                {
                                    checkBox1.Checked = true;
                                }
                                else { checkBox1.Checked = false; }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            addButton.Visible = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            addButton.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            addButton.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;"))
                {
                    string query = $@"UPDATE reserve SET chIn = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}', 
                                                  chOut = '{dateTimePicker2.Value.ToString("yyyy-MM-dd")}', 
                                                  Confirmation = {(checkBox1.Checked ? "'Yes'" : "'No'")}
                              WHERE id = {selectedID}";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Details successfully updated");

                            // Close the form
                            this.Close();

                            ReserveInstance.DisplayReservations();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
