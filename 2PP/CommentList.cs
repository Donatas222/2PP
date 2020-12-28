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
    public class CommentList
    {
        private SQLiteConnection cn;

        public CommentList()
        {
            cn = new SQLiteConnection(@"URI=file:C:\sqlite\EShopDB.db");
        }

        public List<Comment> GetComments()
        {
            List<Comment> commentList = new List<Comment>();
            try
            {
                string sql = "select commentID, itemID, userID, commentText, commentDate from comments";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int commentID = int.Parse(rd["commentID"].ToString());
                    int itemID = int.Parse(rd["itemID"].ToString());
                    int userID = int.Parse(rd["userID"].ToString());
                    string commentText = rd["commentText"].ToString();
                    DateTime commentDate = DateTime.Parse(rd["commentDate"].ToString());
                    commentList.Add(new Comment(commentID, itemID, userID, commentText, commentDate));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return commentList;
        }


        public List<Comment> GetComments(int itemID)
        {
            List<Comment> commentList = new List<Comment>();
            try
            {
                string sql = "select commentID, userID, commentText, commentDate from comments where itemID=@itemID";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@itemID", itemID);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int commentID = int.Parse(rd["commentID"].ToString());
                    int userID = int.Parse(rd["userID"].ToString());
                    string commentText = rd["commentText"].ToString();
                    DateTime commentDate = DateTime.Parse(rd["commentDate"].ToString());
                    commentList.Add(new Comment(commentID, itemID, userID, commentText, commentDate));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return commentList;
        }
    }
}
