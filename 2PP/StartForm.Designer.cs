
namespace _2PP
{
    partial class StartForm
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
            this.TopCenterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainFieldPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RegistrationLabel = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.LinkLabel();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UserListButton = new System.Windows.Forms.Button();
            this.ProfileLabel = new System.Windows.Forms.LinkLabel();
            this.WishlistButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopCenterPanel
            // 
            this.TopCenterPanel.Location = new System.Drawing.Point(0, 61);
            this.TopCenterPanel.Name = "TopCenterPanel";
            this.TopCenterPanel.Size = new System.Drawing.Size(799, 28);
            this.TopCenterPanel.TabIndex = 2;
            // 
            // MainFieldPanel
            // 
            this.MainFieldPanel.AutoScroll = true;
            this.MainFieldPanel.Location = new System.Drawing.Point(0, 88);
            this.MainFieldPanel.Name = "MainFieldPanel";
            this.MainFieldPanel.Size = new System.Drawing.Size(800, 350);
            this.MainFieldPanel.TabIndex = 3;
            this.MainFieldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleLabel.Location = new System.Drawing.Point(4, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(236, 25);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Maistas Augintiniams";
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabel.Location = new System.Drawing.Point(612, 40);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(99, 18);
            this.RegistrationLabel.TabIndex = 6;
            this.RegistrationLabel.TabStop = true;
            this.RegistrationLabel.Text = "Registruotis";
            this.RegistrationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLabel_LinkClicked);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(717, 40);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(82, 18);
            this.LoginLabel.TabIndex = 7;
            this.LoginLabel.TabStop = true;
            this.LoginLabel.Text = "Prisijungti";
            this.LoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLabel_LinkClicked);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAsLabel.Location = new System.Drawing.Point(496, 3);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(97, 15);
            this.LoggedInAsLabel.TabIndex = 8;
            this.LoggedInAsLabel.Text = "Prisijunges kaip:";
            this.LoggedInAsLabel.Visible = false;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.Location = new System.Drawing.Point(723, 2);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(76, 18);
            this.LogoutLabel.TabIndex = 9;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Atsijungti";
            this.LogoutLabel.Visible = false;
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(599, 2);
            this.NameLabel.MaximumSize = new System.Drawing.Size(120, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 15);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "name";
            this.NameLabel.Visible = false;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(599, 21);
            this.SurnameLabel.MaximumSize = new System.Drawing.Size(120, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(63, 15);
            this.SurnameLabel.TabIndex = 11;
            this.SurnameLabel.Text = "surname";
            this.SurnameLabel.Visible = false;
            // 
            // UserListButton
            // 
            this.UserListButton.Location = new System.Drawing.Point(0, 0);
            this.UserListButton.Name = "UserListButton";
            this.UserListButton.Size = new System.Drawing.Size(110, 23);
            this.UserListButton.TabIndex = 12;
            this.UserListButton.Text = "Naudotojų sąrašas";
            this.UserListButton.UseVisualStyleBackColor = true;
            this.UserListButton.Visible = false;
            this.UserListButton.Click += new System.EventHandler(this.UserListButton_Click);
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.Location = new System.Drawing.Point(341, 3);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(98, 16);
            this.ProfileLabel.TabIndex = 13;
            this.ProfileLabel.TabStop = true;
            this.ProfileLabel.Text = "Mano Profilis";
            this.ProfileLabel.Visible = false;
            this.ProfileLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ProfileLabel_LinkClicked);
            // 
            // WishlistButton
            // 
            this.WishlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WishlistButton.Location = new System.Drawing.Point(258, 0);
            this.WishlistButton.Name = "WishlistButton";
            this.WishlistButton.Size = new System.Drawing.Size(77, 26);
            this.WishlistButton.TabIndex = 14;
            this.WishlistButton.Text = "♥ sąrašas";
            this.WishlistButton.UseVisualStyleBackColor = true;
            this.WishlistButton.Visible = false;
            this.WishlistButton.Click += new System.EventHandler(this.WishlistButton_Click);
            // 
            // CartButton
            // 
            this.CartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartButton.Location = new System.Drawing.Point(258, 32);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(171, 26);
            this.CartButton.TabIndex = 15;
            this.CartButton.Text = "Prekių Krepšelis";
            this.CartButton.UseVisualStyleBackColor = true;
            this.CartButton.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.WishlistButton);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.UserListButton);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainFieldPanel);
            this.Controls.Add(this.TopCenterPanel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Shop";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel TopCenterPanel;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.FlowLayoutPanel MainFieldPanel;
        public System.Windows.Forms.Button UserListButton;
        public System.Windows.Forms.Label LoggedInAsLabel;
        public System.Windows.Forms.LinkLabel LogoutLabel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.Label SurnameLabel;
        public System.Windows.Forms.LinkLabel LoginLabel;
        public System.Windows.Forms.LinkLabel RegistrationLabel;
        public System.Windows.Forms.LinkLabel ProfileLabel;
        public System.Windows.Forms.Button WishlistButton;
        public System.Windows.Forms.Button CartButton;
    }
}

