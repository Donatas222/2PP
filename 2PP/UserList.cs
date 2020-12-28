using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace _2PP
{
    public class UserList
    {
        private static List<User> userList;
        private SQLiteConnection cn;

        public UserList()
        {
                cn = new SQLiteConnection(@"URI=file:C:\sqlite\EShopDB.db");
        }

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            try
            {
                string sql = "SELECT userID, name, surname, birthdate, username, password, isAdmin FROM users";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int userID = int.Parse(rd["userID"].ToString());
                    string name = rd["name"].ToString();
                    string surname = rd["surname"].ToString();
                    DateTime birthdate = DateTime.Parse(rd["birthdate"].ToString());
                    string username = rd["username"].ToString();
                    string password = rd["password"].ToString();
                    bool isAdmin = bool.Parse(rd["isAdmin"].ToString());
                    userList.Add(new User(userID, name, surname, birthdate, username, password, isAdmin));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return userList;
        }

        public void Register(User user)
        {
            userList.Add(user);
        }

        public User Login(string username, string pass)
        {
            foreach (User user in userList)
                if (user.GetUsername().Equals(username) && user.GetPassword().Equals(pass))
                    return user;
            throw new Exception("Blogai ivesti duomenys");
        }

        public void ChangePassword(string name, string newpass)
        {
            try
            {
                string sql = "UPDATE users SET password=@newpass WHERE username=@username";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@newpass", newpass);
                cmd.Parameters.AddWithValue("@username", name);
                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();
                cmd.Connection = cn;
                rd = cmd.ExecuteReader();
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void AddUser(string Name, string Surname, string Birthdate, string Username, string Password)
        {
            try
            {
                string sql = "INSERT INTO users (name, surname, birthdate, username, password, isAdmin) VALUES (@name, @surname, @birthdate, @username, @password, 'FALSE')";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@birthdate", Birthdate);
                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", Password);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
