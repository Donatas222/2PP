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
    public partial class ItemPublicView : UserControl
    {
        public ItemPublicView()
        {
            InitializeComponent();
        }

        private void ItemPublicView_Load(object sender, EventArgs e)
        {

        }

        public ItemPublicView(Item item)
        {
            InitializeComponent();
            NameLabel.Text = item.Name;
            DescriptionLabel.Text = item.Description;
            PriceLabel.Text = item.Price.ToString();
            pictureBox1.Image = Image.FromFile("pics/" + item.Picture);
            CommentsButton.Tag = item.ID;
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void ToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void CommentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ši funkcija kolkas neįgyvendinta.");
            // Button button = (Button)sender;
            // CommentList cl = (CommentList)button.Tag;
        }
    }
}
