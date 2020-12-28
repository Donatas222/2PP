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
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationView_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();

            if (registration.CheckFieldsNotEmpty(nameTextBox.Text, surnameTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, passwordConfirmTextBox.Text)
                && registration.CheckUsernameUnique(usernameTextBox.Text)
                && registration.CheckDateFormat(birthDateTextBox.Text)
                && registration.CheckAge(DateTime.Parse(birthDateTextBox.Text))
                && registration.CheckPassword(passwordTextBox.Text, passwordConfirmTextBox.Text))
            {
                UserList u = new UserList();
                u.AddUser(nameTextBox.Text, surnameTextBox.Text, DateTime.Parse(birthDateTextBox.Text).ToString(), usernameTextBox.Text, passwordTextBox.Text);

                StartForm.currentUser = usernameTextBox.Text;

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                    tb.Text = string.Empty;

                MessageBox.Show("Registracija sekminga");
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
    }
}
