namespace HotelReservation_Ngo
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            splitContainer1 = new SplitContainer();
            toggle1 = new CheckBox();
            passtxt = new TextBox();
            label2 = new Label();
            usertxt = new TextBox();
            Username = new Label();
            extbtn = new Label();
            loginbtn = new Button();
            toggle = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlDarkDark;
            splitContainer1.Panel1.BackgroundImage = (Image)resources.GetObject("splitContainer1.Panel1.BackgroundImage");
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Zoom;
            splitContainer1.Panel1.ForeColor = Color.Coral;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel2.Controls.Add(toggle1);
            splitContainer1.Panel2.Controls.Add(passtxt);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(usertxt);
            splitContainer1.Panel2.Controls.Add(Username);
            splitContainer1.Panel2.Controls.Add(extbtn);
            splitContainer1.Panel2.Controls.Add(loginbtn);
            splitContainer1.Panel2.Controls.Add(toggle);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 259;
            splitContainer1.TabIndex = 0;
            // 
            // toggle1
            // 
            toggle1.Appearance = Appearance.Button;
            toggle1.AutoSize = true;
            toggle1.BackgroundImageLayout = ImageLayout.None;
            toggle1.CheckAlign = ContentAlignment.MiddleCenter;
            toggle1.FlatStyle = FlatStyle.Flat;
            toggle1.Image = Properties.Resources.view;
            toggle1.Location = new Point(377, 216);
            toggle1.Name = "toggle1";
            toggle1.Size = new Size(22, 22);
            toggle1.TabIndex = 7;
            toggle1.UseVisualStyleBackColor = true;
            toggle1.Visible = false;
            toggle1.CheckedChanged += toggle1_CheckedChanged;
            toggle1.Click += toggle1_Click;
            // 
            // passtxt
            // 
            passtxt.BackColor = Color.White;
            passtxt.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passtxt.HideSelection = false;
            passtxt.Location = new Point(118, 212);
            passtxt.Margin = new Padding(0);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(281, 29);
            passtxt.TabIndex = 1;
            passtxt.Text = "Password";
            passtxt.Click += passtxt_Click;
            passtxt.TextChanged += passtxt_TextChanged;
            passtxt.Leave += passtxt_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 189);
            label2.Margin = new Padding(0, 16, 0, 8);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // usertxt
            // 
            usertxt.BackColor = Color.White;
            usertxt.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usertxt.Location = new Point(119, 142);
            usertxt.Margin = new Padding(128, 8, 128, 32);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(281, 29);
            usertxt.TabIndex = 1;
            usertxt.Text = "Username";
            usertxt.Click += usertxt_Click;
            usertxt.Leave += usertxt_Leave;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Username.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(118, 119);
            Username.Margin = new Padding(0);
            Username.Name = "Username";
            Username.Size = new Size(59, 15);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // extbtn
            // 
            extbtn.AutoSize = true;
            extbtn.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            extbtn.Location = new Point(506, 16);
            extbtn.Margin = new Padding(0, 16, 8, 0);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(14, 15);
            extbtn.TabIndex = 6;
            extbtn.Text = "X";
            extbtn.Click += extbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DarkSlateGray;
            loginbtn.FlatStyle = FlatStyle.Popup;
            loginbtn.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.DarkGoldenrod;
            loginbtn.Location = new Point(118, 295);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(281, 47);
            loginbtn.TabIndex = 5;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // toggle
            // 
            toggle.AutoSize = true;
            toggle.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toggle.Location = new Point(118, 257);
            toggle.Margin = new Padding(0, 16, 0, 16);
            toggle.Name = "toggle";
            toggle.Size = new Size(101, 19);
            toggle.TabIndex = 4;
            toggle.Text = "Remember me";
            toggle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0, 16, 0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 64, 0, 24);
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(537, 119);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox usertxt;
        private TextBox passtxt;
        private Label label2;
        private Label Username;
        private Button loginbtn;
        private CheckBox toggle;
        private Label extbtn;
        private CheckBox toggle1;
    }
}