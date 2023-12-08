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
    public partial class rooms : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=celestia;");

        public rooms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addRoom addRoom = new addRoom(this);
            addRoom.Show();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            try
            {
                connection.Open();

                string query = "SELECT rdetails.rid as ID, rdetails.rname as Name, rdetails.occupancy as Occupancy, rdetails.price as Price, " +
                    "(SELECT roomtype.rtype_name FROM roomtype WHERE roomtype.rtypeid = rdetails.rtypeid) AS RoomType," +
                    "(SELECT bedtype.bedtype_name FROM bedtype WHERE bedtype.bedtype_id = rdetails.btype_id) AS BedType " +
                    "FROM rdetails";


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

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Extract data from the selected row
                int rid = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Assuming "rid" is the name of the column for rdetails.rid

                // Pass 'rid' to updateroom form
                updateRoom updateRoomForm = new updateRoom(rid, this);
                updateRoomForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
