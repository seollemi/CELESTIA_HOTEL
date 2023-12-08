using MySqlX.XDevAPI;
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
    public partial class index : Form
    {
        private login loginForm;
        private dashboard dashboardForm;
        private rooms roomsForm;
        private reserve reserveForm;
        private clients clientForm;


        public index(login loginForm)
        {
            InitializeComponent();
            setcolor();
            this.loginForm = loginForm;

            dashboardForm = new dashboard();
            roomsForm = new rooms();
            reserveForm = new reserve();
            clientForm = new clients();

            ShowFormInPanel(dashboardForm);
        }

        private void setcolor()
        {
            panel1.BackColor = System.Drawing.ColorTranslator.FromHtml("#051927");
            panel3.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn1.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn2.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn3.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn4.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btn4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btnLogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#07263A");
            btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D4D4D4");
            btn1.FlatAppearance.BorderSize = 0;
            btn2.FlatAppearance.BorderSize = 0;
            btn3.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.BorderSize = 0;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (loginForm.NewLogin())
            {
                this.Hide();
                login newLoginForm = new login();
                newLoginForm.Show();
            }
            else
            {
                this.Hide();
                loginForm.Show();
            }
        }

        private void ShowFormInPanel(Form form)
        {
            viewPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            viewPanel.Controls.Add(form);
            form.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(dashboardForm);
            btn1.Font = new Font(btn1.Font, FontStyle.Bold);
            btn2.Font = new Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new Font(btn1.Font, FontStyle.Regular);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(roomsForm);
            btn1.Font = new Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new Font(btn1.Font, FontStyle.Bold);
            btn3.Font = new Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new Font(btn1.Font, FontStyle.Regular);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            reserveForm.DisplayReservations();
            ShowFormInPanel(reserveForm);
            btn1.Font = new Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new Font(btn1.Font, FontStyle.Bold);
            btn4.Font = new Font(btn1.Font, FontStyle.Regular);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(clientForm);
            btn1.Font = new Font(btn1.Font, FontStyle.Regular);
            btn2.Font = new Font(btn1.Font, FontStyle.Regular);
            btn3.Font = new Font(btn1.Font, FontStyle.Regular);
            btn4.Font = new Font(btn1.Font, FontStyle.Bold);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void index_Load(object sender, EventArgs e)
        {

        }
    }
}
