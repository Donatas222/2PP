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
    public class ItemList
    {
        private SQLiteConnection cn;

        public ItemList()
        {
            cn = new SQLiteConnection(@"URI=file:C:\sqlite\EShopDB.db");
        }

        public List<Item> GetItems()
        {
            List<Item> itemList = new List<Item>();
            try
            {
                string sql = "select itemID, itemName, itemPrice, itemDescription, itemPicture from items";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int itemID = int.Parse(rd["itemID"].ToString());
                    string itemName = rd["itemName"].ToString();
                    double itemPrice = double.Parse(rd["itemPrice"].ToString());
                    string itemDescription = rd["itemDescription"].ToString();
                    string itemPicture = rd["itemPicture"].ToString();
                    itemList.Add(new Item(itemID, itemName, itemPrice, itemDescription, itemPicture));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return itemList;
        }

        public List<Category> GetCategories()
        {
            List<Category> catList = new List<Category>();
            try
            {
                string sql = "select categoryID, categoryName from categories";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int categoryID = int.Parse(rd["categoryID"].ToString());
                    string categoryName = rd["categoryName"].ToString();
                    catList.Add(new Category(categoryID, categoryName));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            foreach (Category ct in catList)
                ct.SetItems(GetItems(ct.ID));

            return catList;    
        }

        private List<Item> GetItems (int categoryID)
        {
            List<Item> itemList = new List<Item>();
            try
            {
                string sql = "select itemID, itemName, itemPrice, itemDescription, itemPicture from items where categoryID=@categoryID";
                SQLiteCommand cmd = new SQLiteCommand(sql, cn);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);

                cn.Open();
                SQLiteDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int itemID = int.Parse(rd["itemID"].ToString());
                    string itemName = rd["itemName"].ToString();
                    double itemPrice = double.Parse(rd["itemPrice"].ToString());
                    string itemDescription = rd["itemDescription"].ToString();
                    string itemPicture = rd["itemPicture"].ToString();
                    itemList.Add(new Item(itemID, itemName, itemPrice, itemDescription, itemPicture));
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return itemList;
        }
    }
}
