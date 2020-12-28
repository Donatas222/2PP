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
    public partial class ProfileView : UserControl
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void ProfileView_Load(object sender, EventArgs e)
        {
            UserList ul = new UserList();
            User x = ul.GetUsers().Where(i => i.GetUsername() == StartForm.currentUser).FirstOrDefault();
            UsernameLabel.Text = x.GetUsername();
            NameLabel.Text = x.GetName();
            SurnameLabel.Text = x.GetSurname();
            BirthdateLabel.Text = x.GetBirthdate().ToString();
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            ChangePassButton.Visible = false;
            ChangePictureButton.Visible = false;
            CurrentPassLabel.Visible = true;
            NewPassLabel.Visible = true;
            NewPassConfirmLabel.Visible = true;
            CurrentPassTextBox.Visible = true;
            NewPassTextBox.Visible = true;
            NewPassConfirmTextBox.Visible = true;
            CancelButton.Visible = true;
            ConfirmButton.Visible = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CurrentPassTextBox.Text = "";
            NewPassTextBox.Text = "";
            NewPassConfirmTextBox.Text = "";
            CurrentPassLabel.Visible = false;
            NewPassLabel.Visible = false;
            NewPassConfirmLabel.Visible = false;
            CurrentPassTextBox.Visible = false;
            NewPassTextBox.Visible = false;
            NewPassConfirmTextBox.Visible = false;
            CancelButton.Visible = false;
            ConfirmButton.Visible = false;
            ChangePassButton.Visible = true;
            ChangePictureButton.Visible = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CheckFieldsNotEmpty(CurrentPassTextBox.Text, NewPassTextBox.Text, NewPassConfirmTextBox.Text))
            {
                UserList ul = new UserList();
                User x = ul.GetUsers().Where(i => i.GetUsername() == StartForm.currentUser).FirstOrDefault();
                if (x.GetPassword() == CurrentPassTextBox.Text && NewPassTextBox.Text == NewPassConfirmTextBox.Text)
                {
                    UserList us = new UserList();
                    us.ChangePassword(StartForm.currentUser, NewPassTextBox.Text);

                    CurrentPassTextBox.Text = "";
                    NewPassTextBox.Text = "";
                    NewPassConfirmTextBox.Text = "";
                    CurrentPassLabel.Visible = false;
                    NewPassLabel.Visible = false;
                    NewPassConfirmLabel.Visible = false;
                    CurrentPassTextBox.Visible = false;
                    NewPassTextBox.Visible = false;
                    NewPassConfirmTextBox.Visible = false;
                    CancelButton.Visible = false;
                    ConfirmButton.Visible = false;
                    ChangePassButton.Visible = true;
                    ChangePictureButton.Visible = true;
                }
                else
                    MessageBox.Show("Duomenys suvesti klaidingai.");

            }
        }

        private bool CheckFieldsNotEmpty(string oldpass, string newpass, string cfpass)
        {
            oldpass = oldpass.Replace(" ", "");
            newpass = newpass.Replace(" ", "");
            cfpass = cfpass.Replace(" ", "");


            if (oldpass != "" && newpass != "" && cfpass != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Negali būti tuščių laukų");
                return false;
            }
        }

        private void ChangePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.png;*.jpg;*.jpeg;.*.gif;)|*.png;*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
