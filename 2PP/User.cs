using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class User : Person
    {
        protected int userID;
        protected string username;
        protected string password;
        protected bool isAdmin;

        #region Constructors
        public User()
        {

        }

        public User(int userID, string name, string surname, DateTime birthDate, string userName, string password)
        {
            this.userID = userID;
            this.name = name;
            this.surname = surname;
            this.birthdate = birthDate;
            this.username = userName;
            this.password = password;
            isAdmin = false;
        }

        public User(int userID, string name, string surname, DateTime birthDate, string userName, string password, bool isAdmin)
        {
            this.userID = userID;
            this.name = name;
            this.surname = surname;
            this.birthdate = birthDate;
            this.username = userName;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public User(string name, string surname, DateTime birthDate, string userName, string password, bool isAdmin)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthDate;
            this.username = userName;
            this.password = password;
            this.isAdmin = isAdmin;
        }
        #endregion

        public int GetUserID()
        {
            return userID;
        }

        public void SetUserID(int value)
        {
            userID = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string value)
        {
            surname = value;
        }

        public DateTime GetBirthdate()
        {
            return birthdate.Date;
        }

        public void SetBirthdate(DateTime value)
        {
            birthdate = value.Date;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string value)
        {
            username = value;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }

        public bool GetIsAdmin()
        {
            return isAdmin;
        }

        public void SetIsAdmin(bool value)
        {
            isAdmin = value;
        }

        public void ChangePassword(string oldPass, string newPass, string repeatNewPass)
        {
            if (oldPass == password && newPass == repeatNewPass)
            {
                password = newPass;
            }
            else
                System.Windows.Forms.MessageBox.Show("Duomenys suvesti neteisingai.");
        }
    }
}
