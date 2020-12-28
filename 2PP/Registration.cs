using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class Registration : User
    {
        public bool CheckAge(DateTime date)
        {
            if ((int)((DateTime.Now - date).TotalDays / 365) >= 14)
                return true;
            else
                System.Windows.Forms.MessageBox.Show("Atsiprašome, jūs per jaunas");
            return false;
        }

        public bool CheckPassword(string pass1, string pass2)
        {
            if (pass1 == pass2)
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Slaptažodis pakartotas neteisingai");
                return false;
            }
        }

        public bool CheckFieldsNotEmpty(string name, string surname, string username, string pass, string pass2)
        {
            name = name.Replace(" ", "");
            surname = surname.Replace(" ", "");
            username = username.Replace(" ", "");
            pass = pass.Replace(" ", "");
            pass2 = pass2.Replace(" ", "");


            if (name != "" && surname != "" && username != "" && pass != "" && pass2 != "")
            {
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Negali būti tuščių laukų");
                return false;
            }
        }

        public bool CheckUsernameUnique(string un)
        {
            UserList ul = new UserList();
            if (ul.GetUsers().Where(i => i.GetUsername() == un).FirstOrDefault() == null)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Toks naudotojo vardas jau užimtas");
                return false;
            }
        }

        public bool CheckDateFormat(string date)
        {
            DateTime d;
            bool validation = DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (validation == true)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Datos formatas netinkamas");
                return false;
            }
        }
    }
}
