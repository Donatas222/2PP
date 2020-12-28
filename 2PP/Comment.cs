using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2PP
{
    public class Comment
    {
        public int ID { get; private set; }
        public int Item { get; private set; }
        public int User { get; private set; }
        public string Text { get; private set; }
        public DateTime Date { get; private set; }


        public Comment(int commentID, int commentItem, int commentUser, string commentText, DateTime commentDate)
        {
            ID = commentID;
            Item = commentItem;
            User = commentUser;
            Text = commentText;
            Date = commentDate;
        }
    }
}
