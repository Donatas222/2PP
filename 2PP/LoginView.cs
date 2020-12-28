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
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            if (login.CheckFieldsNotEmpty(usernameTextBox.Text, passwordTextBox.Text)
                && login.CheckPassword(usernameTextBox.Text, passwordTextBox.Text))
            {
                StartForm.currentUser = usernameTextBox.Text;
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    tb.Text = string.Empty;

                MessageBox.Show("Prisijungimas sekmingas");
                StartForm st = new StartForm();
                st.Show();
                st.RegistrationLabel.Visible = false;
                st.LoginLabel.Visible = false;
                st.LoggedInAsLabel.Visible = true;
                st.LogoutLabel.Visible = true;
                st.NameLabel.Visible = true;
                st.SurnameLabel.Visible = true;
                st.ProfileLabel.Visible = true;
                st.WishlistButton.Visible = true;
                st.CartButton.Visible = true;
                UserList ul = new UserList();
                User x = ul.GetUsers().Where(i => i.GetUsername() == StartForm.currentUser).FirstOrDefault();
                st.NameLabel.Text = x.GetName();
                st.SurnameLabel.Text = x.GetSurname();

                if (x.GetIsAdmin())
                    st.UserListButton.Visible = true;
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
