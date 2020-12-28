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
    public partial class ItemRegisteredView : ItemPublicView
    {
        public ItemRegisteredView()
        {
            InitializeComponent();
        }

        public ItemRegisteredView(Item item) : base(item)
        {
            InitializeComponent();
        }

        private void ItemRegisteredView_Load(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ši funkcija kolkas neįgyvendinta.");
        }

        private void WishlistButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ši funkcija kolkas neįgyvendinta.");
        }
    }
}
