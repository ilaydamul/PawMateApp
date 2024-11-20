using Npgsql;
using PawMateApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawMateApp.Screens
{
    public partial class Advertisements : Form
    {
        public Advertisements()
        {
            InitializeComponent();
        }

        private void Advertisements_Load(object sender, EventArgs e)
        {
            int y = 10;
            Button btnCategory = new Button
            {
                Text = "İlan",
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Font = new Font("Arial", 8),
                Width = 146,
                Height = 107,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(10, y)
            };

            btnCategory.Click += (s, args) =>
            {
                MessageBox.Show("Kategori: " + "İlan");
            };

            advert_table.Controls.Add(btnCategory);

            //baglan.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand("Select * from blog_categories", baglan);
            //NpgsqlDataReader dr = cmd.ExecuteReader();
            //int y = 10;
            //while (dr.Read())
            //{
            //    string categoryName = dr["title"].ToString();

            //    Button btnCategory = new Button
            //    {
            //        Text = categoryName,
            //        BackColor = Color.DarkBlue,
            //        ForeColor = Color.White,
            //        Font = new Font("Arial", 8),
            //        Width = 132,
            //        Height = 89,
            //        FlatStyle = FlatStyle.Flat,
            //        Location = new Point(10, y)
            //    };

            //    btnCategory.Click += (s, args) =>
            //    {
            //        MessageBox.Show("Kategori: " + categoryName);
            //    };

            //    categories_grid.Controls.Add(btnCategory);

            //    y += btnCategory.Height + 10;
            //}

            //baglan.Close();

        }

    

    }
}
