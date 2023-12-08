using MySql.Data.MySqlClient;
using System.Data;

namespace HotelReservation_Ngo
{
    public partial class addReserve : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");
        private reserve ReserveInstance;
        public addReserve(reserve Reserv)
        {
            InitializeComponent();
            ReserveInstance = Reserv;
        }
        private void PopulateRType()
        {
            string query = "SELECT CONCAT(c_lname, ', ', c_fname) AS concatenated_name FROM `client`";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string concatenatedName = reader["concatenated_name"].ToString();
                            rtype.Items.Add(concatenatedName); // Assuming 'rtype' is a ComboBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void PopulateBType()
        {
            string query = "SELECT rname FROM `rdetails`";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string rname = reader["rname"].ToString();
                            btype.Items.Add(rname); // Assuming 'btype' is a ComboBox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void addReserve_Load(object sender, EventArgs e)
        {
            PopulateRType();
            PopulateBType();
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private int ClientID(string concatenatedName)
        {
            string[] names = concatenatedName.Split(new string[] { ", " }, StringSplitOptions.None);

            if (names.Length == 2)
            {
                string c_lname = names[0];
                string c_fname = names[1];

                string query = "SELECT cid FROM `client` WHERE c_lname = @lname AND c_fname = @fname";

                using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=celestia;"))
                {
                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@lname", c_lname);
                    command.Parameters.AddWithValue("@fname", c_fname);

                    try
                    {
                        con.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return -1;
        }

        private int RoomID(string selectedValue)
        {
            string query = "SELECT rid FROM `rdetails` WHERE rname = @selectedValue";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@selectedValue", selectedValue);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string concatenatedName = rtype.SelectedItem.ToString();
            int clientID = ClientID(concatenatedName);

            string selectedValue = btype.SelectedItem.ToString();
            int roomID = RoomID(selectedValue);

            DateTime chIn = dateTimePicker1.Value;
            DateTime chOut = dateTimePicker2.Value;

            string confirmation = checkBox1.Checked ? "yes" : "no";

            string query = "INSERT INTO reserve (clientID, roomID, chIn, chOut, Confirmation) VALUES (@clientID, @roomID, @chIn, @chOut, @confirmation)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@clientID", clientID);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@chIn", chIn);
                    command.Parameters.AddWithValue("@chOut", chOut);
                    command.Parameters.AddWithValue("@confirmation", confirmation);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        ReserveInstance.DisplayReservations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
