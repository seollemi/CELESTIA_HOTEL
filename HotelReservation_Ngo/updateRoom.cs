using MySql.Data.MySqlClient;

namespace HotelReservation_Ngo
{
    public partial class updateRoom : Form
    {
        private rooms roomsFormInstance;
        private int roomId;
        private string ogValue;
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");
        public updateRoom(int rid, rooms roomsForm)
        {
            InitializeComponent();
            roomsFormInstance = roomsForm;
            roomId = rid;
        }

        private void updateRoom_Load(object sender, EventArgs e)
        {
            string query = "SELECT rdetails.rid, rdetails.rname, rdetails.occupancy, " +
                "rdetails.price, (SELECT roomtype.rtype_name FROM roomtype WHERE roomtype.rtypeid = rdetails.rtypeid) AS rtype_name, " +
                "(SELECT bedtype.bedtype_name FROM bedtype WHERE bedtype.bedtype_id = rdetails.btype_id) " +
                "AS bedtype_name FROM rdetails WHERE rdetails.rid = @roomId";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@roomId", roomId); // 'roomId' received from the previous form

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Assuming these are TextBox controls
                    rtype.Text = reader["rtype_name"].ToString();
                    btype.Text = reader["bedtype_name"].ToString();
                    occtxt.Text = reader["occupancy"].ToString();
                    pricetxt.Text = reader["price"].ToString();
                    nametxt.Text = reader["rname"].ToString();

                    ogValue = pricetxt.Text;
                }

                reader.Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (pricetxt.Text == ogValue)
            {
                MessageBox.Show("No changes have been made to the price.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "UPDATE rdetails SET price = @newPrice WHERE rid = @roomId"; // Assuming 'rid' is the primary key

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPrice", pricetxt.Text);
                command.Parameters.AddWithValue("@roomId", roomId); // 'roomId' received from the previous form

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Price updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
                roomsFormInstance.displayData();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
