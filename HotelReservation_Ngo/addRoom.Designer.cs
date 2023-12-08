namespace HotelReservation_Ngo
{
    partial class addRoom
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            panel14 = new Panel();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            nametxt = new TextBox();
            panel15 = new Panel();
            panel12 = new Panel();
            addButton = new Button();
            panel13 = new Panel();
            button1 = new Button();
            pricetxt = new TextBox();
            panel11 = new Panel();
            occtxt = new TextBox();
            panel9 = new Panel();
            btype = new ComboBox();
            panel7 = new Panel();
            rtype = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 16);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 16);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 418);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(784, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(16, 418);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 4;
            label1.Text = "Add Room";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(16, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(768, 16);
            panel5.TabIndex = 5;
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
            splitContainer1.Panel2.Controls.Add(nametxt);
            splitContainer1.Panel2.Controls.Add(panel15);
            splitContainer1.Panel2.Controls.Add(panel12);
            splitContainer1.Panel2.Controls.Add(pricetxt);
            splitContainer1.Panel2.Controls.Add(panel11);
            splitContainer1.Panel2.Controls.Add(occtxt);
            splitContainer1.Panel2.Controls.Add(panel9);
            splitContainer1.Panel2.Controls.Add(btype);
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(rtype);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(768, 378);
            splitContainer1.SplitterDistance = 251;
            splitContainer1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 156);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 8;
            label6.Text = "Room Name";
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 140);
            panel14.Name = "panel14";
            panel14.Size = new Size(251, 16);
            panel14.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 117);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 6;
            label5.Text = "Price per night";
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
            label4.Size = new Size(89, 23);
            label4.TabIndex = 4;
            label4.Text = "Occupancy";
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
            label3.Size = new Size(76, 23);
            label3.TabIndex = 2;
            label3.Text = "Bed Type";
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
            label2.Size = new Size(90, 23);
            label2.TabIndex = 0;
            label2.Text = "Room Type";
            // 
            // nametxt
            // 
            nametxt.Dock = DockStyle.Top;
            nametxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nametxt.Location = new Point(0, 151);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(513, 21);
            nametxt.TabIndex = 10;
            // 
            // panel15
            // 
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 135);
            panel15.Name = "panel15";
            panel15.Size = new Size(513, 16);
            panel15.TabIndex = 9;
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
            // pricetxt
            // 
            pricetxt.Dock = DockStyle.Top;
            pricetxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pricetxt.Location = new Point(0, 114);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(513, 21);
            pricetxt.TabIndex = 7;
            // 
            // panel11
            // 
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 98);
            panel11.Name = "panel11";
            panel11.Size = new Size(513, 16);
            panel11.TabIndex = 6;
            // 
            // occtxt
            // 
            occtxt.Dock = DockStyle.Top;
            occtxt.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            occtxt.Location = new Point(0, 77);
            occtxt.Name = "occtxt";
            occtxt.Size = new Size(513, 21);
            occtxt.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 61);
            panel9.Name = "panel9";
            panel9.Size = new Size(513, 16);
            panel9.TabIndex = 4;
            // 
            // btype
            // 
            btype.Dock = DockStyle.Top;
            btype.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btype.FormattingEnabled = true;
            btype.Items.AddRange(new object[] { "Select Bed Type", "1 Single", "1 Queen", "1 King", "1 King, 1 Twin", "1 Queen, 1 Twin", "King Luxurious Bedding" });
            btype.Location = new Point(0, 38);
            btype.Name = "btype";
            btype.Size = new Size(513, 23);
            btype.TabIndex = 3;
            btype.Text = "Select Bed Type";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 23);
            panel7.Name = "panel7";
            panel7.Size = new Size(513, 15);
            panel7.TabIndex = 2;
            // 
            // rtype
            // 
            rtype.Dock = DockStyle.Top;
            rtype.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtype.FormattingEnabled = true;
            rtype.Items.AddRange(new object[] { "Select Room Type", "Standard", "Suite", "Deluxe", "Family Room", "Penthouse" });
            rtype.Location = new Point(0, 0);
            rtype.Name = "rtype";
            rtype.Size = new Size(513, 23);
            rtype.TabIndex = 1;
            rtype.Text = "Select Room Type";
            // 
            // addRoom
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
            Name = "addRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Room";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private SplitContainer splitContainer1;
        private Label label3;
        private Panel panel6;
        private Label label2;
        private ComboBox btype;
        private Panel panel7;
        private ComboBox rtype;
        private Label label5;
        private Panel panel10;
        private Label label4;
        private Panel panel8;
        private Panel panel12;
        private Button addButton;
        private Panel panel13;
        private Button button1;
        private TextBox pricetxt;
        private Panel panel11;
        private TextBox occtxt;
        private Panel panel9;
        private Label label6;
        private Panel panel14;
        private TextBox nametxt;
        private Panel panel15;
    }
}