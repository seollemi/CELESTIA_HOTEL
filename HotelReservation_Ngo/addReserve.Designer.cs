namespace HotelReservation_Ngo
{
    partial class addReserve
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
            panel12 = new Panel();
            addButton = new Button();
            panel13 = new Panel();
            button1 = new Button();
            label6 = new Label();
            panel14 = new Panel();
            panel9 = new Panel();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            btype = new ComboBox();
            rtype = new ComboBox();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            splitContainer1 = new SplitContainer();
            panel16 = new Panel();
            checkBox1 = new CheckBox();
            panel15 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            panel11 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.Controls.Add(addButton);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(button1);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 338);
            panel12.Name = "panel12";
            panel12.Size = new Size(513, 40);
            panel12.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Right;
            addButton.Location = new Point(225, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(128, 40);
            addButton.TabIndex = 2;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Right;
            panel13.Location = new Point(353, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(32, 40);
            panel13.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(385, 0);
            button1.Name = "button1";
            button1.Size = new Size(128, 40);
            button1.TabIndex = 0;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 156);
            label6.Name = "label6";
            label6.Size = new Size(250, 23);
            label6.TabIndex = 8;
            label6.Text = "Confirmed Booking? (Check if Yes)";
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 140);
            panel14.Name = "panel14";
            panel14.Size = new Size(251, 16);
            panel14.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 61);
            panel9.Name = "panel9";
            panel9.Size = new Size(513, 16);
            panel9.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 117);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 6;
            label5.Text = "Check Out";
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 101);
            panel10.Name = "panel10";
            panel10.Size = new Size(251, 16);
            panel10.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 78);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 4;
            label4.Text = "Check In";
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 62);
            panel8.Name = "panel8";
            panel8.Size = new Size(251, 16);
            panel8.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 39);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Room Type";
            // 
            // btype
            // 
            btype.Dock = DockStyle.Top;
            btype.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btype.FormattingEnabled = true;
            btype.Items.AddRange(new object[] { "Select Room Type" });
            btype.Location = new Point(0, 38);
            btype.Name = "btype";
            btype.Size = new Size(513, 23);
            btype.TabIndex = 3;
            btype.Text = "Select Room Type";
            // 
            // rtype
            // 
            rtype.Dock = DockStyle.Top;
            rtype.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtype.FormattingEnabled = true;
            rtype.Items.AddRange(new object[] { "Select Client Name" });
            rtype.Location = new Point(0, 0);
            rtype.Name = "rtype";
            rtype.Size = new Size(513, 23);
            rtype.TabIndex = 1;
            rtype.Text = "Select Client Name";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 23);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 16);
            panel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 0;
            label2.Text = "Client Name";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(513, 15);
            panel7.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(16, 56);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(panel14);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(panel10);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(panel8);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(panel6);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel16);
            splitContainer1.Panel2.Controls.Add(panel15);
            splitContainer1.Panel2.Controls.Add(dateTimePicker2);
            splitContainer1.Panel2.Controls.Add(panel11);
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Controls.Add(panel12);
            splitContainer1.Panel2.Controls.Add(panel9);
            splitContainer1.Panel2.Controls.Add(btype);
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(rtype);
            splitContainer1.Size = new Size(768, 378);
            splitContainer1.SplitterDistance = 251;
            splitContainer1.TabIndex = 13;
            // 
            // panel16
            // 
            panel16.Controls.Add(checkBox1);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 151);
            panel16.Name = "panel16";
            panel16.Size = new Size(513, 24);
            panel16.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Left;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 24);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 135);
            panel15.Name = "panel15";
            panel15.Size = new Size(513, 16);
            panel15.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Top;
            dateTimePicker2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(0, 114);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(513, 21);
            dateTimePicker2.TabIndex = 11;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 98);
            panel11.Name = "panel11";
            panel11.Size = new Size(513, 16);
            panel11.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Top;
            dateTimePicker1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(0, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(513, 21);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(16, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(768, 16);
            panel5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 11;
            label1.Text = "Add Reservation";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(784, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 418);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 418);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 16);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 16);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // addReserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel5);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addReserve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addReserve";
            Load += addReserve_Load;
            panel12.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel12;
        private Button addButton;
        private Panel panel13;
        private Button button1;
        private Label label6;
        private Panel panel14;
        private Panel panel9;
        private Label label5;
        private Panel panel10;
        private Label label4;
        private Panel panel8;
        private Label label3;
        private ComboBox btype;
        private ComboBox rtype;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private SplitContainer splitContainer1;
        private Panel panel5;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel16;
        private CheckBox checkBox1;
        private Panel panel15;
        private DateTimePicker dateTimePicker2;
        private Panel panel11;
        private DateTimePicker dateTimePicker1;
    }
}