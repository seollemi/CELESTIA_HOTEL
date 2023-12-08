namespace HotelReservation_Ngo
{
    partial class index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnLogout = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            viewPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 58);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(24, 58);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btn4);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 0, 16);
            panel3.Size = new Size(293, 522);
            panel3.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Image = Properties.Resources.logout__2_;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 458);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(24, 0, 0, 0);
            btnLogout.Size = new Size(293, 48);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "   Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Top;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Image = Properties.Resources.rating;
            btn4.ImageAlign = ContentAlignment.MiddleLeft;
            btn4.Location = new Point(0, 144);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Padding = new Padding(24, 0, 0, 0);
            btn4.Size = new Size(293, 48);
            btn4.TabIndex = 3;
            btn4.Text = "   Manage Clients";
            btn4.TextAlign = ContentAlignment.MiddleLeft;
            btn4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Top;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Image = Properties.Resources.calendar;
            btn3.ImageAlign = ContentAlignment.MiddleLeft;
            btn3.Location = new Point(0, 96);
            btn3.Margin = new Padding(0);
            btn3.Name = "btn3";
            btn3.Padding = new Padding(24, 0, 0, 0);
            btn3.Size = new Size(293, 48);
            btn3.TabIndex = 2;
            btn3.Text = "   Manage Reservation";
            btn3.TextAlign = ContentAlignment.MiddleLeft;
            btn3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Top;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Image = Properties.Resources.double_bed;
            btn2.ImageAlign = ContentAlignment.MiddleLeft;
            btn2.Location = new Point(0, 48);
            btn2.Margin = new Padding(0);
            btn2.Name = "btn2";
            btn2.Padding = new Padding(24, 0, 0, 0);
            btn2.Size = new Size(293, 48);
            btn2.TabIndex = 1;
            btn2.Text = "   Manage Rooms";
            btn2.TextAlign = ContentAlignment.MiddleLeft;
            btn2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Top;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Image = Properties.Resources.dashboard;
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(0, 0);
            btn1.Margin = new Padding(0);
            btn1.Name = "btn1";
            btn1.Padding = new Padding(24, 0, 0, 0);
            btn1.Size = new Size(293, 48);
            btn1.TabIndex = 0;
            btn1.Text = "   Dashboard";
            btn1.TextAlign = ContentAlignment.MiddleLeft;
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // viewPanel
            // 
            viewPanel.AutoSize = true;
            viewPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewPanel.Dock = DockStyle.Fill;
            viewPanel.Location = new Point(293, 58);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new Size(803, 522);
            viewPanel.TabIndex = 2;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1096, 580);
            Controls.Add(viewPanel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            Load += index_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Button btn1;
        private Button btnLogout;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Panel viewPanel;
    }
}