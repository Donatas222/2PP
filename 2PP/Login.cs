using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    class Login : User
    {
        public bool CheckFieldsNotEmpty(string username, string pass)
        {
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");

            if (username != "" && pass != "")
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Negali būti tuščių laukų");
                return false;
            }
        }

        public bool CheckPassword(string username, string pass)
        {
            UserList ul = new UserList();
            User x = ul.GetUsers().Where(i => i.GetUsername() == username).FirstOrDefault();
            if ((ul.GetUsers().Where(i => i.GetUsername() == username).FirstOrDefault() != null) && (x.GetPassword() == pass))
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Klaidingi duomenys");
                return false;
            }
        }


    }
}
