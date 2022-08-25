using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bejelentkezes
{
    public partial class AdminForm : Form
    {
        public MySqlConnection connection = null;
        public MySqlCommand sql = null;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            frissit();
        }

        private void frissit()
        {
            listBox_admin.Items.Clear();
            string felhasznalokSql = "SELECT * FROM `userek`";

            MySqlConnectionStringBuilder sw = new MySqlConnectionStringBuilder();
            sw.Server = "localhost";
            sw.UserID = "root";
            sw.Password = "";
            sw.Database = "felhasznalok";
            connection = new MySqlConnection(sw.ConnectionString);
            try
            {
                connection.Open();
                sql = connection.CreateCommand();
                sql.CommandText = felhasznalokSql;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string nev = dr.GetString("nev");
                        int kor = dr.GetInt32("kor");

                        User user = new User(nev, kor);
                        listBox_admin.Items.Add(user);
                    }   
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
