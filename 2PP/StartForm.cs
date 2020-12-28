using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2PP
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            RegistrationLabel.Cursor = Cursors.Hand;
            UserListButton.Cursor = Cursors.Hand;
            LoginLabel.Cursor = Cursors.Hand;
            LogoutLabel.Cursor = Cursors.Hand;
            ItemList itemList = new ItemList();
            List<Category> categories = itemList.GetCategories();

            foreach (Category c in categories)
            {
                Button categoryButton = new Button();
                categoryButton.Text = c.Name;
                categoryButton.Tag = c;
                categoryButton.Width = 192;
                categoryButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                categoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
                categoryButton.Click += CategoryButton_Click;
                TopCenterPanel.Controls.Add(categoryButton);
            }
        }

        public static string currentUser;

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Category category = (Category)button.Tag;

            MainFieldPanel.Controls.Clear();


            UserList ul = new UserList();
            User x = ul.GetUsers().Where(i => i.GetUsername() == currentUser).FirstOrDefault();

            if (currentUser != null && x.GetIsAdmin() == true)
            {
                foreach (Item item in category.Items)
                {
                    ItemAdminView iaw = new ItemAdminView(item);
                    MainFieldPanel.Controls.Add(iaw);
                }
            }
            else if (currentUser != null)
            {
                foreach (Item item in category.Items)
                {
                    ItemRegisteredView irw = new ItemRegisteredView(item);
                    MainFieldPanel.Controls.Add(irw);
                }
            }
            else
            {
                foreach (Item item in category.Items)
                {
                    ItemPublicView ipv = new ItemPublicView(item);
                    MainFieldPanel.Controls.Add(ipv);
                }
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void RegistrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            RegistrationView rg = new RegistrationView();
            MainFieldPanel.Controls.Add(rg);
        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            LoginView lg = new LoginView();
            MainFieldPanel.Controls.Add(lg);
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            currentUser = null;
        }

        private void UserListButton_Click(object sender, EventArgs e)
        {
            MainFieldPanel.Controls.Clear();

            UserList ul = new UserList();
            foreach (User x in ul.GetUsers())
            {
                UserListAdminView u = new UserListAdminView();
                u.UserIDLabel.Text = x.GetUserID().ToString();
                u.UsernameLabel.Text = x.GetUsername();
                u.NameLabel.Text = x.GetName();
                u.SurnameLabel.Text = x.GetSurname();
                u.BirthdateLabel.Text = x.GetBirthdate().ToString();
                u.IsAdminLabel.Text = x.GetIsAdmin().ToString();
                MainFieldPanel.Controls.Add(u);
            }
            
        }

        private void ProfileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainFieldPanel.Controls.Clear();
            ProfileView pf = new ProfileView();
            MainFieldPanel.Controls.Add(pf);
        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ši funkcija kolkas neįgyvendinta.");
        }
    }
}
